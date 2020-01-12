using System;
using System.Globalization;

namespace Core
{
    public static class MetodosDeExtensao
    {
        public static double Double(this string str)
        {
            var valor = str.Replace('.', ',');
            var i = 0.0;
            if (double.TryParse(str, out i))
            {
                return i;
            }
            return i;
        }
        public static int Int(this string str)
        {
            var i = 0;
            if(int.TryParse(str, out i))
            {
                return i;
            }
            return i;
        }
        public static string ToStringFormatada(this double valor)
        {
            return valor.ToString("R$ ###.##0.", CultureInfo.InvariantCulture);
        }

        public static string ToStringCPF(this string cpf)
        {
            return String.Format(@"{0:\000\.000\.000\-00}", cpf);
        }

        public static string ToStringDDMMAAAA(this DateTime data)
        {
            string dataFormatada = "";
            var dia = data.Day;
            dataFormatada = dia < 10 ? $"0{dia}" : dia.ToString();
            var mes = data.Month;
            dataFormatada += mes < 10 ? $"0{mes}" : mes.ToString();
            var ano = data.Year;
            dataFormatada += ano.ToString();
            return dataFormatada;
        }
    }
}
