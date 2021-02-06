using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        void Add(Color color);
        void Deleted(Color color);
        void Update(Color color);
        List<Color> GetAll();
        List<Color> GetCarsByColorsId(int id);
    }
}
