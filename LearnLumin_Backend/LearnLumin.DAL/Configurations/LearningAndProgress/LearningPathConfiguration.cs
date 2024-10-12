using LearnLumin.DAL.Entities.LearningAndProgress;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnLumin.DAL.Configurations.LearningAndProgress;

public class LearningPathConfiguration : IEntityTypeConfiguration<LearningPath>
{ 
    public void Configure(EntityTypeBuilder<LearningPath> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x => x.Title).HasMaxLength(100).IsRequired();
        builder.Property(x => x.Description).HasMaxLength(1000);
        builder.Property(x => x.CreatedDate).IsRequired();

        builder.ToTable("LearningPaths");
        
        builder.HasOne(x => x.User)
            .WithMany(u => u.LearningPaths)
            .HasForeignKey("UserId")
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasMany(x => x.Courses) 
            .WithOne(lp => lp.LearningPath)
            .HasForeignKey("LearningPathId")
            .OnDelete(DeleteBehavior.Cascade);
    }
}