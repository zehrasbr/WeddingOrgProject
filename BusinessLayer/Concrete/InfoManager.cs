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
    public class InfoManager : IInfoService
    {
        IInfoDal _ınfoDal;

        public InfoManager(IInfoDal ınfoDal)
        {
            _ınfoDal = ınfoDal;
        }

        public void TAdd(Info t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Info t)
        {
            throw new NotImplementedException();
        }

        public Info TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Info> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Info t)
        {
            throw new NotImplementedException();
        }
    }
}
