using GetARoom.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.BLL.ObjectHandlers
{
    public class AssetHandler : RepositoryHandler<Asset>
    {
       
        protected const string handlerName = "ASSET";
        public AssetHandler(IRepository<Asset> db) : base(db)
        {

        }

        public override bool Add(Asset asset)
        {
            if (!ValidObject(asset))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Add(asset);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Adding failed [{handlerName}] : {e.Message}");
                return false;
            }
            return true;
        }

        public override bool ValidObject(Asset asset)
        {
            //TODO: if statements

            return true;
        }

        public override bool Delete(Asset asset)
        {

            if (!ValidObject(asset))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Delete(asset);
            }
            catch
            {
                Console.WriteLine($"Removing failed [{handlerName}]");
                return false;
            }
            return true;
        }

        public override IEnumerable<Asset> GetAll()
        {
            return _db.GetAll();
        }

        public override Asset GetById(int id)
        {
            // validation: object

            // validation: db
            RepoValidation.ValidateIdSearch(id);
            return _db.GetById(id);
        }

        public override Boolean Update(Asset asset)
        {
            if (!ValidObject(asset))
            {
                return false;
            }

            //validation error

            try
            {
                _db.Update(asset);
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
