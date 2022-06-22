using Microsoft.AspNetCore.Mvc;
using CommonClasses;

namespace FlightsFetchService.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class FlightsController : Controller {
        private readonly ILogger<FlightsController> _logger;

        public FlightsController(ILogger<FlightsController> logger) {
            _logger = logger;
        }

        [HttpGet(Name = "GetFlights")]
        public IEnumerable<Flight> Get() {
            List<Flight> flights = new List<Flight>();

            for (int i = 0; i < 10; i++) {
                Flight flight = new Flight("Lh123", "Lufthansa", 20, "MLA", "21", "economy", "extra", 100.0f);
                flights.Add(flight);
             }

            return flights;
        }
    }
}
