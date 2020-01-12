using Core.Enumeradores.Enumeradores;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Negocio.Classes
{
    public class ICliente
    {
        public string Nome { get; set; }
        public int Codigo { get; set; }
        public EnumeradorDeTipoDeCliente ClienteTipo { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public string Fone { get; set; }
        public string Celular { get; set; }
        public string InscricaoRG { get; set; }
        public string Estado { get; set; }
    }
}
