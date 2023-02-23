using BankSystem.Service.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BankSystem.Mvc.ViewComponents.Cart
{
    public class CartList : ViewComponent
    {
        private readonly ICartService _cartService;

        public CartList(ICartService cartService)
        {
            _cartService= cartService;
        }

        public IViewComponentResult Invoke()
        {

           var carts3Records =  _cartService.TGetCarts3Records();
            return View(carts3Records);
        }


    }
}
