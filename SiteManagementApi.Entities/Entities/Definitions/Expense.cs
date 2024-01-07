using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace SiteManagementApi.Entities.Entities.Definitions
{
    public class Expense
    {
        public int Id { get; set; }
        // Gider kodu
        public string? ExpenseCode { get; set; }
        // Gider adı
        public string? ExpenseName { get; set; }
        // Gider grubu
        public string? ExpenseGroup { get; set; }
        // Dağılım şekli
        public int? DistribitionType { get; set; }
        // Borçlandırılacak kişiler. parametrik olacak.
        public int? PersonForDebited { get; set; }
        // Gider açıklaması
        public string? ExpenseDesc { get; set; }
        // Rapora dahilmi?
        public bool? IsInclude { get; set; }
        // Boş dairelere dağılmasın
        public bool? NotScatterEmptyFlats { get; set; }
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
    public class ExpenseEntityConfiguration : IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ExpenseCode).HasColumnType("varchar(50)");
            builder.Property(x => x.ExpenseName).HasColumnType("varchar(50)");
            builder.Property(x => x.ExpenseGroup).HasColumnType("varchar(50)");
            builder.Property(x => x.DistribitionType).HasColumnType("int");
            builder.Property(x => x.PersonForDebited).HasColumnType("int");
            builder.Property(x => x.ExpenseDesc).HasColumnType("varchar(250)");
            builder.Property(x => x.IsInclude).HasColumnType("bit");
            builder.Property(x => x.NotScatterEmptyFlats).HasColumnType("bit");
            builder.Property(x => x.IsActive).HasColumnType("bit");
            builder.Property(x => x.CreatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.CreatedDate).HasColumnType("datetime");
            builder.Property(x => x.UpdatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.UpdatedDate).HasColumnType("datetime");
            builder.HasIndex(x => x.Id);
            builder.HasIndex(x => x.ExpenseCode);

        }

    }
}
