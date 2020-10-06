using System;
using Microsoft.EntityFrameworkCore;
using Restaurants.DataAccess.Entities;

namespace Restaurants.DataAccess.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Tenant> Tenants { get; set; }
    }
}
