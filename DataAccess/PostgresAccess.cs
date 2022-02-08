using Microsoft.EntityFrameworkCore;
using GardenTracker.Model;


namespace GardenTracker.DataAccess
{
    public class PostgresAccess
    {
        public PostgresAccess(DbContextOptions<PostgresAccess> options) : base(options)
        {
        }

        public DbSet<Garden> patients { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
    }
}
