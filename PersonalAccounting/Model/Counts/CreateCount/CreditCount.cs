using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.Model.Counts.CreateCount
{
    public class CreditCount : ISelectedCount
    {
        public bool CreateAction(InputCountParametrs inputCountParametrs)
        {
            //TODO
            //Mapper

            DataLayer.AccountingContext.CreditCounts.Add(new DataLayer.DataModels.CreditCount()
            {
                AmountOfMoney = inputCountParametrs.AmountOfMoney,
                Comment = inputCountParametrs.Comment,
                Name = inputCountParametrs.Name,
                Valuta = inputCountParametrs.Valuta,
                BankName = inputCountParametrs.BankName,
                StartDate = Convert.ToDateTime(inputCountParametrs.StartDate).ToString("dd.MM.yyyy")
            });
            return true;
        }

        public string GetDataQuestion() => "Когда был взят кредит?";

        public string GetMoneyQuestion() => "На какую сумму взят кредит?";

        public string GetTypeName() => "Кредит";

        public float GetVisibilityBankQuestion() => 1;

        public float GetVisibilityDataQuestion() => 1;
    }
}
