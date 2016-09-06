using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.DAL
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        bool Add(TEntity item);
        bool Delete(TEntity item);

        bool Update(TEntity item);
       
    }
}
