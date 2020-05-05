using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PersonalAccounting.ViewModel.Login
{
    public class LoginWindowVM : BaseVM
    {
        private BaseVM _selectedViewModel;
        public BaseVM SelectedViewModel
        {
            get => _selectedViewModel;
            set
            {
                _selectedViewModel = value;
                OnPropertyChanged("SelectedViewModel");
            }
        }


        public ICommand CloseCommand { get; private set; }
        public ICommand GoToRegistrationCommand { get; private set; }
        public ICommand GoToLoginCommand { get; private set; }


        public LoginWindowVM()
        {
            SelectedViewModel = new LoginInfoVM();


            CloseCommand = new DelegateCommand(Close);
            GoToRegistrationCommand = new DelegateCommand(GoToRegistration);
            GoToLoginCommand = new DelegateCommand(GoToLogin);
        }

        private void GoToLogin(object obj)
        {
            Window window = obj as Window;
            SelectedViewModel = new LoginVM(window);
        }

        private void GoToRegistration(object obj)
        {
           
            Window window = obj as Window;

            SelectedViewModel = new RegistarationVM(window);
        }

        private void Close(object obj)
        {
            if (!(obj is Window window))
                return;
            window.Close();
        }
    }
}
