using Microsoft.AspNetCore.Mvc;

namespace WeddingOrganization.PresantationLayer.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
