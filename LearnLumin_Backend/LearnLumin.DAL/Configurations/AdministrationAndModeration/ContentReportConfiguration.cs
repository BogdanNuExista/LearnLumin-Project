using LearnLumin.DAL.Entities.AdministrationAndModeration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnLumin.DAL.Configurations.AdministrationAndModeration;

public class ContentReportConfiguration : IEntityTypeConfiguration<ContentReport>
{
    public void Configure(EntityTypeBuilder<ContentReport> builder)
    {
        builder.HasKey(cr => cr.Id);
        builder.Property(cr => cr.Id).ValueGeneratedOnAdd();
        builder.Property(cr => cr.ContentType).HasMaxLength(50);
        builder.Property(cr => cr.ReportReason).HasMaxLength(1000);
        builder.Property(cr => cr.ReportDate).IsRequired();
        builder.Property(cr => cr.ResolutionStatus).HasMaxLength(50);

        builder.ToTable("ContentReports");
        
        builder.HasOne(cr => cr.ReportedBy)
            .WithMany()
            .HasForeignKey("ReportedById")
            .OnDelete(DeleteBehavior.Restrict);
    }
}