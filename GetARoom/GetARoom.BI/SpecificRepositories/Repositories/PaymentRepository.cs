using GetARoom.DAL.SpecificRepositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace GetARoom.DAL.SpecificRepositories.Repositories
{
    public class PaymentRepository : Repository<Payment>, IPaymentRepository
    {
        public PaymentRepository(GetARoomEntities db) : base(db)
        {
        }

        public IEnumerable<Payment> GetPaymentsWithBooking()
        {
            return _db.Payment.Include(x => x.Booking);
        }

        public Payment GetPaymentWithBooking(int id)
        {
            return _db.Payment.Include(x => x.Booking).FirstOrDefault(x => x.PaymentId == id);
        }
    }
}
