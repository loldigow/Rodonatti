using Core.Processos;
using System;
using Core.Negocio.Classes;
using Core.Inconsistencias;
using System.Windows.Forms;

namespace aplicacao.Forms.SubTelas
{
    public partial class frmCadastroDeProdutos : frmBase
    {
        public frmCadastroDeProdutos(Produto produto = null)
        {
            InitializeComponent();
            this.NomeDaFuncao = "Cadastro de Produtos";
            this.inpCodigo.Text = "0";
            if(produto != null)
            {
                CarregueProduto(produto);
            }
        }

        private void CarregueProduto(Produto produto)
        {
            inpCodigo.Text = produto.Codigo.ToString();
            inpDescricao.Text = produto.Descricao;
            inpNome.Text = produto.Nome;
            inpValor.Valor = produto.Valor;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!PodeProsseguir()) return;
                var produto = CrieProduto();
                new ProcessoDeProduto().CrieOuAtualize(produto);
                MessageBox.Show("Cadastro realizado com sucesso", "Aviso de sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch(Exception erro)
            {
               var excessao = new  PublicadorDeExcessoes.PublicadorDeExcessoes(erro);
                excessao.Show();
            }
        }

        private Produto CrieProduto()
        {
            return new Produto()
            {
                Codigo = Convert.ToInt32(inpCodigo.Text),
                Nome = inpNome.Text,
                Valor = inpValor.Valor,
                Descricao = inpDescricao.Text
            };
        }

        private bool PodeProsseguir()
        {
            if(inpNome.Equals(string.Empty))
            {
               new PublicadorDeExcessoes.PublicadorDeExcessoes(new InconsistenciaException("Campo Nome Vazio."));
                return false;
            }

            double valor = inpValor.Valor;
            if (valor < 0)
            {
                new PublicadorDeExcessoes.PublicadorDeExcessoes(new InconsistenciaException("Valor negativo."));
                return false;
            }

            return true;
        }
    }
}
