using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SiteManagementApi.Entities.Entities.Site
{
    //Daire
    public class Apartment
    {
        public int Id { get; set; }
        // Site id. siteler tablosunda hangi sitenin dairesi olduğu bilgisi için.
        public Guid? SiteId { get; set; }
        // Daire id
        public Guid? ApartmentId { get; set; }
        // Adres id
        public Guid? AddressId { get; set; }
        // Daire tipi (daire/villa)
        public int ApartmentType { get; set; }
        // Blok bina no
        public string? Block { get; set; }
        // Kapı no
        public string? DoorNumber { get; set; }
        // Oda sayısı
        public string? RoomCount { get; set; }
        //Brüt m2
        public decimal Gross { get; set; }
        // Net m2
        public decimal Net { get; set; }
        // Arsapayı
        public decimal LandShare { get; set; }
        // Kat numarası
        public int FloorNumber { get; set; }
        // Durum
        public int Statu { get; set; }
        // Aidat
        public decimal Dues { get; set; }
        // park yeri
        public string? ParkingSpaceNumber { get; set; }
        // Cephe
        public int Aspect { get; set; }
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
    public class ApartmentEntityConfiguration : IEntityTypeConfiguration<Apartment>
    {
        public void Configure(EntityTypeBuilder<Apartment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.SiteId).HasColumnType("uniqueidentifier");
            builder.Property(x => x.ApartmentId).HasColumnType("uniqueidentifier");
            builder.Property(x => x.ApartmentType).HasColumnType("int");
            builder.Property(x => x.Block).HasColumnType("varchar(30)");
            builder.Property(x => x.DoorNumber).HasColumnType("varchar(30)");
            builder.Property(x => x.RoomCount).HasColumnType("varchar(30)");
            builder.Property(x => x.Gross).HasColumnType("decimal(15,2)");
            builder.Property(x => x.Net).HasColumnType("decimal(15,2)");
            builder.Property(x => x.LandShare).HasColumnType("decimal(15,2)");
            builder.Property(x => x.FloorNumber).HasColumnType("int");
            builder.Property(x => x.Statu).HasColumnType("int");
            builder.Property(x => x.Dues).HasColumnType("decimal(15,2)");
            builder.Property(x => x.ParkingSpaceNumber).HasColumnType("varchar(30)");
            builder.Property(x => x.Aspect).HasColumnType("int");
            builder.Property(x => x.IsActive).HasColumnType("bit");
            builder.Property(x => x.CreatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.CreatedDate).HasColumnType("datetime");
            builder.Property(x => x.UpdatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.UpdatedDate).HasColumnType("datetime");
            builder.HasIndex(x => x.SiteId);
            builder.HasIndex(x => x.ApartmentId);

        }
    }
}
