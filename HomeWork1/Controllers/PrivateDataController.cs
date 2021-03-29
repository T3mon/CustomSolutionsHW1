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
    public class PrivateDataController : ControllerBase
    {
        private readonly IPrivateDataService _PrivateDataServicee;

        public PrivateDataController(IPrivateDataService PrivateDataService)
        {
            _PrivateDataServicee = PrivateDataService;
        }


        [HttpGet]
        [Route("get-privatedata")]
        public List<PrivateDataDTO> GetPrivateData()
        {
            return _PrivateDataServicee.GetAll();
        }
    }
}
