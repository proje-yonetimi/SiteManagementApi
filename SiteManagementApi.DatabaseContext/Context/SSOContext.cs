using Microsoft.EntityFrameworkCore;
using SiteManagementApi.Entities.Entities;

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
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("SSOUserDB"));
        }
    }
}
