using Microsoft.AspNetCore.Mvc;

namespace GitASPDemo.Controllers
{
    public class developmentController : Controller
    {
        public IActionResult Index()
        {
            //changes made
            return View();
        }
    }
}
