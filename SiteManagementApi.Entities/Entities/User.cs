using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SiteManagementApi.Entities.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int? AuthId { get; set; }
        public bool? IsActive { get; set; }
        public string? CreatedUserName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedUserName { get; set; }
        public DateTime? UpdatedDate { get; set; }

    }
    public class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.UserId);
            builder.Property(x => x.UserName).HasColumnType("varchar(30)");
            builder.Property(x => x.Name).HasColumnType("varchar(50)");
            builder.Property(x => x.Surname).HasColumnType("varchar(50)");
            builder.Property(x => x.AuthId).HasColumnType("integer");
            builder.Property(x => x.IsActive).HasColumnType("bit");
            builder.Property(x => x.CreatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.CreatedDate).HasColumnType("datetime");
            builder.Property(x => x.UpdatedUserName).HasColumnType("varchar(50)");
            builder.Property(x => x.UpdatedDate).HasColumnType("datetime");

        }
    }
}
