using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCO.Core.Helpers
{
    public class AppSettingsReader
    {
        public static string ReadString(string key)
        {
            try
            {
                return Convert.ToString(ConfigurationManager.AppSettings[key]);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
