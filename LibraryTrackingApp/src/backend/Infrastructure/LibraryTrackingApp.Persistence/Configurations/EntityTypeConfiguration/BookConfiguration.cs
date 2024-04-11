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

        builder.HasMany(b => b.BookStocks)
           .WithOne(bs => bs.Book) 
           .HasForeignKey(bs => bs.Id);

    }
}
