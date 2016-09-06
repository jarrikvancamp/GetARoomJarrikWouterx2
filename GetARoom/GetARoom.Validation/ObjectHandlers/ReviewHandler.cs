using GetARoom.DAL;
using GetARoom.DAL.SpecificRepositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.BLL.ObjectHandlers
{
    public class ReviewHandler 
    {
        protected IUnitOfWork _db;

        public ReviewHandler(IUnitOfWork db)
        {
            _db = db;
        }

        protected const string handlerName = "Review";

        public  bool Add(Review review)
        {
            if (!ValidObject(review))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Reviews.Add(review);
            }
            catch
            {
                Console.WriteLine($"Adding failed [{handlerName}]");
                return false;
            }
            return true;
        }
        public  bool ValidObject(Review review)
        {
            //TODO: if statements
            return true;
        }

        public  bool Delete(Review review)
        {

            if (!ValidObject(review))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Reviews.Delete(review);
            }
            catch
            {
                Console.WriteLine($"Removing failed [{handlerName}]");
                return false;
            }
            return true;
        }

        public  IEnumerable<Review> GetAll()
        {
            return _db.Reviews.GetAll();
        }

        public  Review GetById(int id)
        {
            // validation: object

            // validation: db
            RepoValidation.ValidateIdSearch(id);
            return _db.Reviews.GetById(id);
        }

        public  Boolean Update(Review review)
        {
            if (!ValidObject(review))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Reviews.    Update(review);
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
