using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.Model.Counts.CreateCount
{
    public interface ISelectedCount
    {
        string GetTypeName();

        string GetMoneyQuestion();

        string GetDataQuestion();

        float GetVisibilityDataQuestion();

        float GetVisibilityBankQuestion();

        bool CreateAction(InputCountParametrs inputCountParametrs);
        

    }
}
