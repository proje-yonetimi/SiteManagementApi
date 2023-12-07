using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SiteManagementApi.DatabaseContext.Entities
{
    public class MenuItem
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string? URL { get; set; }
        public string? StringId { get; set; }
        public bool? IsVisible { get; set; }
        public string? Icon { get; set; }
        public string? LastUpdatedUserName { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public bool? IsActive { get; set; }
        public MenuItemHierarchy MenuItemHierarchy { get; set; }

    }
    public class MenuItemEntityConfiguration : IEntityTypeConfiguration<MenuItem>
    {
        public void Configure(EntityTypeBuilder<MenuItem> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.ItemId).HasColumnType("integer");
            builder.Property(p => p.URL).HasColumnType("varchar(150)");
            builder.Property(p => p.StringId).HasColumnType("varchar(50)");
            builder.Property(p => p.IsVisible).HasColumnType("bit");
            builder.Property(p => p.Icon).HasColumnType("varchar(50)");
            builder.Property(p => p.LastUpdatedUserName).HasColumnType("varchar(50)");
            builder.Property(p => p.LastUpdatedDate).HasColumnType("datetime");
            builder.Property(p => p.IsActive).HasColumnType("bit");

            builder.HasOne(p => p.MenuItemHierarchy).WithOne(p=>p.MenuItem).HasForeignKey<MenuItemHierarchy>(p => p.ItemId);
        }
    }
}
