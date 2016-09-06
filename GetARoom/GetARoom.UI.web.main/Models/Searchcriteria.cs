using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetARoom.UI.web.main.Models
{
    public class Searchcriteria
    {
        public int NrOfKids { get; set; }
        public int NrOfAdults { get; set; }

        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
    }
}