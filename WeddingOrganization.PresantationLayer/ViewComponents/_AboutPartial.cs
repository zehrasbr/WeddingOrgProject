using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace WeddingOrganization.PresantationLayer.ViewComponents
{
	public class _AboutPartial : ViewComponent
	{
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        public IViewComponentResult Invoke()
		{
            var values = aboutManager.TGetList();
            return View(values);
		}
	}
}
