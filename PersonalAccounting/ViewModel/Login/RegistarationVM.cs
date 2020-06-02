using PersonalAccounting.Model.Login;
using PersonalAccounting.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PersonalAccounting.ViewModel.Login
{
    public class RegistarationVM : BaseVM
    {
        
        
        private Window _window;

        private RegistrationModel _registrationModel;
        public RegistrationModel RegistrationModel
        {
            get => _registrationModel;
            set
            {
                _registrationModel = value;
                OnPropertyChanged("RegistrationModel");
            }
        }

        public RegistarationVM(Window window)
        {
            _window = window;

            RegistrationModel = new RegistrationModel();

            RegistrationCommand = new DelegateCommand(Registration);
        }

        private async void Registration(object obj)
        {
            ApiHelper.InitializeClient();

            bool correctdata = await VerificationProcessor.CheckRegistrationModel(RegistrationModel);
            if (!correctdata)
            {
                MessageBox.Show("Ошибка!");
            }
            else
            {
                logic = new LoginLogic();

                if (!logic.AddNewUser(RegistrationModel))
                {
                    MessageBox.Show("Ошибка!");
                }
            }
        }

        private LoginLogic logic;
        public ICommand RegistrationCommand { get; private set; }
    }
}
