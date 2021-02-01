using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        ICarDal _CarDal;

        public CarManager(ICarDal carDal)
        {
            _CarDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _CarDal.GetAll();
        }

        public List<Car> GetAllByColorId(int colorId)
        {
            return _CarDal.GetAllByColorId(colorId);
        }

        public List<Car> GetAllByBrandId(int brandId)
        {
            return _CarDal.GetAllByBrandId(brandId);
        }

        public void Add(Car car)
        {
            _CarDal.Add(car);
        }

        public void Delete(Car car)
        {
            _CarDal.Delete(car);
        }

        public void Update(Car car)
        {
            _CarDal.Update(car);
        }
    }
}