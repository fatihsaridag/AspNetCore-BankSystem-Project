using BankSystem.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Service.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {
        IEnumerable<Blog> GetBlogs3Records();
        IEnumerable<Blog> GetBlogsByCategory(int id);


    }
}
