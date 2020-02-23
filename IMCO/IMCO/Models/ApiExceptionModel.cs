using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMCO.Models
{
    public class ApiExceptionModel
    {
        public string Message { get; set; }
        public string ExceptionMessage { get; set; }
        public string ExceptionType { get; set; }
        public string StackTrace { get; set; }
    }
}