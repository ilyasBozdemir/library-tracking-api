using LibraryTrackingApp.Domain.Entities.Library;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;
public class ReturnConfiguration : IEntityTypeConfiguration<Return>
{
    public void Configure(EntityTypeBuilder<Return> builder)
    {
        builder.ToTable("Returns");
        builder.HasKey(r => r.Id);
        builder.Property(r => r.ReturnDate).IsRequired();

        
        builder.HasOne(r => r.Loan)
               .WithOne(l => l.Return) 
               .HasForeignKey<Return>(r => r.LoanId)
               .IsRequired();
    }
}
