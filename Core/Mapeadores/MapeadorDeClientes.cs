using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Core.DTO;
using Core.Enumeradores.Enumeradores;
using Core.Negocio.Classes;
using FirebirdSql.Data.FirebirdClient;

namespace Core.Mapeadores
{
    class MapeadorDeClientes : MapeadorAbstrato
    {
        public MapeadorDeClientes() : base() { }

        internal void Exclua(ICliente cliente)
        {
            if (cliente != null)
            {
                var sql = $"DELETE FROM TBCLIENTE WHERE CLICOD = {cliente.Codigo}";
                string sqlIncluir = sql;
                _conexao.CrieComando(sqlIncluir);
                _conexao.ExecuteComando();
            }
        }

        internal void AtualizeCliente(ICliente cliente)
        {
            Exclua(cliente);
            SalveCliente(cliente);
        }

        public IEnumerable<ICliente> Obtenha100Clientes()
        {
            var clientes = new List<ICliente>();
            using (var conexao = new Conexao())
            {
                conexao.CrieComando("SELECT * FROM TBCLIENTE ROWS 10");
                var dr = conexao.ObtenhaDataReader();
                while (dr.Read())
                {
                    if (dr["CLICOD"] is int codigo)
                    {
                        var cliente = FabricaDeCliente(dr);
                        cliente.Nome = dr["CLINOME"].ToString();
                        cliente.Email = dr["CLIEMAIL"].ToString();
                        cliente.Endereco = dr["CLIEND"].ToString();
                        cliente.Cidade = dr["CLICIDADE"].ToString();
                        cliente.Bairro = dr["CLIBAIRRO"].ToString();
                        cliente.Cep = dr["CLICEP"].ToString();
                        cliente.Complemento = dr["CLICOMP"].ToString();
                        cliente.Fone = dr["CLIFONE"].ToString();
                        cliente.Celular = dr["CLICEL"].ToString();
                        cliente.InscricaoRG = dr["CLIINSCRICAO"].ToString();
                        cliente.Estado = dr["CLIESTADO"].ToString();
                        cliente.Codigo = codigo;
                        clientes.Add(cliente);
                    }
                }
            }
            return clientes;
        }

        private ICliente FabricaDeCliente(FbDataReader dr)
        {

            if (dr["CLITIPO"].ToString() == "F")
            {
                return new ClienteFisico()
                {
                    ClienteTipo = EnumeradorDeTipoDeCliente.Fisico,
                    CPF = dr["CLICPF"].ToString()
                };

            }
            else
            {
                return new ClienteJuridico()
                {
                    ClienteTipo = EnumeradorDeTipoDeCliente.Juridico,
                    CNPJ = dr["CLICNPJ"].ToString()
                };
            }
        }

        internal void SalveCliente(ICliente cliente)
        {
            var codigo = DBHelper.ObtenhaProximoCodigo("TBCLIENTE", "CLICOD");
            var sql = @"INSERT INTO TBCLIENTE 
(CLICOD, CLITIPO, CLINOME, CLIEMAIL, CLIEND, CLICIDADE, CLIBAIRRO, CLICEP, CLICOMP, CLIFONE, CLICEL, CLIINSCRICAO, CLIESTADO, CLICPF, CLICNPJ)  
VALUES ";
            if (cliente is ClienteFisico clienteFisico)
            {
                sql += $"({codigo},'{clienteFisico.ClienteTipo.Codigo}' ,'{clienteFisico.Nome}','{clienteFisico.Email}','{clienteFisico.Endereco}','{clienteFisico.Cidade}','{clienteFisico.Bairro}','{clienteFisico.Cep}','{clienteFisico.Complemento}','{clienteFisico.Fone}','{clienteFisico.Celular}','{clienteFisico.InscricaoRG}','{clienteFisico.Estado}','{clienteFisico.CPF}', NULL)";
            }
            if (cliente is ClienteJuridico clienteJuridico)
            {
                sql += $"({codigo},'{clienteJuridico.ClienteTipo.Codigo}' ,'{clienteJuridico.Nome}','{clienteJuridico.Email}','{clienteJuridico.Endereco}','{clienteJuridico.Cidade}','{clienteJuridico.Bairro}','{clienteJuridico.Cep}','{clienteJuridico.Complemento}','{clienteJuridico.Fone}','{clienteJuridico.Celular}','{clienteJuridico.InscricaoRG}','{clienteJuridico.Estado}', NULL, '{clienteJuridico.CNPJ}')";

            }
            string sqlIncluir = sql;
            _conexao.CrieComando(sqlIncluir);
            _conexao.ExecuteComando();
        }
        internal IEnumerable<ICliente> Pesquise(DTOPesquisaCliente parametros)
        {
            var clientes = new List<ICliente>();
            using (var conexao = new Conexao())
            {
                var filtro = string.Empty;
                if (!parametros.Nome.Equals(string.Empty))
                {
                    filtro = $" WHERE CLINOME LIKE '%{parametros.Nome}%'";
                }
                conexao.CrieComando($"SELECT * FROM TBCLIENTE {filtro}");
                var dr = conexao.ObtenhaDataReader();
                while (dr.Read())
                {
                    var cliente = FabricaDeCliente(dr);
                    //cliente.Codigo = dr["CLICOD"].ToString();
                    cliente.Nome = dr["CLINOME"].ToString();
                    cliente.Email = dr["CLIEMAIL"].ToString();
                    cliente.Endereco = dr["CLIEND"].ToString();
                    cliente.Cidade = dr["CLICIDADE"].ToString();
                    cliente.Bairro = dr["CLIBAIRRO"].ToString();
                    cliente.Cep = dr["CLICEP"].ToString();
                    cliente.Complemento = dr["CLICOMP"].ToString();
                    cliente.Fone = dr["CLIFONE"].ToString();
                    cliente.Celular = dr["CLICEL"].ToString();
                    cliente.InscricaoRG = dr["CLIINSCRICAO"].ToString();
                    cliente.Estado = dr["CLIESTADO"].ToString();
                    clientes.Add(cliente);
                }
            }
            return clientes;
        }
    }
}
