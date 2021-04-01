using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class ApiRequestsLogs
    {
        public int Id { get; set; }
        public string ResourceName { get; set; }
        public string EndpointName  { get; set; }
        public string RequestTime { get; set; }
    }
}
