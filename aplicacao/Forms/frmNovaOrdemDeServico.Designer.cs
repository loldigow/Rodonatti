namespace aplicacao.Forms
{
    partial class frmNovaOrdemDeServico
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
            this.pesquisaDeCliente1 = new aplicacao.Forms.Controles.PesquisaDeCliente();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.inpCodigo = new System.Windows.Forms.TextBox();
            this.inpData = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionarServico = new System.Windows.Forms.Button();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.dgvProdutoServico = new aplicacao.Forms.Controles.DataGrideViewFacil();
            this.bsProdutoServico = new System.Windows.Forms.BindingSource(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProdutoServico)).BeginInit();
            this.SuspendLayout();
            // 
            // pesquisaDeCliente1
            // 
            this.pesquisaDeCliente1.Location = new System.Drawing.Point(53, 41);
            this.pesquisaDeCliente1.Name = "pesquisaDeCliente1";
            this.pesquisaDeCliente1.Size = new System.Drawing.Size(471, 22);
            this.pesquisaDeCliente1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cliente";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(853, 385);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ordem";
            // 
            // inpCodigo
            // 
            this.inpCodigo.Enabled = false;
            this.inpCodigo.Location = new System.Drawing.Point(53, 15);
            this.inpCodigo.Name = "inpCodigo";
            this.inpCodigo.Size = new System.Drawing.Size(100, 20);
            this.inpCodigo.TabIndex = 9;
            // 
            // inpData
            // 
            this.inpData.Location = new System.Drawing.Point(239, 15);
            this.inpData.Name = "inpData";
            this.inpData.Size = new System.Drawing.Size(100, 20);
            this.inpData.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data Emissão";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(853, 88);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(853, 117);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemover);
            this.groupBox2.Controls.Add(this.btnAdicionarServico);
            this.groupBox2.Controls.Add(this.btnAdicionarProduto);
            this.groupBox2.Controls.Add(this.dgvProdutoServico);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.inpCodigo);
            this.groupBox2.Controls.Add(this.inpData);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pesquisaDeCliente1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(825, 332);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(733, 127);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 16;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionarServico
            // 
            this.btnAdicionarServico.Location = new System.Drawing.Point(733, 98);
            this.btnAdicionarServico.Name = "btnAdicionarServico";
            this.btnAdicionarServico.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarServico.TabIndex = 15;
            this.btnAdicionarServico.Text = "Servico";
            this.btnAdicionarServico.UseVisualStyleBackColor = true;
            this.btnAdicionarServico.Click += new System.EventHandler(this.AdidionarServico_Onclick);
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Location = new System.Drawing.Point(733, 70);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarProduto.TabIndex = 15;
            this.btnAdicionarProduto.Text = "Produto";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.Insiraproduto_Click);
            // 
            // dgvProdutoServico
            // 
            this.dgvProdutoServico.Location = new System.Drawing.Point(12, 69);
            this.dgvProdutoServico.Name = "dgvProdutoServico";
            this.dgvProdutoServico.Size = new System.Drawing.Size(701, 251);
            this.dgvProdutoServico.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(625, 426);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(591, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total";
            // 
            // frmNovaOrdemDeServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 486);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnSair);
            this.Name = "frmNovaOrdemDeServico";
            this.Text = "frmNovaOrdemDeServico";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnLimpar, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.textBox3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProdutoServico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.PesquisaDeCliente pesquisaDeCliente1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inpCodigo;
        private System.Windows.Forms.MaskedTextBox inpData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdicionarServico;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private Controles.DataGrideViewFacil dgvProdutoServico;
        private System.Windows.Forms.BindingSource bsProdutoServico;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
    }
}