using PersonalAccounting.Model.Counts.ModelsForList;

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
        
        public OneCashCountViewVM(CashCountViewInList countView)
        {
            CountView = countView;
        }
    }
}
