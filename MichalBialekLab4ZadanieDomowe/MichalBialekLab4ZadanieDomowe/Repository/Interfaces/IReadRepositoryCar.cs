using MichalBialekLab4ZadanieDomowe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichalBialekLab4ZadanieDomowe.Repository.Interfaces
{
    public interface IReadRepositoryCar<T> where T : Car
    {
        IList<T> GetAll();
        IList<T> GetByAvailable();
        IList<T> GetByModel(string model);
        IList<T> GetByBrand(string brand);
        IList<T> GetByYear(int beginYear, int endYear);
        IList<T> GetByFuel(bool pb, bool diesel);
        IList<T> GetById(int id);
    }
}
