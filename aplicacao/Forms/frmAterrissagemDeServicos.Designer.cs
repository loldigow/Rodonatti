namespace aplicacao.Forms
{
    partial class frmAterrissagemDeServicos
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
            this.dgvServicos = new aplicacao.Forms.Controles.DataGrideViewFacil();
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblServico = new System.Windows.Forms.Label();
            this.pesquisaServico1 = new aplicacao.Forms.Controles.PesquisaServico();
            this.bsServicos = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsServicos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvServicos
            // 
            this.dgvServicos.Location = new System.Drawing.Point(6, 128);
            this.dgvServicos.Name = "dgvServicos";
            this.dgvServicos.Size = new System.Drawing.Size(443, 228);
            this.dgvServicos.TabIndex = 5;
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(463, 126);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(75, 23);
            this.btnCriar.TabIndex = 6;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(463, 155);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(463, 334);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(463, 184);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Location = new System.Drawing.Point(6, 95);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(89, 13);
            this.lblServico.TabIndex = 10;
            this.lblServico.Text = "Pesquisa Serviço";
            // 
            // pesquisaServico1
            // 
            this.pesquisaServico1.Location = new System.Drawing.Point(102, 92);
            this.pesquisaServico1.Name = "pesquisaServico1";
            this.pesquisaServico1.Size = new System.Drawing.Size(347, 20);
            this.pesquisaServico1.TabIndex = 11;
            // 
            // frmAterrissagemDeServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 387);
            this.Controls.Add(this.pesquisaServico1);
            this.Controls.Add(this.lblServico);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.dgvServicos);
            this.Name = "frmAterrissagemDeServicos";
            this.Text = "frmCadastroDeServicos";
            this.Controls.SetChildIndex(this.dgvServicos, 0);
            this.Controls.SetChildIndex(this.btnCriar, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.lblServico, 0);
            this.Controls.SetChildIndex(this.pesquisaServico1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bsServicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.DataGrideViewFacil dgvServicos;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblServico;
        private Controles.PesquisaServico pesquisaServico1;
        private System.Windows.Forms.BindingSource bsServicos;
    }
}