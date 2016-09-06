using GetARoom.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.BLL.ObjectHandlers
{
    public class BookingHandler : RepositoryHandler<Booking>
    {
       
        public BookingHandler(IRepository<Booking> db) : base(db)
        {

        }

        protected const string handlerName = "BOOKING";

        public override bool Add(Booking booking)
        {
            if (!ValidObject(booking))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Add(booking);
            }
            catch
            {
                Console.WriteLine($"Adding failed [{handlerName}]");
                return false;
            }
            return true;
        }
        public override bool ValidObject(Booking booking)
        {
            //TODO: if statements
            return true;
        }

        public override bool Delete(Booking booking)
        {

            if (!ValidObject(booking))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Delete(booking);
            }
            catch
            {
                Console.WriteLine($"Removing failed [{handlerName}]");
                return false;
            }
            return true;
        }

        public override IEnumerable<Booking> GetAll()
        {
            return _db.GetAll();
        }

        public override Booking GetById(int id)
        {
            // validation: object

            // validation: db
            RepoValidation.ValidateIdSearch(id);
            return _db.GetById(id);
        }

        public override Boolean Update(Booking booking)
        {
            if (!ValidObject(booking))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Update(booking);
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
