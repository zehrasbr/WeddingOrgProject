using Microsoft.AspNetCore.Mvc;

namespace WeddingOrganization.PresantationLayer.ViewComponents
{
    public class _ContentsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
