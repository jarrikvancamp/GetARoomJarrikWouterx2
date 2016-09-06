using GetARoom.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.DAL.SpecificRepositories.Interfaces
{
   public interface IAmenityForHotel : IRepository<AmenityForHotel>
    {
        AmenityForHotel GetAmenityForHotelWithHotel(int id);
        AmenityForHotel GetAmenityForHotelWithAmenity(int id);
        AmenityForHotel GetAmenityForHotelFull(int id);

        IEnumerable<AmenityForHotel> GetAmenityForHotelswithHotel();
        IEnumerable<AmenityForHotel> GetAmenityForHotelsWithAmenity();
        IEnumerable<AmenityForHotel> GetAmenityForHotelsFull();
    }
}
