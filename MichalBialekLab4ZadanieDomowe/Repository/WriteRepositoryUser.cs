using MichalBialekLab4ZadanieDomowe.Models;
using MichalBialekLab4ZadanieDomowe.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichalBialekLab4ZadanieDomowe.Repository
{
    public class WriteRepositoryUser<T> : IWriteRepositoryUser<T> where T : User
    {
        private readonly MichalBialekDbContext _context;

        public WriteRepositoryUser(MichalBialekDbContext context)
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

        public void Edit(T entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(T original,T current)
        {
            _context.Entry<T>(original).CurrentValues.SetValues(current);
            _context.SaveChanges();
        }
    }
}
