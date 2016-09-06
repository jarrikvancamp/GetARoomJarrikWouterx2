using GetARoom.DAL.SpecificRepositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace GetARoom.DAL.SpecificRepositories.Repositories
{
    public class AmenityForHotelRepository : Repository<AmenityForHotel>, IAmenityForHotel
    {
        public AmenityForHotelRepository(GetARoomEntities db) : base(db)
        {
        }

        public AmenityForHotel GetAmenityForHotelFull(int id)
        {
            return _db.AmenityForHotel.Include(x => x.Amenity).Include(x => x.Hotel).FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<AmenityForHotel> GetAmenityForHotelsFull()
        {
            return _db.AmenityForHotel.Include(x => x.Amenity).Include(x => x.Hotel);
        }

        public IEnumerable<AmenityForHotel> GetAmenityForHotelsWithAmenity()
        {
            return _db.AmenityForHotel.Include(x => x.Amenity);
        }

        public IEnumerable<AmenityForHotel> GetAmenityForHotelswithHotel()
        {
            return _db.AmenityForHotel.Include(x => x.Hotel);
        }

        public AmenityForHotel GetAmenityForHotelWithAmenity(int id)
        {
            return _db.AmenityForHotel.Include(x => x.Amenity).FirstOrDefault(x => x.Id == id);
        }

        public AmenityForHotel GetAmenityForHotelWithHotel(int id)
        {
            return _db.AmenityForHotel.Include(x => x.Hotel).FirstOrDefault(x => x.Id == id);
        }
    }
}
