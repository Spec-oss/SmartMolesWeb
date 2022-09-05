using Microsoft.AspNetCore.Mvc;
using SmartmolesUI.Models;
using System.Diagnostics;

namespace SmartmolesUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("/hakkimizda")]
        public IActionResult AboutUs()
        {
            return View();
        }
        [Route("/iletisim")]
        public IActionResult Contact()
        {
            return View();
        }
    }
}