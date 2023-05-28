using Microsoft.AspNetCore.Mvc;

namespace HotelBookingApp.Controllers;

public class HotelController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}