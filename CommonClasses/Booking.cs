using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses {
    public class Booking {
        public Booking(Accommodation accommodation, Flight flight, CarRental carRental, string email) {
            Id = new Guid();
            this.accommodation = accommodation;
            this.flight = flight;
            this.carRental = carRental;
            this.email = email;
            this.total_price = accommodation.total_accomodation_price + flight.price + carRental.price;
        }

        public Guid Id { get; set; }
        public Accommodation accommodation { get; set; }
        public Flight flight { get; set; }  
        public CarRental carRental { get; set; }
        public string email { get; set; }
        public float total_price { get; set; }  
    }
}
