using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICarService
    {
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        Car Get(int carId);
        List<Car> GetAllCars();
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByColorId(int colorId);
        List<Car> GetCarsByDailyPrice(decimal minDailyPrice, decimal maxDailyPrice);
        List<CarDetailDto> GetCarDetails();


        //GetCarsByBrandId , GetCarsByColorId servislerini yazınız.
    }
}
