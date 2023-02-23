using BankSystem.Data.EntityFramework.Contexts;
using BankSystem.Data.EntityFramework.Repositories.Abstract;
using BankSystem.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Data.EntityFramework.Repositories.Concrete
{
    public class EfCartRepository : EfGenericRepository<Cart>, ICartRepository
    {
        private readonly BankSystemContext _context;
        public EfCartRepository(BankSystemContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Cart> GetCarts3Records()
        {
           return _context.Carts.ToList().Take(3);
        }
    }
}
