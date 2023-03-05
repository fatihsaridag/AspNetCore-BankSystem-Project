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
    public class EfBlogCategoryRepository : EfGenericRepository<BlogCategory>, IBlogCategoryRepository
    {
        public EfBlogCategoryRepository(BankSystemContext context) : base(context)
        {
        }
    }
}
