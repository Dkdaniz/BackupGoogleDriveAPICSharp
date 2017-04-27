using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup
{
    public partial class frmConfiguração : Form
    {
        public frmConfiguração()
        {
            InitializeComponent();
        }

        private void frmConfiguração_Load(object sender, EventArgs e)
        {
            MostrarDados();
        }

        private void MostrarDados()
        {
            txtOrigemBackup.Text = BeckupListo.Properties.Settings.Default.PastaOrigemBackup;
            txtDestinoBackup.Text = BeckupListo.Properties.Settings.Default.PastaDestinoBackup;
            txtOrigemZip.Text = BeckupListo.Properties.Settings.Default.PastaOrigemZip;
            txtDestinoZip.Text = BeckupListo.Properties.Settings.Default.PastaDestinoZip;
            txtNomeArquivoBackup.Text = BeckupListo.Properties.Settings.Default.NomeArquivo;
            txtUsuarioEmail.Text = BeckupListo.Properties.Settings.Default.UsuarioEmail;
            txtSenhaEmail.Text = BeckupListo.Properties.Settings.Default.SenhaEmail;
            mskHoraMeioDia.Text = BeckupListo.Properties.Settings.Default.HoraMeioDia;
            mskHoraNoite.Text = BeckupListo.Properties.Settings.Default.HoraNoite;
            if (BeckupListo.Properties.Settings.Default.SegundaMeioDia == "Ativo")
            {
                chkSegundaMeioDia.Checked = true;
            }

            if (BeckupListo.Properties.Settings.Default.SegundaNoite == "Ativo")
            {
                chkSegundaNoite.Checked = true;
            }

            if (BeckupListo.Properties.Settings.Default.TercaMeioDia == "Ativo")
            {
                chkTercaMeioDia.Checked = true;
            }

            if (BeckupListo.Properties.Settings.Default.TercaNoite == "Ativo")
            {
                chkTercaNoite.Checked = true;
            }

            if (BeckupListo.Properties.Settings.Default.QuartaMeioDia == "Ativo")
            {
                chkQuartaMeioDia.Checked = true;
            }

            if (BeckupListo.Properties.Settings.Default.QuartaNoite == "Ativo")
            {
                chkQuartaNoite.Checked = true;
            }

            if (BeckupListo.Properties.Settings.Default.QuintaMeioDia == "Ativo")
            {
                chkQuintaMeioDia.Checked = true;
            }

            if (BeckupListo.Properties.Settings.Default.QuintaNoite == "Ativo")
            {
                chkQuintaNoite.Checked = true;
            }

            if (BeckupListo.Properties.Settings.Default.SextaMeioDia == "Ativo")
            {
                chkSextaMeioDia.Checked = true;
            }

            if (BeckupListo.Properties.Settings.Default.SextaNoite == "Ativo")
            {
                chkSextaNoite.Checked = true;
            }
           
        }
    

        private void cmdAbrirPastaOrigemBackup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog objBrowserFD = new FolderBrowserDialog();
            if (objBrowserFD.ShowDialog() == DialogResult.OK)
            {
                txtOrigemBackup.Text = objBrowserFD.SelectedPath;
            }
        }

        private void cmdAbrirPastaDestinoBackup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog objBrowserFD = new FolderBrowserDialog();
            if (objBrowserFD.ShowDialog() == DialogResult.OK)
            {
                txtDestinoBackup.Text = objBrowserFD.SelectedPath;
            }
        }

        private void cmdAbrirPastaOrigemZip_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog objBrowserFD = new FolderBrowserDialog();
            if (objBrowserFD.ShowDialog() == DialogResult.OK)
            {
                txtOrigemZip.Text = objBrowserFD.SelectedPath;
            }
        }

        private void cmdAbrirPastaDestinoZip_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog objBrowserFD = new FolderBrowserDialog();
            if (objBrowserFD.ShowDialog() == DialogResult.OK)
            {
                txtDestinoZip.Text = objBrowserFD.SelectedPath;
            }
        }

        private void cmdTestarEmail_Click(object sender, EventArgs e)
        {
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential(txtUsuarioEmail.Text, txtSenhaEmail.Text);
            MailMessage mail = new MailMessage();
            mail.Sender = new System.Net.Mail.MailAddress("email que vai enviar", "ENVIADOR");
            mail.From = new MailAddress(txtUsuarioEmail.Text, txtUsuarioEmail.Text);
            mail.To.Add(new MailAddress(txtUsuarioEmail.Text, txtUsuarioEmail.Text));
            mail.Subject = "TESTE BACKUP";
            mail.Body = "TESTE EMAIL - BECKUP QUALIFY";
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;
            try
            {
                client.Send(mail);
            }
            catch (System.Exception)
            {
                MessageBox.Show("Erro ao enviar email");
            }
            finally
            {
                mail = null;
            }
        }
        private void cmdSalvar_Click(object sender, EventArgs e)
        {
            if (txtOrigemBackup.Text == "")
            {
                MessageBox.Show("Local Origem backup não foi preenchido");
                return;

            }

            if (txtDestinoBackup.Text == "")
            {
                MessageBox.Show("Local Destino backup não foi preenchido");
                return;

            }


            if (txtOrigemZip.Text == "")
            {
                MessageBox.Show("Local Origem Zip não foi preenchido");
                return;

            }


            if (txtDestinoZip.Text == "")
            {
                MessageBox.Show("Local Destino Zip não foi preenchido");
                return;

            }


            if (txtNomeArquivoBackup.Text == "")
            {
                MessageBox.Show("Nome Arquivo não foi preenchido");
                return;

            }            

            if (mskHoraMeioDia.Text == "")
            {
                MessageBox.Show("Horario Meio Dia não foi preenchido");
                return;

            }

            if (mskHoraNoite.Text == "")
            {
                MessageBox.Show("Horario Noite não foi preenchido");
                return;

            }

            BeckupListo.Properties.Settings.Default.PastaOrigemBackup = txtOrigemBackup.Text;
            BeckupListo.Properties.Settings.Default.PastaDestinoBackup = txtDestinoBackup.Text;
            BeckupListo.Properties.Settings.Default.PastaOrigemZip = txtOrigemZip.Text;
            BeckupListo.Properties.Settings.Default.PastaDestinoZip = txtDestinoZip.Text;
            BeckupListo.Properties.Settings.Default.NomeArquivo = txtNomeArquivoBackup.Text;
            BeckupListo.Properties.Settings.Default.UsuarioEmail = txtUsuarioEmail.Text;
            BeckupListo.Properties.Settings.Default.SenhaEmail = txtSenhaEmail.Text;
            BeckupListo.Properties.Settings.Default.HoraMeioDia = mskHoraMeioDia.Text;
            BeckupListo.Properties.Settings.Default.HoraNoite = mskHoraNoite.Text;
            if (chkSegundaMeioDia.Checked)
            {
                BeckupListo.Properties.Settings.Default.SegundaMeioDia = "Ativo";                
            }
            else
            {
                BeckupListo.Properties.Settings.Default.SegundaMeioDia = "Inativo";
            }

            if (chkSegundaNoite.Checked)
            {
                BeckupListo.Properties.Settings.Default.SegundaNoite = "Ativo";
            }
            else
            {
                BeckupListo.Properties.Settings.Default.SegundaNoite = "Inativo";
            }

            if (chkTercaMeioDia.Checked)
            {
                BeckupListo.Properties.Settings.Default.TercaMeioDia = "Ativo";
            }
            else
            {
                BeckupListo.Properties.Settings.Default.TercaMeioDia = "Inativo";
            }

            if (chkTercaNoite.Checked)
            {
                BeckupListo.Properties.Settings.Default.TercaNoite   = "Ativo";
            }
            else
            {
                BeckupListo.Properties.Settings.Default.TercaNoite = "Inativo";
            }

            if (chkQuartaMeioDia.Checked)
            {
                BeckupListo.Properties.Settings.Default.QuartaMeioDia   = "Ativo";
            }
            else
            {
                BeckupListo.Properties.Settings.Default.QuartaMeioDia = "Inativo";
            }

            if (chkQuartaNoite.Checked)
            {
                BeckupListo.Properties.Settings.Default.QuartaNoite = "Ativo";
            }
            else
            {
                BeckupListo.Properties.Settings.Default.QuartaNoite = "Inativo";
            }
          

            if (chkQuintaMeioDia.Checked)
            {
                BeckupListo.Properties.Settings.Default.QuintaMeioDia   = "Ativo";
            }
            else
            {
                BeckupListo.Properties.Settings.Default.QuintaMeioDia = "Inativo";
            }

            if (chkQuintaNoite.Checked)
            {
                BeckupListo.Properties.Settings.Default.QuintaNoite   = "Ativo";
            }
            else
            {
                BeckupListo.Properties.Settings.Default.QuintaNoite = "Inativo";
            }

            if (chkSextaMeioDia.Checked)
            {
                BeckupListo.Properties.Settings.Default.SextaMeioDia   = "Ativo";
            }
            else
            {
                BeckupListo.Properties.Settings.Default.SextaMeioDia = "Inativo";
            }

            if (chkSextaNoite.Checked)
            {
                BeckupListo.Properties.Settings.Default.SextaNoite   = "Ativo";
            }
            else
            {
                BeckupListo.Properties.Settings.Default.SextaNoite = "Inativo";
            }

            BeckupListo.Properties.Settings.Default.Save();
        }
    }
}
