using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataModels
{
    public class CashCountPeriodChange
    {
        public int Id { get; set; }
        public int CashCountActionCategoryId { get; set; }
        public int CashCountId { get; set; }
        public float Sum { get; set; }
        public string Comment { get; set; }
        public string ChangeDate { get; set; }

        public CashCount CashCount { get; set; }
        public CashCountActionCategory CashCountActionCategory { get; set; }
    }
}
