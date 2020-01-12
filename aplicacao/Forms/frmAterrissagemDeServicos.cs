using System;
using System.Linq;
using System.Windows.Forms;
using aplicacao.Forms.SubTelas;
using Core.Negocio.Classes;
using Core.Processos;
using Core;

namespace aplicacao.Forms
{
    public partial class frmAterrissagemDeServicos : frmBase
    {
        public Servico Selecionado { get; private set; }

        public frmAterrissagemDeServicos()
        {
            InitializeComponent();
            InicializeDgv();
            lblNomeFuncaoTela.Text = "Informações de Serviços";
            CarregueServicos();
        }

        private void InicializeDgv()
        {
            dgvServicos.AdicioneBindingSource(bsServicos);
            dgvServicos.AdicioneColuna("Código", nameof(ServicoVM.Codigo), 40);
            dgvServicos.AdicioneColunaFill("Nome", nameof(ServicoVM.Nome));
            dgvServicos.AdicioneColuna("Valor", nameof(ServicoVM.Valor), 80);
            dgvServicos.AjustaSelecaoDeLinha(DataGridViewSelectionMode.FullRowSelect);
            dgvServicos.MultiSelecao(false);
            dgvServicos.DesabiliteCabecalhoLinha();

        }

        private void btnCriar_Click(object sender, System.EventArgs e)
        {
            var telaDeCadastro = new frmCadastroServico();
            if (telaDeCadastro != null)
            {
                telaDeCadastro.FormClosed += frmCadastroDeProdutos_FormClosed;
                telaDeCadastro.Show();
            }
            CarregueServicos();
        }

        private void frmCadastroDeProdutos_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregueServicos();
        }

        private void CarregueServicos()
        {
            var servicos = new ProcessoDeServico().ObtenhaParcial();
            bsServicos.DataSource = servicos.Select(x => new ServicoVM(x));
            bsServicos.ResetBindings(true);
        }

        private void btnEditar_Click(object sender, System.EventArgs e)
        {
            if (bsServicos.Current is ServicoVM selecionado)
            {
                var telaDeEdicao = new frmCadastroServico(selecionado.Servico);
                if (telaDeEdicao != null)
                {
                    telaDeEdicao.FormClosed += frmCadastroDeProdutos_FormClosed;
                    telaDeEdicao.Show();
                }
            }
            CarregueServicos();
        }

        private void btnExcluir_Click(object sender, System.EventArgs e)
        {
            if (bsServicos.Current is ServicoVM selecionado)
            {
                new ProcessoDeServico().Exclua(selecionado.Servico);
            }
            CarregueServicos();
        }

        internal void AjusteParaAdicionarNaOrdemDeServico()
        {
            btnEditar.Visible = false;
            btnExcluir.Visible = false;
            dgvServicos.AjusteCliqueDuplo(EventoDeCliqueDuplo);
        }

        private void EventoDeCliqueDuplo(object sender, System.EventArgs e)
        {
            if (bsServicos.Current is ServicoVM selecionado)
            {
                Selecionado = selecionado.Servico;
            }
            Close();
        }

        private void btnSair_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private class ServicoVM
        {
            public Servico Servico;
            public ServicoVM(Servico servico)
            {
                Servico = servico;
            }

            public string Nome => Servico.Nome;
            public int Codigo => Servico.Codigo;
            public string Valor => Servico.Valor.ToStringFormatada();
        }
    }
}
