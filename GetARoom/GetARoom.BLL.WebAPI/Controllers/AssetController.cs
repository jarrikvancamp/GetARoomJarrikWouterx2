using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using GetARoom.DAL;
using GetARoom.BLL.ObjectHandlers;

namespace GetARoom.BLL.WebAPI.Controllers
{
    
    public class AssetController : ApiController
    {
       


        // GET: api/Assets
        public IEnumerable<Asset> GetAsset()
        {
            return _RepositoryHandlerCollection.AssetHandler.GetAll();
        }

        // GET: api/Assets/5
        [ResponseType(typeof(Asset))]
        public IHttpActionResult GetAsset(int id)
        {
            //Asset asset =(Asset) db.Asset.Find(id);
            Asset asset2 = _RepositoryHandlerCollection.AssetHandler.GetById(id);
            if (asset2 == null)
            {
                return NotFound();
            }

            return Ok(asset2);
        }


    }
}