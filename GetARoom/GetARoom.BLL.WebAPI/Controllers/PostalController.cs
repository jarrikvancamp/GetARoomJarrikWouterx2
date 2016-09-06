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
    public class PostalController : ApiController
    {
       
        // GET: api/Hotels
        public IEnumerable<Postal> GetHotel()
        {
            return _RepositoryHandlerCollection.PostalHandler.GetAll();
        }

        // GET: api/Assets/5

        public IHttpActionResult GetHotel(int id)
        {
            //Asset asset =(Asset) db.Asset.Find(id);
            Postal item = _RepositoryHandlerCollection.PostalHandler.GetById(id);
            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }


    }
}
