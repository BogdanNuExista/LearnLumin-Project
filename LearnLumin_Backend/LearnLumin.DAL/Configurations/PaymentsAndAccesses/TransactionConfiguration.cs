using LearnLumin.DAL.Entities.PaymentsAndAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnLumin.DAL.Configurations.PaymentsAndAccesses;

public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
{
    public void Configure(EntityTypeBuilder<Transaction> builder)
    {
        builder.HasKey(t => t.Id);
        builder.Property(t => t.Id).ValueGeneratedOnAdd();
        builder.Property(t => t.Amount).HasColumnType("decimal(10,2)").IsRequired();
        builder.Property(t => t.TransactionDate).IsRequired();
        
        builder.ToTable("Transactions");

        builder.HasOne(t => t.User)
            .WithMany(u => u.Transactions)
            .HasForeignKey("UserId")
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(t => t.Course)
            .WithMany()
            .HasForeignKey("CourseId");
    }
}