
using System;

namespace Core.Mapeadores
{
    class DBHelper
    {
        public static int ObtenhaProximoCodigo(string nomeTabela, string nomeColuna)
        {
            using (var conexao = new Conexao())
            {
                try
                {
                    conexao.CrieComando($"SELECT MAX({nomeColuna}) FROM {nomeTabela}");
                    var dr = conexao.ObtenhaDataReader();
                    if (dr.Read())
                    {
                        int numeiro;
                        if (Int32.TryParse(dr[0].ToString(), out numeiro))
                        {
                            return ++numeiro;
                        }
                    }
                }
                catch(Exception erro)
                {
                    throw new Exception("não foi possivel fazer o parse de codigo" + erro);
                }

            }
            return 1;
        }
    }
}
