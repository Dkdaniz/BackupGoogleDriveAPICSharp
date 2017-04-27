namespace Backup
{
    partial class frmVisualizarArquivos
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
            this.grdArquivo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdArquivo)).BeginInit();
            this.SuspendLayout();
            // 
            // grdArquivo
            // 
            this.grdArquivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdArquivo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.grdArquivo.Location = new System.Drawing.Point(12, 12);
            this.grdArquivo.Name = "grdArquivo";
            this.grdArquivo.RowTemplate.Height = 24;
            this.grdArquivo.Size = new System.Drawing.Size(655, 273);
            this.grdArquivo.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Arquivo";
            this.Column1.Name = "Column1";
            this.Column1.Width = 580;
            // 
            // cmdAtualizar
            // 
            this.cmdAtualizar.Location = new System.Drawing.Point(673, 12);
            this.cmdAtualizar.Name = "cmdAtualizar";
            this.cmdAtualizar.Size = new System.Drawing.Size(89, 29);
            this.cmdAtualizar.TabIndex = 4;
            this.cmdAtualizar.Text = "Atualizar";
            this.cmdAtualizar.UseVisualStyleBackColor = true;
            this.cmdAtualizar.Click += new System.EventHandler(this.cmdAtualizar_Click);
            // 
            // frmVisualizarArquivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 292);
            this.Controls.Add(this.grdArquivo);
            this.Controls.Add(this.cmdAtualizar);
            this.Name = "frmVisualizarArquivos";
            this.Text = "frmVisualizarArquivos";
            this.Load += new System.EventHandler(this.frmVisualizarArquivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdArquivo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdArquivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button cmdAtualizar;
    }
}