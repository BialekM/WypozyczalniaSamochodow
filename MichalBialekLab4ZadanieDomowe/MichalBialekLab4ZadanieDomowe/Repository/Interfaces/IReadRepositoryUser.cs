using MichalBialekLab4ZadanieDomowe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichalBialekLab4ZadanieDomowe.Repository.Interfaces
{
    interface IReadRepositoryUser<T> where T : User
    {
        IList<T> GetAll();
        IList<T> GetById(int id);
        IList<T> GetBySurname(string surname);
        IList<T> GetByLogin(string login);
        IList<T> GetByPesel(long pesel);
        IList<T> GetByName(string name);
        IList<T> GetByLoginAndPassword(string login, string password);
    }
}
