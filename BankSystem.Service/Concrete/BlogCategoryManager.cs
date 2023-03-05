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
    public class BlogCategoryManager : IBlogCategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BlogCategoryManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork= unitOfWork;
        }


        public void TAdd(BlogCategory entity)
        {
            _unitOfWork.BlogCategories.Add(entity);
            _unitOfWork.Save();
        }

        public void TDelete(BlogCategory entity)
        {
            _unitOfWork.BlogCategories.Delete(entity); 
            _unitOfWork.Save();
        }

        public BlogCategory TGetById(int id)
        {
            return _unitOfWork.BlogCategories.GetById(id);

        }

        public IEnumerable<BlogCategory> TGetList()
        {
            return _unitOfWork.BlogCategories.GetAll();
        }

        public void TUpdate(BlogCategory entity)
        {
            _unitOfWork.BlogCategories.Update(entity);
            _unitOfWork.Save();
        }
    }
}
