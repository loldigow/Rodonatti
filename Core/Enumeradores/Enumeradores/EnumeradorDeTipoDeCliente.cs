using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Enumeradores.Enumeradores
{
    public class EnumeradorDeTipoDeCliente : EnumerationSeguro<char, string>
    {
        public static EnumeradorDeTipoDeCliente Fisico = new EnumeradorDeTipoDeCliente('F', "Pessoa Física");
        public static EnumeradorDeTipoDeCliente Juridico = new EnumeradorDeTipoDeCliente('J', "Pessoa Juridica");

        public EnumeradorDeTipoDeCliente(char chave, string valor) : base(chave, valor)
        {
        }

    }
}
