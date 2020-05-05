using DataLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.UserRepository
{
    public interface IUserRepository : IRepository<User>
    {
        User LoginUser(string name, string password);
    }
}
