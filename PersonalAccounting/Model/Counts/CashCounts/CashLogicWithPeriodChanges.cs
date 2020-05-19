using PersonalAccounting.ViewModel.Counts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.Model.Counts.CashCounts
{
    public class CashLogicWithPeriodChanges : CashCountLogicDecorator
    {
        public CashLogicWithPeriodChanges(IGeneralCashCountLogic generalCashCountLogic):base(generalCashCountLogic)
        {

        }


        public bool GetAllPeriodChange(int id)
        {
            //add period change
            return false;
        }
    }
}
