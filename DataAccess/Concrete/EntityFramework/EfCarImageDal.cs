﻿using Core.DataAccess.EntityFrameworkk;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarImageDal : EfEntityRepositoryBase<CarImage, MyFinalProjectContext>, ICarImagesDal
    {

    }
}