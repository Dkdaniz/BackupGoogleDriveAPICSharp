namespace Backup
{
    partial class frmInicio
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
            this.components = new System.ComponentModel.Container();
            this.TimerAuto = new System.Windows.Forms.Timer(this.components);
            this.cmdConfiguracao = new System.Windows.Forms.Button();
            this.cmdUpload = new System.Windows.Forms.Button();
            this.cmdDownload = new System.Windows.Forms.Button();
            this.cmdVisualizar = new System.Windows.Forms.Button();
            this.cmdDeletar = new System.Windows.Forms.Button();
            this.lblService = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.rbAutomaticoOn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDesligado = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerAuto
            // 
            this.TimerAuto.Tick += new System.EventHandler(this.TimerContra_Tick);
            // 
            // cmdConfiguracao
            // 
            this.cmdConfiguracao.Location = new System.Drawing.Point(492, 12);
            this.cmdConfiguracao.Name = "cmdConfiguracao";
            this.cmdConfiguracao.Size = new System.Drawing.Size(129, 51);
            this.cmdConfiguracao.TabIndex = 0;
            this.cmdConfiguracao.Text = "Configuração";
            this.cmdConfiguracao.UseVisualStyleBackColor = true;
            this.cmdConfiguracao.Click += new System.EventHandler(this.cmdConfiguracao_Click);
            // 
            // cmdUpload
            // 
            this.cmdUpload.Location = new System.Drawing.Point(12, 12);
            this.cmdUpload.Name = "cmdUpload";
            this.cmdUpload.Size = new System.Drawing.Size(112, 51);
            this.cmdUpload.TabIndex = 1;
            this.cmdUpload.Text = "Enviar Arquivos";
            this.cmdUpload.UseVisualStyleBackColor = true;
            this.cmdUpload.Click += new System.EventHandler(this.cmdUpload_Click);
            // 
            // cmdDownload
            // 
            this.cmdDownload.Location = new System.Drawing.Point(130, 12);
            this.cmdDownload.Name = "cmdDownload";
            this.cmdDownload.Size = new System.Drawing.Size(112, 51);
            this.cmdDownload.TabIndex = 2;
            this.cmdDownload.Text = "Baixar Arquivos";
            this.cmdDownload.UseVisualStyleBackColor = true;
            this.cmdDownload.Click += new System.EventHandler(this.cmdDownload_Click);
            // 
            // cmdVisualizar
            // 
            this.cmdVisualizar.Location = new System.Drawing.Point(248, 12);
            this.cmdVisualizar.Name = "cmdVisualizar";
            this.cmdVisualizar.Size = new System.Drawing.Size(112, 51);
            this.cmdVisualizar.TabIndex = 3;
            this.cmdVisualizar.Text = "Visualizar Arquivos";
            this.cmdVisualizar.UseVisualStyleBackColor = true;
            this.cmdVisualizar.Click += new System.EventHandler(this.cmdVisualizar_Click);
            // 
            // cmdDeletar
            // 
            this.cmdDeletar.Location = new System.Drawing.Point(366, 12);
            this.cmdDeletar.Name = "cmdDeletar";
            this.cmdDeletar.Size = new System.Drawing.Size(120, 51);
            this.cmdDeletar.TabIndex = 4;
            this.cmdDeletar.Text = "DeletarArquivos";
            this.cmdDeletar.UseVisualStyleBackColor = true;
            this.cmdDeletar.Click += new System.EventHandler(this.cmdDeletar_Click);
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(12, 70);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(146, 17);
            this.lblService.TabIndex = 5;
            this.lblService.Text = "Google Drive Service:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(155, 70);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(20, 17);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "...";
            // 
            // rbAutomaticoOn
            // 
            this.rbAutomaticoOn.AutoSize = true;
            this.rbAutomaticoOn.Location = new System.Drawing.Point(6, 31);
            this.rbAutomaticoOn.Name = "rbAutomaticoOn";
            this.rbAutomaticoOn.Size = new System.Drawing.Size(72, 21);
            this.rbAutomaticoOn.TabIndex = 7;
            this.rbAutomaticoOn.TabStop = true;
            this.rbAutomaticoOn.Text = "Ligado";
            this.rbAutomaticoOn.UseVisualStyleBackColor = true;
            this.rbAutomaticoOn.Click += new System.EventHandler(this.rbAutomaticoOn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDesligado);
            this.groupBox1.Controls.Add(this.rbAutomaticoOn);
            this.groupBox1.Location = new System.Drawing.Point(641, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 63);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Automático";
            // 
            // rbDesligado
            // 
            this.rbDesligado.AutoSize = true;
            this.rbDesligado.Location = new System.Drawing.Point(84, 31);
            this.rbDesligado.Name = "rbDesligado";
            this.rbDesligado.Size = new System.Drawing.Size(92, 21);
            this.rbDesligado.TabIndex = 8;
            this.rbDesligado.TabStop = true;
            this.rbDesligado.Text = "Desligado";
            this.rbDesligado.UseVisualStyleBackColor = true;
            this.rbDesligado.Click += new System.EventHandler(this.rbDesligado_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 89);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.cmdDeletar);
            this.Controls.Add(this.cmdVisualizar);
            this.Controls.Add(this.cmdDownload);
            this.Controls.Add(this.cmdUpload);
            this.Controls.Add(this.cmdConfiguracao);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeletarArquivos";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimerAuto;
        private System.Windows.Forms.Button cmdConfiguracao;
        private System.Windows.Forms.Button cmdUpload;
        private System.Windows.Forms.Button cmdDownload;
        private System.Windows.Forms.Button cmdVisualizar;
        private System.Windows.Forms.Button cmdDeletar;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RadioButton rbAutomaticoOn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDesligado;
    }
}