using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.DAL.SpecificRepositories.Interfaces
{
    public interface IRoomForHotelRepository : IRepository<RoomForHotel>
    {
        IEnumerable<RoomForHotel> GetAllRoomsForHotelFull();
        IEnumerable<RoomForHotel> GetAllRoomsForHotelWithRoom();
        IEnumerable<RoomForHotel> GetAllRoomsForHotelWithHotel();

        RoomForHotel GetRoomForHotelFull(int id);
        RoomForHotel GetRoomForHotelWithRoom(int id);
        RoomForHotel GetRoomForHotelWithHotel(int id);
    }
}
