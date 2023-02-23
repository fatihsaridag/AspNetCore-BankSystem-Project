using BankSystem.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Data.EntityFramework.Repositories.Abstract
{
    public interface ICartRepository : IGenericRepository<Cart>
    {
        IEnumerable<Cart> GetCarts3Records();
    }
}
