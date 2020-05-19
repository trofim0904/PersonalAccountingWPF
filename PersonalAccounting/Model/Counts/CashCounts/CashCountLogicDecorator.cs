using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.Model.Counts.CashCounts
{
    public abstract class CashCountLogicDecorator : IGeneralCashCountLogic
    {
        protected IGeneralCashCountLogic generalCashCountLogic;

        public CashCountLogicDecorator(IGeneralCashCountLogic generalCashCountLogic)
        {
            this.generalCashCountLogic = generalCashCountLogic;
        }

        public bool AddExpensesOrIncome(int id)
        {
            return generalCashCountLogic.AddExpensesOrIncome(id);
        }

        
    }
}
