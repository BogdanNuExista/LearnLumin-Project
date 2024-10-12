using LearnLumin.DAL.Entities.StudyGroups;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnLumin.DAL.Configurations.StudyGroups;

public class StudyGroupConfiguration : IEntityTypeConfiguration<StudyGroup>
{
    public void Configure(EntityTypeBuilder<StudyGroup> builder)
    {
        builder.HasKey(sg => sg.Id);
        builder.Property(sg => sg.Id).ValueGeneratedOnAdd();    
        builder.Property(sg => sg.Title).HasMaxLength(255).IsRequired();
        builder.Property(sg => sg.Description).HasMaxLength(1000).IsRequired();
        builder.Property(sg => sg.CreatedDate).IsRequired();
        
        builder.ToTable("StudyGroups");
        
        builder.HasOne(sg => sg.Creator)
            .WithMany(u => u.StudyGroups)
            .HasForeignKey("CreatorId")
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(sg => sg.Memberships)
            .WithOne(m => m.StudyGroup)
            .HasForeignKey("StudyGroupId")
            .OnDelete(DeleteBehavior.Cascade);

    }
}