using PersonalAccounting.Model.Counts.CashCounts.PeriodChangeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.ViewModel.Counts
{
    public class PeriodChangeInListVM:BaseVM
    {
        private PeriodChange _periodChange;
        public PeriodChange PeriodChange
        {
            get => _periodChange;
            set
            {
                _periodChange = value;
                OnPropertyChanged("PeriodChange");
            }
        }
        public PeriodChangeInListVM(PeriodChange periodChange)
        {
            PeriodChange = periodChange;
        }
    }
}
