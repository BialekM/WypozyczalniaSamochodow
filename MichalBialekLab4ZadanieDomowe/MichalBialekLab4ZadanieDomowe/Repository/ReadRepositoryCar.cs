using MichalBialekLab4ZadanieDomowe.Models;
using MichalBialekLab4ZadanieDomowe.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MichalBialekLab4ZadanieDomowe.Repository
{
    public class ReadRepositoryCar<T> : IReadRepositoryCar<T> where T : Car
    {
        private readonly MichalBialekDbContext _context;

        public ReadRepositoryCar(MichalBialekDbContext context)
        {
            _context = context;
        }

        public IList<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public IList<T> GetByAvailable()
        {
            return _context.Set<T>().Where(x => x.available).ToList();
        }

        public IList<T> GetByModel(string model)
        {
            return _context.Set<T>().Where(x => x.Model == model).ToList();
        }

        public IList<T> GetByBrand(string brand)
        {
            return _context.Set<T>().Where(x => x.Brand == brand).ToList();
        }

        public IList<T> GetByYear(int beginYear, int endYear)
        {
            return _context.Set<T>().Where(x => x.Year >= beginYear && x.Year <= endYear).ToList();
        }

        public IList<T> GetById(int id)
        {
            return _context.Set<T>().Where(x => x.id == id).ToList();
        }

        public IList<T> GetByFuel(bool pb,bool diesel)
        {
            if(pb==true && diesel == true)
            {
                return _context.Set<T>().Where(x => x.Fuel == "benzyna" || x.Fuel == "diesel").ToList();
            }else if(pb == true)
            {
                return _context.Set<T>().Where(x => x.Fuel == "benzyna").ToList();
            }else if(diesel==true)
            {
                return _context.Set<T>().Where(x => x.Fuel == "diesel").ToList();
            }
            return _context.Set<T>().ToList();          
        }
    }
}
