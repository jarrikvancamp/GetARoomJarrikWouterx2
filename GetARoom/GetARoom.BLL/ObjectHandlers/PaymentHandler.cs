using GetARoom.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.BLL.ObjectHandlers
{
    public class PaymentHandler : RepositoryHandler<Payment>
    {

        public PaymentHandler(IRepository<Payment> db) : base(db)
        {

        }

        protected const string handlerName = "Payment";

        public override bool Add(Payment payment)
        {
            if (!ValidObject(payment))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Add(payment);
            }
            catch
            {
                Console.WriteLine($"Adding failed [{handlerName}]");
                return false;
            }
            return true;
        }
        public override bool ValidObject(Payment payment)
        {
            //TODO: if statements
            return true;
        }

        public override bool Delete(Payment payment)
        {

            if (!ValidObject(payment))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Delete(payment);
            }
            catch
            {
                Console.WriteLine($"Removing failed [{handlerName}]");
                return false;
            }
            return true;
        }

        public override IEnumerable<Payment> GetAll()
        {
            return _db.GetAll();
        }

        public override Payment GetById(int id)
        {
            // validation: object

            // validation: db
            RepoValidation.ValidateIdSearch(id);
            return _db.GetById(id);
        }

        public override Boolean Update(Payment payment)
        {
            if (!ValidObject(payment))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Update(payment);
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
