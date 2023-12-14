using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SiteManagementApi.Entities.Entities.Site
{
    public class JobToDo
    {
        public int JobId { get; set; }
        public int EmployeeId { get; set; }
        public string? JobTitle { get; set; }
        public string? Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Renew { get; set; }
        public DateTime RenewalEndDate { get; set; }
        public int Priority { get; set; }
        public bool SmsAlert { get; set; }
        public bool EmailAlert { get; set; }
        public bool PushAlert { get; set; }
        public string? Description { get; set; }
        public int Status { get; set; }
    }
    public class JobToDoEntityConfiguration : IEntityTypeConfiguration<JobToDo>
    {
        public void Configure(EntityTypeBuilder<JobToDo> builder)
        {
            builder.HasKey(x => x.JobId);
            builder.Property(x => x.EmployeeId).HasColumnType("int");
            builder.Property(x => x.JobTitle).HasColumnType("varchar(100)");
            builder.Property(x => x.Location).HasColumnType("varchar(100)");
            builder.Property(x => x.StartDate).HasColumnType("datetime");
            builder.Property(x => x.EndDate).HasColumnType("datetime");
            builder.Property(x => x.Renew).HasColumnType("int");
            builder.Property(x => x.RenewalEndDate).HasColumnType("datetime");
            builder.Property(x => x.Priority).HasColumnType("int");
            builder.Property(x => x.SmsAlert).HasColumnType("bit");
            builder.Property(x => x.EmailAlert).HasColumnType("bit");
            builder.Property(x => x.PushAlert).HasColumnType("bit");
            builder.Property(x => x.Description).HasColumnType("varchar(1000)");
            builder.Property(x => x.Status).HasColumnType("int");


        }
    }
}
