using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses {
    public class Accommodation {
        public Accommodation(string accommodation_Name, string address, int star_rating, string contact_info, string review, string room_type, int num_of_people, float rate, float total_accomodation_price) {
            this.accommodation_Id = new Guid();
            this.accommodation_Name = accommodation_Name;
            this.address = address;
            this.star_rating = star_rating;
            this.contact_info = contact_info;
            this.review = review;
            this.room_type = room_type;
            this.num_of_people = num_of_people;
            this.rate = rate;
            this.total_accomodation_price = total_accomodation_price;
        }

        public Guid accommodation_Id { get; set; }
        public string accommodation_Name { get; set; }
        public string address { get; set; }
        public int star_rating { get; set; }
        public string contact_info { get; set; }
        public string review { get; set; }
        public string room_type { get; set; }
        public int num_of_people { get; set; }
        public float rate { get; set; }

        public float total_accomodation_price   { get; set; }   
    }
}
