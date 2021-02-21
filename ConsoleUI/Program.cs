﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            var cars = carManager.GetAllCars();

            foreach (var car  in cars)
            {
                Console.WriteLine(car.CarDescription);
            }
            
        }
    }
}
