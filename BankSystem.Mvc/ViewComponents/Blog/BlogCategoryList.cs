using BankSystem.Service.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BankSystem.Mvc.ViewComponents.Blog
{
    public class BlogCategoryList : ViewComponent
    {
        private readonly IBlogCategoryService _blogCategoryService;

        public BlogCategoryList(IBlogCategoryService blogCategoryService)
        {
            _blogCategoryService = blogCategoryService;
        }

        public IViewComponentResult Invoke()
        {

            var blogCategories = _blogCategoryService.TGetList();
            return View(blogCategories);
        }


    }
}
