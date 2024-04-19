using LibraryTrackingApp.Domain.Entities.Library;
using LibraryTrackingApp.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;

public class BorrowBookConfiguration : IEntityTypeConfiguration<BorrowBook>
{
    public void Configure(EntityTypeBuilder<BorrowBook> builder)
    {
        builder.ToTable(name: "BorrowBooks", schema: "lm");// LibraryManagement
        builder.HasKey(l => l.Id);
        builder.Property(l => l.BorrowDate).IsRequired();
        builder.Property(l => l.DueDate).IsRequired();

        builder.HasIndex(b => b.MemberId);
        builder.HasIndex(b => b.BookId);
        builder.HasIndex(b => b.BorrowDate);
        builder.HasIndex(b => b.DueDate);


        builder.Property(b => b.HasFee)
            .HasColumnType("bit");

        builder.Property(b => b.FeeAmount)
            .HasColumnType("decimal(18,2)");


        builder
            .Property(b => b.BorrowStatus)
            .HasConversion(new EnumToStringConverter<BorrowStatus>());


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
