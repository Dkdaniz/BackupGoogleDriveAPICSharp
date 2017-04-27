namespace Backup
{
    partial class frmApagarArquivo
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
            this.cmdApagar = new System.Windows.Forms.Button();
            this.cmdAtualizar = new System.Windows.Forms.Button();
            this.grdArquivo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdArquivo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdApagar
            // 
            this.cmdApagar.Location = new System.Drawing.Point(673, 45);
            this.cmdApagar.Name = "cmdApagar";
            this.cmdApagar.Size = new System.Drawing.Size(89, 29);
            this.cmdApagar.TabIndex = 1;
            this.cmdApagar.Text = "Apagar";
            this.cmdApagar.UseVisualStyleBackColor = true;
            this.cmdApagar.Click += new System.EventHandler(this.cmdApagar_Click);
            // 
            // cmdAtualizar
            // 
            this.cmdAtualizar.Location = new System.Drawing.Point(673, 10);
            this.cmdAtualizar.Name = "cmdAtualizar";
            this.cmdAtualizar.Size = new System.Drawing.Size(89, 29);
            this.cmdAtualizar.TabIndex = 2;
            this.cmdAtualizar.Text = "Atualizar";
            this.cmdAtualizar.UseVisualStyleBackColor = true;
            this.cmdAtualizar.Click += new System.EventHandler(this.cmdAtualizar_Click_1);
            // 
            // grdArquivo
            // 
            this.grdArquivo.AllowUserToAddRows = false;
            this.grdArquivo.AllowUserToDeleteRows = false;
            this.grdArquivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdArquivo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.grdArquivo.Location = new System.Drawing.Point(12, 10);
            this.grdArquivo.MultiSelect = false;
            this.grdArquivo.Name = "grdArquivo";
            this.grdArquivo.RowTemplate.Height = 24;
            this.grdArquivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdArquivo.Size = new System.Drawing.Size(655, 273);
            this.grdArquivo.TabIndex = 3;
            this.grdArquivo.SelectionChanged += new System.EventHandler(this.grdArquivo_SelectionChanged);
            this.grdArquivo.Click += new System.EventHandler(this.grdArquivo_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Arquivo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 580;
            // 
            // frmApagarArquivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 289);
            this.Controls.Add(this.grdArquivo);
            this.Controls.Add(this.cmdAtualizar);
            this.Controls.Add(this.cmdApagar);
            this.Name = "frmApagarArquivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apagar Arquivos";
            this.Load += new System.EventHandler(this.frmApagarArquivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdArquivo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdApagar;
        private System.Windows.Forms.Button cmdAtualizar;
        private System.Windows.Forms.DataGridView grdArquivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}