using GetARoom.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.BLL.ObjectHandlers
{
    public class AddressHandler : RepositoryHandler<Address>
    {
      
        protected const string handlerName = "ADDRESS";
        public AddressHandler(IRepository<Address> db) : base(db)
        {

        }

        public override bool Add(Address address)
        {
            if (!ValidObject(address))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Add(address);
            }
            catch
            {
                Console.WriteLine($"Adding failed [{handlerName}]");
                return false;
            }
            return true;
        }
        public override bool ValidObject(Address address)
        {
            //TODO: if statements

            return true;
        }

        public override bool Delete(Address address)
        {

            if (!ValidObject(address))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Delete(address);
            }
            catch
            {
                Console.WriteLine($"Removing failed [{handlerName}]");
                return false;
            }
            return true;
        }

        public override IEnumerable<Address> GetAll()
        {
            return _db.GetAll();
        }

        public override Address GetById(int id)
        {
            // validation: object

            // validation: db
            RepoValidation.ValidateIdSearch(id);
            return _db.GetById(id);
        }

        public override Boolean Update(Address address)
        {
            if (!ValidObject(address))
            {
                return false;
            }

            //validation error

            try
            {
               // _db.Update(address);
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
