using GetARoom.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetARoom.BLL.WebAPI.Models.ViewModels
{
    public class RoomListViewModel
    {

        public Picture Picture { get; set; }
        public string Name { get; set; }
        public string Description    { get; set; }
        public double Price { get; set; }
        public double Rating { get; set; }
        List<Asset> Assets { get; set; } = new List<Asset>();


    }
}