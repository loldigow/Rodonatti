using System;
using System.Linq;
using System.Windows.Forms;
using aplicacao.Forms.SubTelas;
using Core.Negocio.Classes;
using Core.Processos;

namespace aplicacao.Forms
{
    public partial class frmAterrissagemDeClientes : frmBase
    {
        class ClienteMV
        {
            public ICliente Cliente;
            public ClienteMV(ICliente cliente)
            {
                Cliente = cliente;
            }
            public string Nome => Cliente.Nome;
            public int Codigo => Cliente.Codigo;
            public string Tipo => Cliente.ClienteTipo.Descricao;
        }


        public frmAterrissagemDeClientes() : base()
        {
            InitializeComponent();
            InicializeGrideView();
            this.lblNomeFuncaoTela.Text = "Informações de Clientes";

            //pesquisaClientes.AoSelecionarCliente((object sender, EventArgs e) => {
            //    var clienteFiltrado = pesquisaClientes.ObtenhaSelecionado();
            //    if (clienteFiltrado != null)
            //    {
            //        bsClientes.DataSource = new ClienteMV(clienteFiltrado);
            //        bsClientes.ResetBindings(true);
            //    }
            //});

            pesquisaClientes.AoSelecionarTipoDeCliente((object sender, EventArgs e) => {

            });

        }

        private void InicializeGrideView()
        {
            dgvClientes.AdicioneBindingSource(bsClientes);
            dgvClientes.AdicioneColuna("codigo", nameof(ClienteMV.Codigo), 40);
            dgvClientes.AdicioneColuna("Tipo", nameof(ClienteMV.Tipo), 80);
            dgvClientes.AdicioneColunaFill("Nome", nameof(ClienteMV.Nome));
            dgvClientes.AjustaSelecaoDeLinha(DataGridViewSelectionMode.FullRowSelect);
            dgvClientes.MultiSelecao(false);
            dgvClientes.DesabiliteCabecalhoLinha();

        }

        private void btnSair_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }



        private void btnNovo_Click(object sender, EventArgs e)
        {
            var telaDeCadastro = new frmCadastroCliente();
            telaDeCadastro.FormClosed += frmCadastroDeClientes_Closed;
            pesquisaClientes.Pesquise();
            telaDeCadastro.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(bsClientes.Current is ClienteMV selecionado)
            {
                var telaDeCadastro = new frmCadastroCliente(selecionado.Cliente);
                telaDeCadastro.FormClosed += frmCadastroDeClientes_Closed;
                telaDeCadastro.Show();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (bsClientes.Current is ClienteMV selecionado)
            {
                if(MessageBox.Show("Deseja remover cliente selecionado?", "Exclusão de cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try {
                        new ProcessoDeCliente().Exclua(selecionado.Cliente);
                        MessageBox.Show("Cliente Excluido com sucesso!");
                        CarregueParcial();
                    }
                    catch(Exception excessao)
                    {
                        var publicador = new PublicadorDeExcessoes.PublicadorDeExcessoes(excessao);
                        publicador.Show();
                    }
                    
                }
            }
        }

        private void frmCadastroDeClientes_Load(object sender, EventArgs e)
        {
            CarregueParcial();
        }

        private void CarregueParcial()
        {
            var clientes = new ProcessoDeCliente().Obtenha100Clientes();
            bsClientes.DataSource = clientes.Select(x => new ClienteMV(x));
            pesquisaClientes.Pesquise();
            bsClientes.ResetBindings(true);
        }

        private void frmCadastroDeClientes_Closed(object sender, EventArgs e)
        {
            CarregueParcial();
        }
    }
}
