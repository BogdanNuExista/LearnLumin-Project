using LearnLumin.DAL.Entities.CoursesAndLessons;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnLumin.DAL.Configurations.CoursesAndLessons;

public class CourseConfiguration : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id).ValueGeneratedOnAdd();
        builder.Property(c => c.Title).HasMaxLength(100).IsRequired();
        builder.Property(c => c.Description).HasMaxLength(1000);
        builder.Property(c => c.Category).HasMaxLength(50);
        builder.Property(c => c.Price).HasColumnType("decimal(18,2)");
        builder.Property(c => c.CreatedDate).IsRequired();
        builder.Property(c => c.UpdatedDate).IsRequired(false);

        builder.ToTable("Courses");
        
        builder.HasOne(c => c.Creator)
            .WithMany()
            .HasForeignKey("UserId")
            .OnDelete(DeleteBehavior.NoAction);
        
        builder.HasOne(c => c.LearningPath)
            .WithMany(lp => lp.Courses)
            .HasForeignKey("LearningPathId")
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasMany(c => c.Lessons)
            .WithOne(l => l.Course)
            .HasForeignKey("CourseId")
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasMany(c => c.Quizzes)
            .WithOne(q => q.Course)
            .HasForeignKey("CourseId")
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasMany(c => c.UserAccesses)
            .WithOne(ua => ua.Course)
            .HasForeignKey("CourseId")
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasMany(c => c.UserProgresses)
            .WithOne(up => up.Course)
            .HasForeignKey("CourseId")
            .OnDelete(DeleteBehavior.Cascade);
    }
}