using Microsoft.AspNetCore.Mvc;

namespace BookingClone.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
