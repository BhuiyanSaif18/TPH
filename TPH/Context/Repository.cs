using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace TPH.Context
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DbContext Context { get; }
        protected DbSet<T> DbSet { get; }
        public Repository(DbContext context)
        {
            Context = context;
            DbSet = Context.Set<T>();
        }
        public ValueTask<EntityEntry<T>> Add(T entity)
        {
            return DbSet.AddAsync(entity);
        }

        public Task<int> SaveChanges()
        {
            return Context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            DbSet.Update(entity);
        }

        public void Remove(T entity)
        {
            DbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            DbSet.RemoveRange(entities);
        }
    }
}
