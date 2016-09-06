using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GetARoom.DAL
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly GetARoomEntities _db;



        public Repository(GetARoomEntities db)
        {
            _db = db;
            _db.Configuration.ProxyCreationEnabled = false;
            db.Configuration.LazyLoadingEnabled = true;
        }
        public virtual Boolean Add(TEntity item)
        {

            _db.Set<TEntity>().Add(item);
            _db.SaveChanges();
            return true;

        }

        public virtual Boolean Delete(TEntity item)
        {
            try
            {
                _db.Set<TEntity>().Remove(item);
                _db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public virtual IEnumerable<TEntity> GetAll()
        {
                return _db.Set<TEntity>().AsEnumerable<TEntity>();
        }

        public virtual TEntity GetById(int id)
        {
            return _db.Set<TEntity>().Find(id);
        }

        public virtual Boolean Update(TEntity item)
        {
            TEntity te = _db.Set<TEntity>().Find(item.Id);
            _db.SaveChanges();
            return true;
        }
    }
}
