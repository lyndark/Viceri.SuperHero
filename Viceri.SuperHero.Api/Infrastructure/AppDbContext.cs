using Microsoft.EntityFrameworkCore;
using Viceri.SuperHero.Api.Entity;

namespace Viceri.SuperHero.Api.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Power> Powers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Hero>()
                .HasMany(h => h.Powers)
                .WithMany(p => p.Heroes)
                .UsingEntity(j => j.ToTable("HeroPowers"));

        }
    }
}
