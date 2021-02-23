using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using Business.Constants;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        readonly ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            _carDal.Add(car);

            if (1==2)
            {
                return new ErrorResult(Messages.ProductAdded);
            }

            return new SuccessResult(Messages.ProductAdded);
        }

  

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public Car GetById(int carId)
        {
            return _carDal.Get(c => c.Id == carId);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new DataResult( _carDal.GetAll());
        }

        public List<Car> GetAllCars()
        {
            return _carDal.GetAll();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByDailyPrice(decimal minDailyPrice, decimal maxDailyPrice)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

       }
}
