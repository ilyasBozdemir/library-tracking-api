using LibraryTrackingApp.Domain.Entities.Library;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;
public class ReturnConfiguration : IEntityTypeConfiguration<Return>
{
    public void Configure(EntityTypeBuilder<Return> builder)
    {
        builder.ToTable(name: "Returns", schema: "lm");// LibraryManagement

        builder.HasKey(r => r.Id);
        builder.HasIndex(r => r.BorrowId);
        builder.HasIndex(r => r.ReturnDate);


        builder.Property(r => r.ReturnDate).IsRequired();

        
        builder.HasOne(r => r.Borrow)
               .WithOne(l => l.Return) 
               .HasForeignKey<Return>(r => r.BorrowId)
               .IsRequired();
    }
}
