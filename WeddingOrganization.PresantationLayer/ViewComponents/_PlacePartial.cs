using Microsoft.AspNetCore.Mvc;

namespace WeddingOrganization.PresantationLayer.ViewComponents
{
	public class _PlacePartial : ViewComponent
	{ 
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
