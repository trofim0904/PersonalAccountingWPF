using PersonalAccounting.Model.Counts.CreateCount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.Model.Counts
{
    public class CountType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ISelectedCount SelectedCount { get; set; }

        public static readonly List<CountType> CountTypes = new List<CountType>()
        {
            new CountType() { Id=1, Name="Наличные деньги", SelectedCount = new CashCount()},
            new CountType() { Id=2, Name="Кредит", SelectedCount = new CreditCount() },
            new CountType() { Id=3, Name="Депозит", SelectedCount = new DepositCount() }
        };
    }

}
