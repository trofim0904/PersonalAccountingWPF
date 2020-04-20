using PersonalAccounting.View.UserControls;
using PersonalAccounting.View.UserControls.CreateNewCountSteps;
using PersonalAccounting.ViewModel.Counts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PersonalAccounting.ViewModel
{
    public class Navigation
    {
        private Dictionary<NamesOfUC, UserControl> _navigationdictionary;
        public Navigation()
        {
            SetData();
        }

        public UserControl GetUC(NamesOfUC namesOfUC)
        {
            return _navigationdictionary[namesOfUC];
        }
        public void Update()
        {
            SetData();
        }
        void SetData()
        {
            _navigationdictionary = new Dictionary<NamesOfUC, UserControl>
            {
                { NamesOfUC.AllCounts, new AllCountsUC() },
                { NamesOfUC.NewCountFS, new CreateNewCountFirstStepUC(){ DataContext = new CreateNewCountFirstStepVM() } },
                { NamesOfUC.NewCountSS, new CreateNewCountSecondStepUC() }
            };
        }
    }
    public enum NamesOfUC
    {
        AllCounts,
        NewCountFS,
        NewCountSS
    }
}
