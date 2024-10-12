using LearnLumin.DAL.Entities.CommunityAndInterraction;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnLumin.DAL.Configurations.CommunityAndInteraction;

public class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id).ValueGeneratedOnAdd();
        builder.Property(c => c.Content).HasMaxLength(1000);
        builder.Property(c => c.CreatedDate).IsRequired();

        builder.ToTable("Comments");

        builder.HasOne(c => c.Post)
            .WithMany(p => p.Comments)
            .HasForeignKey("PostId")
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(c => c.User)
            .WithMany()
            .HasForeignKey("UserId")
            .OnDelete(DeleteBehavior.NoAction);       
    }
}