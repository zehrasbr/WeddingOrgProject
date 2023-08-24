using Microsoft.AspNetCore.Mvc;

namespace WeddingOrganization.PresantationLayer.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
