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
    public class PlacesDetailManager : IPlacesDetailService
    {
        IPlacesDetailDal _placesDetailDal;

        public PlacesDetailManager(IPlacesDetailDal placesDetailDal)
        {
            _placesDetailDal = placesDetailDal;
        }

        public void TAdd(PlacesDetail t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(PlacesDetail t)
        {
            throw new NotImplementedException();
        }

        public PlacesDetail TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<PlacesDetail> TGetList()
        {
            return _placesDetailDal.GetList();
        }

        public void TUpdate(PlacesDetail t)
        {
            throw new NotImplementedException();
        }
    }
}
