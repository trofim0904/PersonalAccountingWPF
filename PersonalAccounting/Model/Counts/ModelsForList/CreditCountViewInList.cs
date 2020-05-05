using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.Model.Counts.ModelsForList
{
    public class CreditCountViewInList : CountViewInList
    {
        public CreditCountViewInList() : base(false)
        {          
        }

        public override CountViewInList Clone()
        {
            return this.MemberwiseClone() as CashCountViewInList;
        }
    }
}
