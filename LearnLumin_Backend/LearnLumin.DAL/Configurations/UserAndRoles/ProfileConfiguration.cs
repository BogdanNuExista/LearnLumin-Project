using LearnLumin.DAL.Entities.UsersAndRoles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnLumin.DAL.Configurations.UserAndRoles;

public class ProfileConfiguration : IEntityTypeConfiguration<Profile>
{
    public void Configure(EntityTypeBuilder<Profile> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id).ValueGeneratedOnAdd();
        builder.Property(p => p.Bio).HasMaxLength(1000);
        builder.Property(p => p.ProfilePicture).HasMaxLength(255);
        builder.Property(p => p.Location).HasMaxLength(255);
        builder.Property(p => p.Preferences).HasMaxLength(1000);
        
        builder.HasOne(p => p.User)
            .WithOne(u => u.Profile)
            .HasForeignKey<Profile>("UserId");

        builder.ToTable("Profiles");
    }
    
}