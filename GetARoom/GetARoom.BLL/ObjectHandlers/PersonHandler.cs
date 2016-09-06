using GetARoom.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.BLL.ObjectHandlers
{
    public class PersonHandler : RepositoryHandler<Person>
    {

        public PersonHandler(IRepository<Person> db) : base(db)
        {

        }

        protected const string handlerName = "Person";

        public override bool Add(Person person)
        {
            if (!ValidObject(person))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Add(person);
            }
            catch
            {
                Console.WriteLine($"Adding failed [{handlerName}]");
                return false;
            }
            return true;
        }
        public override bool ValidObject(Person person)
        {
            //TODO: if statements
            return true;
        }

        public override bool Delete(Person person)
        {

            if (!ValidObject(person))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Delete(person);
            }
            catch
            {
                Console.WriteLine($"Removing failed [{handlerName}]");
                return false;
            }
            return true;
        }

        public override IEnumerable<Person> GetAll()
        {
            return _db.GetAll();
        }

        public override Person GetById(int id)
        {
            // validation: object

            // validation: db
            RepoValidation.ValidateIdSearch(id);
            return _db.GetById(id);
        }

        public override Boolean Update(Person person)
        {
            if (!ValidObject(person))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Update(person);
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
