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
    public class PlaceManager : IPlaceService
    {
        IPlaceDal _placeDal;

        public PlaceManager(IPlaceDal placeDal)
        {
            _placeDal = placeDal;
        }

        public void TAdd(Place t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Place t)
        {
            throw new NotImplementedException();
        }

        public Place TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Place> TGetList()
        {
            return _placeDal.GetList();
        }

        public void TUpdate(Place t)
        {
            throw new NotImplementedException();
        }
    }
}
