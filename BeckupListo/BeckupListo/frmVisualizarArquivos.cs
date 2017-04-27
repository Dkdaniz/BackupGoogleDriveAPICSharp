using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup
{
    public partial class frmVisualizarArquivos : Form
    {
        //Declarando variaveis
        Google.Apis.Auth.OAuth2.UserCredential LCredenciais;
        Google.Apis.Drive.v3.DriveService LServico;

       
        claNegocioBackup objNegocioBackup = new claNegocioBackup();
        public frmVisualizarArquivos(Google.Apis.Auth.OAuth2.UserCredential inCredenciais, Google.Apis.Drive.v3.DriveService inServico)
        {
            InitializeComponent();
            LCredenciais = inCredenciais;
            LServico = inServico;
        }

        private void Atualizargrid()
        {
            List<claNegocioBackup> lstArquivosDrive = objNegocioBackup.ListarArquivos(LServico);
            grdArquivo.Rows.Clear();
            foreach (claNegocioBackup objLstArquivosDrive in lstArquivosDrive)
            {
                string[] row = new string[]
                {                    
                    objLstArquivosDrive.fdNomeItem.ToString()
                };
                grdArquivo.Rows.Add(row);
            }
        }

        private void frmVisualizarArquivos_Load(object sender, EventArgs e)
        {
            Atualizargrid();
        }

        private void cmdAtualizar_Click(object sender, EventArgs e)
        {
            Atualizargrid();
        }
    }
}
