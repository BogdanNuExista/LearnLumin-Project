using LearnLumin.DAL.Entities.IntegrationAndExternal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnLumin.DAL.Configurations.IntegrationAndExternal;

public class CorporateClientConfiguration : IEntityTypeConfiguration<CorporateClient>
{
    public void Configure(EntityTypeBuilder<CorporateClient> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).ValueGeneratedOnAdd();
        builder.Property(e => e.ClientName).HasMaxLength(100).IsRequired();
        builder.Property(e => e.ContactInfo).HasMaxLength(255);
        builder.Property(e => e.ContractDetails).HasMaxLength(1000);
    }
}
