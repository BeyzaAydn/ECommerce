using ECommerce.BLL.Repositories.Abstracts;
using ECommerce.BLL.ViewModels.CategoryViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.MVC.Areas.AdminDashboard.Controllers
{
    [Area("AdminDashboard")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public  CategoryController(ICategoryService  categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            
                
            var categories=_categoryService.GetAllCategories().ToList();
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();

        }

        
    }
}
