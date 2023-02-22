using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace BankSystem.Mvc.ViewComponents
{
    public class HomeCurrencyViewComponent : ViewComponent
    { 
        public ViewViewComponentResult Invoke()
        {
            return View();
        }
    }
}
