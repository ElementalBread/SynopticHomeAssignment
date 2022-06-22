using Microsoft.AspNetCore.Mvc;

namespace FlightsFetchService.Controllers {
    public class FlightsController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}
