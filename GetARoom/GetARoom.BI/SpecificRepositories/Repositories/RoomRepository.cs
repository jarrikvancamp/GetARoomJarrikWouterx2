using GetARoom.DAL.SpecificRepositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace GetARoom.DAL.SpecificRepositories.Repositories
{
    public class RoomRepository : Repository<Room>, IRoomRepository
    {
        public RoomRepository(GetARoomEntities db) : base(db)
        {
        }

        public IEnumerable<Room> GetAllForHotel(int hotelId)
        {
            var rfh = _db.RoomForHotel.Where(x => x.HotelId == hotelId);
            var rooms = new List<Room>();
            foreach (var room in rfh)
            {
                rooms.Add(_db.Room.FirstOrDefault(x => x.RoomId == room.RoomId));
            }
            return rooms;
        }

        public IEnumerable<Room> GetAllRoomsWithRoomSize()
        {
            return _db.Room.Include(x => x.RoomSize);
        }

        public Room GetRoomWithRoomSize(int id)
        {
            return _db.Room.Include(x => x.RoomSize).SingleOrDefault(x=>x.RoomId == id);
        }



    }
}
