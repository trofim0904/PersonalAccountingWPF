using AutoMapper;
using DataLayer.Repositories.CashCountRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.Model.Counts.CreateCount
{
    public class CashCount : ISelectedCount
    {
        public bool CreateAction(InputCountParametrs inputCountParametrs)
        {
            ////TODO
            ////Mapper
            bool result = true;
            using(CashCountRepository repository = new CashCountRepository())
            {
                DataLayer.DataModels.CashCount count = new DataLayer.DataModels.CashCount()
                {
                    Name = inputCountParametrs.Name,
                    AmountOfMoney = inputCountParametrs.AmountOfMoney,
                    Comment = inputCountParametrs.Comment,
                    Valuta = inputCountParametrs.Valuta,
                    UserId = MyUser.UserId,
                    PeriodChanges = false
                };
                try
                {
                    repository.Create(count);
                    repository.Save();
                }
                catch
                {
                    result = false;
                }
                
            }
            
            return result;
        }

        public string GetDataQuestion() => null;

        public string GetMoneyQuestion() => "Какая сумма находидися на этом счету?";

        public string GetTypeName() => "Наличные деньги";

        public float GetVisibilityBankQuestion() => 0;

        public float GetVisibilityDataQuestion() => 0;
    }
}