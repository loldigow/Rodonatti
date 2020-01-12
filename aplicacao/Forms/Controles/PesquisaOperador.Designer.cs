namespace aplicacao.Forms.Controles
{
    partial class PesquisaOperador
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
            this.components = new System.ComponentModel.Container();
            this.cboPesquisaOperador = new System.Windows.Forms.ComboBox();
            this.bsOperador = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsOperador)).BeginInit();
            this.SuspendLayout();
            // 
            // cboPesquisaOperador
            // 
            this.cboPesquisaOperador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboPesquisaOperador.FormattingEnabled = true;
            this.cboPesquisaOperador.Location = new System.Drawing.Point(0, 0);
            this.cboPesquisaOperador.Name = "cboPesquisaOperador";
            this.cboPesquisaOperador.Size = new System.Drawing.Size(320, 21);
            this.cboPesquisaOperador.TabIndex = 0;
            // 
            // PesquisaOperador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboPesquisaOperador);
            this.Name = "PesquisaOperador";
            this.Size = new System.Drawing.Size(320, 21);
            this.Load += new System.EventHandler(this.PesquisaOperador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsOperador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPesquisaOperador;
        private System.Windows.Forms.BindingSource bsOperador;
    }
}
