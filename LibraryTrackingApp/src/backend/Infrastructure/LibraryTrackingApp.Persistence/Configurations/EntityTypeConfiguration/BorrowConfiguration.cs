using LibraryTrackingApp.Domain.Entities.Library;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;

public class BorrowConfiguration : IEntityTypeConfiguration<Borrow>
{
    public void Configure(EntityTypeBuilder<Borrow> builder)
    {
        builder.ToTable("Borrows");
        builder.HasKey(l => l.Id);
        builder.Property(l => l.BorrowDate).IsRequired();
        builder.Property(l => l.DueDate).IsRequired();



        builder.HasOne(l => l.Book)
               .WithMany(b => b.Borrows) 
               .HasForeignKey(l => l.BookId)
               .IsRequired();

        builder.HasOne(b => b.Book)
             .WithMany(b => b.Borrows)
             .HasForeignKey(b => b.BookId)
             .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(b => b.Member)
               .WithMany(m => m.Borrows)
               .HasForeignKey(b => b.MemberId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(b => b.Lender)
               .WithMany()
               .HasForeignKey(b => b.LenderId)
               .OnDelete(DeleteBehavior.Restrict);

    }
}
