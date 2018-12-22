using System;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AltSource.Entity.Context
{
    public class AltSourceContext : DbContext
    {

        public AltSourceContext(DbContextOptions<AltSourceContext> options)
            : base(options)
        {
        }

        public DbSet<Clothing> Clothing { get; set; }
        public DbSet<ClothingVendor> ClothingVendors { get; set; }
        public DbSet<ClothingRetail> ClothingRetails { get; set; }
        public DbSet<Vendor> Vendors { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API
            //modelBuilder.Entity<User>()
            //.Property(p => p.DecryptedPassword)
            //.HasComputedColumnSql("Uncrypt(p.PasswordText)");
        }

        public override int SaveChanges()
        {
            Audit();
            return base.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            Audit();
            return await base.SaveChangesAsync();
        }

        private void Audit()
        {
            var entries = ChangeTracker.Entries().Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));
            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                {
                    ((BaseEntity)entry.Entity).Created = DateTime.UtcNow;
                }
            ((BaseEntity)entry.Entity).Modified = DateTime.UtcNow;
            }
        }

    }
}
