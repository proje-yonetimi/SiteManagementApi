using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SiteManagementApi.Entities.Entities.Definition
{
    public class Income
    {
        public int Id { get; set; }
        // Gelir kodu
        public string? IncomeCode { get; set; }
        // Gelir adı
        public string? IncomeName { get; set; }
        // Gelir grubu
        public string? IncomeGroup { get; set; }
        // Dağılım şekli
        public int? DistribitionType { get; set; }
        // Alacaklandırılacak kişiler. parametrik olacak.
        public int? PersonForCredited { get; set; }
        // gelir açıklaması
        public string? IncomeDesc { get; set; }
        // Rapora dahilmi?
        public bool? IsInclude { get; set; }
        // Giderlerden düşülecek ?
        public bool? DeductedFromExpense { get; set; }
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
    public class IncomeEntityConfiguration : IEntityTypeConfiguration<Income>
    {
        public void Configure(EntityTypeBuilder<Income> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IncomeCode).HasColumnType("varchar(50)");
            builder.Property(x => x.IncomeName).HasColumnType("varchar(50)");
            builder.Property(x => x.IncomeGroup).HasColumnType("varchar(50)");
            builder.Property(x => x.DistribitionType).HasColumnType("int");
            builder.Property(x => x.PersonForCredited).HasColumnType("int");
            builder.Property(x => x.IncomeDesc).HasColumnType("varchar(250)");
            builder.Property(x => x.IsInclude).HasColumnType("bit");
            builder.Property(x => x.DeductedFromExpense).HasColumnType("bit");
            builder.Property(x => x.IsActive).HasColumnType("bit");
            builder.Property(x => x.CreatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.CreatedDate).HasColumnType("datetime");
            builder.Property(x => x.UpdatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.UpdatedDate).HasColumnType("datetime");
            builder.HasIndex(x => x.Id);
            builder.HasIndex(x => x.IncomeCode);

        }
    }
}
