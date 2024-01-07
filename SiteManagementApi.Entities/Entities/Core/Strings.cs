using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SiteManagementApi.Entities.Entities.Core
{
    public class Strings
    {
        public int Id { get; set; }
        public string? StringCode { get; set; }
        public string? StringValue { get; set; }
        public bool? IsActive { get; set; }
        public string? CreatedUserName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedUserName { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
    public class StringEntityConfiguration : IEntityTypeConfiguration<Strings>
    {
        public void Configure(EntityTypeBuilder<Strings> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.StringCode).HasColumnType("varchar(50)");
            builder.Property(x => x.StringValue).HasColumnType("varchar(50)");

            builder.Property(x => x.IsActive).HasColumnType("bit");
            builder.Property(x => x.CreatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.CreatedDate).HasColumnType("datetime");
            builder.Property(x => x.UpdatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.UpdatedDate).HasColumnType("datetime");

            builder.HasIndex(x => x.StringCode);
        }
    }
}
