using PersonalAccounting.Model.Counts.CashCounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PersonalAccounting.ViewModel.Counts
{
    public class CountInfoWindowVM : BaseVM
    {
        private CashCountInfo _countInfo;
        public CashCountInfo CashCount
        {
            get => _countInfo;
            set
            {
                _countInfo = value;
                OnPropertyChanged("CashCount");
            }
        }

        public ICommand CloseCommand { get; private set; }
        public ICommand AddPeriodFunctionCommand { get; private set; }

        private CashCountLogic _countlogic;

        public CountInfoWindowVM(int id)
        {
            _countlogic = new CashCountLogic();

            CashCount = _countlogic.GetCashCountInfoById(id);

            AddPeriodFunctionCommand = new DelegateCommand(AddPeriodFunction);
            CloseCommand = new DelegateCommand(Close);
        }

        private void AddPeriodFunction(object obj)
        {
            if (_countlogic.UpdatePeriodChanges(CashCount.Id))
            {
                MessageBox.Show("Изменено");
            }
            else MessageBox.Show("Ошибка");
        }

        private void Close(object obj)
        {
            if (!(obj is Window window))
                return;
            window.Close();

        }
    }
}
