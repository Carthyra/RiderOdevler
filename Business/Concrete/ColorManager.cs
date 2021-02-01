using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;


namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _ColorDal;

        public ColorManager(IColorDal colorDal)
        {
            _ColorDal = colorDal;
        }

        public List<Color> GetAll()
        {
            return _ColorDal.GetAll();
        }

        public void Add(Color color)
        {
            _ColorDal.Add(color);
        }

        public void Delete(Color color)
        {
            _ColorDal.Delete(color);
        }

        public void Update(Color color)
        {
            _ColorDal.Update(color);
        }
    }
}