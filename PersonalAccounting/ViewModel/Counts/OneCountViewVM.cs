using PersonalAccounting.Model.Counts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.ViewModel.Counts
{
    public class OneCountViewVM : BaseVM
    {
        private CountViewInList _countView;
        public CountViewInList CountView
        {
            get => _countView;
            set
            {
                _countView = value;
                OnPropertyChanged("CountView");
            }
        }
        public OneCountViewVM(CountViewInList countView)
        {
            CountView = countView;
        }
    }
}
