using BankSystem.Data.EntityFramework.Contexts;
using BankSystem.Data.UnitOfWorks.Abstract;
using BankSystem.Data.UnitOfWorks.Concrete;
using BankSystem.Entities.Entities;
using BankSystem.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Service.Concrete
{
    public class CartApplicationManager : ICartApplicationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CartApplicationManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void TAdd(CartApplication entity)
        {
            _unitOfWork.CartApplications.Add(entity);
            _unitOfWork.Save();
        }

        public void TDelete(CartApplication entity)
        {
            _unitOfWork.CartApplications.Delete(entity);
            _unitOfWork.Save();
        }

        public CartApplication TGetById(int id)
        {
            return _unitOfWork.CartApplications.GetById(id);
        }

        public IEnumerable<CartApplication> TGetList()
        {
            return _unitOfWork.CartApplications.GetAll();
        }

        public void TUpdate(CartApplication entity)
        {
            _unitOfWork.CartApplications.Update(entity);
            _unitOfWork.Save();
        }
    }
}
