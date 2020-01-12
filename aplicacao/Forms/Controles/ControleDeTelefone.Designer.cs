namespace aplicacao.Forms.Controles
{
    partial class ControleDeTelefone
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
            this.lblTelefone = new System.Windows.Forms.Label();
            this.inpDDD = new System.Windows.Forms.MaskedTextBox();
            this.inpTelefone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(4, 8);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(31, 13);
            this.lblTelefone.TabIndex = 0;
            this.lblTelefone.Text = "Fone";
            // 
            // inpDDD
            // 
            this.inpDDD.Location = new System.Drawing.Point(41, 5);
            this.inpDDD.Name = "inpDDD";
            this.inpDDD.Size = new System.Drawing.Size(35, 20);
            this.inpDDD.TabIndex = 1;
            // 
            // inpTelefone
            // 
            this.inpTelefone.Location = new System.Drawing.Point(82, 5);
            this.inpTelefone.Name = "inpTelefone";
            this.inpTelefone.Size = new System.Drawing.Size(112, 20);
            this.inpTelefone.TabIndex = 2;
            // 
            // ControleDeTelefone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.inpTelefone);
            this.Controls.Add(this.inpDDD);
            this.Controls.Add(this.lblTelefone);
            this.Name = "ControleDeTelefone";
            this.Size = new System.Drawing.Size(202, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox inpDDD;
        private System.Windows.Forms.MaskedTextBox inpTelefone;
    }
}
