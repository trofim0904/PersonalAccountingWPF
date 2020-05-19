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

        public int GetTotalNumberOfCounts(int userid)
        {
            try
            {
                return context.CashCounts.Where(c => c.UserId == userid).Count();
            }
            catch
            {
                return 0;
            }
        }

        public float GetTotalSumOfCounts(int userid)
        {
            float result = 0;
            try
            {
                ICollection<CashCount> counts = context.CashCounts.Where(c => c.UserId == userid).ToList();
                foreach (CashCount count in counts)
                {
                    result += count.AmountOfMoney;
                }
            }
            catch { }
            return result;
        }

        public override void Update(CashCount item)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePeriodChanges(int id)
        {
            CashCount cash = context.CashCounts.Find(id);
            if (cash.PeriodChanges)
            {
                cash.PeriodChanges = false;
            }
            else
            {
                cash.PeriodChanges = true;
            }
            return true;
        }
        
    }
}
