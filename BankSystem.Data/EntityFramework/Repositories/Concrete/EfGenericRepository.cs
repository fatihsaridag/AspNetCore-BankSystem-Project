using BankSystem.Data.EntityFramework.Contexts;
using BankSystem.Data.EntityFramework.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Data.EntityFramework.Repositories.Concrete
{
    public class EfGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {

        private readonly BankSystemContext _context;
        public EfGenericRepository(BankSystemContext context)
        {
            _context = context;
        }


        public void Add(TEntity entity)
        {
            _context.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _context.Remove(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
           return _context.Set<TEntity>().Find(id);
        }

        public void Update(TEntity entity)
        {
            _context.Update(entity);
        }

        public TEntity Where(Expression<Func<TEntity, bool>> predicate)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            query = query.Where(predicate);
            return query.FirstOrDefault();
        }
    }
}
