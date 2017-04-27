using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

namespace Backup
{
    public class claNegocioBackup
    {

        public string msgErro { get; set; }
        public string fdNomeItem { get; set; }

        
        /// <summary>
        /// classe realiza a compactação dos arquivos
        /// </summary>
        /// <param name="inDiretorioOrigem"> caminho de origem ex: c:\Pasta </param>
        /// <param name="inDiretorioDestino"> caminho de origem com o nome da pasta ex: c:\Pasta.zip</param>
        public void CompactarArquivo(string inDiretorioOrigem, string inDiretorioDestino)
        {
            msgErro = "";

            string POrigem = inDiretorioOrigem;
            string PDestino = inDiretorioOrigem + ".zip";

            try
            {
                ZipFile.CreateFromDirectory(POrigem, PDestino);
            }
            catch (Exception)
            {
                msgErro = "Erro ao compartarAquivo!";                
            }
        }

        /// <summary>
        /// Solicita permissao do usuario
        /// </summary>
        /// <returns></returns>
        public Google.Apis.Auth.OAuth2.UserCredential Autenticar()
        {
            msgErro = "";
            Google.Apis.Auth.OAuth2.UserCredential credenciais;

            using (var stream = new System.IO.FileStream("client_id.json", System.IO.FileMode.Open, System.IO.FileAccess.Read))
            {
                var diretorioAtual = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                var diretorioCredenciais = System.IO.Path.Combine(diretorioAtual, "credential");

                credenciais = Google.Apis.Auth.OAuth2.GoogleWebAuthorizationBroker.AuthorizeAsync(
                    Google.Apis.Auth.OAuth2.GoogleClientSecrets.Load(stream).Secrets,
                    new[] { Google.Apis.Drive.v3.DriveService.Scope.Drive },
                    "user",
                    System.Threading.CancellationToken.None,
                    new Google.Apis.Util.Store.FileDataStore(diretorioCredenciais, true)).Result;
            }
            return credenciais;
        }

        /// <summary>
        /// Abre serviço para comunicação com API google Drive
        /// </summary>
        /// <param name="credenciais"></param>
        /// <returns></returns>
        public Google.Apis.Drive.v3.DriveService AbrirServico(Google.Apis.Auth.OAuth2.UserCredential credenciais)
        {
            msgErro = "";
            return new Google.Apis.Drive.v3.DriveService(new Google.Apis.Services.BaseClientService.Initializer()
            {
                HttpClientInitializer = credenciais
            });
        }

        /// <summary>
        /// Lista todos os arquivos do diretorio
        /// </summary>
        /// <param name="servico"></param>
        public List<claNegocioBackup> ListarArquivos (Google.Apis.Drive.v3.DriveService servico)
        {
            msgErro = "";
            
             var request = servico.Files.List();
            
            request.Spaces = "drive";
            request.Fields = "files(id, name)";
            request.Q = "mimeType='application/zip' and trashed=false";
            
            var resultado = request.Execute();
            var arquivos = resultado.Files;
            
            List<claNegocioBackup> lstArquivos = new List<claNegocioBackup>();
            
            if (arquivos != null && arquivos.Any())
            {
                foreach (var arquivo in arquivos)
                {
                    claNegocioBackup objBackup = new claNegocioBackup();
                    objBackup.fdNomeItem = arquivo.Name.ToString();
                    lstArquivos.Add(objBackup);
                }               
            }
            return lstArquivos;
        }

        /// <summary>
        /// Cria Diretorio ou seja a pasta no Google Drive
        /// </summary>       
        public void CriarDiretorio(Google.Apis.Drive.v3.DriveService servico, string nomeDiretorio)
        {
            msgErro = "";
            var diretorio = new Google.Apis.Drive.v3.Data.File();
            diretorio.Name = nomeDiretorio;
            diretorio.MimeType = "application/vnd.google-apps.folder";
            var request = servico.Files.Create(diretorio);
            request.Execute();
        }


        /// <summary>
        /// Procurar arquivo pelo nome e retornar as ID
        /// </summary>        
        /// <returns> Retorna as Ids</returns>
        public string[] ProcurarArquivoId(Google.Apis.Drive.v3.DriveService servico, string nomeArquivo, bool procurarNaLixeira = false)
        {
            msgErro = "";
            var retorno = new List<string>();

            var request = servico.Files.List();
            request.Q = string.Format("name = '{0}'", nomeArquivo);
            if (!procurarNaLixeira)
            {
                request.Q += " and trashed = false";
            }
            request.Fields = "files(id)";
            var resultado = request.Execute();
            var arquivos = resultado.Files;

            if (arquivos != null && arquivos.Any())
            {
                foreach (var arquivo in arquivos)
                {
                    retorno.Add(arquivo.Id);
                }
            }
            return retorno.ToArray();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="servico"></param>
        /// <param name="nome"></param>
        public void DeletarItem(Google.Apis.Drive.v3.DriveService servico, string nome)
        {
            msgErro = "";
            var ids = ProcurarArquivoId(servico, nome);
            if (ids != null && ids.Any())
            {
                foreach (var id in ids)
                {
                    try
                    {
                        var request = servico.Files.Delete(id);
                        request.Execute();
                    }
                    catch (Exception )
                    {
                        msgErro = "Erro o Excluir Arquivo (Permissão, Arquivo Inexiste!";
                    }                    
                }
            }
        }


        /// <summary>
        /// Upload google drive
        /// </summary>
        /// <param name="servico"></param>
        /// <param name="caminhoArquivo"></param>
        public void Upload(Google.Apis.Drive.v3.DriveService servico, string caminhoArquivo)
        {
            msgErro = "";
            var arquivo = new Google.Apis.Drive.v3.Data.File();
            arquivo.Name = System.IO.Path.GetFileName(caminhoArquivo);
            arquivo.MimeType = MimeTypes.MimeTypeMap.GetMimeType(System.IO.Path.GetExtension(caminhoArquivo));

            using (var stream = new System.IO.FileStream(caminhoArquivo, System.IO.FileMode.Open, System.IO.FileAccess.Read))
            {
                var ids = ProcurarArquivoId(servico, arquivo.Name);
                Google.Apis.Upload.ResumableUpload<Google.Apis.Drive.v3.Data.File, Google.Apis.Drive.v3.Data.File> request;

                if (ids == null || !ids.Any())
                {
                    request = servico.Files.Create(arquivo, stream, arquivo.MimeType);
                }
                else
                {
                    request = servico.Files.Update(arquivo, ids.First(), stream, arquivo.MimeType);
                }
                request.Upload();
            }
        }

        /// <summary>
        /// Download Google drive
        /// </summary>
        /// <param name="servico"></param>
        /// <param name="nome"></param>
        /// <param name="destino"></param>
        public void Download(Google.Apis.Drive.v3.DriveService servico, string nome, string destino)
        {
            msgErro = "";
            var ids = ProcurarArquivoId(servico, nome);
            if (ids != null && ids.Any())
            {
                var request = servico.Files.Get(ids.First());
                using (var stream = new System.IO.FileStream(destino, System.IO.FileMode.Create, System.IO.FileAccess.Write))
                {
                    request.Download(stream);
                }
            }
        }

        /// <summary>
        /// Enviar arquivo para lixeira, não vai excluir por meio de segurança. caso o bakup que foi enviado não esteja correto, ele não
        /// </summary>
        /// <param name="servico"></param>
        /// <param name="nome"></param>
        public void MoverParaLixeira(Google.Apis.Drive.v3.DriveService servico, string nome)
        {
            msgErro = "";
            var ids = ProcurarArquivoId(servico, nome);
            if (ids != null && ids.Any())
            {
                foreach (var id in ids)
                {
                    var arquivo = new Google.Apis.Drive.v3.Data.File();
                    arquivo.Trashed = true;
                    var request = servico.Files.Update(arquivo, id);
                    request.Execute();
                }
            }
        }
    }
}
