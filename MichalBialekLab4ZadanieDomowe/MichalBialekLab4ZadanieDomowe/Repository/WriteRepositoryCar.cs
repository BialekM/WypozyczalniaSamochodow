using MichalBialekLab4ZadanieDomowe.Models;
using MichalBialekLab4ZadanieDomowe.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichalBialekLab4ZadanieDomowe.Repository
{
    public class WriteRepositoryCar<T> : IWriteRepositoryCar<T> where T : Car
    {
        private readonly MichalBialekDbContext _context;

        public WriteRepositoryCar(MichalBialekDbContext context)
        {
            _context = context;
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public void Edit(T oldCar,T newCar)
        {
            _context.Entry<T>(oldCar).CurrentValues.SetValues(newCar);
            _context.SaveChanges();
        }
    }
}
