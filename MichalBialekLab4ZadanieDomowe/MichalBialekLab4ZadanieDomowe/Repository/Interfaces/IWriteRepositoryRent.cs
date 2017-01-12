using MichalBialekLab4ZadanieDomowe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichalBialekLab4ZadanieDomowe.Repository.Interfaces
{
    public interface IWriteRepositoryRent<T> where T : Rent
    {
        void Create(T entity);
        void Delete(T entity);
        void Edit(T old, T current);
    }
}
