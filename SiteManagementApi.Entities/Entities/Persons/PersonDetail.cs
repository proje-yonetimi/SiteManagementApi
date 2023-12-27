using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace SiteManagementApi.Entities.Entities
{
    public class PersonDetail
    {
        public int Id { get; set; }
        // Kişi id. Person tablosu ile bağlanır
        public int? PersonId { get; set; }
        // Cinsiyet
        public char? Gender { get; set; }
        // Eğitim durum Id. cor.Parameters tablosu groupcode ile eşleşir.
        public int? EducationType { get; set; }
        // Mesleki durum Id. cor.Parameters tablosu groupcode ile eşleşir.
        public int? JobDescriptionId { get; set; }
        // Kart no
        public string? CardNumber { get; set; }
        // Özel sigorta var mı?
        public bool? PrivateInsurance { get; set; }
        // Şehit/Gazi yakını
        public bool? MartyrVeteranRelative { get; set; }
        // Evcil hayvan tipi
        public int? PetType { get; set; }
        // Kişi açıklaması
        public string? Description { get; set; }
    }
    public class PersonDetailEntityConfiguration : IEntityTypeConfiguration<PersonDetail>
    {
        public void Configure(EntityTypeBuilder<PersonDetail> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.PersonId).HasColumnType("int");
            builder.Property(x => x.Gender).HasColumnType("char(1)");
            builder.Property(x => x.EducationType).HasColumnType("int");
            builder.Property(x => x.JobDescriptionId).HasColumnType("int");
            builder.Property(x => x.CardNumber).HasColumnType("varchar(30)");
            builder.Property(x => x.PrivateInsurance).HasColumnType("bit");
            builder.Property(x => x.MartyrVeteranRelative).HasColumnType("bit");
            builder.Property(x => x.PetType).HasColumnType("int");
            builder.Property(x => x.Description).HasColumnType("varchar(2000)");
            builder.HasIndex(e => e.Id);
            builder.HasIndex(e => e.PersonId);
        }
    }
}
