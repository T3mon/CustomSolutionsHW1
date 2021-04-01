using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IApplicationDbContext
    {
		public DbSet<PublicData> PublicDatas { get; set; }
		public DbSet<PrivateData> PrivateDatas{ get; set; }
		public DbSet<User> Users { get; set; }
        public DbSet<ApiRequestsLogs> ApiRequestsLogs { get ; set ; }

    }
}
