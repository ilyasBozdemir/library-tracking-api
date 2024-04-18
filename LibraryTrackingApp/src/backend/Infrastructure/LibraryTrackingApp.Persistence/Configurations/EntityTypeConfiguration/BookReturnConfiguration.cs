using LibraryTrackingApp.Domain.Entities.Library;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;
public class BookReturnConfiguration : IEntityTypeConfiguration<BookReturn>
{
    public void Configure(EntityTypeBuilder<BookReturn> builder)
    {
        builder.ToTable(name: "BookReturns", schema: "lm");// LibraryManagement

        builder.HasKey(r => r.Id);
        builder.HasIndex(r => r.BorrowId);
        builder.HasIndex(r => r.ReturnDate);


        builder.Property(r => r.ReturnDate).IsRequired();

        
        builder.HasOne(r => r.Borrow)
               .WithOne(l => l.Return) 
               .HasForeignKey<BookReturn>(r => r.BorrowId)
               .IsRequired();
    }
}
