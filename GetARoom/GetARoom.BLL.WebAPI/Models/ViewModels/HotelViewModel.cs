using GetARoom.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetARoom.BLL.WebAPI.Models.ViewModels
{
    public class HotelViewModel
    {
        public string Name { get; set; }
        public double Rating { get; set; }
        public string Description { get; set; }
        public string PicturePath  { get; set; }
        public Location Location { get; set; }
        public List<Amenity> Amenities { get; set; } = new List<Amenity>();
        public string Phonenumber { get; set; }


    }
}