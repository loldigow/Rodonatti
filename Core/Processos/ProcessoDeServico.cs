using Core.Mapeadores;
using Core.Negocio.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Processos
{
    public class ProcessoDeServico
    {
        private MapeadorDeServico _mapeadorDeProduto = new MapeadorDeServico();

        public void CrieOuAtualize(Servico servico)
        {
            if (servico.Codigo.Equals(0))
            {
                _mapeadorDeProduto.Crie(servico);
            }
            else
            {
                _mapeadorDeProduto.Atualize(servico);
            }
        }

        public void Exclua(Servico servico)
        {
            _mapeadorDeProduto.Exclua(servico);
        }

        public IEnumerable<Servico> ObtenhaParcial()
        {
            return new MapeadorDeServico().Obtenha100Servicos();
        }
    }
}
