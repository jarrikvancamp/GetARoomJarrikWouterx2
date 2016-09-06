using GetARoom.DAL;
using GetARoom.DAL.SpecificRepositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.BLL.ObjectHandlers
{
    public class RoomHandler
    {
        protected IUnitOfWork _db;
        public RoomHandler(IUnitOfWork db)
        {
            _db = db;
        }

        protected const string handlerName = "Room";

        public  bool Add(Room room)
        {
            if (!ValidObject(room))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Rooms.Add(room);
            }
            catch
            {
                Console.WriteLine($"Adding failed [{handlerName}]");
                return false;
            }
            return true;
        }
        public  bool ValidObject(Room room)
        {
            //TODO: if statements
            return true;
        }

        public  bool Delete(Room room)
        {

            if (!ValidObject(room))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Rooms.Delete(room);
            }
            catch
            {
                Console.WriteLine($"Removing failed [{handlerName}]");
                return false;
            }
            return true;
        }

        public  IEnumerable<Room> GetAll()
        {
            return _db.Rooms.GetAll();
        }

        public  Room GetById(int id)
        {
            // validation: object

            // validation: db
            RepoValidation.ValidateIdSearch(id);
            return _db.Rooms.GetById(id);
        }

        public  Boolean Update(Room room)
        {
            if (!ValidObject(room))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Rooms.Update(room);
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
