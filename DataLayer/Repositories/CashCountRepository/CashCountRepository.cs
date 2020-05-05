using DataLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.CashCountRepository
{
    public class CashCountRepository : GeneralRepository<CashCount>, ICashCountRepository
    {
        public ICollection<CashCount> GetCashCountsByUserId(int userid)
        {
            return context.CashCounts.Where(c => c.UserId == userid).ToList();
        }

        public override void Update(CashCount item)
        {
            throw new NotImplementedException();
        }
    }
}
