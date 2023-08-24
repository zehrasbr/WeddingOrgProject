using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WeddingOrganization.PresantationLayer.ViewComponents
{
    public class _CommentPartial : ViewComponent
    {
        CommentListManager commentManager = new CommentManager(EfCommentDal());
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
