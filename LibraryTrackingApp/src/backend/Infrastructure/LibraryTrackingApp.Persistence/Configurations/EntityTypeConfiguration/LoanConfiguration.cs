using LibraryTrackingApp.Domain.Entities.Library;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;

public class LoanConfiguration : IEntityTypeConfiguration<Loan>
{
    public void Configure(EntityTypeBuilder<Loan> builder)
    {
        builder.ToTable("Loans");
        builder.HasKey(l => l.Id);
        builder.Property(l => l.BorrowDate).IsRequired();
        builder.Property(l => l.DueDate).IsRequired();



        builder.HasOne(l => l.Book)
               .WithMany(b => b.Loans) 
               .HasForeignKey(l => l.BookId)
               .IsRequired(); 
    }
}
