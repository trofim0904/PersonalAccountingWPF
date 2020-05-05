using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.Model.Counts.CreateCount
{
    public class DepositCount : ISelectedCount
    {
        public bool CreateAction(InputCountParametrs inputCountParametrs)
        {
            ////TODO
            ////Mapper

            //DataLayer.AccountingContext.DepositCounts.Add(new DataLayer.DataModels.DepositCount()
            //{
            //    AmountOfMoney = inputCountParametrs.AmountOfMoney,
            //    Comment = inputCountParametrs.Comment,
            //    Name = inputCountParametrs.Name,
            //    Valuta = inputCountParametrs.Valuta,
            //    BankName = inputCountParametrs.BankName,
            //    StartDate = Convert.ToDateTime(inputCountParametrs.StartDate).ToString("dd.MM.yyyy")
            //});
            //return true;
            return false;
        }

        public string GetDataQuestion() => "Когда был открит депозит?";

        public string GetMoneyQuestion() => "На какую сумму Вы открыли депозит?";

        public string GetTypeName() => "Депозит";

        public float GetVisibilityBankQuestion() => 1;

        public float GetVisibilityDataQuestion() => 1;
    }
}