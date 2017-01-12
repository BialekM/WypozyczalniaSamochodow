using MichalBialekLab4ZadanieDomowe.Models;
using MichalBialekLab4ZadanieDomowe.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichalBialekLab4ZadanieDomowe.Repository
{
    class ReadRepositoryAdministrator<T> : IReadRepositoryAdministrator<T> where T : Administrator
    {
        private readonly MichalBialekDbContext _context;

        public ReadRepositoryAdministrator(MichalBialekDbContext context)
        {
            _context = context;
        }

        public IList<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public IList<T> GetById(int id)
        {
            return _context.Set<T>().Where(x => x.Id == id).ToList();
        }

        public IList<T> GetByLogin(string login)
        {
            return _context.Set<T>().Where(x => x.Login == login).ToList();
        }

        public IList<T> GetByLogin(string login, string password)
        {
            return _context.Set<T>().Where(x => x.Login == login && x.Password == password).ToList();
        }

        public IList<T> GetByPesel(long pesel)
        {
            return _context.Set<T>().Where(x => x.Pesel == pesel).ToList();
        }

        public IList<T> GetBySurname(string surname)
        {
            return _context.Set<T>().Where(x => x.Surname == surname).ToList();
        }

        public IList<T> GetByName(string name)
        {
            return _context.Set<T>().Where(x => x.Name == name).ToList();
        }
    }
}
