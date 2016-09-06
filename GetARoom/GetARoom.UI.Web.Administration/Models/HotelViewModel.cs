using GetARoom.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetARoom.UI.Web.Administration.Models
{
    public class HotelViewModel
    {
        public Hotel Hotel { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Picture> Pictures { get; set; }
        

    }
}