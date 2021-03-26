using BusinessLogicLayer.Models;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.PublicDataService
{
    class UserService : IUserService
    {
        private readonly IApplicationDbContext _dbContext;
        public UserService(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool UserExist(UserDTO user)
        {
            if (_dbContext.Users.FirstOrDefault(p => p.Login == user.Login && p.Password == user.Password) != null)
            {
                return true;
            }
            return false;
        }
    }
}
