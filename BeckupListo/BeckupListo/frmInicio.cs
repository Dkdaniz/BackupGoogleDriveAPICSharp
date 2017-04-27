using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;



namespace Backup
{
    public partial class frmInicio : Form
    {
        //Declarando variaveis
        Google.Apis.Auth.OAuth2.UserCredential LCredenciais;
        Google.Apis.Drive.v3.DriveService LServico;


        //Criando Objeto Global
        claNegocioBackup objNegocioBackup = new claNegocioBackup();     

        public frmInicio()
        {
            InitializeComponent();
            if (BeckupListo.Properties.Settings.Default.Automatico == "Ligado")
            {
                rbAutomaticoOn.Checked = true;
                rbDesligado.Checked = false;
            }
            else
            {
                rbAutomaticoOn.Checked = false;
                rbDesligado.Checked = true;
            }
        }        

        private void frmInicio_Load(object sender, EventArgs e)
        {
            try
            {
                //Buscar Credenciais
                LCredenciais = objNegocioBackup.Autenticar();

                //AbreServiço
                LServico = objNegocioBackup.AbrirServico(LCredenciais);



                if (LCredenciais == null)
                {
                    lblStatus.Text = "Close";
                    return;
                }

                if (LServico == null)
                {
                    lblStatus.Text = "Close";
                    return;
                }
                
                lblStatus.Text = "Open";


            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao conectar a api do Google Drive", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblStatus.Text = "Close";
                return;
            }
        }       

        private void cmdVisualizar_Click(object sender, EventArgs e)
        {
            if (LCredenciais == null) return;
            if (LServico == null) return;
            frmVisualizarArquivos objVisualizar = new frmVisualizarArquivos(LCredenciais,LServico);
            objVisualizar.ShowDialog();
        }

        private void cmdUpload_Click(object sender, EventArgs e)
        {
            string PCaminho = "";

            this.Cursor = Cursors.WaitCursor;

            //testando se o caminho foi configurado
            if (BeckupListo.Properties.Settings.Default.PastaDestinoZip == "")
            {
                MessageBox.Show("Parametro Pasta de Destino de compactação não preenchido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            if (BeckupListo.Properties.Settings.Default.PastaOrigemBackup == "")
            {
                MessageBox.Show("Parametro Pasta de Destino de compactação não preenchido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //gera arquivo compactdo
            try
            {
                objNegocioBackup.CompactarArquivo(BeckupListo.Properties.Settings.Default.PastaOrigemZip, BeckupListo.Properties.Settings.Default.PastaDestinoZip);
            }
            catch (Exception)
            {
                MessageBox.Show("Caminho: " + PCaminho + " Não Localizado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            

            //Seta caminho
            PCaminho = BeckupListo.Properties.Settings.Default.PastaDestinoZip;

            //Verifica se caminho existe
            if (System.IO.File.Exists(PCaminho+".zip"))
            {
                objNegocioBackup.Upload(LServico, PCaminho+".zip");
                if (objNegocioBackup.msgErro.ToString() != "")
                {
                    MessageBox.Show("Caminho: " + PCaminho + " Não Localizado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Caminho: " + PCaminho + " Não Localizado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.Cursor = Cursors.Default;
            MessageBox.Show("Concluido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmdDeletar_Click(object sender, EventArgs e)
        {
            if (LCredenciais == null) return;
            if (LServico == null) return;

            frmApagarArquivo objDeletar = new frmApagarArquivo(LCredenciais,LServico);
            objDeletar.ShowDialog();
        }

        private void cmdConfiguracao_Click(object sender, EventArgs e)
        {
            frmConfiguração objConfiguracao = new frmConfiguração();
            objConfiguracao.ShowDialog();
        }

        private void cmdDownload_Click(object sender, EventArgs e)
        {
            //testando se o caminho foi configurado
            if (BeckupListo.Properties.Settings.Default.PastaDestinoBackup == "")
            {
                MessageBox.Show("Parametro Pasta de Destino de compactação não preenchido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            if (MessageBox.Show("Deseja baixar todo o diretorio?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Cursor = Cursors.WaitCursor;
                List<claNegocioBackup> lstArquivosDrive = objNegocioBackup.ListarArquivos(LServico);
                foreach (claNegocioBackup objLstArquivosDrive in lstArquivosDrive)
                {
                    try
                    {
                        objNegocioBackup.Download(LServico, objLstArquivosDrive.fdNomeItem.ToString(), BeckupListo.Properties.Settings.Default.PastaDestinoBackup);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Arquivo: " + objLstArquivosDrive.fdNomeItem + " Impossivel realizar download", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;

                    }
                }
                this.Cursor = Cursors.Default;
                MessageBox.Show("Concluido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sistema Realizará somente download do dia atual!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Cursor = Cursors.WaitCursor;

                //Descobrir Dia Da semana
                DateTime PDiaMes = DateTime.Today;      

                switch (PDiaMes.DayOfWeek.ToString())
                {
                    case "Segunda-Feira":
                        try
                        {

                            objNegocioBackup.Download(LServico, BeckupListo.Properties.Settings.Default.NomeArquivo + "Segunda", BeckupListo.Properties.Settings.Default.PastaDestinoBackup);
                        }
                        catch (Exception)
                        {
                            this.Cursor = Cursors.Default;
                            MessageBox.Show(" Impossivel realizar download do arquivo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;                            
                        }                        
                        break;
                    case "Terça-Feira":
                        try
                        {

                            objNegocioBackup.Download(LServico, BeckupListo.Properties.Settings.Default.NomeArquivo + "Terca", BeckupListo.Properties.Settings.Default.PastaDestinoBackup);
                        }
                        catch (Exception)
                        {
                            this.Cursor = Cursors.Default;
                            MessageBox.Show(" Impossivel realizar download do arquivo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        break;
                    case "Quarta-Feira":
                        try
                        {

                            objNegocioBackup.Download(LServico, BeckupListo.Properties.Settings.Default.NomeArquivo + "Quarta", BeckupListo.Properties.Settings.Default.PastaDestinoBackup);
                        }
                        catch (Exception)
                        {
                            this.Cursor = Cursors.Default;
                            MessageBox.Show(" Impossivel realizar download do arquivo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        break;
                    case "Quinta-Feira":
                        try
                        {

                            objNegocioBackup.Download(LServico, BeckupListo.Properties.Settings.Default.NomeArquivo + "Quinta", BeckupListo.Properties.Settings.Default.PastaDestinoBackup);
                        }
                        catch (Exception)
                        {
                            this.Cursor = Cursors.Default;
                            MessageBox.Show(" Impossivel realizar download do arquivo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        break;
                    case "Sexta-Feira":
                        try
                        {

                            objNegocioBackup.Download(LServico, BeckupListo.Properties.Settings.Default.NomeArquivo + "Sexta", BeckupListo.Properties.Settings.Default.PastaDestinoBackup);
                        }
                        catch (Exception)
                        {
                            this.Cursor = Cursors.Default;
                            MessageBox.Show(" Impossivel realizar download do arquivo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        break;
                    case "Sabado":
                        try
                        {

                            objNegocioBackup.Download(LServico, BeckupListo.Properties.Settings.Default.NomeArquivo + "Sabado", BeckupListo.Properties.Settings.Default.PastaDestinoBackup);
                        }
                        catch (Exception)
                        {
                            this.Cursor = Cursors.Default;
                            MessageBox.Show(" Impossivel realizar download do arquivo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        break;
                    case "Domingo":
                        try
                        {

                            objNegocioBackup.Download(LServico, BeckupListo.Properties.Settings.Default.NomeArquivo + "Domingo", BeckupListo.Properties.Settings.Default.PastaDestinoBackup);
                        }
                        catch (Exception)
                        {
                            this.Cursor = Cursors.Default;
                            MessageBox.Show(" Impossivel realizar download do arquivo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        break;
                }
            }
        }

        private void rbAutomaticoOn_Click(object sender, EventArgs e)
        {
            //Grava Parametro
            BeckupListo.Properties.Settings.Default.Automatico = "Ligado";
            BeckupListo.Properties.Settings.Default.Save();

            //Inicia contador
            TimerAuto.Enabled = true;
        }

        private void rbDesligado_Click(object sender, EventArgs e)
        {
            BeckupListo.Properties.Settings.Default.Automatico = "Desligado";
            BeckupListo.Properties.Settings.Default.Save();
        }

        private void TimerContra_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
