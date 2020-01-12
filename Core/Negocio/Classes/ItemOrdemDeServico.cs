using Core.Enumeradores.Enumeradores;

namespace Core.Negocio.Classes
{
    public class ItemOrdemDeServico
    {
        Produto Produto;
        Servico Servico;
        EnumeradorTipoDeItemOrdemDeServico Tipo;
        public int Quantidade { get; set; }
        public ItemOrdemDeServico(Produto produto)
        {
            Produto = produto;
            Tipo = EnumeradorTipoDeItemOrdemDeServico.Produto;
        }
        public ItemOrdemDeServico(Servico servico)
        {
            Servico = servico;
            Tipo = EnumeradorTipoDeItemOrdemDeServico.Servico;
        }
        public double ValorUnitario {
            get  
                {
                return Tipo.Equals(EnumeradorTipoDeItemOrdemDeServico.Produto) ? Produto.Valor : Servico.Valor;
            }
        }
        public string Descricao
        {
            get
            {
                return Tipo.Equals(EnumeradorTipoDeItemOrdemDeServico.Produto) ? Produto.Nome : Servico.Nome;
            }
        }
        public double Total => ValorUnitario * Quantidade;

    }
}
