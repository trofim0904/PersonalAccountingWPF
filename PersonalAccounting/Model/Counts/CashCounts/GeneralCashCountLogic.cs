using PersonalAccounting.ViewModel.Counts;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.Model.Counts.CashCounts
{
    public interface IGeneralCashCountLogic
    {
        bool AddExpensesOrIncome(int id);
       
    }
}
