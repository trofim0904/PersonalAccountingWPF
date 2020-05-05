using PersonalAccounting.Model.Counts.ModelsForList;
using PersonalAccounting.View.Counts;
using System;
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
        
        public ICommand ShowCountDetailsCommand { get; set; }

        public OneCashCountViewVM(CashCountViewInList countView)
        {
            CountView = countView;
            ShowCountDetailsCommand = new DelegateCommand(ShowCountDetails);
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
