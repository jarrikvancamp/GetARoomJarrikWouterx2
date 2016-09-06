using GetARoom.DAL.SpecificRepositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace GetARoom.DAL.SpecificRepositories.Repositories
{
    public class PictureForRoomRepository : Repository<PictureForRoom>, IPictureForRoomRepository
    {
        public PictureForRoomRepository(GetARoomEntities db) : base(db)
        {
        }

        public IEnumerable<PictureForRoom> GetAllPicturesForRoomFull()
        {
            return _db.PictureForRoom.Include(x => x.Picture).Include(x => x.Room);
        }

        public IEnumerable<PictureForRoom> GetAllPicturesForRoomWithPicture()
        {
            return _db.PictureForRoom.Include(x => x.Picture);
        }

        public IEnumerable<PictureForRoom> GetAllPicturesForRoomWithRoom()
        {
            return _db.PictureForRoom.Include(x => x.Room);
        }

        public PictureForRoom GetPictureForRoomFull(int id)
        {
            return _db.PictureForRoom.Include(x => x.Picture).Include(x => x.Room).FirstOrDefault(x => x.PictureForRoomId == id);
        }

        public PictureForRoom GetPictureForRoomWithPicture(int id)
        {
            return _db.PictureForRoom.Include(x => x.Picture).FirstOrDefault(x => x.PictureForRoomId == id);
        }

        public PictureForRoom GetPictureForRoomWithRoom(int id)
        {
            return _db.PictureForRoom.Include(x => x.Room).FirstOrDefault(x => x.PictureForRoomId == id);
        }
    }
}
