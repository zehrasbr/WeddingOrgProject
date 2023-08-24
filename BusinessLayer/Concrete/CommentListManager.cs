using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentListManager : ICommentListService
    {

        ICommentListDal _commentListDal;

        public CommentListManager(ICommentListDal commentListDal)
        {
            _commentListDal = commentListDal;
        }

        public void TAdd(Comment t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Comment t)
        {
            throw new NotImplementedException();
        }

        public Comment TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetList()
        {
            return _commentListDal.GetList();
        }

        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }
    }
}
