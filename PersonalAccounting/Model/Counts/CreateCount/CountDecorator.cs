using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.Model.Counts.CreateCount
{
    public abstract class CountDecorator : Count
    {
        protected Count count;

        public void SetComponent(Count count)
        {
            this.count = count;
        }

        public abstract string GetDataQuestion();

        public abstract float GetVisibilityDataQuestion();

        public abstract float GetVisibilityBankQuestion();
    }
}
