using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class OpenPlaceManager : IOpenPlaceService
    {
        IOpenPlaceDal _openPlaceDal;

        public OpenPlaceManager(IOpenPlaceDal openPlaceDal)
        {
            _openPlaceDal = openPlaceDal;
        }

        public void TAdd(OpenPlace t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(OpenPlace t)
        {
            throw new NotImplementedException();
        }

        public OpenPlace TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<OpenPlace> TGetList()
        {
            return _openPlaceDal.GetList();
        }

        public void TUpdate(OpenPlace t)
        {
            throw new NotImplementedException();
        }
    }
}
