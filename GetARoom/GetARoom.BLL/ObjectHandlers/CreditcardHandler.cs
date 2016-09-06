using GetARoom.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.BLL.ObjectHandlers
{
    public class CreditcardHandler : RepositoryHandler<Creditcard>
    {

        public CreditcardHandler(IRepository<Creditcard> db) : base(db)
        {

        }

        protected const string handlerName = "Creditcard";

        public override bool Add(Creditcard creditcard)
        {
            if (!ValidObject(creditcard))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Add(creditcard);
            }
            catch
            {
                Console.WriteLine($"Adding failed [{handlerName}]");
                return false;
            }
            return true;
        }
        public override bool ValidObject(Creditcard creditcard)
        {
            //TODO: if statements
            return true;
        }

        public override bool Delete(Creditcard creditcard)
        {

            if (!ValidObject(creditcard))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Delete(creditcard);
            }
            catch
            {
                Console.WriteLine($"Removing failed [{handlerName}]");
                return false;
            }
            return true;
        }

        public override IEnumerable<Creditcard> GetAll()
        {
            return _db.GetAll();
        }

        public override Creditcard GetById(int id)
        {
            // validation: object

            // validation: db
            RepoValidation.ValidateIdSearch(id);
            return _db.GetById(id);
        }

        public override Boolean Update(Creditcard creditcard)
        {
            if (!ValidObject(creditcard))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Update(creditcard);
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
