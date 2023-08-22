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
    public class AdvertManager : IAdvertService
    {
        IAdvertDal _advertDal;

        public AdvertManager(IAdvertDal advertDal)
        {
            _advertDal = advertDal;
        }

        public void TAdd(Advert t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Advert t)
        {
            throw new NotImplementedException();
        }

        public Advert TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Advert> TGetList()
        {
            return _advertDal.GetList();
        }

        public void TUpdate(Advert t)
        {
            throw new NotImplementedException();
        }
    }
}
