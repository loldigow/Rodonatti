using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Core.DTO;
using Core.Negocio.Classes;
using FirebirdSql.Data.FirebirdClient;

namespace Core.Mapeadores
{
    public class MapeadorDeOperador : MapeadorAbstrato
    {
        public MapeadorDeOperador() : base() { }
        public List<Operador> Obtenha(DTOPesquisaDeOperador parametros)
        {
                var operadores = new List<Operador>();
                using (var conexao = new Conexao())
                {
                    conexao.CrieComando("SELECT * FROM TBOPERADOR");
                    var dr = conexao.ObtenhaDataReader();
                    while (dr.Read())
                    {
                        var operador = MapeieOperador(dr);
                        if (operador != null)
                        {
                            operadores.Add(operador);
                        }
                    }
                }
                return operadores;
        }

        private Operador MapeieOperador(FbDataReader dr)
        {
            Operador operador = null;
            if (dr["OPECOD"] is int codigo)
            {
                operador = new Operador()
                {
                    Codigo = codigo,
                    Nome = dr["OPENOME"].ToString(),
                    Login = dr["OPELOGIN"].ToString(),
                    CPF = dr["OPECPF"].ToString(),
                    Senha = dr["OPEHASH"].ToString()
                };
            }
            return operador;
        }
    }
}
