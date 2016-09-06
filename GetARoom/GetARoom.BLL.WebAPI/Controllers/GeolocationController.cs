using GetARoom.BLL.ObjectHandlers;
using GetARoom.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GetARoom.BLL.WebAPI.Controllers
{
    public class GeolocationController : ApiController
    {


      
        // GET: api/Hotels
        public IEnumerable<Geolocation> GetHotel()
        {
            return _RepositoryHandlerCollection.GeolocationHandler.GetAll();
        }

        // GET: api/Assets/5

        public IHttpActionResult GetHotel(int id)
        {
            //Asset asset =(Asset) db.Asset.Find(id);
            Geolocation item = _RepositoryHandlerCollection.GeolocationHandler.GetById(id);
            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

    }
}
