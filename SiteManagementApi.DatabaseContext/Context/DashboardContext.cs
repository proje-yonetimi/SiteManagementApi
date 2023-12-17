using Microsoft.EntityFrameworkCore;
using SiteManagementApi.Entities.Entities;
using SiteManagementApi.Entities.Entities.Core;
using SiteManagementApi.Entities.Entities.Menu;
using SiteManagementApi.Entities.Entities.Persons;
using SiteManagementApi.Entities.Entities.Site;

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
        public DbSet<PersonVehicle> PersonVehicles { get; set; }
        public DbSet<PersonApartment> PersonApartments { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeBankInfo> EmployeesBankInfo { get; set; }
        public DbSet<JobToDo> JobToDo { get; set; }
        public DbSet<Meeting> Meeting { get; set; }
        public DbSet<WaitingApprovePerson> WaitingApprove { get; set; }
        public DbSet<Parameter> Parameters_Tbl { get; set; }
        public DbSet<LogError> LogErrors { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MenuItemEntityConfiguration());
            modelBuilder.ApplyConfiguration(new MenuItemHierEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PersonEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PersonDetailEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PersonCommunicationEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PersonAddressEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PersonIdentityInformationEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PersonVehicleEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PersonApartmentEntityConfiguration());
            modelBuilder.ApplyConfiguration(new SiteEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ApartmentEntityConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeEntityConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeBankInfoEntityConfiguration());
            modelBuilder.ApplyConfiguration(new JobToDoEntityConfiguration());
            modelBuilder.ApplyConfiguration(new MeetingEntityConfiguration());
            modelBuilder.ApplyConfiguration(new WaitingApproveEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ParameterEntityConfiguration());
            modelBuilder.ApplyConfiguration(new LogErrorEntityConfiguration());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DashboardDB"));
        }
    }
}
