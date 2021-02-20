using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (HomeworkContext context = new HomeworkContext())
            {
                var added = context.Entry(entity);
                added.State = Microsoft.EntityFrameworkCore.EntityState.Added;
                context.SaveChanges();
            }
        }



        public void Delete(Car entity)
        {
            using (HomeworkContext context = new HomeworkContext())
            {
                var deleted = context.Entry(entity);
                deleted.State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                context.SaveChanges();
            }
        }



        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (HomeworkContext context = new HomeworkContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }


        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (HomeworkContext context = new HomeworkContext())
            {
                return filter == null
                    ? context.Set<Car>().ToList()
                    : context.Set<Car>().Where(filter).ToList();
            }
        }



        public void Update(Car entity)
        {
            using (HomeworkContext context = new HomeworkContext())
            {
                var updated = context.Entry(entity);
                updated.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
        }


    }
}
