using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SiteManagementApi.Entities.Entities.Definition
{
    public class Company
    {
        public int Id { get; set; }
        // Persons tablosu ile eşleşir. persontype parametrik olarak belirlenecek
        public int PersonId { get; set; }
        // firma ünvan
        public string? CompanyName { get; set; }
        // Vergi dairesi
        public string? TaxBranch { get; set; }
        public string? Sector { get; set; }
        public string? Description { get; set; }
        public string? Bank { get; set; }
        public string? IBAN { get; set; }
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
    public class CompanyEntityConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.CompanyName).HasColumnType("varchar(100)");
            builder.Property(t=>t.PersonId).HasColumnType("int");
            builder.Property(t => t.TaxBranch).HasColumnType("varchar(50)");
            builder.Property(t => t.Sector).HasColumnType("varchar(50)");
            builder.Property(t => t.Description).HasColumnType("varchar(50)");
            builder.Property(t => t.Bank).HasColumnType("varchar(50)");
            builder.Property(t => t.IBAN).HasColumnType("varchar(50)");
            builder.Property(x => x.IsActive).HasColumnType("bit");
            builder.Property(x => x.CreatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.CreatedDate).HasColumnType("datetime");
            builder.Property(x => x.UpdatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.UpdatedDate).HasColumnType("datetime");

            builder.HasIndex(t => t.Id);
            builder.HasIndex(t => t.PersonId);

        }
    }
}
