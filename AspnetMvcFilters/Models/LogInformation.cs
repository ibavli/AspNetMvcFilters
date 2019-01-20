using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspnetMvcFilters.Models
{
    public class LogInformation
    {
        public int Id { get; set; }

        public string ControllerName { get; set; }

        public string ActionName { get; set; }

        public DateTime Date { get; set; }

        public string Type { get; set; }

        public string ErrorMessage { get; set; }
    }
}