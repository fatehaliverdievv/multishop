using Microsoft.AspNetCore.Mvc;

namespace Multishop.Areas.Manage.Controllers
{
        [Area("Manage")]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
