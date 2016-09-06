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
    public class BookingController : ApiController
    {

        
        public IEnumerable<Booking> GetBookings()
        {
            return _RepositoryHandlerCollection.BookingHandler.GetAll();
        }

        // GET: api/Assets/5

        public IHttpActionResult GetBooking(int id)
        {
            //Asset asset =(Asset) db.Asset.Find(id);
            Booking item = _RepositoryHandlerCollection.BookingHandler.GetById(id);
            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        //TODO: write post methods

    }
}
