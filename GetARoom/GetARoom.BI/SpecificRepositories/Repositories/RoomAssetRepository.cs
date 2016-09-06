using GetARoom.DAL.SpecificRepositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace GetARoom.DAL.SpecificRepositories.Repositories
{
    public class RoomAssetRepository : Repository<RoomAsset>, IRoomAssetRepository
    {
        public RoomAssetRepository(GetARoomEntities db) : base(db)
        {
        }

        public IEnumerable<RoomAsset> GetAllRoomAssetsFull()
        {
            return _db.RoomAsset.Include(x => x.Asset).Include(x => x.Room);
        }

        public IEnumerable<RoomAsset> GetAllRoomAssetsWithAsset()
        {
            return _db.RoomAsset.Include(x => x.Asset);
        }

        public IEnumerable<RoomAsset> GetAllRoomAssetsWithRoom()
        {
            return _db.RoomAsset.Include(x => x.Room);
        }

        public RoomAsset GetRoomAssetFull(int id)
        {
            return _db.RoomAsset.Include(x => x.Asset).Include(x => x.Room).FirstOrDefault(x=>x.RoomAssetId == id);
        }

        public RoomAsset GetRoomAssetWithAsset(int id)
        {
            return _db.RoomAsset.Include(x => x.Asset).FirstOrDefault(x => x.RoomAssetId == id);
        }

        public RoomAsset GetRoomAssetWithRoom(int id)
        {
            return _db.RoomAsset.Include(x => x.Room).FirstOrDefault(x => x.RoomAssetId == id);
        }
    }
}
