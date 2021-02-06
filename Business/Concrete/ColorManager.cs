using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorsDal _colorDal;
        public ColorManager(IColorsDal colorsDal)
        {
            _colorDal = colorsDal;
        }



        public void Add(Color color)
        {
            if (color.ColorName.Length > 3)
            {
                _colorDal.Add(color);
                Console.WriteLine("Renk basarıyla eklendi");
            }
            else
            {
                Console.WriteLine("Renk eklenemedi, renk ismi 3 karakterden az olamaz.");
            }
        }

        public void Deleted(Color color)
        {
            _colorDal.Delete(color);
            Console.WriteLine("Renk silindi");
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public List<Color> GetCarsByColorsId(int id)
        {
            return _colorDal.GetAll(c => c.ColorId == id);
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
            Console.WriteLine("Renk bilgisini güncellediniz");
        }
    }
}
