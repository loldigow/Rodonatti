namespace aplicacao.Forms.Controles
{
    partial class DataGrideViewFacil
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
            this.DataGrideView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrideView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrideView
            // 
            this.DataGrideView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrideView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrideView.Location = new System.Drawing.Point(0, 0);
            this.DataGrideView.Name = "DataGrideView";
            this.DataGrideView.Size = new System.Drawing.Size(300, 191);
            this.DataGrideView.TabIndex = 0;
            // 
            // DataGrideViewFacil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DataGrideView);
            this.Name = "DataGrideViewFacil";
            this.Size = new System.Drawing.Size(300, 191);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrideView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrideView;
    }
}
