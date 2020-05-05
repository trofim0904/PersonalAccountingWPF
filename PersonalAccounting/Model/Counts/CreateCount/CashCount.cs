using AutoMapper;
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

            //DataLayer.AccountingContext.CashCounts.Add(new DataLayer.DataModels.CashCount()
            //{
            //    AmountOfMoney = inputCountParametrs.AmountOfMoney,
            //    Comment = inputCountParametrs.Comment,
            //    Name = inputCountParametrs.Name,
            //    Valuta = inputCountParametrs.Valuta
            //});
            //return true;
            return false;
        }

        public string GetDataQuestion() => null;

        public string GetMoneyQuestion() => "Какая сумма находидися на этом счету?";

        public string GetTypeName() => "Наличные деньги";

        public float GetVisibilityBankQuestion() => 0;

        public float GetVisibilityDataQuestion() => 0;
    }
}