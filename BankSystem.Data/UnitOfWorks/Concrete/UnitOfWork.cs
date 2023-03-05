using BankSystem.Data.EntityFramework.Contexts;
using BankSystem.Data.EntityFramework.Repositories.Abstract;
using BankSystem.Data.EntityFramework.Repositories.Concrete;
using BankSystem.Data.UnitOfWorks.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Data.UnitOfWorks.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BankSystemContext _context;
        private EfCartRepository _cartRepository;
        private EfCartApplicationRepository _cartApplicationRepository;
        private EfBlogRepository _blogRepository;
        private EfBlogCategoryRepository _blogCategoryRepository;

        public UnitOfWork(BankSystemContext context)
        {
            _context = context;
        }

        public ICartRepository Carts => _cartRepository ?? new EfCartRepository(_context);
        public ICartApplicationRepository CartApplications => _cartApplicationRepository ?? new EfCartApplicationRepository(_context);

        public IBlogRepository Blogs => _blogRepository ?? new EfBlogRepository(_context);

        public IBlogCategoryRepository BlogCategories =>  _blogCategoryRepository ?? new EfBlogCategoryRepository(_context);

        public void Dispose()
        {
             _context.Dispose();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
