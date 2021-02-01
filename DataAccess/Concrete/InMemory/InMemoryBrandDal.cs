using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal:IBrandDal
    {
        List<Brand> _brands;

        public InMemoryBrandDal()
        {
            _brands = new List<Brand>
            {
                new Brand {BrandId = 1, BrandName = "Mercedes"},
                new Brand {BrandId = 2, BrandName = "BMW"},
                new Brand {BrandId = 3, BrandName = "Ford"},
                new Brand {BrandId = 4, BrandName = "Mazda"},
                new Brand {BrandId = 5, BrandName = "Volkswagen"},
                new Brand {BrandId = 6, BrandName = "Fiat"},
                new Brand {BrandId = 7, BrandName = "Ferrari"},
                new Brand {BrandId = 8, BrandName = "Tesla"},
                new Brand {BrandId = 9, BrandName = "Porsche"},
            };
        }
        public List<Brand> GetAll()
        {
            return _brands;
        }

        public void Add(Brand brand)
        {
            _brands.Add(brand);
        }

        public void Delete(Brand brand)
        {
            Brand brandToDelete = _brands.SingleOrDefault(b => b.BrandId == brand.BrandId);
            _brands.Remove(brandToDelete);

        }

        public void Update(Brand brand)
        {
            Brand brandToUpdate = _brands.SingleOrDefault(b => b.BrandId == brand.BrandId);
            brandToUpdate.BrandName = brand.BrandName;
        }
    }
}