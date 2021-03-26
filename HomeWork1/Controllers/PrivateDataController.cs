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
        public IEnumerable<string> Get()
        {
            return new string[] { "First secred data string", "Second secred data string" };
        }


        [HttpGet]
        [Authorize]
        [Route("get-privatedata")]
        public List<PrivateDataDTO> GetPrivateData()
        {
            return _PrivateDataServicee.GetAll();
        }
    }
}
