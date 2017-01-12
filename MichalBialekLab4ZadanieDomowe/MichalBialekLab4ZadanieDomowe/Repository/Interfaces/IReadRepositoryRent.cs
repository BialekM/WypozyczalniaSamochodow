using MichalBialekLab4ZadanieDomowe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichalBialekLab4ZadanieDomowe.Repository.Interfaces
{
    interface IReadRepositoryRent<T> where T : Rent
    {
        IList<T> GetAll();
        IList<T> GetById(int id);
        IList<T> GetByBiggerDateOfHire(DateTime dataStart);
        IList<T> GetBySmallerDateOEnd(DateTime dataEnd);
        IList<T> GetByBetweenDateOfHireAndDateOEnd(DateTime dataStart, DateTime dataEnd);

    }
}

