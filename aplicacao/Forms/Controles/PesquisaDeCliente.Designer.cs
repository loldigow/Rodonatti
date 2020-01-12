namespace aplicacao.Forms.Controles
{
    partial class PesquisaDeCliente
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
            this.cboTipoCliente = new System.Windows.Forms.ComboBox();
            this.cboPesquisaCliente = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bsTipoCliente = new System.Windows.Forms.BindingSource(this.components);
            this.bsClientes = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTipoCliente
            // 
            this.cboTipoCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboTipoCliente.FormattingEnabled = true;
            this.cboTipoCliente.Items.AddRange(new object[] {
            "<TODOS>"});
            this.cboTipoCliente.Location = new System.Drawing.Point(0, 0);
            this.cboTipoCliente.Name = "cboTipoCliente";
            this.cboTipoCliente.Size = new System.Drawing.Size(97, 21);
            this.cboTipoCliente.TabIndex = 0;
            this.cboTipoCliente.SelectedIndexChanged += new System.EventHandler(this.cboTipoCliente_SelectedIndexChanged);
            // 
            // cboPesquisaCliente
            // 
            this.cboPesquisaCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboPesquisaCliente.FormattingEnabled = true;
            this.cboPesquisaCliente.Location = new System.Drawing.Point(0, 0);
            this.cboPesquisaCliente.Name = "cboPesquisaCliente";
            this.cboPesquisaCliente.Size = new System.Drawing.Size(403, 21);
            this.cboPesquisaCliente.TabIndex = 1;
            this.cboPesquisaCliente.TextChanged += new System.EventHandler(this.cboPesquisaCliente_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboTipoCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(97, 22);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboPesquisaCliente);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(97, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 22);
            this.panel2.TabIndex = 3;
            // 
            // PesquisaDeCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PesquisaDeCliente";
            this.Size = new System.Drawing.Size(500, 22);
            this.Load += new System.EventHandler(this.PesquisaDeCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTipoCliente;
        private System.Windows.Forms.ComboBox cboPesquisaCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource bsTipoCliente;
        private System.Windows.Forms.BindingSource bsClientes;
    }
}
