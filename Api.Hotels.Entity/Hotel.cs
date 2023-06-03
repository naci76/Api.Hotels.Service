using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Hotels.Entity
{
    public class Hotel : BaseEntity
    {
        public Hotel() {
            HotelContacts = new HashSet<HotelContact>();
        }
        public string Name { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public ICollection<HotelContact> HotelContacts { get; set; }
    }
}
