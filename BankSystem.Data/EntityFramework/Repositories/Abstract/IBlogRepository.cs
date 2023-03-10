using BankSystem.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Data.EntityFramework.Repositories.Abstract
{
    public interface IBlogRepository : IGenericRepository<Blog>
    {
        IEnumerable<Blog> GetBlogs3Records();
        IEnumerable<Blog> GetBlogsByCategory(int id);
    }
}
