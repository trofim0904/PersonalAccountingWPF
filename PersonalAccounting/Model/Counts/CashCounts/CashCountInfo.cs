using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.Model.Counts.CashCounts
{
    public class CashCountInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float AmountOfMoney { get; set; }
        public string Valuta { get; set; }
        public string Comment { get; set; }
    }
}
