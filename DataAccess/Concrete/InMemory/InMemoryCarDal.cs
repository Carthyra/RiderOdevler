using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car
                {
                    CarId = 1, BrandId = 1, ColorId = 1, ModelYear = "2015", DailyPrice = 150.00,
                    Description = "4 Kapı Dizel"
                },
                new Car
                {
                    CarId = 2, BrandId = 2, ColorId = 2, ModelYear = "2016", DailyPrice = 160.00,
                    Description = "5 Kapı Dizel"
                },
                new Car
                {
                    CarId = 3, BrandId = 3, ColorId = 3, ModelYear = "2017", DailyPrice = 170.00,
                    Description = "4 Kapı Benzin"
                },
                new Car
                {
                    CarId = 4, BrandId = 4, ColorId = 4, ModelYear = "2017", DailyPrice = 180.00,
                    Description = "4 Kapı Dizel"
                },
                new Car
                {
                    CarId = 5, BrandId = 5, ColorId = 5, ModelYear = "2018", DailyPrice = 190.00,
                    Description = "5 Kapı Dizel"
                },
                new Car
                {
                    CarId = 6, BrandId = 6, ColorId = 5, ModelYear = "2018", DailyPrice = 200.00,
                    Description = "5 Kapı Benzin"
                },
                new Car
                {
                    CarId = 7, BrandId = 7, ColorId = 2, ModelYear = "2019", DailyPrice = 210.00,
                    Description = "4 Kapı Dizel"
                },
                new Car
                {
                    CarId = 8, BrandId = 8, ColorId = 3, ModelYear = "2019", DailyPrice = 220.00,
                    Description = "4 Kapı Benzin"
                },
                new Car
                {
                    CarId = 9, BrandId = 1, ColorId = 1, ModelYear = "2019", DailyPrice = 230.00,
                    Description = "4 Kapı Elektrik"
                },
                new Car
                {
                    CarId = 10, BrandId = 1, ColorId = 4, ModelYear = "2019", DailyPrice = 240.00,
                    Description = "5 Kapı Benzin"
                },
            };
        }
        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrandId(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetAllByColorId(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}