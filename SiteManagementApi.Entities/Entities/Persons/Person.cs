using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SiteManagementApi.Entities.Entities
{
    public class Person
    {
        // PK id
        public int PersonId { get; set; }
        // kişi tipi (kiracı/ev sahibi/ yönetici/ personel)
        public int? PersonType { get; set; }
        // Kişi adı
        public string? FirstName { get; set; }
        // Kişi soyadı
        public string? LastName { get; set; }
        // Kişi tam adı
        public string? FullName { get; set; }
        // Kişi kimlik bilgileri detay tablosu ile eşleşir.
        public Guid? IdentityInformationId { get; set; }
        // Kişi iletişim id'si. İletişim tablosunda CommunicationId ile eşlenir.
        public Guid? CommunicationId { get; set; }
        // Kişi adres id'si. Adres tablosunda AddressId ile eşlenir
        public Guid? AddressId { get; set; }
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
    public class PersonEntityConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(x => x.PersonId);
            builder.Property(x => x.PersonType).HasColumnType("int");
            builder.Property(x => x.FirstName).HasColumnType("varchar(30)");
            builder.Property(x => x.LastName).HasColumnType("varchar(30)");
            builder.Property(x => x.FullName).HasColumnType("varchar(60)");
            builder.Property(x => x.IdentityInformationId).HasColumnType("uniqueidentifier");
            builder.Property(x => x.CommunicationId).HasColumnType("uniqueidentifier");
            builder.Property(x => x.AddressId).HasColumnType("uniqueidentifier");
            builder.Property(x => x.IsActive).HasColumnType("bit");
            builder.Property(x => x.CreatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.CreatedDate).HasColumnType("datetime");
            builder.Property(x => x.UpdatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.UpdatedDate).HasColumnType("datetime");
        }
    }
}