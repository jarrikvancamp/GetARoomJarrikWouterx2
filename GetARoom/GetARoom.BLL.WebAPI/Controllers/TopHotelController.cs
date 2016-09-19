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
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class TopHotelController : ApiController
    {
        public IEnumerable<Hotel> GetAll(int amount)
        {
            var hotels = HotelHelper.GetTopHotels(amount).ToList();

            return hotels;
        }
    }
}
