using PersonalAccounting.Model.Login;
using PersonalAccounting.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PersonalAccounting.ViewModel.Login
{
    public class LoginVM : BaseVM
    {

        private LoginModel _inputdata;
        public LoginModel InputData
        {
            get => _inputdata;
            set
            {
                _inputdata = value;
                OnPropertyChanged("InputData");
            }
        }
        
        private Window _window;


        public LoginVM(Window window)
        {
            _window = window;

            InputData = new LoginModel();
            LoginCommand = new DelegateCommand(Login);
        }

        private LoginLogic loginLogic = new LoginLogic();

        private void Login(object obj)
        {
            if (!(obj is PasswordBox passwordBox))
                return;
            InputData.Password = passwordBox.Password;
            if (loginLogic.LoginUser(InputData))
            {
                Window mainwindow = new MainWindow();
                mainwindow.Show();
                _window.Close();
            }
            else
            MessageBox.Show("Ошибка");
           
        }

        public ICommand LoginCommand { get; private set; }
    }
}
