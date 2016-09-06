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
    public class PictureController : ApiController
    {

        
        public IEnumerable<Picture> GetHotel()
        {
            return _RepositoryHandlerCollection.PictureHandler.GetAll();
        }

        // GET: api/Assets/5

        public IHttpActionResult GetHotel(int id)
        {
            //Asset asset =(Asset) db.Asset.Find(id);
            Picture item = _RepositoryHandlerCollection.PictureHandler.GetById(id);
            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

    }
}
