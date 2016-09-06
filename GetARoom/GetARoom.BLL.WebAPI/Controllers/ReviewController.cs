using GetARoom.BLL.ObjectHandlers;
using GetARoom.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace GetARoom.BLL.WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ReviewController : ApiController
    {

  
        public IEnumerable<Review> GetHotel()
        {
            return _RepositoryHandlerCollection.ReviewHandler.GetAll();
        }

        // GET: api/Assets/5

        public IHttpActionResult GetHotel(int id)
        {
            //Asset asset =(Asset) db.Asset.Find(id);
            Review item = _RepositoryHandlerCollection.ReviewHandler.GetById(id);
            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

    }
}
