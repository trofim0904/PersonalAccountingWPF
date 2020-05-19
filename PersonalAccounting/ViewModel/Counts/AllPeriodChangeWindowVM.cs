using PersonalAccounting.Model.Counts.ModelsForList;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.ViewModel.Counts
{
    public class AllPeriodChangeWindowVM:BaseVM
    {
        private ObservableCollection<PeriodChange> _periodChanges;
        public ObservableCollection<PeriodChange> PeriodChanges
        {
            get => _periodChanges;
            set
            {
                _periodChanges = value;
                OnPropertyChanged("PeriodChanges");
            }
        }

        public AllPeriodChangeWindowVM(List<PeriodChange> periodChanges)
        {
            PeriodChanges = new ObservableCollection<PeriodChange>(periodChanges);
        }
    }
}
