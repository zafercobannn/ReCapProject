using Core.DataAccess.EntityFrameworkk;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, MyFinalProjectContext>, ICarsDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (MyFinalProjectContext context = new MyFinalProjectContext())
            {
                var result = from cr in context.Cars
                             join b in context.Brands
                             on cr.BrandId equals b.BrandId
                             join cl in context.Colors
                             on cr.ColorId equals cl.ColorId
                             select new CarDetailDto 
                             {  
                                 CarId=cr.CarId,
                                 CarName=cr.CarName,
                                 ModelYear=cr.ModelYear,
                                 Description=cr.Description,
                                 BrandName=b.BrandName, 
                                 ColorName=cl.ColorName, 
                                 DailyPrice=cr.DailyPrice,
                                 
                             };
                return result.ToList();
            }
        }
    }
}
