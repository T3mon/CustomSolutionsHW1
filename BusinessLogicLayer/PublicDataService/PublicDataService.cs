using BusinessLogicLayer.Models;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.PublicDataService
{
    public class PublicDataService : IPublicDataService
    {
		private readonly IApplicationDbContext _dbContext;
		public PublicDataService(IApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public List<PublicDatasDTO> GetAll()
		{
			var data = _dbContext.PublicDatas.ToList();
			var dataResult = new List<PublicDatasDTO>();

			foreach (var user in data)
			{
				var mappedData = new PublicDatasDTO{ Text = user.Text};
				dataResult.Add(mappedData);
			}

			return dataResult;
		}

    }
}
