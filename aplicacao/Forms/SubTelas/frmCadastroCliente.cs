using Core.Enumeradores.Enumeradores;
using Core.Negocio.Classes;
using Core.Processos;
using System;
using Core;
using System.Windows.Forms;

namespace aplicacao.Forms.SubTelas
{
    public partial class frmCadastroCliente : frmBase
    {
        public frmCadastroCliente(ICliente cliente = null)
        {
            InitializeComponent();
            this.lblNomeFuncaoTela.Text = "Cadastro de Clientes";
            controleDeTelefone2.AjusteControleParaCarregarCelular();
            inpCodigo.Text = $"{0}";
            inpCodigo.Enabled = false;
            if(cliente != null)
            {
                CarreguePessoa(cliente);
            }
            inpCep.Mask = "00000-000";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PodeProsseguir())
            {
                var cliente = CrieCliente();
                var processo = new ProcessoDeCliente();
                try
                {
                    processo.Salvecliente(cliente);
                    MessageBox.Show("Cadastro realizado com sucesso", "Aviso de sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Campo de cidade vazio\n{exception.Message}", "Inconsistencia Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void LimpeTela()
        {
            inpNomeCliente.Text = "";
            inpEndereco.Text = "";
            inpCidade.Text = "";
            inpEstado.Text = "";
            inpBairro.Text = "";
            inpCep.Text = "";
            inpComplemento.Text = "";
            inpCPF.Text = "";
            inpCNPJ.Text = "";
            InpEmail.Text = "";
            controleDeTelefone1.LimpeControle();
            controleDeTelefone2.LimpeControle();
            inpInscricao.Text = "";
        }

        private ICliente CrieCliente()
        {
            ICliente cliente;
            cliente = FabricaDeCliente();
            cliente.Codigo = inpCodigo.Text.Int();
            cliente.Nome = inpNomeCliente.Text;
            cliente.Endereco = inpEndereco.Text;
            cliente.Cidade = inpCidade.Text;
            cliente.Estado = inpEstado.Text;
            cliente.Bairro = inpBairro.Text;
            cliente.Cep = inpCep.Text;
            cliente.Complemento = inpComplemento.Text;
            cliente.Fone = controleDeTelefone1.ObtenhaTelefone();
            cliente.Celular = controleDeTelefone2.ObtenhaTelefone();
            cliente.Email = InpEmail.Text;
            cliente.InscricaoRG = inpInscricao.Text;
            return cliente;

        }

        internal void CarreguePessoa(ICliente cliente)
        {
            inpCodigo.Text = $"{cliente.Codigo}";
            inpNomeCliente.Text = cliente.Nome;
            inpEndereco.Text = cliente.Endereco;
            inpCidade.Text = cliente.Cidade;
            inpEstado.Text = cliente.Estado;
            inpBairro.Text = cliente.Bairro;
            inpCep.Text = cliente.Cep;
            inpComplemento.Text = cliente.Complemento;
            controleDeTelefone1.Carregue(cliente.Fone);
            controleDeTelefone2.Carregue(cliente.Celular);
            inpInscricao.Text = cliente.InscricaoRG;
            InpEmail.Text = cliente.Email;
            if(cliente is ClienteFisico pessoa)
            {
                rbUsarCPF.Checked = true;
                inpCPF.Text = pessoa.CPF;
            }
            if(cliente is ClienteJuridico empresa)
            {
                rbUsarCNPJ.Checked = true;
                inpCNPJ.Text = empresa.CNPJ;
            }
        }

        private ICliente FabricaDeCliente()
        {
            if (rbUsarCPF.Checked)
            {
                return new ClienteFisico()
                {
                    CPF = inpCPF.Text,
                    ClienteTipo = EnumeradorDeTipoDeCliente.Fisico
                };
            }
            else
            {
                return new ClienteJuridico()
                { 
                    CNPJ = inpCNPJ.Text,
                    ClienteTipo = EnumeradorDeTipoDeCliente.Juridico
                };
            }
        }

        private bool PodeProsseguir()
        {
            if (inpNomeCliente.Text.Equals(0))
            {
                inpNomeCliente.Focus();
                MessageBox.Show("Campo do nome vazio", "Inconsistencia Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (inpEndereco.Text.Equals(string.Empty))
            {
                inpNomeCliente.Focus();
                MessageBox.Show("Campo de endereço vazio", "Inconsistencia Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            if (inpCidade.Text.Equals(string.Empty))
            {
                inpCidade.Focus();
                MessageBox.Show("Campo de cidade vazio", "Inconsistencia Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            if (inpEstado.Text.Equals(string.Empty))
            {
                inpEstado.Focus();
                MessageBox.Show("Campo Estado vazio", "Inconsistencia Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            if (inpBairro.Text.Equals(string.Empty))
            {
                inpBairro.Focus();
                MessageBox.Show("Campo bairro vazio", "Inconsistencia Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            if (rbUsarCPF.Checked && inpCPF.Text.Equals(string.Empty))
            {
                inpCPF.Focus();
                MessageBox.Show("Campo cpf vazio", "Inconsistencia Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            if (rbUsarCNPJ.Checked && inpCNPJ.Text.Equals(string.Empty))
            {
                inpCNPJ.Focus();
                MessageBox.Show("Campo cnpj vazio", "Inconsistencia Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            if (!controleDeTelefone1.valideTelefone() || !controleDeTelefone2.valideTelefone())
            {
                return false;
            }
            return true;
        }

        private void rbUsarCPF_CheckedChanged_1(object sender, EventArgs e)
        {
            inpCPF.Enabled = rbUsarCPF.Checked;
            inpCNPJ.Enabled = !rbUsarCPF.Checked;
        }

        private void rbUsarCNPJ_CheckedChanged_1(object sender, EventArgs e)
        {
            inpCNPJ.Enabled = rbUsarCNPJ.Checked;
            inpCPF.Enabled = !rbUsarCNPJ.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LimpeTela();
        }

        private void inpCPF_TextChanged(object sender, EventArgs e)
        {
            if(inpCPF.TextLength == 11)
            {

            }
        }
    }
}
