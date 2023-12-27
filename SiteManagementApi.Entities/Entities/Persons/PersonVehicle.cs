using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SiteManagementApi.Entities.Entities.Persons
{
    public class PersonVehicle
    {
        public int Id { get; set; }
        // KişiId / Kişi tablosunda kişi id ile eşleşir
        public int PersonId { get; set; }
        // Plaka
        public string? Plate { get; set; }
        // Marka
        public string? Brand { get; set; }
        // Model
        public string? Model { get; set; }
        // Renk
        public string? Color { get; set; }
        // Aktif mi?
        public bool? IsActive { get; set; }
    }
    public class PersonVehicleEntityConfiguration : IEntityTypeConfiguration<PersonVehicle>
    {
        public void Configure(EntityTypeBuilder<PersonVehicle> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.PersonId).HasColumnType("int");
            builder.Property(x => x.Plate).HasColumnType("varchar(30)");
            builder.Property(x => x.Brand).HasColumnType("varchar(30)");
            builder.Property(x => x.Model).HasColumnType("varchar(30)");
            builder.Property(x => x.Color).HasColumnType("varchar(30)");
            builder.Property(x => x.IsActive).HasColumnType("bit");
            builder.HasIndex(e => e.Id);
            builder.HasIndex(e => e.PersonId);
        }
    }
}
