using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace UI
{
     public static class ConfigConection
    {
        public static string Connection = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
    }
}
