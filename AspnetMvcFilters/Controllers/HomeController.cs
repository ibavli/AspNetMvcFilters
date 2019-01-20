using AspnetMvcFilters.Filters;
using AspnetMvcFilters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspnetMvcFilters.Controllers
{
    //[Log]
    //Eğer bu controllerdaki tüm metodlarda çalışmasını istiyorsak buraya bir sefer tanımlayabiliriz.
    public class HomeController : Controller
    {
        /*

        Filtre çeşitleri
        1) Action : Action metodunun çalışmasına göre belirlenen durumda çalışır. (önce ya da sonra)
        2) Authorization : Yetkilendirme filtresidir.
        3) Exception : Action ya da controller içinde hata oluştuğunda çalışır.
        4) Result : Action result (geri dönüş değeri) çalışmadan önce ya da sonra çalışır. 

       */

        //Tek tek tüm metodların üstüne yazmak istemezsek controllerin üzerine yazmamız yeterli. Dikkat bu sayfadaki tüm metodlar için çalışır !


        [Log]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Logs()
        {
            return View(LogDatas.logs);
        }
    }
}