using GetARoom.DAL;
using GetARoom.DAL.SpecificRepositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.BLL.ObjectHandlers
{
    public class BookingHandler 
    {
        protected IUnitOfWork _db;
        public BookingHandler(IUnitOfWork db)
        {

        }

        protected const string handlerName = "BOOKING";

        public  bool Add(Booking booking)
        {
            if (!ValidObject(booking))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Bookings.Add(booking);
            }
            catch
            {
                Console.WriteLine($"Adding failed [{handlerName}]");
                return false;
            }
            return true;
        }
        public  bool ValidObject(Booking booking)
        {
            //TODO: if statements
            return true;
        }

        public  bool Delete(Booking booking)
        {

            if (!ValidObject(booking))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Bookings.Delete(booking);
            }
            catch
            {
                Console.WriteLine($"Removing failed [{handlerName}]");
                return false;
            }
            return true;
        }

        public  IEnumerable<Booking> GetAll()
        {
            return _db.Bookings.GetAll();
        }

        public  Booking GetById(int id)
        {
            // validation: object

            // validation: db
            RepoValidation.ValidateIdSearch(id);
            return _db.Bookings.GetById(id);
        }

        public  Boolean Update(Booking booking)
        {
            if (!ValidObject(booking))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Bookings.Update(booking);
            }
            catch
            {
                Console.WriteLine($"Update failed [{handlerName}]");
                return false;
            }
            return true;
        }
    }
}
