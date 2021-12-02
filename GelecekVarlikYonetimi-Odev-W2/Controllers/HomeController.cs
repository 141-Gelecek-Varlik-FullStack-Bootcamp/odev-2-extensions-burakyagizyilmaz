using Data;
using GelecekVarlikYonetimi_Odev_W2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GelecekVarlikYonetimi_Odev_W2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPageHitCounter _hitCounter;

        public HomeController(ILogger<HomeController> logger, IPageHitCounter hitCounter)
        {
            _hitCounter = hitCounter;
            _logger = logger;
        }

        public IActionResult Index()
        {
          int hit =  _hitCounter.Increase();
            ViewBag.hit = hit.ToString();
            return View();
        }


        [LoginControl("yagizyilmazburak@gmail.com", "123456")] //Users listesinde olmayan bir bilgi girildiğinde error sayfasına yönlendirecektir.
        public IActionResult Privacy()
        {
            return View();
        }


        [CustomLogging] // Eklenen action ile ilgili loglama yapılmak için oluşturulmuştur.
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
