using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Inconsistencias
{
    public class InconsistenciaException : Exception
    {
        public InconsistenciaException(string erro) : base(erro)
        {
        }
    }
}
