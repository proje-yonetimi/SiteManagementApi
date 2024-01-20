using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SiteManagementApi.Entities.Entities.Definition
{
    public class Document
    {
        public int Id { get; set; }
        // Kategori kodu
        public int? CategoryCode { get; set; }
        // Kategori alt kodu
        public int? CategorySubCode{ get; set; }
        // Kategori adı
        public string? CategoryName { get; set; }
        // Açıklama
        public string? Description { get; set; }
        // Bildirimlere dahil edilsin mi?
        public bool? IncludeNotification { get; set; }
        // Aidat gelirlerine dahil edilsin mi ?
        public bool? IncludeDues { get; }
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
    public class DocumentEntityConfiguration : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property( e => e.CategoryCode).HasColumnType("int");
            builder.Property( e => e.CategorySubCode).HasColumnType("int");
            builder.Property( e => e.CategoryName).HasColumnType("varchar(50)");
            builder.Property( e => e.Description).HasColumnType("varchar(250)");
            builder.Property( e => e.IncludeNotification).HasColumnType("bit");
            builder.Property( e => e.IncludeDues).HasColumnType("bit");
            builder.Property(x => x.IsActive).HasColumnType("bit");
            builder.Property(x => x.CreatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.CreatedDate).HasColumnType("datetime");
            builder.Property(x => x.UpdatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.UpdatedDate).HasColumnType("datetime");
            builder.HasIndex(e => e.Id);
            builder.HasIndex(e => e.CategoryCode);
        }
    }
}
