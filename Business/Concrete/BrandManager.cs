using System.Collections.Generic;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager:IBrandDal
    {
        IBrandDal _BrandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _BrandDal = brandDal;
        }
        public List<Brand> GetAll()
        {
            return _BrandDal.GetAll();
        }

        public void Add(Brand brand)
        {
            _BrandDal.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _BrandDal.Delete(brand);
        }

        public void Update(Brand brand)
        {
            _BrandDal.Update(brand);
        }
    }
}