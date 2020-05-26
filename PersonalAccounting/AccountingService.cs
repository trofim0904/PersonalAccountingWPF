using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting
{
    public class AccountingService
    {
        private PersonalAccounting.ProgramService.ServiceClient client;

        public AccountingService()
        {
            client = new ProgramService.ServiceClient("BasicHttpBinding_IService");
        }
        public bool LoginAndPasswordVerification(string login, string password, string repeatpassword)
        {
            return client.LoginAndPasswordVerification(login, password, repeatpassword);
        }
    }
}
