using PersonalAccounting.Model.Counts.CashCounts.PeriodChangeModels;
using PersonalAccounting.Model.Counts.ModelsForList;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PersonalAccounting.ViewModel.Counts
{
    public class AllPeriodChangeWindowVM:BaseVM
    {
        private ObservableCollection<PeriodChangeInListVM> _periodChanges;
        public ObservableCollection<PeriodChangeInListVM> PeriodChanges
        {
            get => _periodChanges;
            set
            {
                _periodChanges = value;
                OnPropertyChanged("PeriodChanges");
            }
        }

        public ICommand CloseCommand { get; private set; }


        public AllPeriodChangeWindowVM(List<PeriodChange> periodChanges)
        {
            PeriodChanges = new ObservableCollection<PeriodChangeInListVM>();
            foreach (PeriodChange periodChange in periodChanges)
            {
                PeriodChanges.Add(new PeriodChangeInListVM(periodChange));
            }


            CloseCommand = new DelegateCommand(Close);

        }

        private void Close(object obj)
        {
            if (!(obj is Window window))
                return;
            window.Close();

        }
    }
}
