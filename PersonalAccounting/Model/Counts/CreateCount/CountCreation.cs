
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.Model.Counts.CreateCount
{
    public abstract class CountCreation
    {

        protected ISelectedCount selectedCount;
        public ISelectedCount SelectedCount
        {
            set
            {
                selectedCount = value;
            }
        }

        public CountCreation(ISelectedCount selectedCount)
        {
            SelectedCount = selectedCount;
        }

        public virtual bool CreateAction(InputCountParametrs inputCountParametrs)
        {
            return selectedCount.CreateAction(inputCountParametrs);
        }

        public virtual string DataQuestion
        {
            get => selectedCount.GetDataQuestion();
        }

        public virtual string MoneyQuestion
        {
            get => selectedCount.GetMoneyQuestion();
        }

        public virtual string TypeName
        {
            get => selectedCount.GetTypeName();
        }

        public virtual float VisibilityBankQuestion
        {
            get => selectedCount.GetVisibilityBankQuestion();
        }

        public virtual float VisibilityDataQuestion
        {
            get => selectedCount.GetVisibilityDataQuestion();
        }
    }
}