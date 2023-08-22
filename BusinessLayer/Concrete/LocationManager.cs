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
    public class LocationManager : ILocationService
    {
        ILocationDal _locationDal;

        public LocationManager(ILocationDal locationDal)
        {
            _locationDal = locationDal;
        }

        public void TAdd(Location t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Location t)
        {
            throw new NotImplementedException();
        }

        public Location TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Location> TGetList()
        {
            return _locationDal.GetList();
        }

        public void TUpdate(Location t)
        {
            throw new NotImplementedException();
        }
    }
}
