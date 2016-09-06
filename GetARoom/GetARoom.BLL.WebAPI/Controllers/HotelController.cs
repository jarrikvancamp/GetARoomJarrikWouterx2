
using GetARoom.BLL.ObjectHandlers;
using GetARoom.DAL;
using GetARoom.DAL.SpecificRepositories.Interfaces;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

namespace GetARoom.BLL.WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class HotelController : ApiController
    {
       
        public HotelController()
        {
            
        }

        // GET: api/Hotels
        public IEnumerable<Hotel> GetHotel()
        {
            return _RepositoryHandlerCollection.HotelHandler.GetAll();
        }

        // GET: api/Assets/5
        [ResponseType(typeof(Hotel))]
        public IHttpActionResult GetHotel(int id)
        {
            //Asset asset =(Asset) db.Asset.Find(id);
            Hotel asset2 = _RepositoryHandlerCollection.HotelHandler.GetById(id);
            if (asset2 == null)
            {
                return NotFound();
            }

            return Ok(asset2);
        }



    }
}
