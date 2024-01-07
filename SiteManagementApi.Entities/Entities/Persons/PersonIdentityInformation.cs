using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace SiteManagementApi.Entities.Entities
{
    public class PersonIdentityInformation
    {
        // PK
        public int Id { get; set; }
        // Kişi id. Person tablosu ile bağlanır
        public Guid? IdentityInformationId { get; set; }
        // Kişi tckn
        public long? IdentityNumber { get; set; }
        //Pasaport no
        public long? PassportNumber { get; set; }
        // Kişi vergi no
        public long? TaxNumber { get; set; }
        // Uyruk bilgisi. cor.Parameter tablosundan çekilir.
        public string? Nationality { get; set; }
        // Kan grubu
        public string? BloodType { get; set; }
        // Kimlik seri no
        public string? SerialNumber { get; set; }
        // Kimlik sıra no
        public string? OrderNumber { get; set; }
        public string? FatherName { get; set; }
        public string? MotherName { get; set; }
        public string? BirthPlace{ get; set; }
        public DateTime? BirthDate { get; set; }
        // Medeni hali
        public int? MaritalStatus { get; set; }
        // Evlilik yılı
        public DateTime? MaritalDate { get; set;}
        public string? HomeTown { get; set; }
    }
    public class PersonIdentityInformationEntityConfiguration : IEntityTypeConfiguration<PersonIdentityInformation>
    {
        public void Configure(EntityTypeBuilder<PersonIdentityInformation> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IdentityInformationId).HasColumnType("uniqueidentifier");
            builder.Property(x => x.IdentityNumber).HasColumnType("bigint");
            builder.Property(x => x.PassportNumber).HasColumnType("bigint");
            builder.Property(x => x.TaxNumber).HasColumnType("bigint");
            builder.Property(x => x.Nationality).HasColumnType("varchar(10)");
            builder.Property(e => e.BloodType).HasColumnType("varchar(10)");
            builder.Property(x => x.SerialNumber).HasColumnType("varchar(30)");
            builder.Property(x => x.OrderNumber).HasColumnType("varchar(30)");
            builder.Property(x => x.FatherName).HasColumnType("varchar(30)");
            builder.Property(x => x.MotherName).HasColumnType("varchar(30)");
            builder.Property(x => x.BirthPlace).HasColumnType("varchar(30)");
            builder.Property(x => x.BirthDate).HasColumnType("datetime");
            builder.Property(x => x.MaritalStatus).HasColumnType("int");
            builder.Property(x => x.MaritalDate).HasColumnType("datetime");
            builder.Property(x => x.HomeTown).HasColumnType("varchar(30)");
            builder.HasIndex(e => e.Id);
            builder.HasIndex(e => e.IdentityInformationId);
        }
    }
}
