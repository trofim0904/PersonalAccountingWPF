using DataLayer.DataModels;
using DataLayer.Repositories.CashCountRepository;
using PersonalAccounting.Model.Counts.ModelsForList;
using PersonalAccounting.ViewModel.Counts;
using System.Collections.Generic;

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
                
                CashCountViewInList cashcount = new CashCountViewInList();

                foreach(CashCount count in list)
                {
                    
                    CashCountViewInList cash = cashcount.Clone() as CashCountViewInList;
                    cash.AmountOfMoney = count.AmountOfMoney;
                    cash.Id = count.Id;
                    cash.Name = count.Name;

                    resultlist.Add(new OneCashCountViewVM(cash));
                    
                }
            }
            return resultlist;
        }
    }
}
