using Microsoft.AspNetCore.Mvc;

namespace ECommerce.MVC.Areas.AdminDashboard.Controllers
{
    [Area("AdminDashboard")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
