using DataLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.CashCountActionCategoryRepository
{
    public interface ICashCountActionCategoryRepository:IRepository<CashCountActionCategory>
    {
        string GetNameById(int id);
    }
}
