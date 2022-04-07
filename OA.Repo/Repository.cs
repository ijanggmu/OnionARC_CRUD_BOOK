using Microsoft.EntityFrameworkCore;
using OA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OA.Repo
{
    public class Repository<T>:IRepository<T> where T:BaseEntity
    {
        private readonly ApplicationContext _db;
        private DbSet<T> entities;
        public Repository(ApplicationContext db)
        {
            _db = db;
            entities = _db.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }
        public T Get(long id)
        {
            return entities.SingleOrDefault(s => s.Id == id);
        }
        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            _db.SaveChanges();
        }
        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");

            }
            //entities.Update(entity);
            _db.SaveChanges();
        }
        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");

            }
            entities.Remove(entity);
            _db.SaveChanges();
        }
        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");

            }
            entities.Remove(entity);
        }
        public void SaveChanges()
        {
            _db.SaveChanges();

        }

    }
}
