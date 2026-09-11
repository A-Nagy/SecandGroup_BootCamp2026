using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SecandGroup_1.Models;

namespace SecandGroup_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // return Content("Text Data"); 
            ViewBag.MyName = "Ahmad";

            //ViewBag.ID =1;
            //ViewBag.Name ="Ahmad";
            //ViewBag.Job ="Developer";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
