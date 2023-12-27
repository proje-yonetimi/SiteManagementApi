using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace SiteManagementApi.Entities.Entities.Site
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int PersonId { get; set; }
        // şirket
        public string? Company { get; set; }
        // Görevi
        public string? Position { get; set; }
        // yemek kartı
        public string? MealCard { get; set; }
        // açıklama
        public string? Description { get; set; }
    }
    public class EmployeeEntityConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.EmployeeId);
            builder.Property(e => e.PersonId).HasColumnType("int");
            builder.Property(e => e.Company).HasColumnType("varchar(30)");
            builder.Property(e => e.Position).HasColumnType("varchar(30)");
            builder.Property(e => e.MealCard).HasColumnType("varchar(30)");
            builder.Property(e => e.Description).HasColumnType("varchar(2000)");
            builder.HasIndex(e => e.EmployeeId);
            builder.HasIndex(e => e.PersonId);

        }
    }
}
