using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SiteManagementApi.Entities.Entities.Finance.OpeningSlips
{
    public class IncomeOpeningSlip
    {
        public int Id { get; set; }
        // Gelir hesabı. Account tablosunda Gelir tipinde hesapla eşleşecek.
        public int? AccountId { get; set; }
        // Borç
        public decimal? Debt { get; set; }
        // Alacak
        public decimal? Credit { get; set; }
        // Slip tarihi
        public DateTime? SlipDateTime { get; set; }
        // Açıklama
        public string? Description { get; set; }
        // Aktif mi?
        public int? IsActive { get; set; }
        // Oluşturan kullanıcı adı
        public string? CreatedUserName { get; set; }
        // Oluşturulan tarih
        public DateTime? CreatedDate { get; set; }
        // Son güncelleyen kullanıcı
        public string? UpdatedUserName { get; set; }
        // Son güncelleme tarihi
        public DateTime? UpdatedDate { get; set; }
    }
    public class IncomeOpeningSlipEntityConfig : IEntityTypeConfiguration<IncomeOpeningSlip>
    {
        public void Configure(EntityTypeBuilder<IncomeOpeningSlip> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.AccountId).HasColumnType("int");
            builder.Property(x => x.Debt).HasColumnType("decimal(15,2)");
            builder.Property(x => x.Credit).HasColumnType("decimal(15,2)");
            builder.Property(x => x.SlipDateTime).HasColumnType("datetime");
            builder.Property(x => x.Description).HasColumnType("varchar(250)");
            builder.Property(x => x.IsActive).HasColumnType("int");
            builder.Property(x => x.CreatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.CreatedDate).HasColumnType("datetime");
            builder.Property(x => x.UpdatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.UpdatedDate).HasColumnType("datetime");

            builder.HasIndex(x => x.Id);
            builder.HasIndex(x => x.AccountId);
            builder.HasIndex(x => x.SlipDateTime);
            builder.HasIndex(x => x.CreatedDate);
        }
    }
}
