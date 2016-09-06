using GetARoom.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.BLL.ObjectHandlers
{
    public class LocationHandler : RepositoryHandler<Location>
    {

        public LocationHandler(IRepository<Location> db) : base(db)
        {

        }

        protected const string handlerName = "Location";

        public override bool Add(Location location)
        {
            if (!ValidObject(location))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Add(location);
            }
            catch
            {
                Console.WriteLine($"Adding failed [{handlerName}]");
                return false;
            }
            return true;
        }
        public override bool ValidObject(Location location)
        {
            //TODO: if statements
            return true;
        }

        public override bool Delete(Location location)
        {

            if (!ValidObject(location))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Delete(location);
            }
            catch
            {
                Console.WriteLine($"Removing failed [{handlerName}]");
                return false;
            }
            return true;
        }

        public override IEnumerable<Location> GetAll()
        {
            return _db.GetAll();
        }

        public override Location GetById(int id)
        {
            // validation: object

            // validation: db
            RepoValidation.ValidateIdSearch(id);
            return _db.GetById(id);
        }

        public override Boolean Update(Location location)
        {
            if (!ValidObject(location))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Update(location);
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
