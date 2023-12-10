using Microsoft.EntityFrameworkCore;
using SiteManagementApi.DatabaseContext.Entities;

namespace SiteManagementApi.DatabaseContext.Context
{
    public class SSOContext: DbContext
    {
        public SSOContext() { }
        public SSOContext(DbContextOptions<SSOContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-7I14ODO; Initial Catalog=SSOUserDB;User Id=mensar;Password=123;TrustServerCertificate=True;");
        }
    }
}
