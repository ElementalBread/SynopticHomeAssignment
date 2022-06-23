using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses {
    public class Booking {
        public Booking(string accommodation, string flight, string carRental, string email, float totalPrice) {
            Id = new Guid();
            this.accommodation = accommodation;
            this.flight = flight;
            this.carRental = carRental;
            this.email = email;
            this.total_price = totalPrice;
        }

        public Booking() { }

        public Guid Id { get; set; }
        public string accommodation { get; set; }
        public string flight { get; set; }  
        public string carRental { get; set; }
        public string email { get; set; }
        public float total_price { get; set; }  
    }
}
