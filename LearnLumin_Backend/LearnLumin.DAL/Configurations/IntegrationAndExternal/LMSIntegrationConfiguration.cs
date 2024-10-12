using LearnLumin.DAL.Entities.IntegrationAndExternal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnLumin.DAL.Configurations.IntegrationAndExternal;

public class LMSIntegrationConfiguration : IEntityTypeConfiguration<LmsIntegration>
{   
    public void Configure(EntityTypeBuilder<LmsIntegration> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).ValueGeneratedOnAdd();
        builder.Property(e => e.LmsName).HasMaxLength(100).IsRequired();
        builder.Property(e => e.IntegrationDetails).HasMaxLength(1000);
    }
}