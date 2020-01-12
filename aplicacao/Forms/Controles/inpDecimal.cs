using System;
using System.Linq;
using System.Windows.Forms;
using Core;

namespace aplicacao.Forms.Controles
{
    public partial class inpDouble : UserControl
    {
        public inpDouble()
        {
            InitializeComponent();
        }

        public double Valor
        {
            get
            {
                return inpValor.Text.Double();
            }
            set
            {
                inpValor.Text = value.ToString();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar))
            {
                if(e.KeyChar != (char)44)
                {
                    if (e.KeyChar != (char)8)
                    {
                        e.Handled = true;
                    }
                }
                else if(inpValor.Text.Contains(','))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
