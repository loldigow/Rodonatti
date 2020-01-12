using System;
using System.Collections.Generic;
using System.Text;
using Core.Negocio.Classes;

namespace Core.Mapeadores
{
    public class MapeadorDeOrdemDeServico : MapeadorAbstrato
    {
        public MapeadorDeOrdemDeServico() : base()
        { }

        internal int ObtenhaProximoCodigo()
        {
             using (var conexao = new Conexao())
             {
                conexao.CrieComando("SELECT MAX(ORDEMCOD) ORDEMCOD FROM TBORDEMSERVICO");
                var dr = conexao.ObtenhaDataReader();
                if(dr.Read())
                {
                    if (dr["ORDEMCOD"] is int codigo)
                    {
                        return codigo;
                    }
                }
            }
            return 0;
        }

        public void GraveOrdemDeServico(OrdemDeServico ordemDeServico)
        {
            using (var conexao = new Conexao())
            using (var transaction = conexao.CrieTransacao())
            {
                GraveAOrdemDeServico(ordemDeServico, transaction);
                GraveItensDeOrdemDeServico(ordemDeServico, transaction);
                transaction.Commit();
            }
        }

        private void GraveItensDeOrdemDeServico(OrdemDeServico ordemDeServico, FirebirdSql.Data.FirebirdClient.FbTransaction transaction)
        {

        }

        private void GraveAOrdemDeServico(OrdemDeServico ordemDeServico, FirebirdSql.Data.FirebirdClient.FbTransaction transaction)
        {
            var sql = $@"INSERT INTO TBORDEMSERVICO  (ORDEMCOD, ORDEMITEMCLIENTE, ORDEMDATA)
                        VALUES ({ordemDeServico.Codigo},{ordemDeServico.Cliente.Codigo},{ordemDeServico.Data})";
            _conexao.CrieComando(sql);
            _conexao.ExecuteComando();
        }
    }
}
