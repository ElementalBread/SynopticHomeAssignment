﻿using Microsoft.AspNetCore.Mvc;
using CommonClasses;
using Google.Cloud.Firestore;
using Newtonsoft.Json;

namespace BookingsManagementService.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class BookingsManagementController : Controller {
        private readonly ILogger<BookingsManagementController> _logger;
        private FirestoreDb db = FirestoreDb.Create("synopticassignmen");

        public BookingsManagementController(ILogger<BookingsManagementController> logger) {
            _logger = logger;
        }

        [HttpGet("~/getBookings/{userEmail}")]
        public async Task<string> getBookings(string userEmail) {
            CollectionReference usersRef = db.Collection("bookings");
            QuerySnapshot snapshot = await usersRef.GetSnapshotAsync();
            List<Booking> bookings = new List<Booking>();

            foreach (DocumentSnapshot document in snapshot.Documents) {
                Dictionary<string, object> documentDictionary = document.ToDictionary();

                Console.WriteLine(documentDictionary);

                if (String.Compare(documentDictionary["userEmail"].ToString(), userEmail) == 0) {
                    Booking temp = new Booking();
                    temp.total_price = float.Parse(documentDictionary["totalPrice"].ToString());
                    temp.email = userEmail;
                    temp.accommodation = (string)documentDictionary["accomodation"];
                    temp.carRental = (string)documentDictionary["carRental"];
                    temp.flight = (string)documentDictionary["flight"];

                    bookings.Add(temp);
                }
            }

            return JsonConvert.SerializeObject(bookings);
        }
    }
}
