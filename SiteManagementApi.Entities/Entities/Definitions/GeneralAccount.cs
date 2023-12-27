using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SiteManagementApi.Entities.Entities.Definitions
{
    public class GeneralAccount
    {
        public int Id { get; set; }
        public int? AccountCode { get; set; }
        public string? Account { get; set; }
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
    public class GeneralAccountEntityConfiguration : IEntityTypeConfiguration<GeneralAccount>
    {
        public void Configure(EntityTypeBuilder<GeneralAccount> builder)
        {
            builder.HasIndex(x => x.Id);
            builder.HasIndex(x => x.AccountCode);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.AccountCode).HasColumnType("int");
            builder.Property(x => x.Account).HasColumnType("varchar(50)");
            builder.Property(x => x.IsActive).HasColumnType("bit");
            builder.Property(x => x.CreatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.CreatedDate).HasColumnType("datetime");
            builder.Property(x => x.UpdatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.UpdatedDate).HasColumnType("datetime");
        }
    }
}
