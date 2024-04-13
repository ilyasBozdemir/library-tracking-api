using LibraryTrackingApp.Domain.Entities.Library;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.ToTable("Books");
        builder.HasKey(b => b.Id);
        builder.Property(b => b.Title).IsRequired();
        builder.Property(b => b.ISBN).IsRequired();
        builder.Property(lb => lb.Description).IsRequired();

        builder.HasOne(b => b.Publisher).WithMany(p => p.Books).HasForeignKey(b => b.Id);

        // Book - BookStocks ilişkisi
        builder.HasMany(b => b.BookStocks).WithOne(bs => bs.Book).HasForeignKey(bs => bs.Id);

        // Book - Borrows ilişkisi
        builder.HasMany(b => b.Borrows).WithOne(br => br.Book).HasForeignKey(br => br.BookId);

        // Book - Tags ilişkisi
        builder.HasMany(b => b.Tags).WithMany(t => t.Books);

        // Book - Authors ilişkisi
        builder.HasMany(b => b.Authors).WithMany(a => a.Books);

        // Book - BookStocks ilişkisi
        builder
            .HasMany(b => b.BookStocks)
            .WithOne(bs => bs.Book)
            .HasForeignKey(bs => bs.BookId)
            .OnDelete(DeleteBehavior.Cascade);

        // Book - Borrows ilişkisi
        builder
            .HasMany(b => b.Borrows)
            .WithOne(br => br.Book)
            .HasForeignKey(br => br.BookId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
