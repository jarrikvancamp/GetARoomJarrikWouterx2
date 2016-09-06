using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.DAL.SpecificRepositories.Interfaces
{
    public interface IHotelRepository : IRepository<Hotel>
    {
        Hotel GetHotelWithLocation(int id);
        IEnumerable<Hotel> GetAllHotelsWithLocation();
    }
}
