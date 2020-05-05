using PersonalAccounting.ViewModel.Counts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.Model.Counts.CashCounts
{
    public abstract class GeneralCashCountLogic
    {
        public abstract bool UpdatePeriodChanges(int id);

        public abstract CashCountInfo GetCashCountInfoById(int id);

        public abstract List<OneCashCountViewVM> GetCashCounts();
    }
}
