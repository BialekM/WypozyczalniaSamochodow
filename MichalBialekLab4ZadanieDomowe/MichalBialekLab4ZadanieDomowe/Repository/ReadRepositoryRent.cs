using MichalBialekLab4ZadanieDomowe.Models;
using MichalBialekLab4ZadanieDomowe.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichalBialekLab4ZadanieDomowe.Repository
{
    class ReadRepositoryRent<T> : IReadRepositoryRent<T> where T : Rent
    {
        private readonly MichalBialekDbContext _context;

        public ReadRepositoryRent(MichalBialekDbContext context)
        {
            _context = context;
        }

        public IList<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public IList<T> GetById(int id)
        {
            return _context.Set<T>().Where(x => x.RentId == id).ToList();
        }

        public IList<T> GetByBiggerDateOfHire(DateTime dataStart)
        {
            return _context.Set<T>().Where(x => x.DateOfHire >= dataStart).ToList();
        }

        public IList<T> GetBySmallerDateOEnd(DateTime dataEnd)
        {
            return _context.Set<T>().Where(x => x.DateOfEnd <= dataEnd).ToList();
        }

        public IList<T> GetByBetweenDateOfHireAndDateOEnd(DateTime dataStart ,DateTime dataEnd)
        {
            return _context.Set<T>().Where(x => x.DateOfHire >= dataStart && x.DateOfEnd<= dataEnd).ToList();
        }
    }
}
