using Core.Mapeadores;
using Core.Negocio.Classes;
using System;

namespace Core.Processos
{
    public class ProcessoDeOrdemDeServico
    {
        public int ObtenhaProximoCodigo()
        {
            return new MapeadorDeOrdemDeServico().ObtenhaProximoCodigo();
        }

        public void Adicione(OrdemDeServico ordemDeServico)
        {
            new MapeadorDeOrdemDeServico().GraveOrdemDeServico(ordemDeServico);
        }
    }
}
