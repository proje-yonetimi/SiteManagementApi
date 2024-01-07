using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SiteManagementApi.Entities.Entities.Site
{
    public class EmployeeBankInfo
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string? Bank { get; set; }
        public string? AccountNumber { get; set; }
        public string? IBAN { get; set; }
    }
    public class EmployeeBankInfoEntityConfiguration : IEntityTypeConfiguration<EmployeeBankInfo>
    {
        public void Configure(EntityTypeBuilder<EmployeeBankInfo> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.EmployeeId).HasColumnType("int");
            builder.Property(x => x.Bank).HasColumnType("varchar(50)");
            builder.Property(x => x.AccountNumber).HasColumnType("varchar(20)");
            builder.Property(x => x.IBAN).HasColumnType("varchar(30)");
            builder.HasIndex(e => e.EmployeeId);
        }
    }
}
