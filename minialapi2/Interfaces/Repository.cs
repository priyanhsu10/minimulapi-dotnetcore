using Microsoft.EntityFrameworkCore;

namespace minialapi2.Interfaces
{
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

        public async Task<T> Update(T t)
        {
            entities.Attach(t);
            dbContext.Entry(t).State = EntityState.Modified;
           await dbContext.SaveChangesAsync();
            return t;

        }
    }
}

