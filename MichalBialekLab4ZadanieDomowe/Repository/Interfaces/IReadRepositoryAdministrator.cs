using MichalBialekLab4ZadanieDomowe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichalBialekLab4ZadanieDomowe.Repository.Interfaces
{
    public interface IReadRepositoryAdministrator<T> where T : Administrator
    {
        IList<T> GetAll();
        IList<T> GetById(int id);
        IList<T> GetByLogin(string login);
        IList<T> GetByLogin(string login, string password);
        IList<T> GetByPesel(int pesel);
        IList<T> GetBySurname(string surname);
        IList<T> GetByName(string name);

    }
}
