using GetARoom.DAL.SpecificRepositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace GetARoom.DAL.SpecificRepositories.Repositories
{
    public class ReviewForBookingRepository : Repository<ReviewForBooking>, IReviewForBookingRepository
    {
        public ReviewForBookingRepository(GetARoomEntities db) : base(db)
        {
        }

        public IEnumerable<ReviewForBooking> GetAllReviewsForBookingFull()
        {
            return _db.ReviewForBooking.Include(x => x.Booking).Include(x => x.Review);
        }

        public IEnumerable<ReviewForBooking> GetAllReviewsForBookingWithBooking()
        {
            return _db.ReviewForBooking.Include(x => x.Booking);
        }

        public IEnumerable<ReviewForBooking> GetAllReviewsForBookingWithReview()
        {
            return _db.ReviewForBooking.Include(x => x.Review);
        }

        public ReviewForBooking GetReviewForBookingFull(int id)
        {
            return _db.ReviewForBooking.Include(x => x.Booking).Include(x => x.Review).FirstOrDefault(x=>x.ReviewForBookingId == id);
        }

        public ReviewForBooking GetReviewForBookingWithBooking(int id)
        {
            return _db.ReviewForBooking.Include(x => x.Booking).FirstOrDefault(x => x.ReviewForBookingId == id);
        }

        public ReviewForBooking GetReviewForBookingWithReview(int id)
        {
            return _db.ReviewForBooking.Include(x => x.Review).FirstOrDefault(x => x.ReviewForBookingId == id);
        }
    }
}
