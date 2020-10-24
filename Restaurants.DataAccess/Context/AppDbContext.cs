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

            // enums to tables ef core: https://kudchikarsk.com/entity-framework-enum-code-first/
            // Configs enum tables not to auto add pk (Id)
            modelBuilder.Entity<TenantStatus>()
                .Property(s => s.Id)
                .ValueGeneratedNever();

            // Seed Data : Insert Enumeration Values
            // https://stackoverflow.com/questions/50375357/how-to-create-a-table-corresponding-to-enum-in-ef-core-code-first
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
