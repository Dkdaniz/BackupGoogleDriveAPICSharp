namespace Backup
{
    partial class frmConfiguração
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDownload = new System.Windows.Forms.GroupBox();
            this.lblNomeArquivoBackup = new System.Windows.Forms.Label();
            this.txtNomeArquivoBackup = new System.Windows.Forms.TextBox();
            this.lblDestinoBackup = new System.Windows.Forms.Label();
            this.cmdAbrirPastaDestinoBackup = new System.Windows.Forms.Button();
            this.txtDestinoBackup = new System.Windows.Forms.TextBox();
            this.lblOrigemBackup = new System.Windows.Forms.Label();
            this.cmdAbrirPastaOrigemBackup = new System.Windows.Forms.Button();
            this.txtOrigemBackup = new System.Windows.Forms.TextBox();
            this.grdHorario = new System.Windows.Forms.GroupBox();
            this.mskHoraNoite = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkSextaNoite = new System.Windows.Forms.CheckBox();
            this.chkSextaMeioDia = new System.Windows.Forms.CheckBox();
            this.chkQuintaNoite = new System.Windows.Forms.CheckBox();
            this.chkQuintaMeioDia = new System.Windows.Forms.CheckBox();
            this.chkQuartaNoite = new System.Windows.Forms.CheckBox();
            this.chkQuartaMeioDia = new System.Windows.Forms.CheckBox();
            this.chkTercaNoite = new System.Windows.Forms.CheckBox();
            this.chkTercaMeioDia = new System.Windows.Forms.CheckBox();
            this.chkSegundaNoite = new System.Windows.Forms.CheckBox();
            this.chkSegundaMeioDia = new System.Windows.Forms.CheckBox();
            this.mskHoraMeioDia = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grdZip = new System.Windows.Forms.GroupBox();
            this.lblDestinoZip = new System.Windows.Forms.Label();
            this.cmdAbrirPastaDestinoZip = new System.Windows.Forms.Button();
            this.txtDestinoZip = new System.Windows.Forms.TextBox();
            this.lblOrigemZip = new System.Windows.Forms.Label();
            this.cmdAbrirPastaOrigemZip = new System.Windows.Forms.Button();
            this.txtOrigemZip = new System.Windows.Forms.TextBox();
            this.grdEmail = new System.Windows.Forms.GroupBox();
            this.lblSenhaEmail = new System.Windows.Forms.Label();
            this.cmdTestarEmail = new System.Windows.Forms.Button();
            this.txtSenhaEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtUsuarioEmail = new System.Windows.Forms.TextBox();
            this.cmdSalvar = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.grpDownload.SuspendLayout();
            this.grdHorario.SuspendLayout();
            this.grdZip.SuspendLayout();
            this.grdEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDownload
            // 
            this.grpDownload.Controls.Add(this.lblNomeArquivoBackup);
            this.grpDownload.Controls.Add(this.txtNomeArquivoBackup);
            this.grpDownload.Controls.Add(this.lblDestinoBackup);
            this.grpDownload.Controls.Add(this.cmdAbrirPastaDestinoBackup);
            this.grpDownload.Controls.Add(this.txtDestinoBackup);
            this.grpDownload.Controls.Add(this.lblOrigemBackup);
            this.grpDownload.Controls.Add(this.cmdAbrirPastaOrigemBackup);
            this.grpDownload.Controls.Add(this.txtOrigemBackup);
            this.grpDownload.Location = new System.Drawing.Point(12, 50);
            this.grpDownload.Name = "grpDownload";
            this.grpDownload.Size = new System.Drawing.Size(434, 249);
            this.grpDownload.TabIndex = 0;
            this.grpDownload.TabStop = false;
            this.grpDownload.Text = "Download e Upload";
            // 
            // lblNomeArquivoBackup
            // 
            this.lblNomeArquivoBackup.AutoSize = true;
            this.lblNomeArquivoBackup.Location = new System.Drawing.Point(6, 151);
            this.lblNomeArquivoBackup.Name = "lblNomeArquivoBackup";
            this.lblNomeArquivoBackup.Size = new System.Drawing.Size(169, 17);
            this.lblNomeArquivoBackup.TabIndex = 7;
            this.lblNomeArquivoBackup.Text = "Nome Arquivo (Generico)";
            // 
            // txtNomeArquivoBackup
            // 
            this.txtNomeArquivoBackup.Location = new System.Drawing.Point(6, 168);
            this.txtNomeArquivoBackup.Name = "txtNomeArquivoBackup";
            this.txtNomeArquivoBackup.Size = new System.Drawing.Size(416, 22);
            this.txtNomeArquivoBackup.TabIndex = 6;
            // 
            // lblDestinoBackup
            // 
            this.lblDestinoBackup.AutoSize = true;
            this.lblDestinoBackup.Location = new System.Drawing.Point(3, 97);
            this.lblDestinoBackup.Name = "lblDestinoBackup";
            this.lblDestinoBackup.Size = new System.Drawing.Size(96, 17);
            this.lblDestinoBackup.TabIndex = 5;
            this.lblDestinoBackup.Text = "Pasta Destino";
            // 
            // cmdAbrirPastaDestinoBackup
            // 
            this.cmdAbrirPastaDestinoBackup.Location = new System.Drawing.Point(347, 113);
            this.cmdAbrirPastaDestinoBackup.Name = "cmdAbrirPastaDestinoBackup";
            this.cmdAbrirPastaDestinoBackup.Size = new System.Drawing.Size(75, 23);
            this.cmdAbrirPastaDestinoBackup.TabIndex = 4;
            this.cmdAbrirPastaDestinoBackup.Text = "Abrir";
            this.cmdAbrirPastaDestinoBackup.UseVisualStyleBackColor = true;
            this.cmdAbrirPastaDestinoBackup.Click += new System.EventHandler(this.cmdAbrirPastaDestinoBackup_Click);
            // 
            // txtDestinoBackup
            // 
            this.txtDestinoBackup.Location = new System.Drawing.Point(3, 114);
            this.txtDestinoBackup.Name = "txtDestinoBackup";
            this.txtDestinoBackup.Size = new System.Drawing.Size(338, 22);
            this.txtDestinoBackup.TabIndex = 3;
            // 
            // lblOrigemBackup
            // 
            this.lblOrigemBackup.AutoSize = true;
            this.lblOrigemBackup.Location = new System.Drawing.Point(3, 32);
            this.lblOrigemBackup.Name = "lblOrigemBackup";
            this.lblOrigemBackup.Size = new System.Drawing.Size(94, 17);
            this.lblOrigemBackup.TabIndex = 2;
            this.lblOrigemBackup.Text = "Pasta Origem";
            // 
            // cmdAbrirPastaOrigemBackup
            // 
            this.cmdAbrirPastaOrigemBackup.Location = new System.Drawing.Point(347, 48);
            this.cmdAbrirPastaOrigemBackup.Name = "cmdAbrirPastaOrigemBackup";
            this.cmdAbrirPastaOrigemBackup.Size = new System.Drawing.Size(75, 23);
            this.cmdAbrirPastaOrigemBackup.TabIndex = 1;
            this.cmdAbrirPastaOrigemBackup.Text = "Abrir";
            this.cmdAbrirPastaOrigemBackup.UseVisualStyleBackColor = true;
            this.cmdAbrirPastaOrigemBackup.Click += new System.EventHandler(this.cmdAbrirPastaOrigemBackup_Click);
            // 
            // txtOrigemBackup
            // 
            this.txtOrigemBackup.Location = new System.Drawing.Point(3, 49);
            this.txtOrigemBackup.Name = "txtOrigemBackup";
            this.txtOrigemBackup.Size = new System.Drawing.Size(338, 22);
            this.txtOrigemBackup.TabIndex = 0;
            // 
            // grdHorario
            // 
            this.grdHorario.Controls.Add(this.mskHoraNoite);
            this.grdHorario.Controls.Add(this.label4);
            this.grdHorario.Controls.Add(this.chkSextaNoite);
            this.grdHorario.Controls.Add(this.chkSextaMeioDia);
            this.grdHorario.Controls.Add(this.chkQuintaNoite);
            this.grdHorario.Controls.Add(this.chkQuintaMeioDia);
            this.grdHorario.Controls.Add(this.chkQuartaNoite);
            this.grdHorario.Controls.Add(this.chkQuartaMeioDia);
            this.grdHorario.Controls.Add(this.chkTercaNoite);
            this.grdHorario.Controls.Add(this.chkTercaMeioDia);
            this.grdHorario.Controls.Add(this.chkSegundaNoite);
            this.grdHorario.Controls.Add(this.chkSegundaMeioDia);
            this.grdHorario.Controls.Add(this.mskHoraMeioDia);
            this.grdHorario.Controls.Add(this.label3);
            this.grdHorario.Location = new System.Drawing.Point(453, 50);
            this.grdHorario.Name = "grdHorario";
            this.grdHorario.Size = new System.Drawing.Size(521, 249);
            this.grdHorario.TabIndex = 1;
            this.grdHorario.TabStop = false;
            this.grdHorario.Text = "Hora e dia(s) Envio";
            // 
            // mskHoraNoite
            // 
            this.mskHoraNoite.Location = new System.Drawing.Point(219, 49);
            this.mskHoraNoite.Mask = "00:00";
            this.mskHoraNoite.Name = "mskHoraNoite";
            this.mskHoraNoite.Size = new System.Drawing.Size(114, 22);
            this.mskHoraNoite.TabIndex = 22;
            this.mskHoraNoite.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Horario Noite";
            // 
            // chkSextaNoite
            // 
            this.chkSextaNoite.AutoSize = true;
            this.chkSextaNoite.Location = new System.Drawing.Point(222, 165);
            this.chkSextaNoite.Name = "chkSextaNoite";
            this.chkSextaNoite.Size = new System.Drawing.Size(188, 21);
            this.chkSextaNoite.TabIndex = 18;
            this.chkSextaNoite.Text = "Sexta - Feira (Meio - Dia)";
            this.chkSextaNoite.UseVisualStyleBackColor = true;
            // 
            // chkSextaMeioDia
            // 
            this.chkSextaMeioDia.AutoSize = true;
            this.chkSextaMeioDia.Location = new System.Drawing.Point(6, 165);
            this.chkSextaMeioDia.Name = "chkSextaMeioDia";
            this.chkSextaMeioDia.Size = new System.Drawing.Size(188, 21);
            this.chkSextaMeioDia.TabIndex = 17;
            this.chkSextaMeioDia.Text = "Sexta - Feira (Meio - Dia)";
            this.chkSextaMeioDia.UseVisualStyleBackColor = true;
            // 
            // chkQuintaNoite
            // 
            this.chkQuintaNoite.AutoSize = true;
            this.chkQuintaNoite.Location = new System.Drawing.Point(222, 147);
            this.chkQuintaNoite.Name = "chkQuintaNoite";
            this.chkQuintaNoite.Size = new System.Drawing.Size(199, 21);
            this.chkQuintaNoite.TabIndex = 16;
            this.chkQuintaNoite.Text = "Quinta  - Feira (Meio - Dia)";
            this.chkQuintaNoite.UseVisualStyleBackColor = true;
            // 
            // chkQuintaMeioDia
            // 
            this.chkQuintaMeioDia.AutoSize = true;
            this.chkQuintaMeioDia.Location = new System.Drawing.Point(6, 147);
            this.chkQuintaMeioDia.Name = "chkQuintaMeioDia";
            this.chkQuintaMeioDia.Size = new System.Drawing.Size(195, 21);
            this.chkQuintaMeioDia.TabIndex = 15;
            this.chkQuintaMeioDia.Text = "Quinta - Feira (Meio - Dia)";
            this.chkQuintaMeioDia.UseVisualStyleBackColor = true;
            // 
            // chkQuartaNoite
            // 
            this.chkQuartaNoite.AutoSize = true;
            this.chkQuartaNoite.Location = new System.Drawing.Point(222, 129);
            this.chkQuartaNoite.Name = "chkQuartaNoite";
            this.chkQuartaNoite.Size = new System.Drawing.Size(197, 21);
            this.chkQuartaNoite.TabIndex = 14;
            this.chkQuartaNoite.Text = "Quarta - Feira (Meio - Dia)";
            this.chkQuartaNoite.UseVisualStyleBackColor = true;
            // 
            // chkQuartaMeioDia
            // 
            this.chkQuartaMeioDia.AutoSize = true;
            this.chkQuartaMeioDia.Location = new System.Drawing.Point(6, 129);
            this.chkQuartaMeioDia.Name = "chkQuartaMeioDia";
            this.chkQuartaMeioDia.Size = new System.Drawing.Size(197, 21);
            this.chkQuartaMeioDia.TabIndex = 13;
            this.chkQuartaMeioDia.Text = "Quarta - Feira (Meio - Dia)";
            this.chkQuartaMeioDia.UseVisualStyleBackColor = true;
            // 
            // chkTercaNoite
            // 
            this.chkTercaNoite.AutoSize = true;
            this.chkTercaNoite.Location = new System.Drawing.Point(222, 111);
            this.chkTercaNoite.Name = "chkTercaNoite";
            this.chkTercaNoite.Size = new System.Drawing.Size(190, 21);
            this.chkTercaNoite.TabIndex = 12;
            this.chkTercaNoite.Text = "Terça - Feira (Meio - Dia)";
            this.chkTercaNoite.UseVisualStyleBackColor = true;
            // 
            // chkTercaMeioDia
            // 
            this.chkTercaMeioDia.AutoSize = true;
            this.chkTercaMeioDia.Location = new System.Drawing.Point(6, 111);
            this.chkTercaMeioDia.Name = "chkTercaMeioDia";
            this.chkTercaMeioDia.Size = new System.Drawing.Size(190, 21);
            this.chkTercaMeioDia.TabIndex = 11;
            this.chkTercaMeioDia.Text = "Terça - Feira (Meio - Dia)";
            this.chkTercaMeioDia.UseVisualStyleBackColor = true;
            // 
            // chkSegundaNoite
            // 
            this.chkSegundaNoite.AutoSize = true;
            this.chkSegundaNoite.Location = new System.Drawing.Point(222, 93);
            this.chkSegundaNoite.Name = "chkSegundaNoite";
            this.chkSegundaNoite.Size = new System.Drawing.Size(179, 21);
            this.chkSegundaNoite.TabIndex = 10;
            this.chkSegundaNoite.Text = "Segunda - Feira (Noite)";
            this.chkSegundaNoite.UseVisualStyleBackColor = true;
            // 
            // chkSegundaMeioDia
            // 
            this.chkSegundaMeioDia.AutoSize = true;
            this.chkSegundaMeioDia.Location = new System.Drawing.Point(6, 93);
            this.chkSegundaMeioDia.Name = "chkSegundaMeioDia";
            this.chkSegundaMeioDia.Size = new System.Drawing.Size(210, 21);
            this.chkSegundaMeioDia.TabIndex = 9;
            this.chkSegundaMeioDia.Text = "Segunda - Feira (Meio - Dia)";
            this.chkSegundaMeioDia.UseVisualStyleBackColor = true;
            // 
            // mskHoraMeioDia
            // 
            this.mskHoraMeioDia.Location = new System.Drawing.Point(6, 49);
            this.mskHoraMeioDia.Mask = "00:00";
            this.mskHoraMeioDia.Name = "mskHoraMeioDia";
            this.mskHoraMeioDia.Size = new System.Drawing.Size(114, 22);
            this.mskHoraMeioDia.TabIndex = 8;
            this.mskHoraMeioDia.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Horario de Meio Dia";
            // 
            // grdZip
            // 
            this.grdZip.Controls.Add(this.lblDestinoZip);
            this.grdZip.Controls.Add(this.cmdAbrirPastaDestinoZip);
            this.grdZip.Controls.Add(this.txtDestinoZip);
            this.grdZip.Controls.Add(this.lblOrigemZip);
            this.grdZip.Controls.Add(this.cmdAbrirPastaOrigemZip);
            this.grdZip.Controls.Add(this.txtOrigemZip);
            this.grdZip.Location = new System.Drawing.Point(12, 316);
            this.grdZip.Name = "grdZip";
            this.grdZip.Size = new System.Drawing.Size(434, 249);
            this.grdZip.TabIndex = 6;
            this.grdZip.TabStop = false;
            this.grdZip.Text = "Compactar Arquivos";
            // 
            // lblDestinoZip
            // 
            this.lblDestinoZip.AutoSize = true;
            this.lblDestinoZip.Location = new System.Drawing.Point(6, 97);
            this.lblDestinoZip.Name = "lblDestinoZip";
            this.lblDestinoZip.Size = new System.Drawing.Size(96, 17);
            this.lblDestinoZip.TabIndex = 5;
            this.lblDestinoZip.Text = "Pasta Destino";
            // 
            // cmdAbrirPastaDestinoZip
            // 
            this.cmdAbrirPastaDestinoZip.Location = new System.Drawing.Point(350, 113);
            this.cmdAbrirPastaDestinoZip.Name = "cmdAbrirPastaDestinoZip";
            this.cmdAbrirPastaDestinoZip.Size = new System.Drawing.Size(75, 23);
            this.cmdAbrirPastaDestinoZip.TabIndex = 4;
            this.cmdAbrirPastaDestinoZip.Text = "Abrir";
            this.cmdAbrirPastaDestinoZip.UseVisualStyleBackColor = true;
            this.cmdAbrirPastaDestinoZip.Click += new System.EventHandler(this.cmdAbrirPastaDestinoZip_Click);
            // 
            // txtDestinoZip
            // 
            this.txtDestinoZip.Location = new System.Drawing.Point(6, 114);
            this.txtDestinoZip.Name = "txtDestinoZip";
            this.txtDestinoZip.Size = new System.Drawing.Size(338, 22);
            this.txtDestinoZip.TabIndex = 3;
            // 
            // lblOrigemZip
            // 
            this.lblOrigemZip.AutoSize = true;
            this.lblOrigemZip.Location = new System.Drawing.Point(6, 32);
            this.lblOrigemZip.Name = "lblOrigemZip";
            this.lblOrigemZip.Size = new System.Drawing.Size(94, 17);
            this.lblOrigemZip.TabIndex = 2;
            this.lblOrigemZip.Text = "Pasta Origem";
            // 
            // cmdAbrirPastaOrigemZip
            // 
            this.cmdAbrirPastaOrigemZip.Location = new System.Drawing.Point(350, 48);
            this.cmdAbrirPastaOrigemZip.Name = "cmdAbrirPastaOrigemZip";
            this.cmdAbrirPastaOrigemZip.Size = new System.Drawing.Size(75, 23);
            this.cmdAbrirPastaOrigemZip.TabIndex = 1;
            this.cmdAbrirPastaOrigemZip.Text = "Abrir";
            this.cmdAbrirPastaOrigemZip.UseVisualStyleBackColor = true;
            this.cmdAbrirPastaOrigemZip.Click += new System.EventHandler(this.cmdAbrirPastaOrigemZip_Click);
            // 
            // txtOrigemZip
            // 
            this.txtOrigemZip.Location = new System.Drawing.Point(6, 49);
            this.txtOrigemZip.Name = "txtOrigemZip";
            this.txtOrigemZip.Size = new System.Drawing.Size(338, 22);
            this.txtOrigemZip.TabIndex = 0;
            // 
            // grdEmail
            // 
            this.grdEmail.Controls.Add(this.lblSenhaEmail);
            this.grdEmail.Controls.Add(this.cmdTestarEmail);
            this.grdEmail.Controls.Add(this.txtSenhaEmail);
            this.grdEmail.Controls.Add(this.lblEmail);
            this.grdEmail.Controls.Add(this.txtUsuarioEmail);
            this.grdEmail.Location = new System.Drawing.Point(453, 316);
            this.grdEmail.Name = "grdEmail";
            this.grdEmail.Size = new System.Drawing.Size(521, 249);
            this.grdEmail.TabIndex = 7;
            this.grdEmail.TabStop = false;
            this.grdEmail.Text = "Enviar Email";
            // 
            // lblSenhaEmail
            // 
            this.lblSenhaEmail.AutoSize = true;
            this.lblSenhaEmail.Location = new System.Drawing.Point(6, 74);
            this.lblSenhaEmail.Name = "lblSenhaEmail";
            this.lblSenhaEmail.Size = new System.Drawing.Size(53, 17);
            this.lblSenhaEmail.TabIndex = 5;
            this.lblSenhaEmail.Text = "Senha:";
            // 
            // cmdTestarEmail
            // 
            this.cmdTestarEmail.Location = new System.Drawing.Point(426, 49);
            this.cmdTestarEmail.Name = "cmdTestarEmail";
            this.cmdTestarEmail.Size = new System.Drawing.Size(75, 67);
            this.cmdTestarEmail.TabIndex = 4;
            this.cmdTestarEmail.Text = "Testar";
            this.cmdTestarEmail.UseVisualStyleBackColor = true;
            this.cmdTestarEmail.Click += new System.EventHandler(this.cmdTestarEmail_Click);
            // 
            // txtSenhaEmail
            // 
            this.txtSenhaEmail.Location = new System.Drawing.Point(6, 94);
            this.txtSenhaEmail.Name = "txtSenhaEmail";
            this.txtSenhaEmail.PasswordChar = '*';
            this.txtSenhaEmail.Size = new System.Drawing.Size(415, 22);
            this.txtSenhaEmail.TabIndex = 3;
            this.txtSenhaEmail.UseSystemPasswordChar = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 32);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // txtUsuarioEmail
            // 
            this.txtUsuarioEmail.Location = new System.Drawing.Point(6, 49);
            this.txtUsuarioEmail.Name = "txtUsuarioEmail";
            this.txtUsuarioEmail.Size = new System.Drawing.Size(413, 22);
            this.txtUsuarioEmail.TabIndex = 0;
            // 
            // cmdSalvar
            // 
            this.cmdSalvar.Location = new System.Drawing.Point(899, 12);
            this.cmdSalvar.Name = "cmdSalvar";
            this.cmdSalvar.Size = new System.Drawing.Size(75, 32);
            this.cmdSalvar.TabIndex = 8;
            this.cmdSalvar.Text = "Salvar";
            this.cmdSalvar.UseVisualStyleBackColor = true;
            this.cmdSalvar.Click += new System.EventHandler(this.cmdSalvar_Click);
            // 
            // frmConfiguração
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 571);
            this.Controls.Add(this.cmdSalvar);
            this.Controls.Add(this.grdEmail);
            this.Controls.Add(this.grdZip);
            this.Controls.Add(this.grdHorario);
            this.Controls.Add(this.grpDownload);
            this.Name = "frmConfiguração";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConfiguração";
            this.Load += new System.EventHandler(this.frmConfiguração_Load);
            this.grpDownload.ResumeLayout(false);
            this.grpDownload.PerformLayout();
            this.grdHorario.ResumeLayout(false);
            this.grdHorario.PerformLayout();
            this.grdZip.ResumeLayout(false);
            this.grdZip.PerformLayout();
            this.grdEmail.ResumeLayout(false);
            this.grdEmail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDownload;
        private System.Windows.Forms.MaskedTextBox mskHoraMeioDia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDestinoBackup;
        private System.Windows.Forms.Button cmdAbrirPastaDestinoBackup;
        private System.Windows.Forms.TextBox txtDestinoBackup;
        private System.Windows.Forms.Label lblOrigemBackup;
        private System.Windows.Forms.Button cmdAbrirPastaOrigemBackup;
        private System.Windows.Forms.TextBox txtOrigemBackup;
        private System.Windows.Forms.GroupBox grdHorario;
        private System.Windows.Forms.MaskedTextBox mskHoraNoite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkSextaNoite;
        private System.Windows.Forms.CheckBox chkSextaMeioDia;
        private System.Windows.Forms.CheckBox chkQuintaNoite;
        private System.Windows.Forms.CheckBox chkQuintaMeioDia;
        private System.Windows.Forms.CheckBox chkQuartaNoite;
        private System.Windows.Forms.CheckBox chkQuartaMeioDia;
        private System.Windows.Forms.CheckBox chkTercaNoite;
        private System.Windows.Forms.CheckBox chkTercaMeioDia;
        private System.Windows.Forms.CheckBox chkSegundaNoite;
        private System.Windows.Forms.CheckBox chkSegundaMeioDia;
        private System.Windows.Forms.GroupBox grdZip;
        private System.Windows.Forms.Label lblDestinoZip;
        private System.Windows.Forms.Button cmdAbrirPastaDestinoZip;
        private System.Windows.Forms.TextBox txtDestinoZip;
        private System.Windows.Forms.Label lblOrigemZip;
        private System.Windows.Forms.Button cmdAbrirPastaOrigemZip;
        private System.Windows.Forms.TextBox txtOrigemZip;
        private System.Windows.Forms.GroupBox grdEmail;
        private System.Windows.Forms.Label lblSenhaEmail;
        private System.Windows.Forms.Button cmdTestarEmail;
        private System.Windows.Forms.TextBox txtSenhaEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtUsuarioEmail;
        private System.Windows.Forms.Label lblNomeArquivoBackup;
        private System.Windows.Forms.TextBox txtNomeArquivoBackup;
        private System.Windows.Forms.Button cmdSalvar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}