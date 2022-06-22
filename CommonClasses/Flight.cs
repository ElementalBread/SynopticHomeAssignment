using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses {
    public class Flight {
        public  Flight(string flight_Number, string airline, int duration, string airport_name, string departure_gate, string seat_class, string luggage_options, float price) {
            Guid g = Guid.NewGuid();
            this.flight_Id = g;
            this.flight_Number = flight_Number;
            this.airline = airline;
            this.duration = duration;
            this.airport_name = airport_name;
            this.departure_gate = departure_gate;
            this.seat_class = seat_class;
            this.luggage_options = luggage_options;
            this.price = price;
        }

        public Guid flight_Id { get; set; }
        public string flight_Number { get; set; }
        public string airline { get; set; }
        public int duration { get; set; }
        public string airport_name { get; set; }
        public string departure_gate { get; set; }
        public string seat_class { get; set; }
        public string luggage_options { get; set; }
        public float price { get; set; }

    }
}
