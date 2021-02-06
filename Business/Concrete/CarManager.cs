using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarsDal _carDal;

        public CarManager(ICarsDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine(" Araba başarıyla eklendi. ");
            }
        }

        public void Deleted(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Araba sistemden çıkarıldı");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllByBrandId(int id)
        {
            return _carDal.GetAll(b => b.BrandId == id);
        }

        public List<Car> GetAllByColorId(int id)
        {
            return _carDal.GetAll(b => b.ColorId == id);
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(b => b.DailyPrice == min && b.DailyPrice == max);
        }

        public Car GetById(int id)
        {
            return _carDal.Get(b => b.CarId == id);
        }

        public void Update(Car car)
        {
            
            _carDal.Update(car);
            Console.WriteLine("Araba güncellendi");
            Console.ReadLine();
        }
    }
}
