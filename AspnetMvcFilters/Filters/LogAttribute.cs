using AspnetMvcFilters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspnetMvcFilters.Filters
{
    public class LogAttribute : FilterAttribute, IActionFilter, IResultFilter, IExceptionFilter
    {
        //Bu 4 metodun çalışma sırası aşağıdaki gibidir.

        public void OnActionExecuting(ActionExecutingContext filterContext)//Action başladığında
        {
            LogDatas.logs.Add(new LogInformation
            {
                ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                ActionName = filterContext.ActionDescriptor.ActionName,
                Date = DateTime.Now,
                Type = "Before"
            });
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)//Action tamamlandığında
        {
            LogDatas.logs.Add(new LogInformation
            {
                ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                ActionName = filterContext.ActionDescriptor.ActionName,
                Date = DateTime.Now,
                Type = "After"
            });
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)//Action'ın geri dönüş verisi işlenmeden hemen önce çalışır.
        {
            LogDatas.logs.Add(new LogInformation
            {
                ControllerName = filterContext.RouteData.Values["controller"].ToString(),
                ActionName = filterContext.RouteData.Values["action"].ToString(),
                Date = DateTime.Now,
                Type = "BeforeResult"
            });
        }

        public void OnResultExecuted(ResultExecutedContext filterContext)//Action'ın geri dönüş verisi işlenmesinden hemen sonra çalışır.
        {
            LogDatas.logs.Add(new LogInformation
            {
                ControllerName = filterContext.RouteData.Values["controller"].ToString(),
                ActionName = filterContext.RouteData.Values["action"].ToString(),
                Date = DateTime.Now,
                Type = "AfterResult"
            });
        }

        public void OnException(ExceptionContext filterContext)//Bir hata alındığında
        {
            LogDatas.logs.Add(new LogInformation
            {
                ControllerName = filterContext.RouteData.Values["controller"].ToString(),
                ActionName = filterContext.RouteData.Values["action"].ToString(),
                Date = DateTime.Now,
                Type = "Error",
                ErrorMessage = filterContext.Exception.Message
            });
        }
    }
}