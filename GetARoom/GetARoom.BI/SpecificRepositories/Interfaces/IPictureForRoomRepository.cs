using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.DAL.SpecificRepositories.Interfaces
{
    public interface IPictureForRoomRepository : IRepository<PictureForRoom>
    {
        IEnumerable<PictureForRoom> GetAllPicturesForRoomFull();
        IEnumerable<PictureForRoom> GetAllPicturesForRoomWithRoom();
        IEnumerable<PictureForRoom> GetAllPicturesForRoomWithPicture();

        PictureForRoom GetPictureForRoomFull(int id);
        PictureForRoom GetPictureForRoomWithPicture(int id);
        PictureForRoom GetPictureForRoomWithRoom(int id);
    }
}
