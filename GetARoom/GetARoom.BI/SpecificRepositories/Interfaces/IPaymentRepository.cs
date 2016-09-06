using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.DAL.SpecificRepositories.Interfaces
{
    public interface IPaymentRepository : IRepository<Payment>
    {
        Payment GetPaymentWithBooking(int id);
        IEnumerable<Payment> GetPaymentsWithBooking();

    }
}
