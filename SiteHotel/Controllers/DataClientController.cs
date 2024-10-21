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
            string allContent = "Qtd de adultos: " + qtdAdults + " Qtd de Crianças: " + qtdQtdChildren + " Suíte: " + suiteName + " CheckIn: " + checkIn + " CheckOut " + checkOut + " Roupa de cama: " + bedLinen;

            ViewBag.ShowAllContent = allContent;
            return View("HomePage");
        }

    }
}
