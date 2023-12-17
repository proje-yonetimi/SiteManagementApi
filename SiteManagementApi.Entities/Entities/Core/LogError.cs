using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SiteManagementApi.Entities.Entities.Core
{
    public class LogError
    {
        public int Id { get; set; }
        public string? ErrorMessage { get; set; }
        public string? ErrorMethod { get; set; }
        public DateTime? ErrorTime { get; set; }
        public string? UserCode { get; set; }
    }
    public class LogErrorEntityConfiguration : IEntityTypeConfiguration<LogError>
    {
        public void Configure(EntityTypeBuilder<LogError> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ErrorMessage).HasColumnType("varchar(350)");
            builder.Property(x => x.ErrorMethod).HasColumnType("varchar(250)");
            builder.Property(x => x.ErrorTime).HasColumnType("datetime");
            builder.Property(x => x.UserCode).HasColumnType("varchar(50)");

        }
    }
}
