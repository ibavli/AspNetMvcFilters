using AspnetMvcFilters.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspnetMvcFilters.Controllers
{
    [Log]
    public class HataController : Controller
    {
        //Web.config'e <customErrors mode="On" /> ekledik.
        //Varsayılan hata sayfası /Views/Shared/Error.cshtml içerisindedir.

        [HandleError(ExceptionType = typeof(FormatException), View = "Hata")]
        public ActionResult Index()
        {
            throw new FormatException();
        }
    }
}