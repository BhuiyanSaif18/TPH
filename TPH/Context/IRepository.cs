using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace TPH.Context
{
    public interface IRepository<T> where T : class
    {
        ValueTask<EntityEntry<T>> Add(T entity);
        Task<int> SaveChanges();
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
