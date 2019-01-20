using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspnetMvcFilters.Models
{
    public class LogDatas
    {
        private static List<LogInformation> _logs = new List<LogInformation>();
        public static List<LogInformation> logs
        {
            get { return _logs; }
        }
    }
}