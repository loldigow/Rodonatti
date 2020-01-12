namespace aplicacao.Forms.Controles
{
    partial class inpDouble
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
            this.inpValor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inpValor
            // 
            this.inpValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inpValor.Location = new System.Drawing.Point(0, 0);
            this.inpValor.Name = "inpValor";
            this.inpValor.Size = new System.Drawing.Size(179, 20);
            this.inpValor.TabIndex = 0;
            this.inpValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // inpDecimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.inpValor);
            this.Name = "inpDecimal";
            this.Size = new System.Drawing.Size(179, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inpValor;
    }
}
