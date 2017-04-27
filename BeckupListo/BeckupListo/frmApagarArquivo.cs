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
    public partial class frmApagarArquivo : Form
    {
        //Declarando variaveis
        Google.Apis.Auth.OAuth2.UserCredential LCredenciais;
        Google.Apis.Drive.v3.DriveService LServico;

        string LNomeArquivo = "";

        claNegocioBackup objNegocioBackup = new claNegocioBackup();
        public frmApagarArquivo(Google.Apis.Auth.OAuth2.UserCredential inCredenciais, Google.Apis.Drive.v3.DriveService inServico)
        {
            InitializeComponent();
            LCredenciais = inCredenciais;
            LServico = inServico;
        }

        private void Atualizargrid()
        {
            List<claNegocioBackup> lstArquivosDrive = objNegocioBackup.ListarArquivos(LServico);
            if (lstArquivosDrive.Count > 0)
            {
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
        }

        private void cmdApagar_Click(object sender, EventArgs e)
        {
            if (LNomeArquivo == "")
            {
                MessageBox.Show("Nenhum Produto foi Selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            objNegocioBackup.DeletarItem(LServico, LNomeArquivo);
            if (objNegocioBackup.msgErro != "")
            {
                MessageBox.Show(objNegocioBackup.msgErro,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            MessageBox.Show("Concluido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Atualizargrid();

        }

        private void frmApagarArquivo_Load(object sender, EventArgs e)
        {
            Atualizargrid();
        }

        private void grdArquivo_Click(object sender, EventArgs e)
        {
            if (grdArquivo.SelectedRows.Count > 0)
            {
                LNomeArquivo = grdArquivo.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void grdArquivo_SelectionChanged(object sender, EventArgs e)
        {
            if (grdArquivo.SelectedRows.Count > 0)
            {
                LNomeArquivo = grdArquivo.SelectedRows[0].Cells[0].Value.ToString();
            }
        }      

        private void cmdAtualizar_Click_1(object sender, EventArgs e)
        {
            Atualizargrid();
        }
    }
}
