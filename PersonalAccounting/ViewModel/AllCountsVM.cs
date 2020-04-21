using PersonalAccounting.ViewModel.Counts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.ViewModel
{
    public class AllCountsVM : BaseVM
    {
        public AllCountsVM()
        {
            //TODO:
            //Normal data input
            ListOfCashCounts = new ObservableCollection<OneCountViewVM>();
            foreach (DataLayer.DataModels.CashCount cashCount in DataLayer.AccountingContext.CashCounts)
            {
                ListOfCashCounts.Add(new OneCountViewVM(
                    new Model.Counts.CountViewInList()
                    {
                        AmountOfMoney = cashCount.AmountOfMoney,
                        Name = cashCount.Name
                    }));
            }

            ListOfCreditCounts = new ObservableCollection<OneCountViewVM>();
            foreach (DataLayer.DataModels.CreditCount cashCount in DataLayer.AccountingContext.CreditCounts)
            {
                ListOfCreditCounts.Add(new OneCountViewVM(
                    new Model.Counts.CountViewInList()
                    {
                        AmountOfMoney = cashCount.AmountOfMoney,
                        Name = cashCount.Name
                    }));
            }

            ListOfDepositCounts = new ObservableCollection<OneCountViewVM>();
            foreach (DataLayer.DataModels.DepositCount cashCount in DataLayer.AccountingContext.DepositCounts)
            {
                ListOfDepositCounts.Add(new OneCountViewVM(
                    new Model.Counts.CountViewInList()
                    {
                        AmountOfMoney = cashCount.AmountOfMoney,
                        Name = cashCount.Name
                    }));
            }


        }

        #region Cash Counts

        private ObservableCollection<OneCountViewVM> _listOfCashCounts;
        public ObservableCollection<OneCountViewVM> ListOfCashCounts
        {
            get => _listOfCashCounts;
            set
            {
                _listOfCashCounts = value;
                OnPropertyChanged("ListOfCashCounts");
            }
        }


        #endregion
        #region Credit Counts

        private ObservableCollection<OneCountViewVM> _listOfCreditCounts;
        public ObservableCollection<OneCountViewVM> ListOfCreditCounts
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

        private ObservableCollection<OneCountViewVM> _listOfDepositCounts;
        public ObservableCollection<OneCountViewVM> ListOfDepositCounts
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
