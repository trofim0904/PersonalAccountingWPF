using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.Model.Counts.CashCounts
{
    public abstract class CashCountLogicDecorator : GeneralCashCountLogic
    {
        protected GeneralCashCountLogic generalCashCountLogic;

        public CashCountLogicDecorator(GeneralCashCountLogic generalCashCountLogic)
        {
            this.generalCashCountLogic = generalCashCountLogic;
        }

        public abstract List<CashCountPeriodChanges> GetChanges(int id);
    }
}
