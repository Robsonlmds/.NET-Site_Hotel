using Microsoft.AspNetCore.Mvc;

namespace SiteHotel.Controllers
{
    public class DataClientController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View("HomePage");
        }

        [HttpPost]
        public IActionResult Index(string qtdAdults, string qtdQtdChildren, string suiteName, DateOnly checkIn, DateOnly checkOut, string bedLinen)
        {
            string allContent = qtdAdults + "+" + qtdQtdChildren + "+" + suiteName + "+" + checkIn + "+" + checkOut + "+" + bedLinen;

            TempData["ShowAllContent"] = allContent;

            return View("HomePage");
        }



    }
}
