using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Core.Processos;
using Core.Negocio.Classes;

namespace aplicacao.Forms.Controles
{
    public partial class PesquisaOperador : UserControl
    {
        public PesquisaOperador()
        {
            InitializeComponent();
        }

        private void PesquisaOperador_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigureComboBox();
                CarregueBindings();
                AtualizeBindings();
            }
            catch (Exception excessao)
            {
                var publicador = new PublicadorDeExcessoes.PublicadorDeExcessoes(excessao);
                publicador.Show();
            }
        }

        public Operador ObtenhaOperadorSelecionado()
        {
            Operador operador = null;
            if(bsOperador.Current is OperadorMV operadorSelecionado)
            {
                operador = operadorSelecionado.Operador;
            }
            return operador;
        }

        private void AtualizeBindings()
        {
            cboPesquisaOperador.DataSource = bsOperador;
        }

        private void CarregueBindings()
        {
            var operadores = new ProcessoDePesquisaOperadores().Obtenha();
            bsOperador.DataSource = operadores.Select(x => new OperadorMV(x));
        }

        private void ConfigureComboBox()
        {
            cboPesquisaOperador.DisplayMember = nameof(OperadorMV.Nome);
            cboPesquisaOperador.ValueMember = nameof(OperadorMV.Nome);
        }

        private class OperadorMV 
        {
            public Operador Operador;
            public OperadorMV(Operador operador)
            {
                Operador = operador;
            }
            public string Nome => Operador.Login;
        }

    }
}
