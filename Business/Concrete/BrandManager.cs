using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandsDal _brandDal;
        public BrandManager(IBrandsDal brandsDal)
        {
            _brandDal = brandsDal;
        }
        
        public void Add(Brand brand)
        {
            if (brand.BrandName.Length > 2)
            {
                _brandDal.Add(brand);
                Console.WriteLine("Marka eklendi");
            }
            else
            {
                Console.WriteLine("Marka eklenemedi marka uzunluğu 2 karakterden uzun olmalıde");
            }

            
        }

        public void Deleted(Brand brand)
        {
            _brandDal.Delete(brand);
            Console.WriteLine("Marka silindi !");
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public List<Brand> GetCarsByBrandId(int id)
        {
            return _brandDal.GetAll(b => b.BrandId == id);
        }

        public void Updated(Brand brand)
        {
            if (brand.BrandName.Length >= 2)
            {
                _brandDal.Update(brand);
                Console.WriteLine("Marka güncellendi");
            }

            else
            {
                Console.WriteLine("Marka güncellenemedi , lütfen  marka uzunlugunu 2 ve daha uzun karakterlerden olusturunuz");
            }
          
           
        }
    }
}
