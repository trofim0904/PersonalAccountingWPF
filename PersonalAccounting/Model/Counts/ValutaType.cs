using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.Model.Counts
{
    public class ValutaType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly List<ValutaType> ValutaTypes = new List<ValutaType>()
        {
            new ValutaType()
            {
                Id = 0,
                Name = "UAN"
            }
        };

        public override string ToString()
        {
            return Name;
        }
    }
}
