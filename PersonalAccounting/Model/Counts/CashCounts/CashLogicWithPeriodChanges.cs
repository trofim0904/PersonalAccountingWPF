using DataLayer.DataModels;
using DataLayer.Repositories.CashCountPeriodChangeRepository;
using PersonalAccounting.Model.Counts.CashCounts.PeriodChangeModels;
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


        public List<PeriodChange> GetAllPeriodChange(int id)
        {
            List<PeriodChange> result = new List<PeriodChange>();  
            using (CashCountPeriodChangeRepository repository = new CashCountPeriodChangeRepository())
            {
                ICollection<CashCountPeriodChange> list = repository.GetCashCountPeriodChangeByCountId(id);
                foreach(CashCountPeriodChange periodChange in list)
                {
                    result.Add(new PeriodChange()
                    {
                        CashCountActionCategory = repository.GetCountActionNameById(periodChange.CashCountActionCategoryId),
                        ChangeDate = periodChange.ChangeDate,
                        Comment = periodChange.Comment,
                        Sum = periodChange.Sum,
                        Id = periodChange.Id
                    });
                }
            }
            return result;
        }
    }
}
