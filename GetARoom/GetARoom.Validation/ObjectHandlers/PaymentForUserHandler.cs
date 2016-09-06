using GetARoom.DAL;
using GetARoom.DAL.SpecificRepositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.BLL.ObjectHandlers
{
    public class PaymentForUserHandler
    {
        protected IUnitOfWork _db;
        public PaymentForUserHandler(IUnitOfWork db)
        {
            _db = db;
        }

        protected const string handlerName = "Payment";


        public bool Add(PaymentTypeForUser payment)
        {
            if (!ValidObject(payment))
            {
                return false;
            }

            //validation error

            try
            {
                _db.PaymentsForUser.Add(payment);
            }
            catch
            {
                Console.WriteLine($"Adding failed [{handlerName}]");
                return false;
            }
            return true;
        }
        public bool ValidObject(PaymentTypeForUser payment)
        {
            //TODO: if statements
            return true;
        }

        public bool Delete(PaymentTypeForUser payment)
        {

            if (!ValidObject(payment))
            {
                return false;
            }

            //validation error

            try
            {
                _db.PaymentsForUser.Delete(payment);
            }
            catch
            {
                Console.WriteLine($"Removing failed [{handlerName}]");
                return false;
            }
            return true;
        }

        public IEnumerable<PaymentTypeForUser> GetAll()
        {
            return _db.PaymentsForUser.GetAll();
        }

        public PaymentTypeForUser GetById(int id)
        {
            // validation: object

            // validation: db
            RepoValidation.ValidateIdSearch(id);
            return _db.PaymentsForUser.GetById(id);
        }

        public Boolean Update(PaymentTypeForUser payment)
        {
            if (!ValidObject(payment))
            {
                return false;
            }

            //validation error

            try
            {
                _db.PaymentsForUser.Update(payment);
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
