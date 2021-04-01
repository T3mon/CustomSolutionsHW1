using DataAccessLayer;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.LogginService
{
    public class LogginFilterAttribute : ActionFilterAttribute
    {
        private readonly ApplicationDbContext _dbContext;
        public LogginFilterAttribute(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var request = context.HttpContext.Request;

            _dbContext.ApiRequestsLogs.Add(new ApiRequestsLogs()
            {
                EndpointName = request.Path.ToString(),
                ResourceName = request.Method.ToString(),
                RequestTime = DateTime.Now.ToLongDateString()
            });
            _dbContext.SaveChanges();
            base.OnActionExecuting(context);
        }

    }
}
