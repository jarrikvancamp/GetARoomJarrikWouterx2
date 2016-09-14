using GetARoom.BLL.WebAPI.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GetARoom.BLL.WebAPI.Controllers
{
    public class HotelViewController : ApiController
    {
        
        public IHttpActionResult GetHotels()
        {
            var hotels = HotelHelper.GetAllHotels();
            return Ok(hotels);
        }
        public IHttpActionResult GetHotel(int id)
        {
            var hotel = HotelHelper.GetHotelViewModel(id);
            return Ok(hotel);
        }

    }
}
