using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {
            //Data Transformation Object
            //CarTest();
            //IoC 
            //CategoryTest();
            RentalTest();
        }


        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.GetAll();

            if (result.Success == true)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine(rental.CarId + " / " + rental.RentDate);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }























        //private static void CarTest()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());

        //    var result = carManager.GetCarDetails();

        //    if (result.Success == true)
        //    {
        //        foreach (var car in result.Data)
        //        {
        //            Console.WriteLine(car.BrandName + "/" + car.DailyPrice );
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }




        //private static void CategoryTest()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandsDal());
        //    foreach (var brand in brandManager.GetAll())
        //    {
        //        Console.WriteLine(brand.BrandName);
        //    }
        //}









    }
}