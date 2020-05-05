using PersonalAccounting.Model.Counts.CashCounts;
using System.Collections.ObjectModel;

namespace PersonalAccounting.ViewModel.Counts
{
    public class AllCountsVM : BaseVM
    {
        public AllCountsVM()
        {

            //TODO:
            //Normal data input
            cashlogic = new CashCountLogic();
            ListOfCashCounts = new ObservableCollection<OneCashCountViewVM>(cashlogic.GetCashCounts());
            //foreach (DataLayer.DataModels.CashCount count in DataLayer.AccountingContext.CashCounts)
            //{
            //    ListOfCashCounts.Add(new OneCashCountViewVM(
            //        new Model.Counts.CashCountViewInList()
            //        {
            //            AmountOfMoney = count.AmountOfMoney,
            //            Name = count.Name
            //        }));
            //}

            //ListOfCreditCounts = new ObservableCollection<OneCountViewVM>();
            //foreach (DataLayer.DataModels.CreditCount count in DataLayer.AccountingContext.CreditCounts)
            //{
            //    ListOfCreditCounts.Add(new OneCountViewVM(
            //        new Model.Counts.CountViewInList()
            //        {
            //            AmountOfMoney = count.AmountOfMoney,
            //            Name = count.Name
            //        }));
            //}

            //ListOfDepositCounts = new ObservableCollection<OneCountViewVM>();
            //foreach (DataLayer.DataModels.DepositCount count in DataLayer.AccountingContext.DepositCounts)
            //{
            //    ListOfDepositCounts.Add(new OneCountViewVM(
            //        new Model.Counts.CountViewInList()
            //        {
            //            AmountOfMoney = count.AmountOfMoney,
            //            Name = count.Name
            //        }));
            //}


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
