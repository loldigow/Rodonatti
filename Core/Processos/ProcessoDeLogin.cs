using System;
using System.Collections.Generic;
using System.Text;
using Core.Inconsistencias;
using Core.Negocio.Classes;

namespace Core.Processos
{
    public class ProcessoDeLogin
    {
        public void Valide(Operador operador, string senha)
        {
            if(!Md5.Valide(senha, operador.Senha))
            {
                throw new ErroDeSenhaException();
            }
        }

        public SessaoDoUsuario IntancieUsuario(Operador operador)
        {
            return new SessaoDoUsuario()
            { 
                Operador = operador
            };

        }
    }
}
