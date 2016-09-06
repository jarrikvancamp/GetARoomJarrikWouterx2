using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.DAL.SpecificRepositories.Interfaces
{
    public interface IReviewRepository : IRepository<Review>
    {

        IEnumerable<Review> GetReviewsWithUser();
        Review GetReviewWithUser(int id);
    }
}
