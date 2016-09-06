using GetARoom.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.BLL.ObjectHandlers
{
    public class RoleHandler : RepositoryHandler<Role>
    {

        public RoleHandler(IRepository<Role> db) : base(db)
        {

        }

        protected const string handlerName = "Role";

        public override bool Add(Role role)
        {
            if (!ValidObject(role))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Add(role);
            }
            catch
            {
                Console.WriteLine($"Adding failed [{handlerName}]");
                return false;
            }
            return true;
        }
        public override bool ValidObject(Role role)
        {
            //TODO: if statements
            return true;
        }

        public override bool Delete(Role role)
        {

            if (!ValidObject(role))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Delete(role);
            }
            catch
            {
                Console.WriteLine($"Removing failed [{handlerName}]");
                return false;
            }
            return true;
        }

        public override IEnumerable<Role> GetAll()
        {
            return _db.GetAll();
        }

        public override Role GetById(int id)
        {
            // validation: object

            // validation: db
            RepoValidation.ValidateIdSearch(id);
            return _db.GetById(id);
        }

        public override Boolean Update(Role role)
        {
            if (!ValidObject(role))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Update(role);
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
