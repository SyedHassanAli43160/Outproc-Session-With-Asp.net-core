using distributedsessionaspnetcore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace distributedsessionaspnetcore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult insertsession()
        {
            HttpContext.Session.SetString("name", "Syed Hassan Ali");
            return RedirectToAction("GetSessionData");
        }
       
        public IActionResult GetSessionData()
        {
            ViewBag.data = HttpContext.Session.GetString("name");
            return View();
        }
    }
}