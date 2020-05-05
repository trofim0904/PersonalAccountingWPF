using DataLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.CashCountRepository
{
    public interface ICashCountRepository : IRepository<CashCount>
    {
        ICollection<CashCount> GetCashCountsByUserId(int userid);
    }
}
