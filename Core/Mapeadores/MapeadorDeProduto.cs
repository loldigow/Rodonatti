using System;
using System.Collections.Generic;
using Core.Negocio.Classes;
using FirebirdSql.Data.FirebirdClient;

namespace Core.Mapeadores
{
    public class MapeadorDeProduto : MapeadorAbstrato
    {
        public MapeadorDeProduto() : base() { }

        public void Crie(Produto produto)
        {
            if(produto != null)
            {
                var codigo = DBHelper.ObtenhaProximoCodigo("TBPRODUTO", "PRODCODIGO");
                using(var conexao =  new Conexao())
                {
                    var sql = $@"INSERT INTO TBPRODUTO 
(PRODCODIGO, PRODVALOR, PRODNOME, PRODDESCRICAO)  
VALUES ({codigo},{produto.Valor.ToString().Replace(',','.')},'{produto.Nome}','{produto.Descricao}')";
                    conexao.CrieComando(sql);
                    conexao.ExecuteComando();
                }
            }
        }

        internal void Atualize(Produto produto)
        {
            Exclua(produto);
            Crie(produto);
        }

        public void Exclua(Produto produto)
        {
            if (produto != null)
            {
                var sql = $"DELETE FROM TBPRODUTO WHERE PRODCODIGO = {produto.Codigo}";
                string sqlIncluir = sql;
                _conexao.CrieComando(sqlIncluir);
                _conexao.ExecuteComando();
            }
        }

        public IEnumerable<Produto> Obtenha100Produtos()
        {
            var produtos = new List<Produto>();
            using (var conexao = new Conexao())
            {
                conexao.CrieComando("SELECT * FROM TBPRODUTO ROWS 10");
                var dr = conexao.ObtenhaDataReader();
                while (dr.Read())
                {
                    var produto = MapeieProduto(dr);
                    if(produto != null)
                    {
                        produtos.Add(produto);
                    }
                }
            }
            return produtos;
        }

        private Produto MapeieProduto(FbDataReader dr)
        {
            Produto produto = null;
            if (dr["PRODCODIGO"] is int codigo)
            {
                produto = new Produto()
                { 
                    Codigo = codigo,
                    Descricao = dr["PRODDESCRICAO"].ToString(),
                    Nome = dr["PRODNOME"].ToString(),
                    Valor = dr["PRODVALOR"].ToString().Double()
                };
            }
            return produto;
        }
    }
}
