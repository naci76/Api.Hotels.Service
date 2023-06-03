using Api.Hotels.Entity;
using Api.Hotels.Repositories.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Hotels.Repositories.Repository
{
    public class HotelRepository : IHotelRepository
    {
        HotelDbContext db;
        public HotelRepository(HotelDbContext _db)
        {
            db = _db;
        }

        public void Add(Hotel hotelModel)
        {
            db.Hotels.Add(hotelModel);
        }

        public void Delete(Hotel hotelModel)
        {
            db.Hotels.Remove(hotelModel);
        }

        public void Update(Hotel hotelModel)
        {
            db.Hotels.Update(hotelModel);
        }
        public async Task<List<Hotel>> GetAll()
        {
            return await db.Hotels.ToListAsync();
        }

        public async Task<Hotel> Get(int id)
        {
            return await db.Hotels.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}
