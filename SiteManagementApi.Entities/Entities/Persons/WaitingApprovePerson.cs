using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SiteManagementApi.Entities.Entities.Persons
{
    public class WaitingApprovePerson
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        // Onay durumu parametre tablosundan çekilir.
        public int Status { get; set; }
        public string? CreatedUserName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
    public class WaitingApproveEntityConfiguration : IEntityTypeConfiguration<WaitingApprovePerson>
    {
        public void Configure(EntityTypeBuilder<WaitingApprovePerson> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.PersonId).HasColumnType("int");
            builder.Property(x=>x.Status).HasColumnType("int");
            builder.Property(x=>x.CreatedUserName).HasColumnType("varchar(30)");
            builder.Property(x => x.CreatedDate).HasColumnType("datetime");
        }
    }
}
