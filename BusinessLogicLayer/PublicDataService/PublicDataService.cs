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
			var users = _dbContext.PublicDatas.ToList();
			var userResult = new List<PublicDatasDTO>();

			foreach (var user in users)
			{
				var mappedUser = new PublicDatasDTO{ Text = user.Text};
				userResult.Add(mappedUser);
			}

			return userResult;
		}

    }
}
