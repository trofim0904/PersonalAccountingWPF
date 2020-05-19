using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataModels
{
    public class CashCount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float AmountOfMoney { get; set; }
        public string Valuta { get; set; }
        public string Comment { get; set; }
        public bool PeriodChanges { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
        public virtual List<CashCountAction> CashCountActions { get; set; } 
        public virtual List<CashCountPeriodChange> CashCountPeriodChanges { get; set; }

    }
}
