using GetARoom.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.BLL.ObjectHandlers
{
    public class ReviewHandler : RepositoryHandler<Review>
    {

        public ReviewHandler(IRepository<Review> db) : base(db)
        {

        }

        protected const string handlerName = "Review";

        public override bool Add(Review review)
        {
            if (!ValidObject(review))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Add(review);
            }
            catch
            {
                Console.WriteLine($"Adding failed [{handlerName}]");
                return false;
            }
            return true;
        }
        public override bool ValidObject(Review review)
        {
            //TODO: if statements
            return true;
        }

        public override bool Delete(Review review)
        {

            if (!ValidObject(review))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Delete(review);
            }
            catch
            {
                Console.WriteLine($"Removing failed [{handlerName}]");
                return false;
            }
            return true;
        }

        public override IEnumerable<Review> GetAll()
        {
            return _db.GetAll();
        }

        public override Review GetById(int id)
        {
            // validation: object

            // validation: db
            RepoValidation.ValidateIdSearch(id);
            return _db.GetById(id);
        }

        public override Boolean Update(Review review)
        {
            if (!ValidObject(review))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Update(review);
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
