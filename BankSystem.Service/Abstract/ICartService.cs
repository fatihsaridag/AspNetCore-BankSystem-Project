using BankSystem.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Service.Abstract
{
    public interface ICartService : IGenericService<Cart>
    {
        IEnumerable<Cart> TGetCarts3Records();

    }
}
