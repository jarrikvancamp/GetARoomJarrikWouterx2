using GetARoom.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.BLL.ObjectHandlers
{
    public class AmenityHandler : RepositoryHandler<Amenity>
    {
        
        protected const string handlerName = "AMENITY";
        public AmenityHandler(IRepository<Amenity> db) : base(db)
        {

        }

        public override bool Add(Amenity amenity)
        {
            if (!ValidObject(amenity))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Add(amenity);
            }
            catch
            {
                Console.WriteLine($"Adding failed [{handlerName}]");
                return false;
            }
            return true;
        }
        
        public override bool ValidObject(Amenity amenity)
        {
            //TODO: if statements

            return true;
        }

        public override bool Delete(Amenity amenity)
        {

            if (!ValidObject(amenity))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Delete(amenity);
            }
            catch
            {
                Console.WriteLine($"Removing failed [{handlerName}]");
                return false;
            }
            return true;
        }

        public override IEnumerable<Amenity> GetAll()
        {
            return _db.GetAll();
        }

        public override Amenity GetById(int id)
        {
            // validation: object

            // validation: db
            RepoValidation.ValidateIdSearch(id);
            return _db.GetById(id);
        }

        public override Boolean Update(Amenity amenity)
        {
            if (!ValidObject(amenity))
            {
                return false;
            }

            //validation error

            try
            {
                //_db.Update(amenity);
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
