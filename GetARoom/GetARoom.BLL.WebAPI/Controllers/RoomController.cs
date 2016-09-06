using GetARoom.BLL.ObjectHandlers;
using GetARoom.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace GetARoom.BLL.WebAPI.Controllers
{
    public class RoomController : ApiController
    {
       
        // GET: api/Hotels
        public IEnumerable<Room> GetHotel()
        {
            return _RepositoryHandlerCollection.RoomHandler.GetAll();
        }

        // GET: api/Assets/5
        [ResponseType(typeof(Room))]
        public IHttpActionResult GetHotel(int id)
        {
            //Asset asset =(Asset) db.Asset.Find(id);
            Room item = _RepositoryHandlerCollection.RoomHandler.GetById(id);
            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }
    }
}
