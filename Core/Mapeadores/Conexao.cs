using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Core.Mapeadores
//DataSource=52.191.117.227
{
    public class Conexao : IDisposable
    {
        private string _strConn = @"DataSource = localhost; Database=C:\SERVICO.FDB; username = SYSDBA; password = masterkey";
        private FbConnection _conexao;
        private FbCommand _comando;

        public Conexao()
        {
            try
            {
                _conexao = new FbConnection(_strConn);
                if (_conexao == null)
                {
                    throw new Exception("Conexão deu problema");
                }
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public FbTransaction CrieTransacao()
        {
            return _conexao.BeginTransaction();
        }

        internal void CrieComando(string sqlIncluir)
        {
            _comando = new FbCommand(sqlIncluir, this._conexao);
        }

        internal void ExecuteComando()
        {
            if(_comando != null)
            {
                _conexao.Open();
                _comando.ExecuteNonQuery();
                _conexao.Close();
            }
        }

        internal FbDataReader ObtenhaDataReader()
        {
            try
            {
                _conexao.Open();
                var dr = _comando.ExecuteReader();
                return dr;
            }
            catch(Exception erro)
            {
                throw  new Exception("Erro na conexão" + erro);
            }
        }

        public void Dispose()
        {
            _conexao.Close();
        }
    }
}
