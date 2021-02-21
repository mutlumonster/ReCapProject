using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, HomeworkContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            ////rabaları şu bilgiler olacak şekilde listeleyiniz. CarName, BrandName, ColorName, DailyPrice
            
            using (HomeworkContext context = new HomeworkContext())
            {
                var result = from car in context.Cars
                             join color in context.Colors
                             on car.ColorId equals color.Id
                             join brand in context.Brands
                             on car.BrandId equals brand.Id
                                select new CarDetailDto { 
                                    BrandName = brand.Name,
                                    CarName = car.CarName,
                                    ColorName = color.Name,
                                    DailyPrice = car.DailyPrice
                                };
                return result.ToList();
            }
        }
    }
}
