using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int hour = DateTime.Now.Hour;

            ViewData["Greeting"] = hour > 12 ? "İyi günler" : "Günaydın";
            ViewData["UserName"] = "Emir";

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "Bursa",
                Date = new DateTime(2024, 01, 20, 20, 0, 0),
                NumberOfPeople = 100
            };

            return View(meetingInfo);
        }
    }
}