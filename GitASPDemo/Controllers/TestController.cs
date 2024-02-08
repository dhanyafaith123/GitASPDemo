using System;
using Microsoft.AspNetCore.Mvc;

namespace GitASPDemo.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            //changes made in dev branch
            Console.WriteLine("Changes in development branch");
            return View();
        }
    }
}
