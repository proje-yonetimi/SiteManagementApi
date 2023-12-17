using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SiteManagementApi.Entities.Entities.Core
{
    public class Parameter
    {
        public int Id { get; set; }
        // Parametre grup kodu
        public string? GroupCode { get; set; }
        // Parametre kodu
        public string? ParameterCode { get; set; }
        // Parametre değeri
        public string? ParameterValue { get; set; }
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
    public class ParameterEntityConfiguration : IEntityTypeConfiguration<Parameter>
    {
        public void Configure(EntityTypeBuilder<Parameter> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.GroupCode).HasColumnType("varchar(50)");
            builder.Property(p => p.ParameterCode).HasColumnType("varchar(50)");
            builder.Property(p => p.ParameterValue).HasColumnType("varchar(100)");
            builder.Property(x => x.IsActive).HasColumnType("bit");
            builder.Property(x => x.CreatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.CreatedDate).HasColumnType("datetime");
            builder.Property(x => x.UpdatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.UpdatedDate).HasColumnType("datetime");
        }
    }
}
