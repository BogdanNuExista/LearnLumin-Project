using LearnLumin.DAL.Entities.CoursesAndLessons;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnLumin.DAL.Configurations.CoursesAndLessons;

public class QuizConfiguration : IEntityTypeConfiguration<Quiz>
{
    public void Configure(EntityTypeBuilder<Quiz> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x => x.Title).HasMaxLength(100).IsRequired();
        builder.Property(x => x.Description).HasMaxLength(1000);
        builder.Property(x => x.CreatedDate).IsRequired();

        builder.ToTable("Quizzes");
        
        builder.HasOne(x => x.Lesson)
            .WithMany()
            .HasForeignKey("LessonId")
            .OnDelete(DeleteBehavior.NoAction);
        
        builder.HasOne(x => x.Course)
            .WithMany(c => c.Quizzes)
            .HasForeignKey("CourseId")
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(x => x.Questions)
            .WithOne(q => q.Quiz)
            .HasForeignKey("QuizId")
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(x => x.UserResults)
            .WithOne(ur => ur.Quiz)
            .HasForeignKey("QuizId")
            .OnDelete(DeleteBehavior.Cascade);

    }
}