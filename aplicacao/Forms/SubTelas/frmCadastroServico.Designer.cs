namespace aplicacao.Forms.SubTelas
{
    partial class frmCadastroServico
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
            this.inpValor = new aplicacao.Forms.Controles.inpDouble();
            this.inpCodigo = new System.Windows.Forms.TextBox();
            this.inpNome = new System.Windows.Forms.TextBox();
            this.inpDescricao = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inpValor
            // 
            this.inpValor.Location = new System.Drawing.Point(200, 97);
            this.inpValor.Name = "inpValor";
            this.inpValor.Size = new System.Drawing.Size(90, 20);
            this.inpValor.TabIndex = 5;
            this.inpValor.Valor = 0D;
            // 
            // inpCodigo
            // 
            this.inpCodigo.Enabled = false;
            this.inpCodigo.Location = new System.Drawing.Point(80, 97);
            this.inpCodigo.Name = "inpCodigo";
            this.inpCodigo.Size = new System.Drawing.Size(66, 20);
            this.inpCodigo.TabIndex = 6;
            // 
            // inpNome
            // 
            this.inpNome.Location = new System.Drawing.Point(80, 123);
            this.inpNome.Name = "inpNome";
            this.inpNome.Size = new System.Drawing.Size(275, 20);
            this.inpNome.TabIndex = 7;
            // 
            // inpDescricao
            // 
            this.inpDescricao.Location = new System.Drawing.Point(80, 149);
            this.inpDescricao.Name = "inpDescricao";
            this.inpDescricao.Size = new System.Drawing.Size(275, 96);
            this.inpDescricao.TabIndex = 8;
            this.inpDescricao.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Descrição";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(375, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmCadastroServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 281);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inpDescricao);
            this.Controls.Add(this.inpNome);
            this.Controls.Add(this.inpCodigo);
            this.Controls.Add(this.inpValor);
            this.Name = "frmCadastroServico";
            this.Text = "frmCadastroServico";
            this.Controls.SetChildIndex(this.inpValor, 0);
            this.Controls.SetChildIndex(this.inpCodigo, 0);
            this.Controls.SetChildIndex(this.inpNome, 0);
            this.Controls.SetChildIndex(this.inpDescricao, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.inpDouble inpValor;
        private System.Windows.Forms.TextBox inpCodigo;
        private System.Windows.Forms.TextBox inpNome;
        private System.Windows.Forms.RichTextBox inpDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}