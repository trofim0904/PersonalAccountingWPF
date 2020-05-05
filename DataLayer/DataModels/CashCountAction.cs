using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataModels
{
    public class CashCountAction
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public int CashCountActionCategoryId { get; set; }
        public float Sum { get; set; }
        public float Price { get; set; }
        public int Number { get; set; }
        public string Comment { get; set; }

        public CashCount CashCount { get; set; }
        public CashCountActionCategory CashCountActionCategory { get; set; }
    }
}
