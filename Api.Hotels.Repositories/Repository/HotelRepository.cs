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

        public void Add(Hotel model)
        {
            db.Hotels.Add(model);
        }

        public void Delete(Hotel model)
        {
            var entity = db.Entry(model);
            entity.State = EntityState.Deleted;
        }

        public void Update(Hotel model)
        {
           var entity= db.Entry(model);
            entity.State = EntityState.Modified;
        }
        public async Task<List<Hotel>> GetAll()
        {
            return await db.Hotels.Include(x=>x.HotelContacts).ToListAsync();
        }

        public async Task<Hotel> Get(int id)
        {
            return await db.Hotels.Where(x => x.Id == id).Include(x=>x.HotelContacts).FirstOrDefaultAsync();
        }

        public void AddHotelContact(HotelContact model)
        {
            db.hotelContacts.Add(model);
        }

        public void DeleteHotelContact(HotelContact model)
        {
            var entity = db.Entry(model);
            entity.State = EntityState.Deleted;
        }

        public void UpdateHotelContact(HotelContact model)
        {
            var entity = db.Entry(model);
            entity.State = EntityState.Modified;
        }

        public async Task<List<HotelContact>> GetAllHotelContact(int hotelId)
        {
            return await db.hotelContacts.Where(x=>x.Hotel.Id==hotelId).ToListAsync();
        }

        public async Task<HotelContact> GetHotelContact(int id)
        {
          return  await db.hotelContacts.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}
