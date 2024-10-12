using LearnLumin.DAL.Entities.CommunityAndInterraction;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnLumin.DAL.Configurations.CommunityAndInteraction;

public class PostConfiguration : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id).ValueGeneratedOnAdd();
        builder.Property(p => p.Title).HasMaxLength(100).IsRequired();
        builder.Property(p => p.Content).HasMaxLength(1000);
        builder.Property(p => p.CreatedDate).IsRequired();

        builder.ToTable("Posts");

        builder.HasOne(p => p.Forum)
            .WithMany(f => f.Posts)
            .HasForeignKey("ForumId")
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(p => p.User)
            .WithMany()
            .HasForeignKey("UserId")
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(p => p.Comments)
            .WithOne(c => c.Post)
            .HasForeignKey("PostId")
            .OnDelete(DeleteBehavior.Cascade);
    }
}