using Core.Inconsistencias;
using Core.Negocio.Classes;
using Core.Processos;
using System;
using System.Windows.Forms;

namespace aplicacao.Forms.SubTelas
{
    public partial class frmCadastroServico : frmBase
    {
        public frmCadastroServico(Servico servico = null)
        {
            InitializeComponent();
            this.NomeDaFuncao = "Cadastro de Serviço";
            this.inpCodigo.Text = "0";
            if (servico != null)
            {
                CarregueServico(servico);
            }
        }

        private void CarregueServico(Servico servico)
        {
            inpCodigo.Text = servico.Codigo.ToString();
            inpDescricao.Text = servico.Descricao;
            inpNome.Text = servico.Nome;
            inpValor.Valor = servico.Valor;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!PodeProsseguir()) return;
                var servico = CrieServico();
                new ProcessoDeServico().CrieOuAtualize(servico);
                MessageBox.Show("Cadastro realizado com sucesso", "Aviso de sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception erro)
            {
                var excessao = new PublicadorDeExcessoes.PublicadorDeExcessoes(erro);
                excessao.Show();
            }
        }

        private Servico CrieServico()
        {
            return new Servico()
            {
                Codigo = Convert.ToInt32(inpCodigo.Text),
                Nome = inpNome.Text,
                Valor = inpValor.Valor,
                Descricao = inpDescricao.Text
            };
        }

        private bool PodeProsseguir()
        {
            if (inpCodigo.Equals(string.Empty))
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
