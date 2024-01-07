using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SiteManagementApi.Entities.Entities.Definitions
{
    public class BankCase
    {
        public int Id { get; set; }
        public int? CaseCode { get; set; }
        public string? CaseName { get; set; }
        public bool? IsShowSummaryPage { get; set; }
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
    public class BankCaseEntityConfiguration : IEntityTypeConfiguration<BankCase>
    {
        public void Configure(EntityTypeBuilder<BankCase> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CaseCode).HasColumnType("int");
            builder.Property(x => x.CaseName).HasColumnType("varchar(50)");
            builder.Property(x => x.IsShowSummaryPage).HasColumnType("bit");
            builder.Property(x => x.IsActive).HasColumnType("bit");
            builder.Property(x => x.CreatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.CreatedDate).HasColumnType("datetime");
            builder.Property(x => x.UpdatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.UpdatedDate).HasColumnType("datetime");
        }
    }
}
