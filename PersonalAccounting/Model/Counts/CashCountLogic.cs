using DataLayer.DataModels;
using DataLayer.Repositories.CashCountRepository;
using PersonalAccounting.ViewModel.Counts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.Model.Counts
{
    public class CashCountLogic
    {
        public List<OneCashCountViewVM> GetCashCounts()
        {
            List<OneCashCountViewVM> resultlist = new List<OneCashCountViewVM>();
            using (ICashCountRepository repository = new CashCountRepository())
            {
                ICollection<CashCount> list = repository.GetCashCountsByUserId(MyUser.UserId);
                foreach(CashCount count in list)
                {
                    resultlist.Add(new OneCashCountViewVM(new CashCountViewInList()
                    {
                        AmountOfMoney = count.AmountOfMoney,
                        Id = count.Id,
                        Name = count.Name
                    }));
                    
                }
            }
            return resultlist;
        }
    }
}
