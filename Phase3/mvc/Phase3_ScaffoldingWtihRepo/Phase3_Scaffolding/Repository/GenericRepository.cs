using Microsoft.EntityFrameworkCore;
using Phase3_Scaffolding.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phase3_Scaffolding.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private SchoolContext db = null;
        private DbSet<T> table = null;
        public GenericRepository()
        {
            this.db = new SchoolContext();
            table = db.Set<T>();
        }
        public GenericRepository(SchoolContext db)
        {
            this.db = db;
            table = db.Set<T>();
        }
        public IEnumerable<T> SelectAll()
        {
            return table.ToList();
        }
        public T SelectByID(object id)
        {
            return table.Find(id);
        }
        public void Insert(T obj)
        {
            table.Add(obj);
        }
        public void Update(T obj)
        {
            table.Attach(obj);
            db.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }

}
