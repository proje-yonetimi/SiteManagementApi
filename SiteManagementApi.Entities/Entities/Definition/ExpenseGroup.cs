﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace SiteManagementApi.Entities.Entities.Definition
{
    public class ExpenseGroup
    {
        public int Id { get; set; }
        // Gider grubu kodu
        public string? GroupCode { get; set; }
        // Gider grubu adı
        public string? GroupName { get; set; }
        // Bağlı olduğu Gider grubu kodu
        public string? ParentGroupCode { get; set; }
        public string? Description { get; set; }
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
    public class ExpenseGroupEntityConfiguration : IEntityTypeConfiguration<ExpenseGroup>
    {
        public void Configure(EntityTypeBuilder<ExpenseGroup> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.GroupCode).HasColumnType("varchar(50)");
            builder.Property(x => x.GroupName).HasColumnType("varchar(50)");
            builder.Property(x => x.ParentGroupCode).HasColumnType("varchar(50)");
            builder.Property(x => x.Description).HasColumnType("varchar(300)");
            builder.Property(x => x.IsActive).HasColumnType("bit");
            builder.Property(x => x.CreatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.CreatedDate).HasColumnType("datetime");
            builder.Property(x => x.UpdatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.UpdatedDate).HasColumnType("datetime");

            builder.HasIndex(x => x.GroupCode);

        }
    }
}
