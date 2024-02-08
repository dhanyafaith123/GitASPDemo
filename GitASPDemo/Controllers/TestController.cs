using Microsoft.AspNetCore.Mvc;

namespace GitASPDemo.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            //changes made in hima branch
            System.Console.WriteLine("Changes in hima branch");
            return View();
        }
    }
}
