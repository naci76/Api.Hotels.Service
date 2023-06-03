using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Hotels.Models
{
    public class HotelContactModel:BaseModel
    {
        /// <summary>
        /// Yetkili Adı
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Yetkili Soyadı
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Ünvan
        /// </summary>
        public string Title { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int HotelId { get; set; }
        public HotelModel Hotel { get; set; }
    }
}
