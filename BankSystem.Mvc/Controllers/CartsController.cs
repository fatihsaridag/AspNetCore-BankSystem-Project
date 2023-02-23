using BankSystem.Entities.Entities;
using BankSystem.Mvc.Models.ViewModels.CartsApplication;
using BankSystem.Service.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BankSystem.Mvc.Controllers
{
    public class CartsController : Controller
    {
        private readonly ICartService _cartService;
        private readonly ICartApplicationService _cartApplicationService;

        public CartsController(ICartService cartService, ICartApplicationService cartApplicationService)
        {
            _cartService = cartService;
            _cartApplicationService = cartApplicationService;
        }


        public IActionResult Index()
        {
            var cartList = _cartService.TGetList();
            return View(cartList);
        }

        [HttpGet]
        public IActionResult CartsApplication(int id) 
        {
            var cartEntity = _cartService.TGetById(id);

            if (cartEntity == null)
            {
                return RedirectToAction("Index");
            }

            CartsModel cartsModel = new();
            cartsModel.Image = cartEntity.Image;

            TempData["CartId"] = id;
            return View(cartsModel);
        }



        [HttpPost]
        public IActionResult CartsApplication(CartsModel cartsModel)
        {
            if (ModelState.IsValid)
            {

                CartApplication cartApplication = new();

                cartApplication.CartId = Convert.ToInt32(TempData["CartId"]);
                cartApplication.IdentificationNumber = cartsModel.AddCartsApplicationViewModel.IdentificationNumber;
                cartApplication.PhoneNumber = cartsModel.AddCartsApplicationViewModel.PhoneNumber;
                cartApplication.DateTime = cartsModel.AddCartsApplicationViewModel.DateTime;

                _cartApplicationService.TAdd(cartApplication);
                return RedirectToAction("Index");
            }
            return View(cartsModel.AddCartsApplicationViewModel);
        }








    }
}
