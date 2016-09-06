using GetARoom.BLL.ObjectHandlers;
using GetARoom.DAL;
using GetARoom.UI.web.main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetARoom.UI.web.main.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(Searchcriteria result)
        {
            //result.ArrivalDate; 
            //    result.DepartureDate



            //FoundHotels hotels = new FoundHotels<>
            //return View("Searchresults", hotels);
            return View();
        }

        public ActionResult Book()
        {
            return View();
        }

        public ActionResult ViewHotel(String id)
        {
            int HotelId;
            bool IsNumber = int.TryParse(id, out HotelId);
            if (id !=null && IsNumber) { 

            Hotel hotel = _RepositoryHandlerCollection.HotelHandler.GetById(HotelId);

            return View(hotel);
            }
            else
            {
                return NotFound();
            }
        }

        public ViewResult NotFound()
        {
            Response.StatusCode = 404;  //you may want to set this to 200
            return View("NotFound");
        }

    }
}