using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Negocio.Classes
{
    public class ClienteJuridico : ICliente
    {
        public string CNPJ { get; set; }
    }
}
