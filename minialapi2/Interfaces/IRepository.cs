using System;
using Microsoft.EntityFrameworkCore;

namespace minialapi2.Interfaces
{
    public interface IEntity<ID> where ID :struct
    {
         ID Id { get; set; }
    }
    public interface IRepository<T,ID> where T : class, new() where ID:  struct
    {
        Task<T> Create(T t);
        Task<T> Update(ID id,T t);
        Task Delete(ID id);
        Task<List<T>> getAll();

    }

    public class Repository<T, ID> : IRepository<T, ID> where T : class,IEntity<ID>, new() where ID : struct
    {
        private readonly DbContext dbContext;
        private DbSet<T> entities;
        public Repository(DbContext dbContext)
        {
            entities = dbContext.Set<T>();
            this.dbContext = dbContext;
        }

        public async Task<T> Create(T t)
        {
            await entities.AddAsync(t);
           await  dbContext.SaveChangesAsync();
            return t;
        }

        public async Task Delete(ID id)
        {
            var entity =await entities.FindAsync(id);
            if (entity == null)
            {
                throw new InvalidDataException("invalid id");
            }
             entities.Remove(entity);
            await dbContext.SaveChangesAsync();
        }

        public Task<List<T>> getAll()
        {
            return entities.ToListAsync();
        }

        public Task<T> Update(ID id, T t)
        {
            throw new NotImplementedException();
        }
    }
}

