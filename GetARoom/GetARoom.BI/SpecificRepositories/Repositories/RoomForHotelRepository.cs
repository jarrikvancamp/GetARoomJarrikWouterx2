using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using GetARoom.DAL.SpecificRepositories.Interfaces;

namespace GetARoom.DAL.SpecificRepositories.Repositories
{
    public class RoomForHotelRepository : Repository<RoomForHotel>, IRoomForHotelRepository
    {
        public RoomForHotelRepository(GetARoomEntities db) : base(db)
        {
        }

        public IEnumerable<RoomForHotel> GetAllRoomsForHotelFull()
        {
            return _db.RoomForHotel.Include(x => x.Hotel).Include(x => x.Room);
        }

        public IEnumerable<RoomForHotel> GetAllRoomsForHotelWithHotel()
        {
            return _db.RoomForHotel.Include(x => x.Hotel);
        }

        public IEnumerable<RoomForHotel> GetAllRoomsForHotelWithRoom()
        {
            return _db.RoomForHotel.Include(x => x.Room);
        }

        public RoomForHotel GetRoomForHotelFull(int id)
        {
            return _db.RoomForHotel.Include(x => x.Hotel).Include(x => x.Room).SingleOrDefault(x=>x.RoomForHotelId == id);
        }

        public RoomForHotel GetRoomForHotelWithHotel(int id)
        {
            return _db.RoomForHotel.Include(x => x.Hotel).SingleOrDefault(x => x.RoomForHotelId == id);
        }

        public RoomForHotel GetRoomForHotelWithRoom(int id)
        {
            return _db.RoomForHotel.Include(x => x.Room).SingleOrDefault(x => x.RoomForHotelId == id);
        }
    }
}
