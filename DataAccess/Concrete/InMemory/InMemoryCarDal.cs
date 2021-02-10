using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarsDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{CarId=1 , BrandId=1 , ColorId = 232 , DailyPrice =100 , Description = "Renault", ModelYear = 2015},
                new Car{CarId=2 , BrandId=1 , ColorId = 200 , DailyPrice =80  , Description = "Renault", ModelYear = 2012},
                new Car{CarId=3 , BrandId=2 , ColorId = 255 , DailyPrice =130 , Description = "Hyundai", ModelYear = 2019},
                new Car{CarId=4 , BrandId=2 , ColorId = 210 , DailyPrice =120 , Description = "Hyundai", ModelYear = 2017},
                new Car{CarId=5 , BrandId=3 , ColorId = 255 , DailyPrice =300 , Description = "Tesla ModelS", ModelYear = 2020}
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.CarId == car.CarId);
            _car.Remove(carToDelete);
        }
        public List<Car> GetAll()
        {
            return _car;
        }

        public void Update(Car car)
        {
            Car cartoUptade = _car.SingleOrDefault(c => c.CarId == car.CarId);
            cartoUptade.BrandId = car.BrandId;
            cartoUptade.ColorId = car.ColorId;
            cartoUptade.DailyPrice = car.DailyPrice;
            cartoUptade.Description = car.Description;
            cartoUptade.ModelYear = car.ModelYear;
        }

        public List<Car> GetAllByBrandId(int brandId)
        {
            return _car.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }   
}
