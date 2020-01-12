using Braintree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Core.Enumeradores
{
    public abstract class EnumerationSeguro<TChave, TValor> : IComparable
    {
        public TValor Descricao { get; private set; }

        public TChave Codigo { get; private set; }

        protected EnumerationSeguro(TChave id, TValor name)
        {
            Codigo = id;
            Descricao = name;
        }

        public override string ToString() => Descricao.ToString();

        private static IEnumerable<T> GetAll<T>() where T : EnumerationSeguro<TChave, TValor>
        {
            var fields = typeof(T).GetFields(BindingFlags.Public |
                                             BindingFlags.Static |
                                             BindingFlags.DeclaredOnly);

            return fields.Select(f => f.GetValue(null)).Cast<T>();
        }
        public static IEnumerable<T> ObtenhaTodos<T>()
        {
            var fields = typeof(T).GetFields(BindingFlags.Public |
                                             BindingFlags.Static |
                                             BindingFlags.DeclaredOnly);

            return fields.Select(f => f.GetValue(null)).Cast<T>();
        }
        public bool Equals(EnumerationSeguro<TChave, TValor> obj)
        {
            var otherValue = obj as EnumerationSeguro<TChave, TValor>;

            if (otherValue == null)
                return false;

            var typeMatches = GetType().Equals(obj.GetType());
            var valueMatches = Codigo.Equals(otherValue.Codigo);

            return typeMatches && valueMatches;
        }
        public int CompareTo(object obj)
        {
            return 0;
        }

        public static void Obtenha<T>(TChave codigo)
        {
            var enumeradores = ObtenhaTodos<T>();
            foreach (var enumerador in enumeradores)
            {
                //    if(enumerador is T enum)
                //{
                //    if (enumerador is T enum)
                //    {
                //    }
                //}
                
            }
        }
    }
}
