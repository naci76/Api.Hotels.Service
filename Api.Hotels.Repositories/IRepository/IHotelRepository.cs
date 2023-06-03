using Api.Hotels.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api.Hotels.Repositories.IRepository
{
    public interface IHotelRepository
    {
        void Add(Hotel hotelModel);
        void Delete(Hotel hotelModel);
        void Update(Hotel hotelModel);
        Task<List<Hotel>> GetAll();
        Task<Hotel> Get(int id);
    }
}
