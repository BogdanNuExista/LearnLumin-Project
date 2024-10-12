using LearnLumin.DAL.Entities.CommunityAndInterraction;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnLumin.DAL.Configurations.CommunityAndInteraction;

public class DiscussionForumConfiguration : IEntityTypeConfiguration<DiscussionForum>
{
    public void Configure(EntityTypeBuilder<DiscussionForum> builder)
    {
        builder.HasKey(df => df.Id);
        builder.Property(df => df.Id).ValueGeneratedOnAdd();
        builder.Property(df => df.Title).HasMaxLength(100).IsRequired();
        builder.Property(df => df.Description).HasMaxLength(1000);
        builder.Property(df => df.CreatedDate).IsRequired();

        builder.ToTable("DiscussionForums");

        builder.HasOne(df => df.Creator)
            .WithMany()
            .HasForeignKey("CreatorId")
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(df => df.Posts)
            .WithOne(p => p.Forum)
            .HasForeignKey("ForumId")
            .OnDelete(DeleteBehavior.Cascade);
    }
}