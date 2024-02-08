using Microsoft.AspNetCore.Mvc;

namespace GitASPDemo.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            //changes made in hima branch
            System.Console.WriteLine("Change 2");
            return View();
        }
    }
}
