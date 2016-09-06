using GetARoom.DAL;
using GetARoom.DAL.SpecificRepositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.BLL.ObjectHandlers
{
    public class AddressHandler 
    {
        protected IUnitOfWork _db;
        protected const string handlerName = "ADDRESS";
        public AddressHandler(IUnitOfWork db) 
        {
            _db = db;
        }

        public  bool Add(Address address)
        {
            if (!ValidObject(address))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Addresses.Add(address);
            }
            catch
            {
                Console.WriteLine($"Adding failed [{handlerName}]");
                return false;
            }
            return true;
        }
        public  bool ValidObject(Address address)
        {
            //TODO: if statements

            return true;
        }

        public  bool Delete(Address address)
        {

            if (!ValidObject(address))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Addresses.Delete(address);
            }
            catch
            {
                Console.WriteLine($"Removing failed [{handlerName}]");
                return false;
            }
            return true;
        }

        public  IEnumerable<Address> GetAll()
        {
            return _db.Addresses.GetAll();
        }

        public  Address GetById(int id)
        {
            // validation: object

            // validation: db
            RepoValidation.ValidateIdSearch(id);
            return _db.Addresses.GetById(id);
        }

        public  Boolean Update(Address address)
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
