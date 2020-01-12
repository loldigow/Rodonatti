using System;
using System.Windows.Forms;

namespace aplicacao.Forms.Controles
{
    public partial class DataGrideViewFacil : UserControl
    {
        public DataGrideViewFacil()
        {
            InitializeComponent();
            this.DataGrideView.AutoGenerateColumns = false;
        }

        public void MultiSelecao(bool ativo)
        {
            DataGrideView.MultiSelect = ativo;
        }

        public void AdicioneBindingSource(BindingSource bindingSource){
            DataGrideView.DataSource = bindingSource;
        }

        public void AdicioneColuna(string nomeColuna, string nomeAtribulo, int tamanho)
        {
            DataGridViewColumn coluna = new DataGridViewTextBoxColumn();
            coluna.DataPropertyName = nomeAtribulo;
            coluna.Name = nomeColuna;
            coluna.Width = tamanho;
            coluna.ReadOnly = true;
            DataGrideView.Columns.Add(coluna);
        }

        public void AdicioneColunaEditavel(string nomeColuna, string nomeAtribulo, int tamanho)
        {
            DataGridViewColumn coluna = new DataGridViewTextBoxColumn();
            coluna.DataPropertyName = nomeAtribulo;
            coluna.Name = nomeColuna;
            coluna.Width = tamanho;
            coluna.ReadOnly = false;
            DataGrideView.Columns.Add(coluna);
        }

        public void AdicioneColunaCombobox(BindingSource bs, string cabecalho, string nomePropriedade, int posicao)
        {
            var coluna = CreateComboBoxColumn(bs, cabecalho, nomePropriedade);
            DataGrideView.Columns.Insert(posicao, coluna);
        }

        private DataGridViewComboBoxColumn CreateComboBoxColumn(BindingSource bs, string cabecalho, string nomePropriedade)
        {
            var column = new DataGridViewComboBoxColumn()
            {
                DataPropertyName = cabecalho,
                HeaderText = cabecalho,
                DropDownWidth = 100,
                Width = 200,
                MaxDropDownItems = 3,
                FlatStyle = FlatStyle.Standard,
                ValueMember = nomePropriedade,
                DisplayMember = nomePropriedade
            };
            column.DataSource = bs;
            return column;
        }

        public void AdicioneColunaFill(string nomeColuna, string nomeAtribulo)
        {
            DataGridViewColumn coluna = new DataGridViewTextBoxColumn();
            coluna.DataPropertyName = nomeAtribulo;
            coluna.Name = nomeColuna;
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            coluna.ReadOnly = true;
            DataGrideView.Columns.Add(coluna);
        }
        public void AjustaSelecaoDeLinha(DataGridViewSelectionMode tipoDeSelecao)
        {
            DataGrideView.SelectionMode = tipoDeSelecao;
        }

        public void DesabiliteCabecalhoLinha()
        {
            DataGrideView.RowHeadersVisible = false;
        }

        public void AjusteCliqueDuplo(EventHandler evento)
        {
            this.DataGrideView.DoubleClick += evento;
        }
    }

    public static class ExtensaoDataGrideView
    {
        public static void Apenasleitura(this DataGridViewColumn coluna)
        {
            coluna.ReadOnly = true;
        }
    }

}
