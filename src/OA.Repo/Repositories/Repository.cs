using Microsoft.EntityFrameworkCore;
using OA.Data.Entities;
using OA.Repo.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.Repo.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationContext context;
        private DbSet<T> entities;
        string errorMessage = string.Empty;

        public Repository(ApplicationContext context)
        {
            this.context = context;
            this.entities = context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return this.entities.AsEnumerable();
        }
        
        public T Get(long id)
        {
            return this.entities.SingleOrDefault(s => s.Id == id);
        }
        
        public void Insert(T entity)
        {
            if(entity == null)
            {
                throw new AggregateException("entity");
            }

            this.entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new AggregateException("entity");
            }
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            if(entity == null)
            {
                throw new AggregateException("entity");
            }
            this.entities.Remove(entity);
            context.SaveChanges();
        }       

        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new AggregateException("entity");
            }
            this.entities.Remove(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

    }
}
