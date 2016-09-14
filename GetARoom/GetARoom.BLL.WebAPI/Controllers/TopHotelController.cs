using GetARoom.BLL.WebAPI.Models.Helpers;
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
    public class TopHotelController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public IEnumerable<Hotel> GetAll(int Id)
        {
            var hotels = HotelHelper.GetTopHotels(Id);
            return hotels;
        }
    }
}
