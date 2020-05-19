using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.Model.Counts.ModelsForList
{
    public abstract class CountViewInList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float AmountOfMoney { get; set; }

        public bool AmountMoneyChangeEnable { get; set; }

        public CountViewInList(bool param)
        {
            AmountMoneyChangeEnable = param;
        }

        public abstract CountViewInList Clone();
    }
}
