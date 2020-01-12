using System;
using System.Reflection;

namespace aplicacao.FormsHelper
{
    class FormHelper
    {
        public static frmBase CrieInstancia(string tipoNome)
        {
            string assemblyPath = Environment.CurrentDirectory + "\\aplicacao.exe";
            try
            {
                Assembly assembly;
                assembly = Assembly.LoadFrom(assemblyPath);
                Type type = assembly.GetType($"aplicacao.Forms.{tipoNome}");

                var form = Activator.CreateInstance(type);
                if (!(form == null))
                {
                    return form as frmBase;
                }
                else
                {
                    throw new Exception("Não foi possivel Criar instancia de tela");
                }
            }
            catch(Exception erro)
            {
                //throw new Exception("Tela não encontrada."+erro);
                return null;
            }
        }
    }
}
