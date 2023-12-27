using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SiteManagementApi.Entities.Entities.Definitions
{
    public class Authorities
    {
        public int Id { get; set; }
        // Kişi id. persons tablosuna bağlanır. PersonType:5
        public int? PersonId { get; set; }
        // Yetki tipi. parametre tablosundan çekilir. GroupCode:AuthorityTypes
        public int? AuthType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        // Dosya çıktısı alabilir mi?
        public bool? IsCanExportFile { get; set; }
        public bool? IsActive { get; set; }
        // Oluşturan kullanıcı adı
        public string? CreatedUserName { get; set; }
        // Oluşturulan tarih
        public DateTime? CreatedDate { get; set; }
    }
    public class AuthoritiesEntityConfiguration : IEntityTypeConfiguration<Authorities>
    {
        public void Configure(EntityTypeBuilder<Authorities> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.PersonId).HasColumnType("int");
            builder.Property(x => x.AuthType).HasColumnType("varchar(10)");
            builder.Property(x => x.StartDate).HasColumnType("datetime");
            builder.Property(x => x.EndDate).HasColumnType("datetime");
            builder.Property(x => x.IsCanExportFile).HasColumnType("bit");
            builder.Property(x => x.IsActive).HasColumnType("bit");
            builder.Property(x => x.CreatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.CreatedDate).HasColumnType("datetime");
            builder.HasIndex(x => x.PersonId);
            builder.HasIndex(x => x.AuthType);
        }
    }
}
