using LearnLumin.DAL.Entities.LearningAndProgress;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnLumin.DAL.Configurations.LearningAndProgress;

public class UserAchievementConfiguration : IEntityTypeConfiguration<UserAchievement>
{   
    public void Configure(EntityTypeBuilder<UserAchievement> builder)
    {
        builder.HasKey(ua => ua.Id);
        builder.Property(ua => ua.Id).ValueGeneratedOnAdd();
        builder.Property(ua => ua.EarnedDate).IsRequired();

        builder.ToTable("UserAchievements");
        
        builder.HasOne(ua => ua.User)
            .WithMany()
            .HasForeignKey("UserId")
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(ua => ua.Achievement)
            .WithMany(a => a.UserAchievements)
            .HasForeignKey("AchievementId")
            .OnDelete(DeleteBehavior.Cascade);
    }
}