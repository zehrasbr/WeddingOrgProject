using Microsoft.AspNetCore.Mvc;

namespace WeddingOrganization.PresantationLayer.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
