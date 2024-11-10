using E_TicktsCinma.Models;
using E_TicktsCinma.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace E_TicktsCinma.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            var categories = categoryRepository.GetAll("Movie");
            return View(categories);
        }
    }
}
