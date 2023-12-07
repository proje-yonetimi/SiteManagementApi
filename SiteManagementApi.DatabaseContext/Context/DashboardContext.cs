using Microsoft.EntityFrameworkCore;
using SiteManagementApi.DatabaseContext.Entities;

namespace SiteManagementApi.Data.Context
{
    public class DashboardContext: DbContext
    {
        public DashboardContext(DbContextOptions<DashboardContext> options): base(options) { }
        public DbSet<MenuItem> MenuItem { get; set; }
        public DbSet<MenuItemHierarchy> MenuItemHierarchy { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MenuItemEntityConfiguration());
            modelBuilder.ApplyConfiguration(new MenuItemHierEntityConfiguration());
        }
    }
}
