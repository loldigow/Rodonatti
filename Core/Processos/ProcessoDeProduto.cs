using Core.Mapeadores;
using Core.Negocio.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Processos
{
    public class ProcessoDeProduto
    {
        private MapeadorDeProduto _mapeadorDeProduto = new MapeadorDeProduto();
        public void CrieOuAtualize(Produto produto)
        {
            if(produto.Codigo.Equals(0))
            {
                _mapeadorDeProduto.Crie(produto);
            }
            else
            {
                _mapeadorDeProduto.Atualize(produto);
            }
            
        }

        public void Exclua(Produto produto)
        {
            _mapeadorDeProduto.Exclua(produto);
        }

        public IEnumerable<Produto> ObtenhaParcial()
        {
            return new MapeadorDeProduto().Obtenha100Produtos();
        }
    }
}
