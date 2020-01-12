namespace aplicacao
{
    partial class frmPrincipal
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeServiçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.aberturaDeCaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaCaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEmissoes = new System.Windows.Forms.ToolStripMenuItem();
            this.emissaoDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aberturaEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasESaidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordemDeServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOrdemServico = new System.Windows.Forms.ToolStripMenuItem();
            this.novaOrdemDeServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOperador = new System.Windows.Forms.Label();
            this.lblAmbiente = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastros,
            this.MenuCaixa,
            this.MenuEmissoes,
            this.MenuOrdemServico,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1081, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuCadastros
            // 
            this.MenuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeClientesToolStripMenuItem,
            this.cadastroDeProdutosToolStripMenuItem,
            this.cadastroDeServiçosToolStripMenuItem});
            this.MenuCadastros.Name = "MenuCadastros";
            this.MenuCadastros.Size = new System.Drawing.Size(71, 20);
            this.MenuCadastros.Text = "Cadastros";
            // 
            // cadastroDeClientesToolStripMenuItem
            // 
            this.cadastroDeClientesToolStripMenuItem.Name = "cadastroDeClientesToolStripMenuItem";
            this.cadastroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.cadastroDeClientesToolStripMenuItem.Text = "Cadastro de Clientes";
            this.cadastroDeClientesToolStripMenuItem.Click += new System.EventHandler(this.itemClick_generico);
            // 
            // cadastroDeProdutosToolStripMenuItem
            // 
            this.cadastroDeProdutosToolStripMenuItem.Name = "cadastroDeProdutosToolStripMenuItem";
            this.cadastroDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.cadastroDeProdutosToolStripMenuItem.Text = "Cadastro de Produtos";
            this.cadastroDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.itemClick_generico);
            // 
            // cadastroDeServiçosToolStripMenuItem
            // 
            this.cadastroDeServiçosToolStripMenuItem.Name = "cadastroDeServiçosToolStripMenuItem";
            this.cadastroDeServiçosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.cadastroDeServiçosToolStripMenuItem.Text = "Cadastro de Serviços";
            this.cadastroDeServiçosToolStripMenuItem.Click += new System.EventHandler(this.itemClick_generico);
            // 
            // MenuCaixa
            // 
            this.MenuCaixa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aberturaDeCaixaToolStripMenuItem,
            this.entradaCaixaToolStripMenuItem});
            this.MenuCaixa.Name = "MenuCaixa";
            this.MenuCaixa.Size = new System.Drawing.Size(48, 20);
            this.MenuCaixa.Text = "Caixa";
            // 
            // aberturaDeCaixaToolStripMenuItem
            // 
            this.aberturaDeCaixaToolStripMenuItem.Name = "aberturaDeCaixaToolStripMenuItem";
            this.aberturaDeCaixaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.aberturaDeCaixaToolStripMenuItem.Text = "Abertura de Caixa";
            this.aberturaDeCaixaToolStripMenuItem.Click += new System.EventHandler(this.itemClick_generico);
            // 
            // entradaCaixaToolStripMenuItem
            // 
            this.entradaCaixaToolStripMenuItem.Name = "entradaCaixaToolStripMenuItem";
            this.entradaCaixaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.entradaCaixaToolStripMenuItem.Text = "Entrada Caixa";
            this.entradaCaixaToolStripMenuItem.Click += new System.EventHandler(this.itemClick_generico);
            // 
            // MenuEmissoes
            // 
            this.MenuEmissoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emissaoDeProdutosToolStripMenuItem,
            this.aberturaEToolStripMenuItem,
            this.entradasESaidasToolStripMenuItem,
            this.ordemDeServiçoToolStripMenuItem});
            this.MenuEmissoes.Name = "MenuEmissoes";
            this.MenuEmissoes.Size = new System.Drawing.Size(67, 20);
            this.MenuEmissoes.Text = "Emissões";
            // 
            // emissaoDeProdutosToolStripMenuItem
            // 
            this.emissaoDeProdutosToolStripMenuItem.Name = "emissaoDeProdutosToolStripMenuItem";
            this.emissaoDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.emissaoDeProdutosToolStripMenuItem.Text = "Produtos";
            this.emissaoDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.itemClick_generico);
            // 
            // aberturaEToolStripMenuItem
            // 
            this.aberturaEToolStripMenuItem.Name = "aberturaEToolStripMenuItem";
            this.aberturaEToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.aberturaEToolStripMenuItem.Text = "Abertura e Fechamento do Caixa";
            this.aberturaEToolStripMenuItem.Click += new System.EventHandler(this.itemClick_generico);
            // 
            // entradasESaidasToolStripMenuItem
            // 
            this.entradasESaidasToolStripMenuItem.Name = "entradasESaidasToolStripMenuItem";
            this.entradasESaidasToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.entradasESaidasToolStripMenuItem.Text = "Entradas e Saidas";
            this.entradasESaidasToolStripMenuItem.Click += new System.EventHandler(this.itemClick_generico);
            // 
            // ordemDeServiçoToolStripMenuItem
            // 
            this.ordemDeServiçoToolStripMenuItem.Name = "ordemDeServiçoToolStripMenuItem";
            this.ordemDeServiçoToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.ordemDeServiçoToolStripMenuItem.Text = "Ordem de Serviço";
            this.ordemDeServiçoToolStripMenuItem.Click += new System.EventHandler(this.itemClick_generico);
            // 
            // MenuOrdemServico
            // 
            this.MenuOrdemServico.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaOrdemDeServiçoToolStripMenuItem});
            this.MenuOrdemServico.Name = "MenuOrdemServico";
            this.MenuOrdemServico.Size = new System.Drawing.Size(118, 20);
            this.MenuOrdemServico.Text = "Ordem de Serviços";
            // 
            // novaOrdemDeServiçoToolStripMenuItem
            // 
            this.novaOrdemDeServiçoToolStripMenuItem.Name = "novaOrdemDeServiçoToolStripMenuItem";
            this.novaOrdemDeServiçoToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.novaOrdemDeServiçoToolStripMenuItem.Text = "Nova Ordem de Serviço";
            this.novaOrdemDeServiçoToolStripMenuItem.Click += new System.EventHandler(this.itemClick_generico);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAmbiente);
            this.panel1.Controls.Add(this.lblOperador);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 539);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 19);
            this.panel1.TabIndex = 2;
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblOperador.Location = new System.Drawing.Point(0, 0);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(51, 13);
            this.lblOperador.TabIndex = 0;
            this.lblOperador.Text = "Operador";
            // 
            // lblAmbiente
            // 
            this.lblAmbiente.AutoSize = true;
            this.lblAmbiente.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblAmbiente.Location = new System.Drawing.Point(1030, 0);
            this.lblAmbiente.Name = "lblAmbiente";
            this.lblAmbiente.Size = new System.Drawing.Size(51, 13);
            this.lblAmbiente.TabIndex = 1;
            this.lblAmbiente.Text = "Ambiente";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1081, 558);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Menu Principal";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastros;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeServiçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuCaixa;
        private System.Windows.Forms.ToolStripMenuItem aberturaDeCaixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuEmissoes;
        private System.Windows.Forms.ToolStripMenuItem emissaoDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aberturaEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasESaidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuOrdemServico;
        private System.Windows.Forms.ToolStripMenuItem ordemDeServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaOrdemDeServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaCaixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAmbiente;
        private System.Windows.Forms.Label lblOperador;
    }
}

