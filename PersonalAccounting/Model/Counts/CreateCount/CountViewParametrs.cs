
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.Model.Counts.CreateCount
{
    public class CountViewParametrs
    {

        ISelectedCount selectedCount;

        public CountViewParametrs(ISelectedCount selectedCount)
        {
            this.selectedCount = selectedCount;
        }

        public bool CreateAction(InputCountParametrs inputCountParametrs)
        {
            return selectedCount.CreateAction(inputCountParametrs);
        }

        public string DataQuestion
        {
            get => selectedCount.GetDataQuestion();
        }

        public string MoneyQuestion
        {
            get => selectedCount.GetMoneyQuestion();
        }

        public string TypeName
        {
            get => selectedCount.GetTypeName();
        }

        public float VisibilityBankQuestion
        {
            get => selectedCount.GetVisibilityBankQuestion();
        }

        public float VisibilityDataQuestion
        {
            get => selectedCount.GetVisibilityDataQuestion();
        }
    }
}