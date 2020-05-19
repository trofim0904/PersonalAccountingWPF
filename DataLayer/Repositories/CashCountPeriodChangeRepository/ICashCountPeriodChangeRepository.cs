using DataLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.CashCountPeriodChangeRepository
{
    public interface ICashCountPeriodChangeRepository:IRepository<CashCountPeriodChange>
    {
        ICollection<CashCountPeriodChange> GetCashCountPeriodChangeByCountId(int countid);
        string GetCountActionNameById(int id);
    }
}
