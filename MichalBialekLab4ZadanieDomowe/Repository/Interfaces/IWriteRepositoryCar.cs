using MichalBialekLab4ZadanieDomowe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichalBialekLab4ZadanieDomowe.Repository.Interfaces
{
    public interface IWriteRepositoryCar<T> where T: Car
    {
        void Create(T entity);
        void Delete(T entity);
        void Edit(T oldCar, T newCar);
    }
}
