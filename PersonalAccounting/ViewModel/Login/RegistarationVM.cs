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

        public RegistarationVM(Window window)
        {
            _window = window;

            RegistrationCommand = new DelegateCommand(Registration);
        }

        private void Registration(object obj)
        {
            throw new NotImplementedException();
        }

        public ICommand RegistrationCommand { get; private set; }
    }
}
