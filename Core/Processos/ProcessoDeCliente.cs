using System;
using System.Collections.Generic;
using System.Text;
using Core.DTO;
using Core.Mapeadores;
using Core.Negocio.Classes;

namespace Core.Processos
{
    public class ProcessoDeCliente
    {

        public void Salvecliente(ICliente cliente)
        {
            if(cliente.Codigo.Equals(0))
            {
                new MapeadorDeClientes().SalveCliente(cliente);
            }
            else
            {
                new MapeadorDeClientes().AtualizeCliente(cliente);
            }
        }

        public IEnumerable<ICliente> Obtenha100Clientes()
        {
            return new MapeadorDeClientes().Obtenha100Clientes();
        }

        public IEnumerable<ICliente> Pesquise(DTOPesquisaCliente parametros)
        {
            return new MapeadorDeClientes().Pesquise(parametros);
        }

        public void Exclua(ICliente cliente)
        {
            new MapeadorDeClientes().Exclua(cliente);
        }
    }
}
