using Microsoft.AspNetCore.Mvc;

namespace GitASPDemo.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
