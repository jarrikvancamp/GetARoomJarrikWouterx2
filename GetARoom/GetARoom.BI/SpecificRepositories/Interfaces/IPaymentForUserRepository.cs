using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.DAL.SpecificRepositories.Interfaces
{
   public interface IPaymentForUserRepository : IRepository<PaymentTypeForUser>
    {

        PaymentTypeForUser GetPaymentForUserWithCreditcard(int id);
        PaymentTypeForUser GetPaymentForUserWithUser(int id);
        PaymentTypeForUser GetPaymentForUserFull(int id);

        IEnumerable<PaymentTypeForUser> GetAllPaymentsFull();
        IEnumerable<PaymentTypeForUser> GetAllPaymentsWithCreditcard();
        IEnumerable<PaymentTypeForUser> GetAllPaymentsWithUser();

    }
}
