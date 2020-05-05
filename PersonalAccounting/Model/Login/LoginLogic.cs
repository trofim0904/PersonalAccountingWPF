using DataLayer;
using DataLayer.DataModels;
using DataLayer.Repositories.UserRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.Model.Login
{
    public class LoginLogic
    {
        public bool LoginUser(LoginModel loginModel)
        {
            bool result;
            using (IUserRepository repository = new UserRepository())
            {
                User user = repository.LoginUser(loginModel.Name, loginModel.Password);
                if (user != null)
                {
                    MyUser.UserName = user.Name;
                    MyUser.UserId = user.Id;
                    result = true;
                }
                else result = false;
            }
            return result;
        }
    }
}
