using aplicacao.FormsHelper;
using Core;
using Core.Enumeradores.Enumeradores;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Core.Negocio.Classes;

namespace aplicacao
{
    public partial class frmPrincipal : Form
    {
        private IDictionary<string, string> hashForm = new Dictionary<string, string>();
        public SessaoDoUsuario SessaoDoUsuario;

        public frmPrincipal(SessaoDoUsuario sessaoDoUsuario)
        {
            InitializeComponent();
            InicializeDicionario();
            this.WindowState = FormWindowState.Maximized;
            AjusteUsuario(sessaoDoUsuario);
        }

        private void AjusteUsuario(SessaoDoUsuario sessaoDoUsuario)
        {
#if DEBUG
            var operador = new Operador()
            {
                Codigo = 1,
                Nome = "ADMINISTRADOR"
            };
            SessaoDoUsuario = new SessaoDoUsuario()
            {
                Operador = operador
            };
            lblAmbiente.Text = "DEBUG";
#else
             SessaoDoUsuario = sessaoDoUsuario;
            lblAmbiente.Text = "PRODUÇÃO";
#endif
            lblOperador.Text = SessaoDoUsuario.Operador.Nome;
        }

        private void InicializeDicionario()
        {
            var telas = EnumeradorDeMenu.ObtenhaTodos<EnumeradorDeMenu>();
            foreach(var tela in telas)
            {
                hashForm.Add(tela.Codigo, tela.Descricao);
            }

        }

        private void CrieForm(ToolStripMenuItem nomeForm)
        {
            if (hashForm.ContainsKey(nomeForm.Text))
            {
                try
                {
                    var telarequisitada = hashForm[nomeForm.Text];
                    var formRequisitada = FormHelper.CrieInstancia(telarequisitada);
                    formRequisitada.Show();
                }
                catch(Exception erro)
                {
                    var publicador = new PublicadorDeExcessoes.PublicadorDeExcessoes(erro);
                    publicador.Show();
                }
            }
        }

        private void itemClick_generico(object sender, EventArgs e)
        {
            var t = sender as ToolStripMenuItem;
            CrieForm(t);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
