using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<Car> GetById(int carId);
        IDataResult<List<Car>> GetAllCars();
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);
        IDataResult<List<Car>> GetCarsByDailyPrice(decimal minDailyPrice, decimal maxDailyPrice);
        IDataResult<List<CarDetailDto>> GetCarDetails();


        //GetCarsByBrandId , GetCarsByColorId servislerini yazınız.
    }
}
