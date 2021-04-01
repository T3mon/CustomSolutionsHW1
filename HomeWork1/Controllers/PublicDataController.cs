using BusinessLogicLayer.LogginService;
using BusinessLogicLayer.Models;
using BusinessLogicLayer.PublicDataService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork1.Controllers
{
    [Route("[controller]")]
    [ServiceFilter(typeof(LogginFilterAttribute))]
    [ApiController]
    public class PublicDataController : ControllerBase
    {
        private readonly IPublicDataService _PublicDataService;

        public PublicDataController(IPublicDataService PublicDataService)
        {
            _PublicDataService = PublicDataService;
        }

        [HttpGet]
        [Route("get-publicdata")]
        public List<PublicDatasDTO> GetPublicData()
        {
            return _PublicDataService.GetAll();
        }
    }
}
