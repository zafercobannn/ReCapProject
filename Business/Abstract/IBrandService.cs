using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        void Add(Brand brand);
        void Deleted(Brand brand);
        void Updated(Brand brand);
        List<Brand> GetAll();
        List<Brand> GetCarsByBrandId(int id);
    }
}
