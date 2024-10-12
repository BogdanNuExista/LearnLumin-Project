using LearnLumin.DAL.Entities.CoursesAndLessons;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnLumin.DAL.Configurations.CoursesAndLessons;

public class QuestionConfiguration : IEntityTypeConfiguration<Question>
{
    public void Configure(EntityTypeBuilder<Question> builder)
    {
        builder.HasKey(q => q.Id);
        builder.Property(q => q.Id).ValueGeneratedOnAdd();
        builder.Property(q => q.Content).HasMaxLength(1000).IsRequired();
        builder.Property(q => q.QuestionType).HasMaxLength(50).IsRequired();
        builder.Property(q => q.Order).IsRequired();

        builder.ToTable("Questions");

        builder.HasOne(q => q.Quiz)
            .WithMany(q => q.Questions)
            .HasForeignKey("QuizId")
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(q => q.Answers)
            .WithOne(a => a.Question)
            .HasForeignKey("QuestionId")
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}