using GetARoom.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.BLL.ObjectHandlers
{
    public class AccountHandler : RepositoryHandler<Account>
    {

        protected const string handlerName = "ACCOUNT";
        public AccountHandler(IRepository<Account> db) : base(db)
        {

        }



        public override bool Add(Account account)
        {
            if (!ValidObject(account))
            {
                return false;
            }
            //validation error
            try
            {
                _db.Add(account);
            }
            catch
            {
                Console.WriteLine($"Adding failed [{handlerName}]");
                return false;

            }

            return true;
        }
        public override bool ValidObject(Account account)
        {
            //TODO: if statements

            return true;
        }

        public override bool Delete(Account account)
        {

            if (!ValidObject(account))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Delete(account);
            }
            catch
            {
                Console.WriteLine($"Removing failed [{handlerName}]");
                return false;
            }
            return true;
        }

        public override IEnumerable<Account> GetAll()
        {
            return _db.GetAll();
        }

        public override Account GetById(int id)
        {
            // validation: object

            // validation: db
            RepoValidation.ValidateIdSearch(id);
            return _db.GetById(id);
        }

        public override Boolean Update(Account account)
        {
            if (!ValidObject(account))
            {
                return false;
            }

            //validation error

            try
            {
                //_db.Update(account);
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
