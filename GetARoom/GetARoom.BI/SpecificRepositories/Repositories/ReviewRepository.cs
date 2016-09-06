using GetARoom.DAL.SpecificRepositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace GetARoom.DAL.SpecificRepositories.Repositories
{
    public class ReviewRepository : Repository<Review>, IReviewRepository
    {
        public ReviewRepository(GetARoomEntities db) : base(db)
        {
        }

        public IEnumerable<Review> GetReviewsWithUser()
        {
            return _db.Review;
        }

        public Review GetReviewWithUser(int id)
        {
            return _db.Review.FirstOrDefault(x => x.ReviewId == id);
        }
    }
}
