using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SiteManagementApi.Entities.Entities.Site
{
    public class MeetingAttendence
    {
        public int Id { get; set; }
        public int? AttendenceId { get; set; }
        public int? PersonId { get; set; }
    }
    public class MeetingAttendenceEntityConfiguration : IEntityTypeConfiguration<MeetingAttendence>
    {
        public void Configure(EntityTypeBuilder<MeetingAttendence> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.AttendenceId).HasColumnType("int");
            builder.Property(e => e.PersonId).HasColumnType("int");

            builder.HasIndex(e => e.AttendenceId);
        }
    }
}
