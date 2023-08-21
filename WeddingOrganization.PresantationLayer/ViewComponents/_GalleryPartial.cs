using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WeddingOrganization.PresantationLayer.ViewComponents
{
	public class _GalleryPartial : ViewComponent
	{
		GalleryManager galleryManager = new GalleryManager(new EfGalleryDal());
		public IViewComponentResult Invoke()
		{
			var values = galleryManager.TGetList();
			return View(values);
		}
	}
}
