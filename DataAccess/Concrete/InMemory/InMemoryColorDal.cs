using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryColorDal:IColorDal
    {
        List<Color> _colors;

        public InMemoryColorDal()
        {
            _colors = new List<Color>
            {
                new Color {ColorId = 1, ColorName = "Kırmızı"},
                new Color {ColorId = 2, ColorName = "Beyaz"},
                new Color {ColorId = 3, ColorName = "Mavi"},
                new Color {ColorId = 4, ColorName = "Füme"},
                new Color {ColorId = 5, ColorName = "Siyah"},
            };
        }
        public List<Color> GetAll()
        {
            return _colors;
        }

        public void Add(Color color)
        {
            _colors.Add(color);
        }

        public void Delete(Color color)
        {
            Color colorToDelete = _colors.SingleOrDefault(c => c.ColorId == color.ColorId);
            _colors.Remove(colorToDelete);
        }

        public void Update(Color color)
        {
            Color colorToUpdate = _colors.SingleOrDefault(c => c.ColorId == color.ColorId);
            colorToUpdate.ColorName = color.ColorName;
        }
    }
}