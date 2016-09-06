
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using GetARoom.DAL.SpecificRepositories.Interfaces;

namespace GetARoom.DAL.SpecificRepositories.Repositories
{
    public class HotelRepository : Repository<Hotel>, IHotelRepository
    {
        public HotelRepository(GetARoomEntities db) : base(db)
        {
            
        }

        public IEnumerable<Hotel> GetAllHotelsWithLocation()
        {
            return _db.Hotel.Include(x => x.Location);
        }

        public Hotel GetHotelWithLocation(int id)
        {
            return _db.Hotel.Include(x => x.Location)
                .FirstOrDefault<Hotel>(c => c.HotelId == id);

        }

       
       
    }
}
