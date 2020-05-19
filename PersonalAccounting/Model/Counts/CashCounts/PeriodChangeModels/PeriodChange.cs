using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.Model.Counts.CashCounts.PeriodChangeModels
{
    public class PeriodChange
    {
        public int Id { get; set; }
        public string CashCountActionCategory { get; set; }
        public float Sum { get; set; }
        public string Comment { get; set; }
        public string ChangeDate { get; set; }
    }
}
