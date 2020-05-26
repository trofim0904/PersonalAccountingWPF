using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.Model.Counts
{
    public class ParameterFactory 
    {
        private Dictionary<string, ParameterType> parameterDictionary = new Dictionary<string, ParameterType>();
        private int id = 0;
        public ParameterFactory()
        {
            parameterDictionary.Add("valuta_1", new ValutaType(++id, "UAH"));
            parameterDictionary.Add("valuta_2", new ValutaType(++id, "USD"));
        }

        public ParameterType GetParameter(string key)
        {
            if (!parameterDictionary.ContainsKey(key))
            {
                return null;
            }

            return parameterDictionary[key];

        }
    }
}
