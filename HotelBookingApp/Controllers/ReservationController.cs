using Microsoft.AspNetCore.Mvc;

namespace HotelBookingApp.Controllers;

public class ReservationController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}