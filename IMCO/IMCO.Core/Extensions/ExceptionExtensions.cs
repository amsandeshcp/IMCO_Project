using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCO.Core.Extensions
{
    public static class ExceptionExtensions
    {
        public static string GetAllMessages(this Exception ex)
        {
            var list = new List<string>();
            if (ex != null && string.IsNullOrWhiteSpace(ex.Message) == false)
                list.Add(ex.Message);
            var tempEx = ex.InnerException;
            while (tempEx != null)
            {
                if (string.IsNullOrWhiteSpace(tempEx.Message) == false)
                    list.Add(tempEx.Message);
                tempEx = tempEx.InnerException;
            }
            return string.Join(" - ", list);
        }
    }
}
