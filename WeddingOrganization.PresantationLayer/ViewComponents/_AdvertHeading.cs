using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WeddingOrganization.PresantationLayer.ViewComponents
{
    public class _AdvertHeading : ViewComponent
    {
        AdvertManager advertManager = new AdvertManager(new EfAdvertDal());
        public IViewComponentResult Invoke()
        {
            var values = advertManager.TGetList();
            return View(values);
        }
    }
}
