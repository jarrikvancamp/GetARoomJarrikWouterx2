using GetARoom.DAL;
using GetARoom.DAL.SpecificRepositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.BLL.ObjectHandlers
{
    public class LocationHandler 
    {
        protected readonly IUnitOfWork _db;
        public LocationHandler( IUnitOfWork db)
        {
            _db = db;
        }

        protected const string handlerName = "Location";

        public  bool Add(Location location)
        {
            if (!ValidObject(location))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Locations.Add(location);
            }
            catch
            {
                Console.WriteLine($"Adding failed [{handlerName}]");
                return false;
            }
            return true;
        }
        public  bool ValidObject(Location location)
        {
            //TODO: if statements
            return true;
        }

        public  bool Delete(Location location)
        {

            if (!ValidObject(location))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Locations.Delete(location);
            }
            catch
            {
                Console.WriteLine($"Removing failed [{handlerName}]");
                return false;
            }
            return true;
        }

        public  IEnumerable<Location> GetAll()
        {
            return _db.Locations.GetAll();
        }

        public  Location GetById(int id)
        {
            // validation: object

            // validation: db
            RepoValidation.ValidateIdSearch(id);
            return _db.Locations.GetById(id);
        }

        public  Boolean Update(Location location)
        {
            if (!ValidObject(location))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Locations.Update(location);
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
