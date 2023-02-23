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
    public class CartManager : ICartService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CartManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork= unitOfWork;
        }


        public void TAdd(Cart entity)
        {
            _unitOfWork.Carts.Add(entity);
            _unitOfWork.Save();
        }

        public void TDelete(Cart entity)
        {
            _unitOfWork.Carts.Delete(entity);
            _unitOfWork.Save();

        }

        public Cart TGetById(int id)
        {
           return _unitOfWork.Carts.GetById(id);
            
        }

        public IEnumerable<Cart> TGetCarts3Records()
        {
            return _unitOfWork.Carts.GetCarts3Records();
        }

        public IEnumerable<Cart> TGetList()
        {
            return _unitOfWork.Carts.GetAll();
        }

        public void TUpdate(Cart entity)
        {
            _unitOfWork.Carts.Update(entity);
            _unitOfWork.Save();
        }
    }
}
