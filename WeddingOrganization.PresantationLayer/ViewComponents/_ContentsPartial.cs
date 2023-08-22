using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WeddingOrganization.PresantationLayer.ViewComponents
{
    public class _ContentsPartial : ViewComponent
    {
        PlacesDetail2Manager placesDetail2Manager = new PlacesDetail2Manager(new EfPlacesDetail2Dal());
        public IViewComponentResult Invoke()
        {
            var values = placesDetail2Manager.TGetList();
            return View(values);
        }
    }
}
