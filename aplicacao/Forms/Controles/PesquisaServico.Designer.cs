namespace aplicacao.Forms.Controles
{
    partial class PesquisaServico
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboServico = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboServico
            // 
            this.cboServico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboServico.FormattingEnabled = true;
            this.cboServico.Location = new System.Drawing.Point(0, 0);
            this.cboServico.Name = "cboServico";
            this.cboServico.Size = new System.Drawing.Size(457, 21);
            this.cboServico.TabIndex = 0;
            // 
            // PesquisaServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboServico);
            this.Name = "PesquisaServico";
            this.Size = new System.Drawing.Size(457, 20);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboServico;
    }
}
