using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses {
    public class CarRental {
        public CarRental(string make, string model, string car_type, int passengers, float price) {
            this.car_rental_id = new Guid();
            this.make = make;
            this.model = model;
            this.car_type = car_type;
            this.passengers = passengers;
            this.price = price;
        }

        public Guid car_rental_id { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public string car_type { get; set; }
        public int passengers { get; set; }
        public float price { get; set; }
    }
}
