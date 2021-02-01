using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllByColorId(int colorId);
        List<Car> GetAllByBrandId(int brandId);
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
    }
}