using GetARoom.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.BLL.ObjectHandlers
{
    public interface IRepositoryHandler<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        bool ValidObject(TEntity item);

    }
}
