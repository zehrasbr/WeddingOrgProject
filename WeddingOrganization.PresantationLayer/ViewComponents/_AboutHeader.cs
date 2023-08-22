using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WeddingOrganization.PresantationLayer.ViewComponents
{
    public class _AboutHeader : ViewComponent
    {
        OpenPlaceManager openPlaceManager = new OpenPlaceManager(new EfOpenPlaceDal());
        public IViewComponentResult Invoke()
        {
            var values = openPlaceManager.TGetList();
            return View(values);
        }
    }
}
