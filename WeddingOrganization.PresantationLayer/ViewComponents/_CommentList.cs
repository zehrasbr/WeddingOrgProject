using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WeddingOrganization.PresantationLayer.ViewComponents
{
    public class _CommentList : ViewComponent
    {
        CommentListManager commentManager = new CommentListManager(new EfCommentListDal());
        public IViewComponentResult Invoke()
        {
            var values = commentManager.TGetList();
            return View(values);
        }
    }
}
