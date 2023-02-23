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
    public class EfCartApplicationRepository : EfGenericRepository<CartApplication>, ICartApplicationRepository
    {
        public EfCartApplicationRepository(BankSystemContext context) : base(context)
        {
        }
    }
}
