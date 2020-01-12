using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Inconsistencias
{
    public class ErroDeSenhaException : Exception
    {
        public ErroDeSenhaException() : base("Senha digitada incorreta!")
        {

        }
    }
}
