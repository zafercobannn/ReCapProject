using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandsDal());

            brandManager.Add(new Brand { BrandName = "Audi" });
            colorManager.Add(new Color { ColorName = "Siyah" });
            carManager.Add(new Car { BrandId = 1, ColorId = 1, DailyPrice = 150, Description = "Otamatik Sanzıman", ModelYear = 2019 });

            foreach (var brand in brandManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(brand.BrandName);
            }

            foreach (var color in colorManager.GetCarsByColorsId(1))
            {
                Console.WriteLine(color.ColorName);
            }


        }
    }
}