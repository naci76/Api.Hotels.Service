using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Hotels.Entity
{
    public class Hotel : BaseEntity
    {
        public string Name { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public List<HotelContact> hotelContacts { get; set; }
    }
}
