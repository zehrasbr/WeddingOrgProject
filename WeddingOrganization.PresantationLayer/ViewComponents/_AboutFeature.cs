using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WeddingOrganization.PresantationLayer.ViewComponents
{
    public class _AboutFeature : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
