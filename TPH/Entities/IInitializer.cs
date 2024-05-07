using Microsoft.EntityFrameworkCore;

namespace TPH.Entities
{
    public interface IInitializer
    {
        void OnModelCreate(ModelBuilder modelBuilder) { }
    }
}
