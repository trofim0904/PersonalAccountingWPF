using DataLayer.DataModels;
using DataLayer.Repositories.CashCountRepository;
using PersonalAccounting.Model.Counts.ModelsForList;
using PersonalAccounting.ViewModel.Counts;
using System.Collections.Generic;
using System.Net.Sockets;

namespace PersonalAccounting.Model.Counts.CashCounts
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
                    cash.PeriodChanges = count.PeriodChanges;

                    resultlist.Add(new OneCashCountViewVM(cash));
                    
                }
            }
            return resultlist;
        }

        public CashCountInfo GetCashCountInfoById(int id)
        {
            CashCountInfo cash = new CashCountInfo();

            using (CashCountRepository repository = new CashCountRepository())
            {
                CashCount cashCount = repository.GetItem(id);
                cash.AmountOfMoney = cashCount.AmountOfMoney;
                cash.Comment = cashCount.Comment;
                cash.Id = cashCount.Id;
                cash.Name = cashCount.Name;
                cash.Valuta = cashCount.Valuta;
            }

            return cash;
        }
        public bool UpdatePeriodChanges(int id)
        {
            bool result;
            using (CashCountRepository repository = new CashCountRepository())
            {
                result = repository.UpdatePeriodChanges(id);
                repository.Save();
                
            }
            return result;
        }
    }
}
