using BankSystem.Data.UnitOfWorks.Abstract;
using BankSystem.Entities.Entities;
using BankSystem.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Service.Concrete
{
    public class BlogManager : IBlogService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BlogManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Blog> GetBlogs3Records()
        {
           return _unitOfWork.Blogs.GetBlogs3Records();
        }

        public IEnumerable<Blog> GetBlogsByCategory(int id)
        {
            return _unitOfWork.Blogs.GetBlogsByCategory(id);
        }

        public void TAdd(Blog entity)
        {
            _unitOfWork.Blogs.Add(entity);
            _unitOfWork.Save();
        }

        public void TDelete(Blog entity)
        {
            _unitOfWork.Blogs.Delete(entity);
            _unitOfWork.Save();
        }

        public Blog TGetById(int id)
        {
           return _unitOfWork.Blogs.GetById(id);
        }

        public IEnumerable<Blog> TGetList()
        {
           return _unitOfWork.Blogs.GetAll();
        }

        public void TUpdate(Blog entity)
        {
            _unitOfWork.Blogs.Update(entity);
            _unitOfWork.Save();
        }
    }
}
