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
    public class GalleryManager : IGalleryService
    {
        IGalleryDal _galleryDal;

        public GalleryManager(IGalleryDal galleryDal)
        {
            _galleryDal = galleryDal;
        }

        public void TAdd(Gallery t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Gallery t)
        {
            throw new NotImplementedException();
        }

        public Gallery TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Gallery> TGetList()
        {
           return _galleryDal.GetList();
        }

        public void TUpdate(Gallery t)
        {
            throw new NotImplementedException();
        }
    }
}
