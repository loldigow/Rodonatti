using Core.DTO;
using Core.Mapeadores;
using Core.Negocio.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Processos
{
    public class ProcessoDePesquisaOperadores
    {
        public List<Operador> Obtenha()
        {
            var parametros = new DTOPesquisaDeOperador();
            return new MapeadorDeOperador().Obtenha(parametros);
        }
    }
}
