using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Hotels.Entity
{
    public class HotelContact : BaseEntity
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
        public Hotel Hotel { get; set; }
    }
}
