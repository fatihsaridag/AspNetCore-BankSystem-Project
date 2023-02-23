using BankSystem.Service.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BankSystem.Mvc.Controllers
{
    public class CartsController : Controller
    {
        private readonly ICartService _cartService;

        public CartsController(ICartService cartService)
        {
            _cartService= cartService;
        }


        public IActionResult Index()
        {
            var cartList = _cartService.TGetList();
            return View(cartList);
        }
    }
}
