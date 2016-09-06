using GetARoom.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.BLL.ObjectHandlers
{
    public class PictureHandler : RepositoryHandler<Picture>
    {

        public PictureHandler(IRepository<Picture> db) : base(db)
        {

        }

        protected const string handlerName = "Picture";

        public override bool Add(Picture picture)
        {
            if (!ValidObject(picture))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Add(picture);
            }
            catch
            {
                Console.WriteLine($"Adding failed [{handlerName}]");
                return false;
            }
            return true;
        }
        public override bool ValidObject(Picture picture)
        {
            //TODO: if statements
            return true;
        }

        public override bool Delete(Picture picture)
        {

            if (!ValidObject(picture))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Delete(picture);
            }
            catch
            {
                Console.WriteLine($"Removing failed [{handlerName}]");
                return false;
            }
            return true;
        }

        public override IEnumerable<Picture> GetAll()
        {
            return _db.GetAll();
        }

        public override Picture GetById(int id)
        {
            // validation: object

            // validation: db
            RepoValidation.ValidateIdSearch(id);
            return _db.GetById(id);
        }

        public override Boolean Update(Picture picture)
        {
            if (!ValidObject(picture))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Update(picture);
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
