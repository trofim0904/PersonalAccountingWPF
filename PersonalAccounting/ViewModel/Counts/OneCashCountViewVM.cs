using PersonalAccounting.Model.Counts.CashCounts;
using PersonalAccounting.Model.Counts.ModelsForList;
using PersonalAccounting.View.Counts;
using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Windows;
using System.Windows.Input;

namespace PersonalAccounting.ViewModel.Counts
{
    public class OneCashCountViewVM : BaseVM
    {
        private CashCountViewInList _countView;
        public CashCountViewInList CountView
        {
            get => _countView;
            set
            {
                _countView = value;
                OnPropertyChanged("CountView");
            }
        }
        private SpecificCashCountLogic _countlogic;
        private CashLogicWithPeriodChanges _periodlogic;
        

        public ICommand ShowCountDetailsCommand { get; private set; }
        public ICommand ShowPeriodChangeCommand { get; private set; }

        public OneCashCountViewVM(CashCountViewInList countView)
        {
            CountView = countView;
            _countlogic = new SpecificCashCountLogic();
            if (countView.PeriodChanges)
            {
                _periodlogic = new CashLogicWithPeriodChanges(_countlogic);
            }
            


            ShowCountDetailsCommand = new DelegateCommand(ShowCountDetails);
            ShowPeriodChangeCommand = new DelegateCommand(ShowPeriodChange,PeriodChangeEnable);
        }

        private bool PeriodChangeEnable(object arg)
        {
            return CountView.PeriodChanges;
        }

        private void ShowPeriodChange(object obj)
        {

            _periodlogic.GetAllPeriodChange(CountView.Id);


            MessageBox.Show("Add Period Change");
        }

        private void ShowCountDetails(object obj)
        {
            //TODO
            //Parametrs info
            Window window = new CountInfoWindow(CountView.Id);
            window.Show();
        }
    }
}
