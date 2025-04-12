using Microsoft.AspNetCore.Mvc;

namespace ilk_asp_projem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
