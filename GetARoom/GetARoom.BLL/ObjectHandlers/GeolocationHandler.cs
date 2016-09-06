using GetARoom.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.BLL.ObjectHandlers
{
    public class GeolocationHandler : RepositoryHandler<Geolocation>
    {

        public GeolocationHandler(IRepository<Geolocation> db) : base(db)
        {

        }

        protected const string handlerName = "Geolocation";

        public override bool Add(Geolocation geolocation)
        {
            if (!ValidObject(geolocation))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Add(geolocation);
            }
            catch
            {
                Console.WriteLine($"Adding failed [{handlerName}]");
                return false;
            }
            return true;
        }
        public override bool ValidObject(Geolocation geolocation)
        {
            //TODO: if statements
            return true;
        }

        public override bool Delete(Geolocation geolocation)
        {

            if (!ValidObject(geolocation))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Delete(geolocation);
            }
            catch
            {
                Console.WriteLine($"Removing failed [{handlerName}]");
                return false;
            }
            return true;
        }

        public override IEnumerable<Geolocation> GetAll()
        {
            return _db.GetAll();
        }

        public override Geolocation GetById(int id)
        {
            // validation: object

            // validation: db
            RepoValidation.ValidateIdSearch(id);
            return _db.GetById(id);
        }

        public override Boolean Update(Geolocation geolocation)
        {
            if (!ValidObject(geolocation))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Update(geolocation);
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
