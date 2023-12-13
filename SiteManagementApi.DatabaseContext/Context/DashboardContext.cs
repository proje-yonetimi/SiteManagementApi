using Microsoft.EntityFrameworkCore;
using SiteManagementApi.Entities.Entities;

namespace SiteManagementApi.Data.Context
{
    public class DashboardContext: DbContext
    {
        public DashboardContext() { }
        public DashboardContext(DbContextOptions<DashboardContext> options): base(options) { }
        public DbSet<MenuItem> MenuItem { get; set; }
        public DbSet<MenuItemHierarchy> MenuItemHierarchy { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<PersonDetail> PersonDetails { get; set; }
        public DbSet<PersonCommunication> PersonCommunications { get; set; }
        public DbSet<PersonAddress> PersonAddresses { get; set; }
        public DbSet<PersonIdentityInformation> PersonIdentityInformations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MenuItemEntityConfiguration());
            modelBuilder.ApplyConfiguration(new MenuItemHierEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PersonEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PersonDetailEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PersonCommunicationEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PersonAddressEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PersonIdentityInformationEntityConfiguration());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DashboardDB"));
        }
    }
}
