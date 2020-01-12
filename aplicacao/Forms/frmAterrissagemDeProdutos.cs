using System;
using System.Linq;
using System.Windows.Forms;
using aplicacao.Forms.SubTelas;
using Core.Negocio.Classes;
using Core.Processos;
using Core;

namespace aplicacao.Forms
{
    public partial class frmAterrissagemDeProdutos : frmBase
    {
        public Produto Selecionado { get; internal set; }
        public frmAterrissagemDeProdutos()
        {
            InitializeComponent();
            InicializeDgv();
            lblNomeFuncaoTela.Text = "Informações de Produtos";
        }

        private void InicializeDgv()
        {
            dgvProdutos.AdicioneBindingSource(bsProdutos);
            dgvProdutos.AdicioneColuna("Código", nameof(ProdutoVM.Codigo), 40);
            dgvProdutos.AdicioneColunaFill("Nome", nameof(ProdutoVM.Nome));
            dgvProdutos.AdicioneColuna("Valor", nameof(ProdutoVM.Valor),80);

            dgvProdutos.AjustaSelecaoDeLinha(DataGridViewSelectionMode.FullRowSelect);
            dgvProdutos.MultiSelecao(false);
            dgvProdutos.DesabiliteCabecalhoLinha();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (bsProdutos.Current is ProdutoVM selecionado)
            {
                var telaDeEdicao = new frmCadastroDeProdutos(selecionado.Produto);
                if (telaDeEdicao != null)
                {
                    telaDeEdicao.FormClosed += frmCadastroDeProdutos_FormClosed;
                    telaDeEdicao.Show();
                }
            }
            CarregueProdutos();
        }

        internal void AjusteParaAdicionarNaOrdemDeServico()
        {
            btnEditar.Visible = false;
            btnExcluir.Visible = false;
            dgvProdutos.AjusteCliqueDuplo(EventoDeCliqueDuplo);
        }
        private void EventoDeCliqueDuplo(object sender, System.EventArgs e)
        {
            if (bsProdutos.Current is ProdutoVM selecionado)
            {
                Selecionado = selecionado.Produto;
            }
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var telaDeCadastro = new frmCadastroDeProdutos();
            if(telaDeCadastro != null)
            {
                telaDeCadastro.FormClosed += frmCadastroDeProdutos_FormClosed;
                telaDeCadastro.Show();
            }
            CarregueProdutos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (bsProdutos.Current is ProdutoVM selecionado)
            {
                new ProcessoDeProduto().Exclua(selecionado.Produto);
            }
            CarregueProdutos();
        }

        private void frmCadastroDeProdutos_Load(object sender, EventArgs e)
        {
            CarregueProdutos();
        }

        private void CarregueProdutos()
        {
            var produtos = new ProcessoDeProduto().ObtenhaParcial();
            bsProdutos.DataSource = produtos.Select(x => new ProdutoVM(x));
            bsProdutos.ResetBindings(true);
        }


        private class ProdutoVM
        {
            public Produto Produto;
            public ProdutoVM(Produto produto)
            {
                Produto = produto;
            }

            public string Nome => Produto.Nome;
            public int Codigo => Produto.Codigo;
            public string Valor => Produto.Valor.ToStringFormatada();
        }

        private void frmCadastroDeProdutos_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregueProdutos();
        }
    }
}
