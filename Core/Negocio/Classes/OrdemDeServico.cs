using System;
using System.Collections.Generic;

namespace Core.Negocio.Classes
{
    public class OrdemDeServico
    {
        private List<ItemOrdemDeServico> ItensDeOrdemDeServico = new List<ItemOrdemDeServico>();
        public int Codigo { get;  private set; }
        public ICliente Cliente { get; private set; }
        public OrdemDeServico(int codigo)
        {
            Codigo = codigo;
        }
        public string Data { get; set; }

        public void AdicioneItem(ItemOrdemDeServico item)
        {
            ItensDeOrdemDeServico.Add(item);
        }
        public void AdicioneCliente(ICliente cliente)
        {
            if(Cliente == null)
            {
                Cliente = cliente;
            }
        }
    }
}
