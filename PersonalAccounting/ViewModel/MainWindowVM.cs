using PersonalAccounting.View.UserControls;
using PersonalAccounting.View.UserControls.CreateNewCountSteps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PersonalAccounting.ViewModel
{
    public class MainWindowVM : BaseVM
    {
        private Frame _frame;
        public Frame Frame
        {
            get => _frame;
            set
            {
                _frame = value;
                OnPropertyChanged("Frame");
            }
        }
        private float _cancelButtonVisibility;
        public float CancelButtonVisibility
        {
            get => _cancelButtonVisibility;
            set
            {
                _cancelButtonVisibility = value;
                OnPropertyChanged("CancelButtonVisibility");
            }
        }
        private Navigation navigation;
        
        public MainWindowVM()
        {
            Frame = new Frame();
            CancelButtonVisibility = 0;
            navigation = new Navigation();
           
            Frame.Content = navigation.GetUC(NamesOfUC.AllCounts);

            NewCountCommand = new DelegateCommand(NewCount);
            CountPageCommand = new DelegateCommand(CountPage);
            BackToAllCountsCommand = new DelegateCommand(BackToAllCounts);
            CloseAppCommand = new DelegateCommand(CloseApp);
        }

        private void CloseApp(object obj)
        {
            if (!(obj is Window window))
                return;
            window.Close();
        }

        private void BackToAllCounts(object obj)
        {
            Frame.Content = navigation.GetUC(NamesOfUC.AllCounts);
            CancelButtonVisibility = 0;
        }

        private void CountPage(object obj)
        {
            Frame.Content = navigation.GetUC(NamesOfUC.AllCounts);
        }

        private void NewCount(object obj)
        {

            Frame.Content = navigation.GetUC(NamesOfUC.NewCountFS);
            CancelButtonVisibility = 1;
        }

        public ICommand BackToAllCountsCommand { get; private set; }
        public ICommand CountPageCommand { get; private set; }
        public ICommand NewCountCommand { get; private set; }
        public ICommand CloseAppCommand { get; private set; }



    }

}
