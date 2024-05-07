using Microsoft.EntityFrameworkCore;

namespace TPH.Entities;

public class Initializer : IInitializer
{
    void OnModelCreate(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<City>();
        modelBuilder.Entity<PointOfInterest>(x =>
        {
            x.HasOne(p => p.City).WithMany(x => x.PointOfInterest).HasForeignKey(x => x.CityId);
        });
    }
}