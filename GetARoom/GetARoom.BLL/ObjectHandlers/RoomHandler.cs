using GetARoom.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.BLL.ObjectHandlers
{
    public class RoomHandler : RepositoryHandler<Room>
    {

        public RoomHandler(IRepository<Room> db) : base(db)
        {

        }

        protected const string handlerName = "Room";

        public override bool Add(Room room)
        {
            if (!ValidObject(room))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Add(room);
            }
            catch
            {
                Console.WriteLine($"Adding failed [{handlerName}]");
                return false;
            }
            return true;
        }
        public override bool ValidObject(Room room)
        {
            //TODO: if statements
            return true;
        }

        public override bool Delete(Room room)
        {

            if (!ValidObject(room))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Delete(room);
            }
            catch
            {
                Console.WriteLine($"Removing failed [{handlerName}]");
                return false;
            }
            return true;
        }

        public override IEnumerable<Room> GetAll()
        {
            return _db.GetAll();
        }

        public override Room GetById(int id)
        {
            // validation: object

            // validation: db
            RepoValidation.ValidateIdSearch(id);
            return _db.GetById(id);
        }

        public override Boolean Update(Room room)
        {
            if (!ValidObject(room))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Update(room);
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
