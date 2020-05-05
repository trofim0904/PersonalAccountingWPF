using DataLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.UserRepository
{
    public class UserRepository : GeneralRepository<User>, IUserRepository
    {
        public User LoginUser(string name, string password)
        {
            User user = null;
            try
            {

                user = context.Users.Where(
                    l => l.Name == name).Where(
                    p => p.Password == password).First();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return user;
        }

        public override void Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}
