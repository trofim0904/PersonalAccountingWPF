using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.Model.Counts.ModelsForList
{
    public class CashCountViewInList : CountViewInList
    {

        public bool PeriodChanges { get; set; }


        public CashCountViewInList():base(true)
        {
        }

        public override CountViewInList Clone()
        {
            return this.MemberwiseClone() as CashCountViewInList;
        }
    }
}
