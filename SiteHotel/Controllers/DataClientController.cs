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
        public IActionResult Index(string inputData)
        {
            return View("HomePage");
        }

    }
}
