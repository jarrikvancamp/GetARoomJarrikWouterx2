using GetARoom.DAL.SpecificRepositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace GetARoom.DAL.SpecificRepositories.Repositories
{
    public class PictureForHotelRepository : Repository<PictureForHotel>, IPictureForHotelRepository
    {
        public PictureForHotelRepository(GetARoomEntities db) : base(db)
        {
        }

        public IEnumerable<PictureForHotel> GetAllPicturesForHotelFull()
        {
            return _db.PictureForHotel.Include(x => x.Hotel).Include(x => x.Picture);
        }

        public IEnumerable<PictureForHotel> GetAllPicturesForHotelWithPicture()
        {
            return _db.PictureForHotel.Include(x => x.Picture);
        }

        public IEnumerable<PictureForHotel> GetAllPicturesForHotelWithHotel()
        {
            return _db.PictureForHotel.Include(x => x.Hotel);
        }
        
        public PictureForHotel GetPictureForHotelFull(int id)
        {
            return _db.PictureForHotel.Include(x => x.Hotel).Include(x => x.Picture).FirstOrDefault(x => x.PictureForHotelId == id);
        }

        public PictureForHotel GetPictureForHotelWithHotel(int id)
        {
            return _db.PictureForHotel.Include(x => x.Hotel).FirstOrDefault(x => x.PictureForHotelId == id);
        }

        public PictureForHotel GetPictureForHotelWithPicture(int id)
        {
            return _db.PictureForHotel.Include(x => x.Picture).FirstOrDefault(x => x.PictureForHotelId == id);
        }

        public PictureForHotel GetPictureForHotelFullByHotelId(int HotelId)
        {
            return _db.PictureForHotel.Include(x => x.Hotel).Include(x => x.Picture).FirstOrDefault(x => x.HotelId == HotelId);
        }
    }
}
