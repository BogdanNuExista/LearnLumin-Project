using LearnLumin.DAL.Entities.UsersAndRoles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnLumin.DAL.Configurations.UserAndRoles;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.Id);
        builder.Property(u => u.Id).ValueGeneratedOnAdd();
        builder.Property(u => u.Username).HasMaxLength(50).IsRequired();
        builder.Property(u => u.Email).HasMaxLength(100).IsRequired();
        builder.Property(u => u.PasswordHash).HasMaxLength(255).IsRequired();
        builder.Property(u => u.CreatedDate).IsRequired();
        
        builder.HasIndex(u => u.Username).IsUnique();
        builder.HasIndex(u => u.Email).IsUnique();

        builder.ToTable("Users");
        
        // Many to many relationship between User and Role

        builder.HasMany(u => u.Roles)
            .WithMany(r => r.Users)
            .UsingEntity<Dictionary<string, object>>(
                "UserRole",
                j => j
                    .HasOne<Role>()
                    .WithMany()
                    .HasForeignKey("RoleId")
                    .HasConstraintName("FK_UserRole_Role_RoleId")
                    .OnDelete(DeleteBehavior.Cascade),
                j => j
                    .HasOne<User>()
                    .WithMany()
                    .HasForeignKey("UserId")
                    .HasConstraintName("FK_UserRole_User_UserId")
                    .OnDelete(DeleteBehavior.Cascade)
            );
        
        // One to one relationship between User and Profile
        
        builder.HasOne(u => u.Profile)
            .WithOne(p => p.User)
            .HasForeignKey<Profile>("UserId")
            .HasConstraintName("FK_User_Profile_UserId")
            .OnDelete(DeleteBehavior.Cascade);
        
        // One to many relationship between User and LearningPath
        
        builder.HasMany(u => u.LearningPaths)
            .WithOne(lp => lp.User)
            .HasForeignKey("UserId")
            .HasConstraintName("FK_LearningPath_User_UserId")
            .OnDelete(DeleteBehavior.Cascade);
        
        // One to many relationship between User and Transaction
        
        builder.HasMany(u => u.Transactions)
            .WithOne(t => t.User)
            .HasForeignKey("UserId")
            .HasConstraintName("FK_Transaction_User_UserId")
            .OnDelete(DeleteBehavior.Cascade);
        
        // One to many relationship between User and UserCourseAccess
        
        builder.HasMany(u => u.CourseAccesses)
            .WithOne(ua => ua.User)
            .HasForeignKey("UserId")
            .HasConstraintName("FK_UserCourseAccess_User_UserId")
            .OnDelete(DeleteBehavior.Cascade);
        
        // One to many relationship between User and UserProgress
        
        builder.HasMany(u => u.Progresses)
            .WithOne(up => up.User)
            .HasForeignKey("UserId")
            .HasConstraintName("FK_UserProgress_User_UserId")
            .OnDelete(DeleteBehavior.Cascade);
        
        // One to many relationship between User and UserQuizResult
        
        builder.HasMany(u => u.QuizResults)
            .WithOne(uqr => uqr.User)
            .HasForeignKey("UserId")
            .HasConstraintName("FK_UserQuizResult_User_UserId")
            .OnDelete(DeleteBehavior.Cascade);
        
        // One to many relationship between User and GroupMembership
        
        builder.HasMany(u => u.GroupMemberships)
            .WithOne(gm => gm.User)
            .HasForeignKey("UserId")
            .HasConstraintName("FK_GroupMembership_User_UserId")
            .OnDelete(DeleteBehavior.Cascade);
        
        // Many to one relationship between User and StudyGroup
        
        builder.HasMany(u => u.StudyGroups)
            .WithOne(sg => sg.Creator)
            .HasForeignKey("CreatorId") // UserId
            .HasConstraintName("FK_StudyGroup_User_CreatorId")
            .OnDelete(DeleteBehavior.Restrict);
    }
}