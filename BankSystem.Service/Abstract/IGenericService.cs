using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Service.Abstract
{
    public interface IGenericService<TEntity>
    {
        void TAdd(TEntity entity);
        void TUpdate(TEntity entity);
        void TDelete(TEntity entity);
        IEnumerable<TEntity> TGetList();
        TEntity TGetById(int id);
    }
}
