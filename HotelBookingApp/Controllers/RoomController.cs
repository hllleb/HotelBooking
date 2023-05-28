using Microsoft.AspNetCore.Mvc;

namespace HotelBookingApp.Controllers;

public class RoomController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}