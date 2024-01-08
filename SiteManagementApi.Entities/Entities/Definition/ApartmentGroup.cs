using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SiteManagementApi.Entities.Entities.Definition
{
    public class ApartmentGroup
    {
        public int Id { get; set; }
        public string? GroupCode { get; set; }
        public string? GroupName { get; set; }
        // Aidat
        public decimal Dues { get; set; }
        // Aktif mi?
        public bool? IsActive { get; set; }
        // Oluşturan kullanıcı adı
        public string? CreatedUserName { get; set; }
        // Oluşturulan tarih
        public DateTime? CreatedDate { get; set; }
        // Son güncelleyen kullanıcı
        public string? UpdatedUserName { get; set; }
        // Son güncelleme tarihi
        public DateTime? UpdatedDate { get; set; }
    }
    public class ApartmentGroupEntityConfiguration : IEntityTypeConfiguration<ApartmentGroup>
    {
        public void Configure(EntityTypeBuilder<ApartmentGroup> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.GroupCode).HasColumnType("varchar(50)");
            builder.Property(x => x.GroupName).HasColumnType("varchar(50)");
            builder.Property(x => x.Dues).HasColumnType("decimal(15,2)");
            builder.Property(x => x.IsActive).HasColumnType("bit");
            builder.Property(x => x.CreatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.CreatedDate).HasColumnType("datetime");
            builder.Property(x => x.UpdatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.UpdatedDate).HasColumnType("datetime");
            builder.HasIndex(x => x.GroupCode);
        }
    }
}
