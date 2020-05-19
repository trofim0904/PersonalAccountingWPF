using DataLayer.DataModels;
using DataLayer.Repositories.CashCountActionCategoryRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.CashCountPeriodChangeRepository
{
    public class CashCountPeriodChangeRepository : GeneralRepository<CashCountPeriodChange>, ICashCountPeriodChangeRepository
    {
        private ICashCountActionCategoryRepository CountCategoryRepository = new CashCountActionCategoryRepository.CashCountActionCategoryRepository();
        public ICollection<CashCountPeriodChange> GetCashCountPeriodChangeByCountId(int countid)
        {
            try
            {
                return context.CashCountPeriodChanges.Where(i => i.CashCountId == countid).ToList();
            }
            catch
            {
                return null;
            }
         
        }

        public string GetCountActionNameById(int id)
        {
            return CountCategoryRepository.GetNameById(id);
        }

        public override void Update(CashCountPeriodChange item)
        {
            throw new NotImplementedException();
        }
    }
}
