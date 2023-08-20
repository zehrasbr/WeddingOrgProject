using Microsoft.AspNetCore.Mvc;

namespace WeddingOrganization.PresantationLayer.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

	}
}
