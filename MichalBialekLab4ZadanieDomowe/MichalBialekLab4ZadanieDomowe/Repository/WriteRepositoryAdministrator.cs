using MichalBialekLab4ZadanieDomowe;
using MichalBialekLab4ZadanieDomowe.Models;
using MichalBialekLab4ZadanieDomowe.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichalBialekLab4ZadanieDomowe.Repository
{
    public class WriteRepositoryAdministrator<T> : IWriteRepositoryAdministrator<T> where T : Human
    {
        private readonly MichalBialekDbContext _context;

        public WriteRepositoryAdministrator(MichalBialekDbContext context)
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

        public void Edit(T old, T current)
        {
            _context.Entry<T>(old).CurrentValues.SetValues(current);
            _context.SaveChanges();
        }
    }
}
