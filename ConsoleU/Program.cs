using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BrandManager brandManager = new BrandManager(new EfBrandsDal());
            brandManager.Add(new Brand { BrandName = "BMW" });
            var brands = brandManager.GetAll();
            foreach (var item in brands)
            {
                System.Console.WriteLine(" Marka : {0} ", item.BrandName);
            }


            
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorName = "Kırmızı" });
            var colors = colorManager.GetAll();
            foreach (var item in colors)
            {
                System.Console.WriteLine(" Rengi : {0} ", item.ColorName);
            }


            
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { ColorId = 1, BrandId = 2, ModelYear = 2021, DailyPrice = 300, Description = "Otomatik sarj" });
            var carDetail = carManager.GetCarDetails();
            foreach (var item in carDetail)
            {
                System.Console.WriteLine("Araç Modeli :{0}  Araç Rengi :{1}  Günlük Fiyatı :{2} ",item.BrandName, item.ColorName, item.DailyPrice);
            }

        }
    }
}