using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace SiteManagementApi.Entities.Entities.Core
{
    public class District
    {
        public int Id { get; set; }
        public int CityCode { get; set; }
        public int DistrictCode { get; set; }
        public string? DistrictName { get; set; }
        public int IsActive { get; set; }
    }
    public class DistrictEntityConfiguration : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CityCode).HasColumnType("int");
            builder.Property(x => x.DistrictCode).HasColumnType("int");
            builder.Property(x => x.DistrictName).HasColumnType("varchar(50)");
            builder.Property(x => x.IsActive).HasColumnType("int");
        }
    
}
}
