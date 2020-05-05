using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.ViewModel.Login
{
    public class LoginInfoVM:BaseVM
    {
        private string _infotext;
        public string InfoText
        {
            get => _infotext;
            set
            {
                _infotext = value;
                OnPropertyChanged("InfoText");
            }
        }
        public LoginInfoVM()
        {
            InfoText = "Если вы не имеете акаут кликните 'Регистрация'. Если вы уже создавали аккаунт нажмите 'Вход'";
        }
    }
}
