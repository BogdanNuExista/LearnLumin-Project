using LearnLumin.DAL.Entities.CoursesAndLessons;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnLumin.DAL.Configurations.CoursesAndLessons;

public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
{
    public void Configure(EntityTypeBuilder<Answer> builder)
    {
        builder.HasKey(a => a.Id);
        builder.Property(a => a.Id).ValueGeneratedOnAdd();
        builder.Property(a => a.Content).HasMaxLength(1000).IsRequired();
        builder.Property(a => a.IsCorrect).IsRequired();
        
        builder.ToTable("Answers");
        
        builder.HasOne(a => a.Question)
            .WithMany(q => q.Answers)
            .HasForeignKey("QuestionId")
            .OnDelete(DeleteBehavior.Cascade)
            .IsRequired();
    }
}