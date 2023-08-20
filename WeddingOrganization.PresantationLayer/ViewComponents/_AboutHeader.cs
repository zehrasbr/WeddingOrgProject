using Microsoft.AspNetCore.Mvc;

namespace WeddingOrganization.PresantationLayer.ViewComponents
{
    public class _AboutHeader : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
