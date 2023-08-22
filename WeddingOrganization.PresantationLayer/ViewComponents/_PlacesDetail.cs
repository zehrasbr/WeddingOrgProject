using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WeddingOrganization.PresantationLayer.ViewComponents
{
    public class _PlacesDetail : ViewComponent
    {
        PlacesDetailManager placesDetailManager = new PlacesDetailManager(new EfPlacesDetailDal());
        public IViewComponentResult Invoke()
        {
            var values = placesDetailManager.TGetList();
            return View(values);
        }
    }
}
