using BusinessLogicLayer.Models;
using BusinessLogicLayer.PublicDataService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class PrivateDataController : ControllerBase
    {
        private readonly IPrivateDataService _PrivateDataServicee;

        public PrivateDataController(IPrivateDataService PrivateDataService)
        {
            _PrivateDataServicee = PrivateDataService;
        }

        [HttpGet]
        [Authorize]
        [Route("get-users")]
        public List<PrivateDataDTO> GetAllUsers()
        {
            return _PrivateDataServicee.GetAll();
        }
    }
}
