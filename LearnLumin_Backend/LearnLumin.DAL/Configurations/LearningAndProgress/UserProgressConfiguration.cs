using LearnLumin.DAL.Entities.LearningAndProgress;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnLumin.DAL.Configurations.LearningAndProgress;

public class UserProgressConfiguration : IEntityTypeConfiguration<UserProgress>
{
    public void Configure(EntityTypeBuilder<UserProgress> builder)
    {   
        builder.HasKey(up => up.Id);
        builder.Property(up => up.Id).ValueGeneratedOnAdd();
        builder.Property(up => up.ProgressPercentage).HasColumnType("decimal(5, 2)");
        builder.Property(up => up.LastAccessedDate).IsRequired();

        builder.ToTable("UserProgresses");

        builder.HasOne(up => up.User)
            .WithMany(u => u.Progresses)
            .HasForeignKey("UserId");

        builder.HasOne(up => up.Course)
            .WithMany(c => c.UserProgresses)
            .HasForeignKey("CourseId")
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(up => up.Lesson)
            .WithMany()
            .HasForeignKey("LessonId")
            .OnDelete(DeleteBehavior.NoAction);
    }    
}