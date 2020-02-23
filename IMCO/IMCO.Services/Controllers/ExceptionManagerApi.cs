using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;

namespace IMCO.Services.Controllers
{
    public class ExceptionManagerApi : ExceptionLogger
    {
        public override void Log(ExceptionLoggerContext context)
        {
            var ex = context.ExceptionContext.Exception;
            Helper.Log(ex, "API Layer Error");
        }
    }
}
