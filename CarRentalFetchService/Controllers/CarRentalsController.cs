using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using CommonClasses;
using Newtonsoft.Json.Linq;

namespace CarRentalFetchService.Controllers {
    public class CarRentalsController : Controller {
        [ApiController]
        [Route("[controller]")]
        public class FlightsController : Controller {
            private readonly ILogger<CarRentalsController> _logger;

            public FlightsController(ILogger<CarRentalsController> logger) {
                _logger = logger;
            }

            [HttpGet("~/getRentalsJson/{origin}/{destination}/{departureDate}")]
            public async Task<string> GetJson(string origin, string destination, string departureDate) {
                var client = new HttpClient();
                var request = new HttpRequestMessage {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://skyscanner44.p.rapidapi.com/search-extended?adults=1&origin=" + origin + "&destination=" + destination +
                                        "&departureDate=" + departureDate + "&currency=EUR&stops=0"), //MLA - Malta , MXP - Milan , example date - 2022-10-11
                    Headers =
                        {
                        { "X-RapidAPI-Key", "911baca7a5mshad44fe6b3ba5b83p1cfb9bjsnec44e825cee0" },
                        { "X-RapidAPI-Host", "skyscanner44.p.rapidapi.com" },
                    },
                };
                string s;
                //using (var response = await client.SendAsync(request)) {
                //    response.EnsureSuccessStatusCode();
                //    s = await response.Content.ReadAsStringAsync();
                //    Console.WriteLine(s);
                //}

                s = "";
                JObject returnJson = JsonConvert.DeserializeObject<JObject>(s);
                JArray results = (JArray)returnJson["itineraries"]["results"];

                Console.WriteLine(results.Count);


                List<CarRental> carRentals = new List<CarRental>();
                //int i = 0;
                //foreach (var result in results) {
                //    try {
                //        int flightNum = int.Parse((string)returnJson["itineraries"]["results"][i]["legs"][0]["segments"][0]["flightNumber"]);
                //        string airline = (string)returnJson["itineraries"]["results"][i]["legs"][0]["carriers"]["marketing"][0]["name"];
                //        int durationInMinutes = int.Parse((string)returnJson["itineraries"]["results"][i]["legs"][0]["segments"][0]["durationInMinutes"]);
                //        string originAirport = (string)returnJson["itineraries"]["results"][i]["legs"][0]["segments"][0]["origin"]["name"];
                //        string destinationAirport = (string)returnJson["itineraries"]["results"][i]["legs"][0]["segments"][0]["destination"]["name"];
                //        float flightPrice = float.Parse((string)returnJson["itineraries"]["results"][i]["pricing_options"][0]["price"]["amount"]);
                //        Flight flight = new Flight(flightNum, airline, durationInMinutes, originAirport, destinationAirport, seatClass, flightPrice);
                //        flights.Add(flight);
                //    } catch (Exception e) {
                //        Console.WriteLine(e.Message);
                //    }
                //    i++;
                //}
                return JsonConvert.SerializeObject(carRentals); ;
            }
        }
    }
}
