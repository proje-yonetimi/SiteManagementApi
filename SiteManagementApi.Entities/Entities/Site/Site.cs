using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SiteManagementApi.Entities.Entities.Site
{
    public class Site
    {
        public int Id { get; set; }
        // Site id. uniqueidentifier olacak
        public Guid SiteId { get; set; }
        // Site adı
        public string? Name { get; set; }
        // Yönetici id. person tablosunda yönetici tipindeki eleman ile eşleşir.
        public int ManagerId { get; set; }
        // Site adresi
        public Guid AddressId { get; set; }
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
    public class SiteEntityConfiguration : IEntityTypeConfiguration<Site>
    {
        public void Configure(EntityTypeBuilder<Site> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.SiteId).HasColumnType("uniqueidentifier");
            builder.Property(x=>x.Name).HasColumnType("varchar(100)");
            builder.Property(x => x.ManagerId).HasColumnType("int");
            builder.Property(x => x.AddressId).HasColumnType("uniqueidentifier");
            builder.Property(x => x.IsActive).HasColumnType("bit");
            builder.Property(x => x.CreatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.CreatedDate).HasColumnType("datetime");
            builder.Property(x => x.UpdatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.UpdatedDate).HasColumnType("datetime");

        }
    }
}
