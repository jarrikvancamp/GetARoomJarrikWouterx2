using GetARoom.DAL.SpecificRepositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace GetARoom.DAL.SpecificRepositories.Repositories
{
    public class LocationRepository : Repository<Location>,ILocationRepository
    {
        public LocationRepository(GetARoomEntities db):base(db)
        {

        }

        public Location GetLocationFull(int id)
        {
            return _db.Location.Include(c => c.Address).Include(c => c.Geolocation).FirstOrDefault(c => c.LocationId == id);
        }

        public IEnumerable<Location> GetLocationsFull()
        {
            return _db.Location.Include(c => c.Address).Include(c => c.Geolocation);
        }

        public IEnumerable<Location> GetLocationsWithAddress()
        {
            return _db.Location.Include(c => c.Address);
        }

        public IEnumerable<Location> GetLocationsWithGeolocation()
        {
            return _db.Location.Include(c => c.Geolocation);
        }

        public Location GetLocationWithAddress(int id)
        {
            return _db.Location.Include(c => c.Address).FirstOrDefault(c => c.LocationId == id);
        }

        public Location GetLocationWithGeolocation(int id)
        {
            return _db.Location.Include(c => c.Geolocation).FirstOrDefault(c => c.LocationId == id);
        }
    }
}
