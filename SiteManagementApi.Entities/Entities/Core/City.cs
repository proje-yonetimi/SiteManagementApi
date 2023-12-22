using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SiteManagementApi.Entities.Entities.Core
{
    public class City
    {
        public int Id { get; set; }
        public int CityCode { get; set; }
        public string? CityName { get; set; }
        public int IsActive { get; set; }
    }
    public class CityEntityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.CityCode).HasColumnType("int");
            builder.Property(x=>x.CityName).HasColumnType("varchar(50)");
            builder.Property(x=>x.IsActive).HasColumnType("int");
        }
    }
}
