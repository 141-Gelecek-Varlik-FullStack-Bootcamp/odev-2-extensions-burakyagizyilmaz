using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace GelecekVarlikYonetimi_Odev_W2
{
    public class CustomLogging : Attribute, IActionFilter
    {
        //Action işlemleri tamamlandıktan sonra çalışacaktır.
        //Yönlendiren, client ip adresi gibi bilgiler loglanmıştır.
        public void OnActionExecuted(ActionExecutedContext context)
        {
            string action = context.RouteData.Values["action"].ToString();
            string controller = context.RouteData.Values["controller"].ToString();
            string refferer = context.HttpContext.Request.Headers["Referer"].ToString();
            string ipAddress = context.HttpContext.Connection.RemoteIpAddress.ToString();
            DateTime dateTime = DateTime.Now;
            //Databasede bir tabloya işlenebilir.
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {

        }
    }
}
