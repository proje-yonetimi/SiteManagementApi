using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SiteManagementApi.Entities.Entities.Finance.DebitCollection
{
    public class DebtReceipt
    {
        public int Id { get; set; }
        // borçlu. person tablosundaki id ile eşleşir
        public int DebtorId { get; set; }
        // Daire id
        public Guid? ApartmentId { get; set; }
        // Kategori id. parametrik
        public string? CategoryId { get; set; }
        // borç tarihi
        public DateTime DebtDate { get; set; }
        // son ödeme tarihi
        public DateTime PaymentDueDate { get; set; }
        // borç satırları idsi
        public Guid? DebtRow { get; set; }
        // makbuz tipi
        public int ReceiptType { get; set; }
        public string? DebtDescription { get; set; }
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
    public class DebtReceiptEntityConfiguration : IEntityTypeConfiguration<DebtReceipt>
    {
        public void Configure(EntityTypeBuilder<DebtReceipt> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DebtorId).HasColumnType("int");
            builder.Property(x => x.ApartmentId).HasColumnType("uniqueidentifier");
            builder.Property(x => x.CategoryId).HasColumnType("varchar(30)");
            builder.Property(x => x.DebtDate).HasColumnType("datetime");
            builder.Property(x => x.PaymentDueDate).HasColumnType("datetime");
            builder.Property(x => x.DebtRow).HasColumnType("uniqueidentifier");
            builder.Property(x => x.ReceiptType).HasColumnType("int");
            builder.Property(x => x.DebtDescription).HasColumnType("varchar(250)");
            builder.Property(x => x.IsActive).HasColumnType("bit");
            builder.Property(x => x.CreatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.CreatedDate).HasColumnType("datetime");
            builder.Property(x => x.UpdatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.UpdatedDate).HasColumnType("datetime");
            builder.HasKey(x => x.DebtorId);
            builder.HasKey(x => x.CreatedDate);

        }
    }
}
