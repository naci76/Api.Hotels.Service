using Api.Hotels.Entity;
using Api.Hotels.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api.Hotels.Repositories.Repository
{
    public class Factory : IFactory
    {
        HotelDbContext db;
        public Factory(HotelDbContext _db)
        {
            db = _db;
        }
        public async Task  SaveChange()
        {
            await db.SaveChangesAsync();
        }
    }
}
