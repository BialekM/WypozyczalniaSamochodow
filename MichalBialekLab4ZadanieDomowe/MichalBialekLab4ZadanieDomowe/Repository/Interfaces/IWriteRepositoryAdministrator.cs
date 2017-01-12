using MichalBialekLab4ZadanieDomowe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichalBialekLab4ZadanieDomowe.Repository
{
    public interface IWriteRepositoryAdministrator<T> where T : Human
    {
        void Create(T entity);
        void Delete(T entity);
        void Edit(T old, T current);
    }
}
