using LearnLumin.DAL.Entities.UsersAndRoles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnLumin.DAL.Configurations.UserAndRoles;

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.HasKey(r => r.Id);
        builder.Property(r => r.Id).ValueGeneratedOnAdd();
        builder.Property(r => r.RoleName).HasMaxLength(50).IsRequired();
        builder.Property(r => r.Permissions).HasMaxLength(1000);
        
        builder.HasIndex(r => r.RoleName).IsUnique();

        builder.ToTable("Roles");
    }
    
}