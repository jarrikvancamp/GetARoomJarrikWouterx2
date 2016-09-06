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
    public class PersonController : ApiController
    {

       
        // GET: api/Hotels
        public IEnumerable<Person> GetHotel()
        {
            return _RepositoryHandlerCollection.PersonHandler.GetAll();
        }

        // GET: api/Assets/5

        public IHttpActionResult GetHotel(int id)
        {
            //Asset asset =(Asset) db.Asset.Find(id);
            Person item = _RepositoryHandlerCollection.PersonHandler.GetById(id);
            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }


    }
}
