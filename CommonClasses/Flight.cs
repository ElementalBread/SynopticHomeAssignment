using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses {
    public class Flight {
        public  Flight(int flight_Number, string airline, int duration, string origin_airport_name, string destination_airport_name, string seat_class, float price) {
            Guid g = Guid.NewGuid();
            this.flight_Id = g;
            this.flight_Number = flight_Number;
            this.airline = airline;
            this.duration = duration;
            this.origin_airport_name = origin_airport_name;
            this.destination_airport_name = destination_airport_name;
            this.seat_class = seat_class;
            this.price = price;
        }

        public Guid flight_Id { get; set; }
        public int flight_Number { get; set; }
        public string airline { get; set; }
        public int duration { get; set; }
        public string origin_airport_name { get; set; }
        public string destination_airport_name { get; set; }
        public string seat_class { get; set; }
        public float price { get; set; }

    }
}
