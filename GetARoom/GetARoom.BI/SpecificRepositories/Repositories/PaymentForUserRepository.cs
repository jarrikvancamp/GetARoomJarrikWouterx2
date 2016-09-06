using GetARoom.DAL.SpecificRepositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace GetARoom.DAL.SpecificRepositories.Repositories
{
    public class PaymentForUserRepository : Repository<PaymentTypeForUser>, IPaymentForUserRepository
    {
        public PaymentForUserRepository(GetARoomEntities db) : base(db)
        {
        }

        public IEnumerable<PaymentTypeForUser> GetAllPaymentsFull()
        {
            return _db.PaymentTypeForUser.Include(x => x.Creditcard).Include(x => x.User);
        }

        public IEnumerable<PaymentTypeForUser> GetAllPaymentsWithCreditcard()
        {
            return _db.PaymentTypeForUser.Include(x => x.Creditcard);
        }

        public IEnumerable<PaymentTypeForUser> GetAllPaymentsWithUser()
        {
            return _db.PaymentTypeForUser.Include(x => x.User);
        }

        public PaymentTypeForUser GetPaymentForUserFull(int id)
        {
            return _db.PaymentTypeForUser.Include(x => x.Creditcard).Include(x => x.User).FirstOrDefault(x=>x.PaymentTyperForUserId == id);
        }

        public PaymentTypeForUser GetPaymentForUserWithCreditcard(int id)
        {
            return _db.PaymentTypeForUser.Include(x => x.Creditcard).FirstOrDefault(x => x.PaymentTyperForUserId == id);
        }

        public PaymentTypeForUser GetPaymentForUserWithUser(int id)
        {
            return _db.PaymentTypeForUser.Include(x => x.User).FirstOrDefault(x => x.PaymentTyperForUserId == id);
        }
    }
}
