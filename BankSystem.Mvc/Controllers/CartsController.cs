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

            TempData["CartId"] = id;

            return View();
        }



        [HttpPost]
        public IActionResult CartsApplication(AddCartsApplicationViewModel addCartApplicationViewModel)
        {
            if (ModelState.IsValid)
            {

                CartApplication cartApplication = new();

                cartApplication.CartId = Convert.ToInt32(TempData["CartId"]);
                cartApplication.IdentificationNumber = addCartApplicationViewModel.IdentificationNumber;
                cartApplication.PhoneNumber = addCartApplicationViewModel.PhoneNumber;
                cartApplication.DateTime = addCartApplicationViewModel.DateTime;

                _cartApplicationService.TAdd(cartApplication);
                return RedirectToAction("Index");
            }
            return View(addCartApplicationViewModel);
        }








    }
}
