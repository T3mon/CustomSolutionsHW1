using BusinessLogicLayer.Models;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.UserService
{
    class UserService : IUserService
    {
		private readonly IApplicationDbContext _dbContext;
		public UserService(IApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public List<UserDTO> GetAll()
		{
			var users = _dbContext.Users.ToList();
			var userResult = new List<UserDTO>();

			foreach (var user in users)
			{
				var mappedUser = new UserDTO { Login = user.Login, Password = user.Password };
				userResult.Add(mappedUser);

			}

			return userResult;
		}

    }
}
