using GetARoom.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.BLL.ObjectHandlers
{
    public class UserHandler : RepositoryHandler<User>
    {

        public UserHandler(IRepository<User> db) : base(db)
        {

        }

        protected const string handlerName = "User";

        public override bool Add(User user)
        {
            if (!ValidObject(user))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Add(user);
            }
            catch
            {
                Console.WriteLine($"Adding failed [{handlerName}]");
                return false;
            }
            return true;
        }
        public override bool ValidObject(User user)
        {
            //TODO: if statements
            return true;
        }

        public override bool Delete(User user)
        {

            if (!ValidObject(user))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Delete(user);
            }
            catch
            {
                Console.WriteLine($"Removing failed [{handlerName}]");
                return false;
            }
            return true;
        }

        public override IEnumerable<User> GetAll()
        {
            return _db.GetAll();
        }

        public override User GetById(int id)
        {
            // validation: object

            // validation: db
            RepoValidation.ValidateIdSearch(id);
            return _db.GetById(id);
        }

        public override Boolean Update(User user)
        {
            if (!ValidObject(user))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Update(user);
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
