using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace BookingClone.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        public IActionResult CustomerCabinet()
        {
            return View();
        }
    }
} 