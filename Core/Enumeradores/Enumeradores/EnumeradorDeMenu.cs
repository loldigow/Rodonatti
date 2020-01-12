using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Enumeradores.Enumeradores
{
    public class EnumeradorDeMenu : EnumerationSeguro<string, string>
    {
        public static EnumeradorDeMenu CadastroDeCliente = new EnumeradorDeMenu("Cadastro de Clientes", "frmAterrissagemDeClientes");
        public static EnumeradorDeMenu CadastroDeProduto = new EnumeradorDeMenu("Cadastro de Produtos", "frmAterrissagemDeProdutos");
        public static EnumeradorDeMenu CadastroDeServico = new EnumeradorDeMenu("Cadastro de Serviços", "frmAterrissagemDeServicos");
        public static EnumeradorDeMenu AberturaDeCaixa = new EnumeradorDeMenu("Abertura de Caixa", "frmAberturaCaixa");
        public static EnumeradorDeMenu Caixa = new EnumeradorDeMenu("Entrada Caixa", "frmCaixa");
        public static EnumeradorDeMenu EmissaoDeProdutos = new EnumeradorDeMenu("Produtos", "frmEmissaoDeProdutos");
        public static EnumeradorDeMenu EmissaoAberturaFechamentoDoCaixa = new EnumeradorDeMenu("Abertura e Fechamento do Caixa", "frmEmissaoDeAberturaEFechamentoDoCaixa");
        public static EnumeradorDeMenu EmissaoDeEntradasESaidas = new EnumeradorDeMenu("Entradas e Saidas", "frmEmissaoEntradasESaidas");
        public static EnumeradorDeMenu EmissaoDeOrdemDeServicos = new EnumeradorDeMenu("Ordem de Serviço" , "frmEmissaoOrdemDeServicos");
        public static EnumeradorDeMenu OrdemDeServico = new EnumeradorDeMenu("Nova Ordem de Serviço", "frmNovaOrdemDeServico");

        public EnumeradorDeMenu(string chave, string valor) : base(chave, valor)
        {
        }
    }
}
