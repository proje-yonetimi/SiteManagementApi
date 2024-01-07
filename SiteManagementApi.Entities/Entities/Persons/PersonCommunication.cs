using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace SiteManagementApi.Entities.Entities
{
    public class PersonCommunication
    {
        public Guid? Id { get; set; }
        public Guid? CommunicationId { get; set; }
        // İletişim tipi (email/gsm/evtel/iştel vs.)
        public int? CommunicationType { get; set; }
        // İletişim değeri
        public string? Communication { get; set; }
        // Birincil iletişim
        public bool? IsPrimary { get; set; }
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
    public class PersonCommunicationEntityConfiguration : IEntityTypeConfiguration<PersonCommunication>
    {
        public void Configure(EntityTypeBuilder<PersonCommunication> builder)
        {
            builder.Property(x => x.Id).HasColumnType("uniqueidentifier");
            builder.Property(x => x.CommunicationId).HasColumnType("uniqueidentifier");
            builder.Property(x => x.CommunicationType).HasColumnType("int");
            builder.Property(x => x.Communication).HasColumnType("varchar(100)");
            builder.Property(x => x.IsPrimary).HasColumnType("bit");
            builder.Property(x => x.IsActive).HasColumnType("bit");
            builder.Property(x => x.CreatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.CreatedDate).HasColumnType("datetime");
            builder.Property(x => x.UpdatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.UpdatedDate).HasColumnType("datetime");
            builder.HasIndex(e => e.CommunicationId);
            builder.HasIndex(e => e.Id);
        }
    }
}
