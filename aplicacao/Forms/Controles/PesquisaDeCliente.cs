using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Core.DTO;
using Core.Enumeradores.Enumeradores;
using Core.Negocio.Classes;
using Core.Processos;

namespace aplicacao.Forms.Controles
{
    public partial class PesquisaDeCliente : UserControl
    {
        private IEnumerable<ClienteMV> _chacheClientes = new List<ClienteMV>();
        public PesquisaDeCliente()
        {
            InitializeComponent();
        }
        private void AjustaCboCliente()
        {
            cboPesquisaCliente.DisplayMember = nameof(ClienteMV.Descricao);
            cboPesquisaCliente.ValueMember = nameof(ClienteMV.Descricao);
            cboPesquisaCliente.DataSource = bsClientes;
        }
        private void AjustaCboTipoCliente()
        {
            cboTipoCliente.DisplayMember = nameof(TipoDeClienteMV.Descricao);
            cboTipoCliente.ValueMember = nameof(TipoDeClienteMV.Descricao);
            cboTipoCliente.DataSource = bsTipoCliente;
        }
        private void PesquisaDeCliente_Load(object sender, EventArgs e)
        {
            Pesquise();
        }

        public void Pesquise()
        {
            ObtenhaTipoClientes();

            ObtenhaClientes();
        }

        private void ObtenhaClientes()
        {
            var parametros = ObtenhaParametros();
            var clientes = new ProcessoDeCliente().Pesquise(parametros);
            _chacheClientes = clientes.Select(x => new ClienteMV(x));
            bsClientes.DataSource = _chacheClientes;
            AjustaCboCliente();
        }

        private DTOPesquisaCliente ObtenhaParametros()
        {
            return new DTOPesquisaCliente()
            {
                Nome = cboPesquisaCliente.Text
            };
        }

        private void ObtenhaTipoClientes()
        {
            var tipoDeCliente = EnumeradorDeTipoDeCliente.ObtenhaTodos<EnumeradorDeTipoDeCliente>();
            bsTipoCliente.DataSource = tipoDeCliente.Select(x => new TipoDeClienteMV(x));
            AjustaCboTipoCliente();
        }

        private void cboTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoCliente.SelectedItem is TipoDeClienteMV tipoSelecionado)
            {
                bsClientes.DataSource = _chacheClientes.Where(x => x.Tipo.Equals(tipoSelecionado.Tipo));
                bsClientes.ResetBindings(true);
            }
        }
        public void AoSelecionarCliente(EventHandler evento)
        {
            this.cboPesquisaCliente.SelectedIndexChanged += evento;
        }
        public void AoSelecionarTipoDeCliente(EventHandler evento)
        {
            this.cboTipoCliente.SelectedIndexChanged += evento;
        }
        public ICliente ObtenhaSelecionado()
        {
            if(cboPesquisaCliente.SelectedItem is ClienteMV clienteSelecionado)
            {
                return clienteSelecionado.Cliente;
            }
            return null;
        }


        #region ModelViews
        private class TipoDeClienteMV
        {
            public EnumeradorDeTipoDeCliente Tipo { get; private set; }
            public TipoDeClienteMV(EnumeradorDeTipoDeCliente tipo)
            {
                Tipo = tipo;
            }
            public string Descricao => Tipo.Descricao;
        }
        private class ClienteMV
        {
            public ICliente Cliente;
            public ClienteMV(ICliente cliente)
            {
                Cliente = cliente;
            }
            public string Descricao => Cliente.Nome;
            public EnumeradorDeTipoDeCliente Tipo => Cliente.ClienteTipo;
        }
        #endregion

        private void cboPesquisaCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
