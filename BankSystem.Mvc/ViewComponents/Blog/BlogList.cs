using BankSystem.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BankSystem.Mvc.ViewComponents.Blog
{
    public class BlogList : ViewComponent
    {
        private readonly IBlogService _blogService;
        public BlogList(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke()
        {
            var blog3Records = _blogService.GetBlogs3Records();
            return View(blog3Records);
        }

    }
}
