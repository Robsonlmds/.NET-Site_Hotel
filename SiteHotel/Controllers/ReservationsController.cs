using Microsoft.AspNetCore.Mvc;

namespace SiteHotel.Controllers
{
    public class ReservationsController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            var allContent = TempData["ShowAllContent"];
            
            var listAllContent = allContent.ToString().Split("+");

            string qtdAdults = listAllContent[0];
            string qtdQtdChildren = listAllContent[1];
            string suiteName = listAllContent[2];
            string checkIn = listAllContent[3];
            string checkOut = listAllContent[4];
            string bedLinen = listAllContent[5];

            ViewBag.ShowQtdAdults = qtdAdults;
            ViewBag.ShowQtdQtdChildren = qtdQtdChildren;
            ViewBag.ShowSuiteName = suiteName;
            ViewBag.ShowCheckIn = checkIn;
            ViewBag.ShowCheckOut = checkOut;
            ViewBag.ShowBedLinen = bedLinen;

            return View("ReservationsView");
        }

        [HttpGet]
        public IActionResult ShowReservations()
        {
            return View("ReservationsView");
        }

    }
}
