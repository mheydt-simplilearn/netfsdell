using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phase3_Scaffolding.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> SelectAll();
        T SelectByID(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
    }

}
