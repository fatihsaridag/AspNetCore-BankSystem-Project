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
    public class EfBlogRepository : EfGenericRepository<Blog>, IBlogRepository
    {

        private readonly BankSystemContext _context;

        public EfBlogRepository(BankSystemContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Blog> GetBlogs3Records()
        {
            return _context.Blogs.ToList().Take(3);
            

        }

        public IEnumerable<Blog> GetBlogsByCategory(int id)
        {
            return _context.Blogs.Where(x => x.BlogCategoryId == id).ToList();
        }
    }
}
