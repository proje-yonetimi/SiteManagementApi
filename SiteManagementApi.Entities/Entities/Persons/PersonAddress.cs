using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace SiteManagementApi.Entities.Entities
{
    public class PersonAddress
    {
        public int Id { get; set; }
        public Guid? AddressId { get; set; }
        // Ülke kodu
        public string CountryCode { get; set; }
        // Şehir kodu
        public string CityCode { get; set; }
        // İlçe kodu
        public string DistrictCode { get; set; }
        // Mahalle
        public string Quarter { get; set; }
        // Açık adres
        public string Address { get; set; }
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
    public class PersonAddressEntityConfiguration : IEntityTypeConfiguration<PersonAddress>
    {
        public void Configure(EntityTypeBuilder<PersonAddress> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.AddressId).HasColumnType("uniqueidentifier");
            builder.Property(x => x.CountryCode).HasColumnType("varchar(10)");
            builder.Property(x => x.CityCode).HasColumnType("varchar(10)");
            builder.Property(x => x.DistrictCode).HasColumnType("varchar(10)");
            builder.Property(x => x.Quarter).HasColumnType("varchar(30)");
            builder.Property(x => x.Address).HasColumnType("varchar(100)");
            builder.Property(x => x.CreatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.CreatedDate).HasColumnType("datetime");
            builder.Property(x => x.UpdatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.UpdatedDate).HasColumnType("datetime");
        }
    }
}
