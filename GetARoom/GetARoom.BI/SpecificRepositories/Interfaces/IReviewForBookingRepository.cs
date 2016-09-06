using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.DAL.SpecificRepositories.Interfaces
{
    public interface IReviewForBookingRepository : IRepository<ReviewForBooking>
    {

        IEnumerable<ReviewForBooking> GetAllReviewsForBookingFull();
        IEnumerable<ReviewForBooking> GetAllReviewsForBookingWithBooking();
        IEnumerable<ReviewForBooking> GetAllReviewsForBookingWithReview();

        ReviewForBooking GetReviewForBookingFull(int id);
        ReviewForBooking GetReviewForBookingWithReview(int id);
        ReviewForBooking GetReviewForBookingWithBooking(int id);

    }
}
