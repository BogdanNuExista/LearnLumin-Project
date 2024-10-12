using LearnLumin.DAL.Entities.PaymentsAndAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnLumin.DAL.Configurations.PaymentsAndAccessesConfiguration;

public class UserCourseAccessConfiguration : IEntityTypeConfiguration<UserCourseAccess>
{   
    public void Configure(EntityTypeBuilder<UserCourseAccess> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x => x.AccessGrantedDate).IsRequired();

        builder.ToTable("UserCourseAccesses");
        
        builder.HasOne(x => x.User)
            .WithMany(x => x.CourseAccesses)
            .HasForeignKey("UserId")
            .OnDelete(DeleteBehavior.NoAction);
        
        builder.HasOne(x => x.Course)
            .WithMany(x => x.UserAccesses)
            .HasForeignKey("CourseId")
            .OnDelete(DeleteBehavior.Cascade);
    }
}