using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Abstraction;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepositoryPattern.EF
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private DbContext dbContext;

        public Repository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Create(T item)
        {
            dbContext.Set<T>().Add(item);
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            T currentItemToDelete = await GetById(id);
            dbContext.Set<T>().Remove(currentItemToDelete);
            await dbContext.SaveChangesAsync();
        }

        public async Task<IList<T>> GetAll()
        {
            IList<T> items = await dbContext.Set<T>().ToListAsync();

            return items;
        }

        public async Task<T> GetById(int id)
        {
            return await dbContext.Set<T>().FindAsync(id);
        }

        public async Task Update(T item)
        {
            dbContext.Set<T>().Update(item);
            await dbContext.SaveChangesAsync();
        }
    }


    public abstract class RepositoryAbstractClass<T> : IRepository<T> where T : class
    {
        private DbContext dbContext;

        public RepositoryAbstractClass(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public virtual async Task Create(T item)
        {
            dbContext.Set<T>().Add(item); //Legen wir ein Movie OBjekt ab und markieren das dieses Objekt hinzugefügt werden soll 
            await dbContext.SaveChangesAsync(); //Sende SQL und setzte das Einfügen um 
        }

        public virtual async Task Delete(int id)
        {
            T currentItemToDelete = await GetById(id);
            dbContext.Set<T>().Remove(currentItemToDelete);
            await dbContext.SaveChangesAsync();
        }

        public virtual async Task<IList<T>> GetAll()
        {
            IList<T> items = await dbContext.Set<T>().ToListAsync();

            return items;
        }

        public virtual async Task<T> GetById(int id)
        {
            return await dbContext.Set<T>().FindAsync(id);
        }

        public virtual async Task Update(T item)
        {
            dbContext.Set<T>().Update(item);
            await dbContext.SaveChangesAsync();
        }
    }
}
