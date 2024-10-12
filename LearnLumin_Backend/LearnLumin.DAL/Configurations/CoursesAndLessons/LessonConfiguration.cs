using LearnLumin.DAL.Entities.CoursesAndLessons;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnLumin.DAL.Configurations.CoursesAndLessons;

public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
{
    public void Configure(EntityTypeBuilder<Lesson> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x => x.Title).HasMaxLength(100).IsRequired();
        builder.Property(x => x.Content).HasMaxLength(1000);
        builder.Property(x => x.Order).IsRequired();
        builder.Property(x => x.CreatedDate).IsRequired();
        builder.Property(x => x.UpdatedDate).IsRequired(false);

        builder.ToTable("Lessons");

        builder.HasOne(x => x.Course)
            .WithMany(x => x.Lessons)
            .HasForeignKey("CourseId");
    }
}