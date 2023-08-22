using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WeddingOrganization.PresantationLayer.ViewComponents
{
	public class _PlacePartial : ViewComponent
	{
        PlaceManager placeManager = new PlaceManager(new EfPlaceDal());
        public IViewComponentResult Invoke()
		{
            var values = placeManager.TGetList();
            return View(values);
		}
	}
}
