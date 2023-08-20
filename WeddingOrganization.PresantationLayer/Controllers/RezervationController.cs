using Microsoft.AspNetCore.Mvc;

namespace WeddingOrganization.PresantationLayer.Controllers
{
    public class RezervationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
