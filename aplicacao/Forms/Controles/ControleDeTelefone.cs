using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace aplicacao.Forms.Controles
{
    public partial class ControleDeTelefone : UserControl
    {
        public string DDD;
        public string Telefone;
        bool Celular;
        public ControleDeTelefone()
        {
            InitializeComponent();
            inpDDD.Mask = "(00)";
            inpTelefone.Mask = "0000-0000";
        }

        internal void AjusteControleParaCarregarCelular()
        {
            Celular = true;
            lblTelefone.Text = "Cel.";
            inpTelefone.Mask = "00000-0000";

        }

        public string ObtenhaTelefone()
        {
            if (inpDDD.Text == string.Empty && inpTelefone.Text == string.Empty) return string.Empty;
            return $"{inpDDD.Text}{inpTelefone.Text}";
        }

        private bool ValideDDD()
        {
            //int ddd;
            //if (int.TryParse(inpDDD.Text.Remove('(').Remove(')'), out ddd))
            //{
            //    if (ddd < 0 || ddd > 100)
            //    {
            //        MessageBox.Show("DDD invalido", "Inconsistencia Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return false;
            //    }
            //    DDD = ddd;
            //}
            return true;
        }

        private bool ValideNumeroTelefone()
        {
            //int telefone;

            //if (Celular)
            //{
            //    if (inpTelefone.Text.Length < 9)
            //    {
            //        MessageBox.Show("Telefone invalido", "Inconsistencia Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return false;
            //    }
            //    if (int.TryParse(inpTelefone.Text, out telefone))
            //    {
            //        Telefone = telefone;
            //    }
            //}
            //else
            //{
            //    if (inpTelefone.Text.Length < 8)
            //    {
            //        MessageBox.Show("Telefone invalido", "Inconsistencia Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return false;
            //    }
            //    if (int.TryParse(inpTelefone.Text, out telefone))
            //    {
            //        Telefone = telefone;
            //    }
            //}
            return true;
        }

        internal void LimpeControle()
        {
            inpDDD.Text = "";
            inpTelefone.Text = "";
        }

        public bool valideTelefone()
        {
            //if(!CamposVazios())
            //{
                //return ValideDDD() && ValideNumeroTelefone();
            //}
            return true;
        }

        private bool CamposVazios()
        {
            return inpDDD.TextLength == 0 && inpTelefone.TextLength == 0;
        }

        internal void Carregue(string fone)
        {
            var ddd = new Regex(@"(\d\d)").Match(fone);
            var telefone = new Regex(Celular? @".....-...." : @"....-...." ).Match(fone);
            inpDDD.Text = ddd.Value;
            inpTelefone.Text = telefone.Value;
        }
    }
}
