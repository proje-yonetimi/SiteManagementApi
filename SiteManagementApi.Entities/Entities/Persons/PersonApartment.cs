using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SiteManagementApi.Entities.Entities.Persons
{
    public class PersonApartment
    {
        public int Id { get; set; }
        public int? PersonId { get; set; }
        // Apartman id
        public Guid ApartmentId { get; set; }
        // kat maliki/kiracı
        public int? Ownership { get; set; }
        // giriş tarihi
        public DateTime? EntryDate { get; set; }
        // çıkış tarihi ilk kayıtta boş olacak.
        public DateTime? QuitDate { get; set; }
        // ilişkili kişi
        public string? RelatedPerson { get; set; }
        //açıklama
        public string? Description { get; set; }
        // banka ödeme kodu
        public string? BankPaymentCode { get; set; }
        public string? CreatedUserName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedUserName { get; set; }
        public DateTime? UpdatedDate { get; set; }

    }
    public class PersonApartmentEntityConfiguration : IEntityTypeConfiguration<PersonApartment>
    {
        public void Configure(EntityTypeBuilder<PersonApartment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.PersonId).HasColumnType("int");
            builder.Property(x => x.ApartmentId).HasColumnType("uniqueidentifier");
            builder.Property(x=>x.Ownership).HasColumnType("int");
            builder.Property(x => x.EntryDate).HasColumnType("datetime");
            builder.Property(x => x.QuitDate).HasColumnType("datetime");
            builder.Property(x => x.RelatedPerson).HasColumnType("varchar(50)");
            builder.Property(x => x.Description).HasColumnType("varchar(2000)");
            builder.Property(x => x.BankPaymentCode).HasColumnType("varchar(100)");
            builder.Property(x => x.CreatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.CreatedDate).HasColumnType("datetime");
            builder.Property(x => x.UpdatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.UpdatedDate).HasColumnType("datetime");
        }
    }
}