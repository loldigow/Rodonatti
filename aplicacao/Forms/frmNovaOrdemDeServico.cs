using Core.Negocio.Classes;
using System;
using System.Windows.Forms;
using Core;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Core.Processos;

namespace aplicacao.Forms
{
    public partial class frmNovaOrdemDeServico : frmBase
    {
        private List<ItemMV> _itens = new List<ItemMV>();
        private readonly ProcessoDeOrdemDeServico processoDeOrdemDeServico = new ProcessoDeOrdemDeServico();
        public frmNovaOrdemDeServico()
        {
            InitializeComponent();
            AjustaGride();
            AjusteForm();
            lblNomeFuncaoTela.Text = "Ordem de Serviço";
        }

        private void AjusteForm()
        {
            inpData.Mask = "00/00/0000";
            inpData.Text = DateTime.Now.ToStringDDMMAAAA();
            inpCodigo.Text = processoDeOrdemDeServico.ObtenhaProximoCodigo().ToString();
        }

        private void AjustaGride()
        {
            dgvProdutoServico.AdicioneBindingSource(bsProdutoServico);
            dgvProdutoServico.AdicioneColuna("#", nameof(ItemMV.Sequencia), 20);
            dgvProdutoServico.AdicioneColunaEditavel("Quantidade", nameof(ItemMV.Quantidade), 70);
            dgvProdutoServico.AdicioneColunaFill("Descrição", nameof(ItemMV.Descricao));
            dgvProdutoServico.AdicioneColuna("Vlr unitário", nameof(ItemMV.ValorUnitario), 80);
            dgvProdutoServico.AdicioneColuna("Vlr Total", nameof(ItemMV.Total), 80);
            dgvProdutoServico.AjustaSelecaoDeLinha(DataGridViewSelectionMode.FullRowSelect);
            dgvProdutoServico.MultiSelecao(false);
            dgvProdutoServico.DesabiliteCabecalhoLinha();
        }

        private void Insiraproduto_Click(object sender, EventArgs e)
        {
            var telaProduto = new frmAterrissagemDeProdutos();
            if (telaProduto != null)
            {
                telaProduto.AjusteParaAdicionarNaOrdemDeServico();
                telaProduto.FormClosed += (object sender1, FormClosedEventArgs e1)=>{
                    var produtoSelecionado = telaProduto.Selecionado;
                    if(produtoSelecionado != null)
                    {
                        var itemOrdemDeServico = new ItemOrdemDeServico(produtoSelecionado);
                        _itens.Add(new ItemMV(itemOrdemDeServico));
                        CarregueItens();
                    }
                };
                telaProduto.Show();
            }
        }

        private void CarregueItens()
        {
            int i = 1;
            foreach(var item in _itens)
            {
                item.Sequencia = i;
                item.PropertyChanged += EventoDeNotificacao;
                i++;
            }
            bsProdutoServico.DataSource = _itens;
            bsProdutoServico.ResetBindings(true);
        }

        private void EventoDeNotificacao(object sender, PropertyChangedEventArgs e)
        {
            textBox3.Text = _itens.Sum(x => x.Item.Total).ToStringFormatada();
        }

        private void AdidionarServico_Onclick(object sender, EventArgs e)
        {
            var telaServico = new frmAterrissagemDeServicos();
            if (telaServico != null)
            {
                telaServico.AjusteParaAdicionarNaOrdemDeServico();
                telaServico.FormClosed += (object sender1, FormClosedEventArgs e1) => {
                    var produtoSelecionado = telaServico.Selecionado;
                    if (produtoSelecionado != null)
                    {
                        var itemOrdemDeServico = new ItemOrdemDeServico(produtoSelecionado);
                        _itens.Add(new ItemMV(itemOrdemDeServico));
                        CarregueItens();
                    }
                };
                telaServico.Show();
            }
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (bsProdutoServico.Current is ItemMV item)
            {
                _itens.Remove(item);

            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private class ItemMV : INotifyPropertyChanged
        {
            public ItemOrdemDeServico Item { get; set; }
            public ItemMV(ItemOrdemDeServico item)
            {
                Item = item;
            }
            public int Sequencia { get; set; }
            public string Descricao => Item.Descricao;
            public string ValorUnitario => Item.ValorUnitario.ToStringFormatada();
            public string Total => Item.Total.ToStringFormatada();

            public event PropertyChangedEventHandler PropertyChanged;

            public int Quantidade
            {
                get { return Item.Quantidade; }
                set
                {
                    if (value != Item.Quantidade)
                    {
                        Item.Quantidade = value;
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Quantidade)));
                    }
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(PodeProsseguir())
            {
                var ordemDeServico = CrieOrdemDeServico();
                try
                {
                    processoDeOrdemDeServico.Adicione(ordemDeServico);
                }
                catch(Exception erro)
                {
                    var excessao = new PublicadorDeExcessoes.PublicadorDeExcessoes(erro);
                    excessao.Show();
                }
            }
        }

        private OrdemDeServico CrieOrdemDeServico()
        {
            var ordemDeServico = new OrdemDeServico(inpCodigo.Text.Int());
            var itens = bsProdutoServico.DataSource as List<ItemMV>;
            foreach (var item in itens)
            {
                ordemDeServico.AdicioneItem(item.Item);
            }
            ordemDeServico.Data = inpData.Text;
            ordemDeServico.AdicioneCliente(pesquisaDeCliente1.ObtenhaSelecionado());

            return ordemDeServico;
        }

        private bool PodeProsseguir()
        {
            if(bsProdutoServico.Count == 0)
            {
                MessageBox.Show("Ordem de serviço sem produto/Serviço", "Inconsistencia Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
