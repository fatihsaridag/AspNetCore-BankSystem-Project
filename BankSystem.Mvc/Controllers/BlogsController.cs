using BankSystem.Service.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BankSystem.Mvc.Controllers
{
    public class BlogsController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogsController(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public IActionResult Index()
        {
           var blogs =  _blogService.TGetList();
           return View(blogs);
        }

        public IActionResult BlogListByCategory(int id)
        {
            if (id != null)
            {
                var blogsByCategory = _blogService.GetBlogsByCategory(id);
                return View(blogsByCategory);
            }
            return View();

        }



    }
}
