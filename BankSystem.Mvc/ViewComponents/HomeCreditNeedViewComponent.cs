using BankSystem.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace BankSystem.Mvc.ViewComponents
{
    public class HomeCreditNeedViewComponent : ViewComponent
    {
        public ViewViewComponentResult Invoke()
        {
            return View();
        }

    }
}
