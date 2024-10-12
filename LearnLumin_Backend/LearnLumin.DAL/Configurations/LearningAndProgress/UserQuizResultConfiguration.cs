using LearnLumin.DAL.Entities.LearningAndProgress;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnLumin.DAL.Configurations.LearningAndProgress;

public class UserQuizResultConfiguration : IEntityTypeConfiguration<UserQuizResult>
{
    public void Configure(EntityTypeBuilder<UserQuizResult> builder)
    {
        builder.HasKey(uqr => uqr.Id);
        builder.Property(uqr => uqr.Id).ValueGeneratedOnAdd();
        builder.Property(uqr => uqr.Score).HasColumnType("decimal(5, 2)").IsRequired();
        builder.Property(uqr => uqr.CompletionDate).IsRequired();

        builder.ToTable("UserQuizResults");

        builder.HasOne(uqr => uqr.User)
            .WithMany(u => u.QuizResults)
            .HasForeignKey("UserId")
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(uqr => uqr.Quiz)
            .WithMany(q => q.UserResults)
            .HasForeignKey("QuizId")
            .OnDelete(DeleteBehavior.NoAction);
    }
}