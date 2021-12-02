using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GelecekVarlikYonetimi_Odev_W2
{
    public class LoginControl : Attribute, IActionFilter
    {
        //Dummy data oluşturuldu.

        public static List<User> users = new List<User>
        {
            new User { Name = "Burak", SurName = "Yagizyilmaz", Id = 1, Mail = "yagizyilmazburak@gmail.com", Password = "123456" },
            new User { Name="Ayaz",SurName="Yagizyilmaz",Id=2,Mail="yagizyilmazayaz@gmail.com",Password="654321"}
        };

        private string _mail;
        private string _password;

        public LoginControl(string mail, string password)
        {
            _mail = mail;
            _password = password;
        }


        //Actiona erişim istendiğinde çalışacaktır.

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (users.Any(x=>x.Mail==_mail && x.Password==_password))
            {
                //Context'in resultını değişmeden ilgili sayfaya gitmesine izin veriyoruz.
            }
            else
            {
                //Kullanıcı bilgileri hatalı olduğu için route unu error sayfası olarak değiştirerek yönlendiriyoruz.
                context.Result = new RedirectToRouteResult(new RouteValueDictionary { { "controller", "Home" }, { "action", "Error" } });
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {

        }
    }
}
