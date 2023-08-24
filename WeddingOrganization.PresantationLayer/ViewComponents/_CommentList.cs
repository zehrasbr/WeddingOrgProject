using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WeddingOrganization.PresantationLayer.ViewComponents
{
    public class _CommentList : ViewComponent
    {
        CommentListManager commentListManager = new CommentListManager(new EfCommentListDal());
        public IViewComponentResult Invoke()
        {
            var values = commentListManager.TGetList();
            return View(values);
        }
    }
}
