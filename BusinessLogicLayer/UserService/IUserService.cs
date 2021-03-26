using BusinessLogicLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.PublicDataService
{
    public interface IUserService
    {
        public bool UserExist(UserDTO user);
    }
}
