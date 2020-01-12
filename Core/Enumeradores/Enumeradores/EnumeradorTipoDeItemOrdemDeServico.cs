using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Enumeradores.Enumeradores
{
    class EnumeradorTipoDeItemOrdemDeServico : EnumerationSeguro<int, string>
    {
        public static EnumeradorTipoDeItemOrdemDeServico Produto = new EnumeradorTipoDeItemOrdemDeServico(1, "Produto");
        public static EnumeradorTipoDeItemOrdemDeServico Servico = new EnumeradorTipoDeItemOrdemDeServico(2, "Serviço");

        public EnumeradorTipoDeItemOrdemDeServico(int chave, string valor) : base(chave, valor)
        {
        }
    }
}
