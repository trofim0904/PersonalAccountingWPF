using PersonalAccounting.Model.Counts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
