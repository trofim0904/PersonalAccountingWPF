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
        public CashLogicWithPeriodChanges(GeneralCashCountLogic generalCashCountLogic):base(generalCashCountLogic)
        {

        }

       

        public override CashCountInfo GetCashCountInfoById(int id)
        {
            return generalCashCountLogic.GetCashCountInfoById(id);
        }

        public override List<OneCashCountViewVM> GetCashCounts()
        {
            return generalCashCountLogic.GetCashCounts();
        }

        public override List<CashCountPeriodChanges> GetChanges(int id)
        {
            return null;
        }

        public override bool UpdatePeriodChanges(int id)
        {
            return generalCashCountLogic.UpdatePeriodChanges(id);
        }
    }
}
