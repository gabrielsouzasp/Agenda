using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T obj);
        IList<T> Get();
        T Get(int id);
        void Update(T obj);
        void Delete(T obj);
    }
}
