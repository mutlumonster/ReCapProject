using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var cars = carManager.GetAllCars();

            foreach (var car  in cars)
            {
                Console.WriteLine(car.CarDescription);
            }
            
        }
    }
}
