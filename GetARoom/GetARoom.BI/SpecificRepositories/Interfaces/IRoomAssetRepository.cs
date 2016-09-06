using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.DAL.SpecificRepositories.Interfaces
{
    public interface IRoomAssetRepository : IRepository<RoomAsset>
    {
        IEnumerable<RoomAsset> GetAllRoomAssetsFull();
        IEnumerable<RoomAsset> GetAllRoomAssetsWithRoom();
        IEnumerable<RoomAsset> GetAllRoomAssetsWithAsset();

        RoomAsset GetRoomAssetFull(int id);
        RoomAsset GetRoomAssetWithRoom(int id);
        RoomAsset GetRoomAssetWithAsset(int id);
    }
}
