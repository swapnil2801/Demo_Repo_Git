using Microsoft.AspNetCore.Mvc;

namespace PracticeApp.Controllers
{
    public class practiceDemo : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
