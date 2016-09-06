using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.DAL.SpecificRepositories.Interfaces
{
    public interface ILocationRepository : IRepository<Location>
    {
        IEnumerable<Location> GetLocationsWithAddress();
        IEnumerable<Location> GetLocationsWithGeolocation();
        IEnumerable<Location> GetLocationsFull();

        Location GetLocationWithAddress(int id);
        Location GetLocationWithGeolocation(int id);
        Location GetLocationFull(int id);


    }
}
