using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SiteManagementApi.Entities.Entities.Site
{
    public class Meeting
    {
        public int Id { get; set; }
        // Toplantı konusu
        public string? Subject { get; set; }
        // Toplantı özeti
        public string? Summary { get; set; }
        // Toplantı mekanı
        public string? Location { get; set; }
        // Toplantı içeriği
        public string? Content { get; set; }
        // Durum
        public int? Status { get; set; }
        // Toplantı tarihi
        public DateTime? MeetingDate { get; set; }
        // Ek dosya url
        public string? Attachment { get; set; }
        // Katılım sağlayacak olan liste
        public int? AttendenceId { get; set; }
    }
    public class MeetingEntityConfiguration : IEntityTypeConfiguration<Meeting>
    {
        public void Configure(EntityTypeBuilder<Meeting> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Subject).HasColumnType("varchar(100)");
            builder.Property(e => e.Summary).HasColumnType("varchar(250)");
            builder.Property(e => e.Location).HasColumnType("varchar(100)");
            builder.Property(e => e.Content).HasColumnType("varchar(500)");
            builder.Property(e => e.Status).HasColumnType("int");
            builder.Property(e => e.MeetingDate).HasColumnType("datetime");
            builder.Property(e => e.Attachment).HasColumnType("varchar(200)");
            builder.Property(e => e.AttendenceId).HasColumnType("int");
            builder.HasIndex(e => e.AttendenceId);
        }
    }
}