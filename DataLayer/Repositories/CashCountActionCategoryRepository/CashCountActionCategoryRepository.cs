using DataLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.CashCountActionCategoryRepository
{
    public class CashCountActionCategoryRepository : GeneralRepository<CashCountActionCategory>, ICashCountActionCategoryRepository
    {
        public string GetNameById(int id)
        {
            return context.CashCountActionCategories.Where(i => i.Id == id).FirstOrDefault().Name;
        }

        public override void Update(CashCountActionCategory item)
        {
            throw new NotImplementedException();
        }
    }
}
