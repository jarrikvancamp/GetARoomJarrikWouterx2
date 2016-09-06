using GetARoom.DAL;
using GetARoom.DAL.SpecificRepositories.Interfaces;
using GetARoom.DAL.SpecificRepositories.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GetARoom.BLL.ObjectHandlers
{
    public class HotelHandler
    {
        protected readonly IUnitOfWork _db;
        public HotelHandler(IUnitOfWork db)
        {
            _db = db;
        }

        protected const string handlerName = "HOTEL";

        public bool Add(Hotel hotel)
        {
            if (!ValidObject(hotel))
            {
                return false;
            }

            //validation error

            try
            {
                
                    }
            catch
            {
                Console.WriteLine($"Adding failed [{handlerName}]");
                return false;
            }
            return true;
        }
        public bool ValidObject(Hotel hotel)
        {
            if (hotel.HotelName == null || hotel.HotelName == "") return false;
            if (hotel.Location == null) return false;
            if (hotel.Phonenumber == null) return false;

            return true;
        }

        public bool Delete(Hotel hotel)
        {

            if (!ValidObject(hotel))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Hotels.Delete(hotel);
            }
            catch
            {
                Console.WriteLine($"Removing failed [{handlerName}]");
                return false;
            }
            return true;
        }

        public IEnumerable<Hotel> GetAll()
        {
            return _db.Hotels.GetAll();
        }

        public Hotel GetById(int id)
        {
            // validation: object

            // validation: db
            RepoValidation.ValidateIdSearch(id);
            return _db.Hotels.GetById(id);
        }

        public Boolean Update(Hotel hotel)
        {
            if (!ValidObject(hotel))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Hotels.Update(hotel);
            }
            catch
            {
                Console.WriteLine($"Update failed [{handlerName}]");
                return false;
            }
            return true;
        }

        public IEnumerable<Room> BookedRooms(DateTime From, DateTime Until)
        {

            IEnumerable<Room> BookedRooms = new List<Room>();
            var Bookings = _RepositoryHandlerCollection.BookingHandler.GetAll().ToList();
            var BookingBetween = Bookings.Where<Booking>(b => From >= b.BookingDateFrom && Until < b.BookingDateTo).ToList();
            BookedRooms = from B in BookingBetween select (B.Room);
            // BookedRooms.Distinct();

            return BookedRooms;
        }

        public List<Room> UnbookedRooms(DateTime From, DateTime Until)
        {
            var Bookings = _RepositoryHandlerCollection.BookingHandler.GetAll().ToList();
            var BookingBetween = Bookings.Where<Booking>(b => From >= b.BookingDateFrom && Until < b.BookingDateTo).ToList();
            var BookedRooms = from B in BookingBetween select B.Room;



            List<Room> FreeRooms = new List<Room>();

            //Alle kamer types afgaan 
            //checken of een kamer in een booking staat voor bepaalde datums
            //tellen hoevaak die kamer geboekt is
            // if(Roomforhotels.Free<room> > aantal keer geboekt )  
            // dat type kamer toevoegen aan free rooms 


            // FreeRooms.Add(AvailableRoom)


            return FreeRooms;
        }

        public Hotel GetHotelWithLocation(int id)
        {
            return _db.Hotels.GetHotelWithLocation(id);
        }


    }
}
