using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.DAL.SpecificRepositories.Interfaces
{
    public interface IRoomRepository : IRepository<Room>
    {
        IEnumerable<Room> GetAllRoomsWithRoomSize();
        Room GetRoomWithRoomSize(int id);
        IEnumerable<Room> GetAllForHotel(int hotelId);
    }
}
