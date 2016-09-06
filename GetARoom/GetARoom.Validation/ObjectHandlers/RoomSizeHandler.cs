using GetARoom.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.BLL.ObjectHandlers
{
    public class RoomSizeHandler : RepositoryHandler<RoomSize>
    {

        public RoomSizeHandler(IRepository<RoomSize> db) : base(db)
        {

        }

        protected const string handlerName = "RoomSize";

        public override bool Add(RoomSize roomSize)
        {
            if (!ValidObject(roomSize))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Add(roomSize);
            }
            catch
            {
                Console.WriteLine($"Adding failed [{handlerName}]");
                return false;
            }
            return true;
        }
        public override bool ValidObject(RoomSize roomSize)
        {
            //TODO: if statements
            return true;
        }

        public override bool Delete(RoomSize roomSize)
        {

            if (!ValidObject(roomSize))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Delete(roomSize);
            }
            catch
            {
                Console.WriteLine($"Removing failed [{handlerName}]");
                return false;
            }
            return true;
        }

        public override IEnumerable<RoomSize> GetAll()
        {
            return _db.GetAll();
        }

        public override RoomSize GetById(int id)
        {
            // validation: object

            // validation: db
            RepoValidation.ValidateIdSearch(id);
            return _db.GetById(id);
        }

        public override Boolean Update(RoomSize roomSize)
        {
            if (!ValidObject(roomSize))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Update(roomSize);
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
