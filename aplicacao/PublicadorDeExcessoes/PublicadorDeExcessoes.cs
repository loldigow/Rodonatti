using Core.Inconsistencias;
using System;
using System.Windows.Forms;

namespace aplicacao.PublicadorDeExcessoes
{
    public partial class PublicadorDeExcessoes : Form
    {
        public PublicadorDeExcessoes(string mensagem)
        {
            InitializeComponent();
        }

        public PublicadorDeExcessoes(ErroDeSenhaException exception)
        {
            MessageBox.Show(exception.Message, "Inconsistencia", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        public PublicadorDeExcessoes(Exception excessao)
        {
            InitializeComponent();
            outPutText.Text = excessao.Message;
        }

        public PublicadorDeExcessoes(InconsistenciaException incosistenciaException)
        {
            MessageBox.Show(incosistenciaException.Message, "Inconsistencia", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void brnFechar_OnClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
