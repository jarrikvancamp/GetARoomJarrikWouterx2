using GetARoom.DAL;
using GetARoom.DAL.SpecificRepositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.BLL.ObjectHandlers
{
    public class PaymentHandler
    {
        protected IUnitOfWork _db;
        public PaymentHandler(IUnitOfWork db) 
        {
            _db = db;
        }

        protected const string handlerName = "Payment";
       

        public  bool Add(Payment payment)
        {
            if (!ValidObject(payment))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Payments.Add(payment);
            }
            catch
            {
                Console.WriteLine($"Adding failed [{handlerName}]");
                return false;
            }
            return true;
        }
        public  bool ValidObject(Payment payment)
        {
            //TODO: if statements
            return true;
        }

        public  bool Delete(Payment payment)
        {

            if (!ValidObject(payment))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Payments.Delete(payment);
            }
            catch
            {
                Console.WriteLine($"Removing failed [{handlerName}]");
                return false;
            }
            return true;
        }

        public  IEnumerable<Payment> GetAll()
        {
            return _db.Payments.GetAll();
        }

        public  Payment GetById(int id)
        {
            // validation: object

            // validation: db
            RepoValidation.ValidateIdSearch(id);
            return _db.Payments.GetById(id);
        }

        public  Boolean Update(Payment payment)
        {
            if (!ValidObject(payment))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Payments.Update(payment);
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
