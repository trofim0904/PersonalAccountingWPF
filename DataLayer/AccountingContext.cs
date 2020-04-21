using DataLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class AccountingContext
    {
        public static List<CashCount> CashCounts = new List<CashCount>()
        {
            new CashCount()
            {
                Id = 0,
                AmountOfMoney = 100.50f,
                Name = "Кошелек",
                Valuta = "UAN"
            }
        };
        public static List<CreditCount> CreditCounts = new List<CreditCount>()
        {
            new CreditCount()
            {
                Id = 0,
                AmountOfMoney = 1020.0f,
                Name = "Неудачный кредит",
                Valuta = "UAN",
                BankName = "Monobank",
                StartDate = "20.04.2020"
            }
        };
        public static List<DepositCount> DepositCounts = new List<DepositCount>()
        {
            new DepositCount()
            {
                Id = 0,
                AmountOfMoney = 2000.0f,
                Name = "Допозит он и есть депозит",
                Valuta = "UAN",
                BankName = "Privat",
                StartDate = "15.04.2020"
                
                
            }
        };
    }
}
