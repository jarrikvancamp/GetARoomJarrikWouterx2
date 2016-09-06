using GetARoom.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.BLL.ObjectHandlers
{
    public class PostalHandler : RepositoryHandler<Postal>
    {

        public PostalHandler(IRepository<Postal> db) : base(db)
        {

        }

        protected const string handlerName = "Postal";

        public override bool Add(Postal postal)
        {
            if (!ValidObject(postal))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Add(postal);
            }
            catch
            {
                Console.WriteLine($"Adding failed [{handlerName}]");
                return false;
            }
            return true;
        }
        public override bool ValidObject(Postal postal)
        {
            //TODO: if statements
            return true;
        }

        public override bool Delete(Postal postal)
        {

            if (!ValidObject(postal))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Delete(postal);
            }
            catch
            {
                Console.WriteLine($"Removing failed [{handlerName}]");
                return false;
            }
            return true;
        }

        public override IEnumerable<Postal> GetAll()
        {
            return _db.GetAll();
        }

        public override Postal GetById(int id)
        {
            // validation: object

            // validation: db
            RepoValidation.ValidateIdSearch(id);
            return _db.GetById(id);
        }

        public override Boolean Update(Postal postal)
        {
            if (!ValidObject(postal))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Update(postal);
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
