using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WeddingOrganization.PresantationLayer.ViewComponents
{
	public class _EventPartial : ViewComponent
	{
        LocationManager locationManager = new LocationManager(new EfLocationDal());
        public IViewComponentResult Invoke()
		{
            var values = locationManager.TGetList();
            return View(values);
		}
	}
}
