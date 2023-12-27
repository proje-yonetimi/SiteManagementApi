using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SiteManagementApi.Entities.Entities.Definitions
{
    public class ApartmentType
    {
        public int Id { get; set; }
        public string? GroupCode { get; set; }
        // Daire tipi kodu
        public string? TypeCode { get; set; }
        // Daire tipi adı
        public string? TypeName { get; set; }
        // Daire tipi açıklaması
        public string? Description { get; set; }
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
    public class ApartmentTypeEntityConfiguration : IEntityTypeConfiguration<ApartmentType>
    {
        public void Configure(EntityTypeBuilder<ApartmentType> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.GroupCode).HasColumnType("varchar(50)");
            builder.Property(x => x.TypeCode).HasColumnType("varchar(50)");
            builder.Property(x => x.TypeName).HasColumnType("varchar(50)");
            builder.Property(x => x.Description).HasColumnType("varchar(300)");
            builder.Property(x => x.Dues).HasColumnType("decimal(15,2)");
            builder.Property(x => x.IsActive).HasColumnType("bit");
            builder.Property(x => x.CreatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.CreatedDate).HasColumnType("datetime");
            builder.Property(x => x.UpdatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.UpdatedDate).HasColumnType("datetime");

            builder.HasIndex(x => x.GroupCode);
            builder.HasIndex(x => x.TypeCode);
        }
    }
}
