using Core.Processos;
using System;
using System.Windows.Forms;

namespace aplicacao.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var processoDeLogin = new ProcessoDeLogin();
            var operador = pesquisaOperador1.ObtenhaOperadorSelecionado();
            var senha = inpSenha.Text;
            try
            {
                processoDeLogin.Valide(operador, senha);
                var sessaoDoUsuario = processoDeLogin.IntancieUsuario(operador);
                var frmPrincipal = new frmPrincipal(sessaoDoUsuario);
                frmPrincipal.FormClosed += frmPrincipal_Closed;
                frmPrincipal.Show();
                this.Hide();
            }
            catch(Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Inconsistencia", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }
        }

        private void frmPrincipal_Closed(object sender, EventArgs e)
        {
            Close();
        }
    }
}
