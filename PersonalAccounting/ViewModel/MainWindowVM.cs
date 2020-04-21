using PersonalAccounting.ViewModel.Counts;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace PersonalAccounting.ViewModel
{
    public class MainWindowVM : BaseVM
    {

        

      
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

        
        public MainWindowVM()
        {
            SelectedViewModel = new AllCountsVM();

            CancelButtonVisibility = 0;


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
            SelectedViewModel = new AllCountsVM();
            CancelButtonVisibility = 0;
        }

        private void CountPage(object obj)
        {
            SelectedViewModel = new AllCountsVM();
            CancelButtonVisibility = 0;
        }

        private void NewCount(object obj)
        {

            SelectedViewModel = new CreateNewCountVM();
            CancelButtonVisibility = 1;
        }

        public ICommand BackToAllCountsCommand { get; private set; }
        public ICommand CountPageCommand { get; private set; }
        public ICommand NewCountCommand { get; private set; }
        public ICommand CloseAppCommand { get; private set; }
        public ICommand NextCommand { get; private set; }



    }

}
