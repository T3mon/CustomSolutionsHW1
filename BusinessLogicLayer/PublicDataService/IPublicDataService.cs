using BusinessLogicLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.PublicDataService
{
    public interface IPublicDataService
    {
		List<PublicDatasDTO> GetAll();
    }
}
