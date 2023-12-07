using Microsoft.EntityFrameworkCore;
using SiteManagementApi.DatabaseContext.Entities;

namespace SiteManagementApi.DatabaseContext.Context
{
    public class SSOContext: DbContext
    {
        public SSOContext(DbContextOptions<SSOContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
        }
    }
}
