using GetARoom.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.BLL.ObjectHandlers
{
   public abstract class RepositoryHandler<TEntity> : IRepositoryHandler<TEntity> where TEntity : BaseEntity
    {
        protected IRepository<TEntity> _db;
        public  RepositoryHandler(IRepository<TEntity> db)
        {
            _db = db;
        }

        public abstract bool Add(TEntity item);


        public abstract bool Delete(TEntity item);

        public abstract IEnumerable<TEntity> GetAll();

        public abstract TEntity GetById(int id);

        public abstract bool Update(TEntity item);

        public abstract bool ValidObject(TEntity item);
    }
}
