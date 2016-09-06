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
    public class AmenityController : ApiController
    {


       
        public IEnumerable<Amenity> GetHotel()
        {
            return _RepositoryHandlerCollection.AmenityHandler.GetAll();
        }

        // GET: api/Assets/5

        public IHttpActionResult GetHotel(int id)
        {
            //Asset asset =(Asset) db.Asset.Find(id);
            Amenity item = _RepositoryHandlerCollection.AmenityHandler.GetById(id);
            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

    }
}
