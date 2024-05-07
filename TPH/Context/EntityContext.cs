using Microsoft.EntityFrameworkCore;
using TPH.Entities;

namespace TPH.Context
{
    public class EntityContext : DbContext
    {
        public EntityContext(DbContextOptions<EntityContext> options ): base(options){
            
        }
        public DbSet<City> Cities { get; set; }
        public DbSet<PointOfInterest> PointOfInterest { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>();//.HasMany(x=>x.PointOfInterest).;
            modelBuilder.Entity<PointOfInterest>() 
                .HasOne(p => p.City)
                .WithMany(x => x.PointOfInterest)
                .HasForeignKey(x => x.CityId);
            
        }
    }
}
