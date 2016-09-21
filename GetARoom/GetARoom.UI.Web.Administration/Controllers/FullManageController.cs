using GetARoom.BLL.ObjectHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetARoom.UI.Web.Administration.Controllers
{
    public class FullManageController : Controller
    {
        // GET: FullManage
        public ActionResult Index()
        {
            return View(_RepositoryHandlerCollection.HotelHandler.GetAll().ToList());
        }
    }
}