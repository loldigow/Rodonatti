using Core.Negocio.Classes;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Mapeadores
{
    public class MapeadorDeServico : MapeadorAbstrato
    {
        public MapeadorDeServico() : base() { }
        internal void Crie(Servico servico)
        {
            if (servico != null)
            {
                var codigo = DBHelper.ObtenhaProximoCodigo("TBSERVICO", "SERVCODIGO");
                using (var conexao = new Conexao())
                {
                    var sql = $@"INSERT INTO TBSERVICO 
(SERVCODIGO, SERVVALOR, SERVNOME, SERVDESCRICAO)  
VALUES ({codigo},{servico.Valor.ToString().Replace(',', '.')},'{servico.Nome}','{servico.Descricao}')";
                    conexao.CrieComando(sql);
                    conexao.ExecuteComando();
                }
            }
        }

        internal void Atualize(Servico servico)
        {
            Exclua(servico);
            Crie(servico);
        }

        public void Exclua(Servico servico)
        {
            if (servico != null)
            {
                var sql = $"DELETE FROM TBSERVICO WHERE SERVCODIGO = {servico.Codigo}";
                string sqlIncluir = sql;
                _conexao.CrieComando(sqlIncluir);
                _conexao.ExecuteComando();
            }
        }

        public IEnumerable<Servico> Obtenha100Servicos()
        {
            var servicos = new List<Servico>();
            using (var conexao = new Conexao())
            {
                conexao.CrieComando("SELECT * FROM TBSERVICO ROWS 10");
                var dr = conexao.ObtenhaDataReader();
                while (dr.Read())
                {
                    var servico = MapeieServico(dr);
                    if (servico != null)
                    {
                        servicos.Add(servico);
                    }
                }
            }
            return servicos;
        }

        private Servico MapeieServico(FbDataReader dr)
        {
            Servico servico = null;
            if (dr["SERVCODIGO"] is int codigo)
            {
                servico = new Servico()
                {
                    Codigo = codigo,
                    Descricao = dr["SERVDESCRICAO"].ToString(),
                    Nome = dr["SERVNOME"].ToString(),
                    Valor = dr["SERVVALOR"].ToString().Double()
                };
            }
            return servico;
        }
    }
}
