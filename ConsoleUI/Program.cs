using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();

        }

        private static void ProductTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var cars = carManager.GetCarDetails();

            foreach (var car in cars)
            {
                Console.WriteLine(car.CarName + " " + car.DailyPrice + " " + car.BrandName + " " + car.ColorName);
            }
        }
    }
}
