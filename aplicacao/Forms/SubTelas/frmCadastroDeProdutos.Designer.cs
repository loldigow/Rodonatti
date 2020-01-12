namespace aplicacao.Forms.SubTelas
{
    partial class frmCadastroDeProdutos
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.inpValor = new aplicacao.Forms.Controles.inpDouble();
            this.inpDescricao = new System.Windows.Forms.RichTextBox();
            this.inpNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDescricaoProduto = new System.Windows.Forms.Label();
            this.inpCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.inpValor);
            this.panel2.Controls.Add(this.inpDescricao);
            this.panel2.Controls.Add(this.inpNome);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblDescricaoProduto);
            this.panel2.Controls.Add(this.inpCodigo);
            this.panel2.Controls.Add(this.lblCodigo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 180);
            this.panel2.TabIndex = 6;
            // 
            // inpValor
            // 
            this.inpValor.Location = new System.Drawing.Point(188, 12);
            this.inpValor.Name = "inpValor";
            this.inpValor.Size = new System.Drawing.Size(71, 20);
            this.inpValor.TabIndex = 3;
            this.inpValor.Valor = 0D;
            // 
            // inpDescricao
            // 
            this.inpDescricao.Location = new System.Drawing.Point(82, 66);
            this.inpDescricao.Name = "inpDescricao";
            this.inpDescricao.Size = new System.Drawing.Size(277, 96);
            this.inpDescricao.TabIndex = 5;
            this.inpDescricao.Text = "";
            // 
            // inpNome
            // 
            this.inpNome.Location = new System.Drawing.Point(82, 39);
            this.inpNome.Name = "inpNome";
            this.inpNome.Size = new System.Drawing.Size(277, 20);
            this.inpNome.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor";
            // 
            // lblDescricaoProduto
            // 
            this.lblDescricaoProduto.AutoSize = true;
            this.lblDescricaoProduto.Location = new System.Drawing.Point(22, 66);
            this.lblDescricaoProduto.Name = "lblDescricaoProduto";
            this.lblDescricaoProduto.Size = new System.Drawing.Size(55, 13);
            this.lblDescricaoProduto.TabIndex = 2;
            this.lblDescricaoProduto.Text = "Descrição";
            // 
            // inpCodigo
            // 
            this.inpCodigo.Enabled = false;
            this.inpCodigo.Location = new System.Drawing.Point(83, 12);
            this.inpCodigo.Name = "inpCodigo";
            this.inpCodigo.Size = new System.Drawing.Size(58, 20);
            this.inpCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(36, 16);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSalvar);
            this.panel3.Controls.Add(this.btnSair);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(368, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(123, 180);
            this.panel3.TabIndex = 7;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(25, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(25, 143);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmCadastroDeProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 286);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(507, 325);
            this.MinimumSize = new System.Drawing.Size(507, 325);
            this.Name = "frmCadastroDeProdutos";
            this.Text = "frmCadastroDeProdutos";
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox inpDescricao;
        private System.Windows.Forms.TextBox inpNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDescricaoProduto;
        private System.Windows.Forms.TextBox inpCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
        private Controles.inpDouble inpValor;
    }
}