using Api.Hotels.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api.Hotels.Repositories.IRepository
{
    public interface IHotelRepository
    {
        void Add(Hotel model);
        void Delete(Hotel model);
        void Update(Hotel model);
        Task<List<Hotel>> GetAll();
        Task<Hotel> Get(int id);
        void AddHotelContact(HotelContact model);
        void DeleteHotelContact(HotelContact model);
        void UpdateHotelContact(HotelContact model);
        Task<List<HotelContact>> GetAllHotelContact(int hotelId);
        Task<HotelContact> GetHotelContact(int id);
        Task<int> GetHotelCountByLocation(string lat,string lon);
        Task<int> GetPhoneCountByLocation(string lat, string lon);
    }
}
