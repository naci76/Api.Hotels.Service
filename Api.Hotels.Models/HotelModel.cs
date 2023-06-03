using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Hotels.Models
{
    public class HotelModel : BaseModel
    {
        public string Name { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public List<HotelContactModel> HotelContacts { get; set; }
    }
}
