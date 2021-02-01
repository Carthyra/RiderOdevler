using System;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // ProductManager productManager = new ProductManager(new InMemoryProductDal());
            CarManager carManager = new CarManager(new InMemoryCarDal());
            ColorManager colorManager = new ColorManager(new InMemoryColorDal());
            BrandManager brandManager = new BrandManager(new InMemoryBrandDal());

            Console.WriteLine("-----------carManager GetAll CarId--------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId);
            }

            Console.WriteLine("-------------------------------------------------");
            carManager.Add(new Car
            {
                CarId = 11, BrandId = 4, Description = "5 kapı elektrik", ColorId = 4, ModelYear = "2020",
                DailyPrice = 300.00
            });
            Console.WriteLine("-----------carManager GetAll CarId Yeni araba eklenmiş --------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId);
            }

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("-----------colorManager GetAll ColorName--------------");

            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("-----------brandManager GetAll BrandName--------------");

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
            Console.WriteLine("-------------------------------------------------");
        }
    }
}