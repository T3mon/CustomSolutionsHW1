﻿using BusinessLogicLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.UserService
{
    interface IUserService
    {
		List<UserDTO> GetAll();
    }
}