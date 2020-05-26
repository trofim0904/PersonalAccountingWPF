using PersonalAccounting.Model.Counts.CashCounts;
using System.Collections.ObjectModel;

namespace PersonalAccounting.ViewModel.Counts
{
    public class AllCountsVM : BaseVM
    {
        private int _totalNumberOfCounts;
        public int TotalNumberOfCounts
        {
            get => _totalNumberOfCounts;
            set
            {
                _totalNumberOfCounts = value;
                OnPropertyChanged("TotalNumberOfCounts");
            }
        }
        private float _totalSum;
        public float TotalSum
        {
            get => _totalSum;
            set
            {
                _totalSum = value;
                OnPropertyChanged("TotalSum");
            }
        }
        public AllCountsVM()
        {
            


            //TODO:
            //Normal data input for credit and deposit
            cashlogic = new CashCountLogic();
            ListOfCashCounts = new ObservableCollection<OneCashCountViewVM>(cashlogic.GetCashCounts());





            TotalSum = cashlogic.GetTotalSumOfCounts();
            TotalNumberOfCounts = cashlogic.GetTotalNumberOfCounts();


        }

        #region Cash Counts

        private ObservableCollection<OneCashCountViewVM> _listOfCashCounts;
        public ObservableCollection<OneCashCountViewVM> ListOfCashCounts
        {
            get => _listOfCashCounts;
            set
            {
                _listOfCashCounts = value;
                OnPropertyChanged("ListOfCashCounts");
            }
        }
        CashCountLogic cashlogic;

        #endregion
        #region Credit Counts

        private ObservableCollection<OneCashCountViewVM> _listOfCreditCounts;
        public ObservableCollection<OneCashCountViewVM> ListOfCreditCounts
        {
            get => _listOfCreditCounts;
            set
            {
                _listOfCreditCounts = value;
                OnPropertyChanged("ListOfCreditCounts");
            }
        }


        #endregion
        #region Deposit Counts

        private ObservableCollection<OneCashCountViewVM> _listOfDepositCounts;
        public ObservableCollection<OneCashCountViewVM> ListOfDepositCounts
        {
            get => _listOfDepositCounts;
            set
            {
                _listOfDepositCounts = value;
                OnPropertyChanged("ListOfDepositCounts");
            }
        }


        #endregion
    }
}
