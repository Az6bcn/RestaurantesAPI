using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Restaurants.Commons.Enumerations;
using Restaurants.DataAccess.Entities;

namespace Restaurants.DataAccess.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<TenantStatus> tenantStatuses { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        public AppDbContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TenantStatus>()
                .Property(s => s.Id)
                .ValueGeneratedNever();

            modelBuilder.Entity<TenantStatus>()
                .HasData(Enum.GetValues(typeof(TenantStatusEnum))
                    .OfType<TenantStatusEnum>()
                    .Select(x => new TenantStatus
                    {
                        Id = x,
                        Name = x.ToString()
                    }));
        }

    }
}
