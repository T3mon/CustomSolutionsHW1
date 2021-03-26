using BusinessLogicLayer.Models;
using BusinessLogicLayer.PublicDataService;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.PrivateDataService
{
    public class PrivateDataService : IPrivateDataService
    {
        private readonly IApplicationDbContext _dbContext;
        public PrivateDataService(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<PrivateDataDTO> GetAll()
        {
            var datas = _dbContext.PrivateDatas.ToList();
            var dataResult = new List<PrivateDataDTO>();

            foreach (var item in datas)
            {
                var mappedDatas = new PrivateDataDTO { Text = item.Text };
                dataResult.Add(mappedDatas);

            }

            return dataResult;
        }
    }
}
