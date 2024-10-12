using LearnLumin.DAL.Entities.AdministrationAndModeration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnLumin.DAL.Configurations.AdministrationAndModeration;

public class UserActivityLogConfiguration : IEntityTypeConfiguration<UserActivityLog>
{
    public void Configure(EntityTypeBuilder<UserActivityLog> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).ValueGeneratedOnAdd();
        builder.Property(e => e.ActivityType).HasMaxLength(50);
        builder.Property(e => e.ActivityDate).IsRequired();
        builder.Property(e => e.Details).HasMaxLength(1000);

        builder.ToTable("UserActivityLogs");
            
        builder.HasOne(e => e.User)
            .WithMany()
            .HasForeignKey("UserId");
    }
}