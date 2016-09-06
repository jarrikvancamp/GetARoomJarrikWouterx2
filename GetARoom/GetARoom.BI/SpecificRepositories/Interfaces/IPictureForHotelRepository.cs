using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.DAL.SpecificRepositories.Interfaces
{
    public interface IPictureForHotelRepository : IRepository<PictureForHotel>
    {
        IEnumerable<PictureForHotel> GetAllPicturesForHotelFull();
        IEnumerable<PictureForHotel> GetAllPicturesForHotelWithHotel();
        IEnumerable<PictureForHotel> GetAllPicturesForHotelWithPicture();

        PictureForHotel GetPictureForHotelFull(int id);
        PictureForHotel GetPictureForHotelWithPicture(int id);
        PictureForHotel GetPictureForHotelWithHotel(int id);

        PictureForHotel GetPictureForHotelFullByHotelId(int HotelId);

    }
}
