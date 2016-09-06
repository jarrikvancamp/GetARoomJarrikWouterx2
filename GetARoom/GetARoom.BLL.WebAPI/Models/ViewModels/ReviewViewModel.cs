using GetARoom.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetARoom.BLL.WebAPI.Models.ViewModels
{
    public class ReviewViewModel
    {

        public DateTime CurrentDate { get; set; }
        public Double Rating { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public Picture Picture { get; set; }
        public User User { get; set; }

    }
}