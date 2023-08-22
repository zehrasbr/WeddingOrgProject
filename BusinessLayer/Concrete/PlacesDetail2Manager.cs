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
    public class PlacesDetail2Manager : IPlacesDetail2Service
    {
        IPlacesDetail2Dal _placesDetail2Dal;

        public PlacesDetail2Manager(IPlacesDetail2Dal placesDetail2Dal)
        {
            _placesDetail2Dal = placesDetail2Dal;
        }

        public void TAdd(PlacesDetail2 t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(PlacesDetail2 t)
        {
            throw new NotImplementedException();
        }

        public PlacesDetail2 TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<PlacesDetail2> TGetList()
        {
            return _placesDetail2Dal.GetList();
        }

        public void TUpdate(PlacesDetail2 t)
        {
            throw new NotImplementedException();
        }
    }
}
