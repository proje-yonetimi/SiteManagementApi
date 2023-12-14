using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SiteManagementApi.Entities.Entities.Menu
{
    public class MenuItemHierarchy
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int ParentId { get; set; }
        public int ItemOrder { get; set; }

    }
    public class MenuItemHierEntityConfiguration : IEntityTypeConfiguration<MenuItemHierarchy>
    {
        public void Configure(EntityTypeBuilder<MenuItemHierarchy> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ItemId).HasColumnType("integer");
            builder.Property(x => x.ParentId).HasColumnType("integer");
            builder.Property(x => x.ItemOrder).HasColumnType("integer");
        }
    }
}
