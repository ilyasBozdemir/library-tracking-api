using LibraryTrackingApp.Domain.Entities.Library;
using LibraryTrackingApp.Domain.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.ToTable(name: "Books", schema: "lm");// LibraryManagement
        builder.HasKey(b => b.Id);
        builder.Property(b => b.Title).IsRequired();
        builder.Property(b => b.ISBN).IsRequired();
        builder.Property(lb => lb.Description).IsRequired();

        builder.HasOne(b => b.Publisher)
            .WithMany(p => p.Books)
            .HasForeignKey(b => b.Id)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .Property(b => b.BookStatus)
            .HasConversion(new EnumToStringConverter<BookStatus>());

        builder
            .Property(b => b.BookFormat)
            .HasConversion(new EnumToStringConverter<BookFormat>());

        builder
            .Property(b => b.BookLanguage)
            .HasConversion(new EnumToStringConverter<BookLanguage>());

        builder.HasIndex(b => b.Title);
        builder.HasIndex(b => b.ISBN);

        // Book - BookStocks ilişkisi
        builder.HasMany(b => b.BookStocks).WithOne(bs => bs.Book).HasForeignKey(bs => bs.Id);//1-1 olması lazım düzenlencek.

        // Book - Borrows ilişkisi
        builder.HasMany(b => b.Borrows).WithOne(br => br.Book).HasForeignKey(br => br.BookId);

        //BookEntry ile olan ilişkiyi tanımlama
        builder.HasMany(b => b.BookEntries)
              .WithOne(be => be.Book)
              .HasForeignKey(be => be.BookId)
              .OnDelete(DeleteBehavior.Cascade);

        // Book - Tags ilişkisi
        builder
            .HasMany(b => b.Tags)
            .WithMany(t => t.Books)
            .UsingEntity<Dictionary<string, object>>(
            "BookTags",
            j => j
            .HasOne<BookTag>()
            .WithMany()
            .HasForeignKey("TagId"),
            j => j
            .HasOne<Book>()
            .WithMany()
            .HasForeignKey("BookId"),
            j =>
            {
                j.HasKey("TagId", "BookId");
                j.ToTable("BookTags", "lm");
            }
            );


        // Book - Authors ilişkisi

        builder.HasMany(b => b.Authors)
            .WithMany(a => a.Books)
            .UsingEntity<Dictionary<string, object>>(
            "BookAuthors",
            j => j
            .HasOne<Author>()
            .WithMany()
            .HasForeignKey("AuthorId"),
                j => j
            .HasOne<Book>()
            .WithMany()
            .HasForeignKey("BookId"),
            j =>
            {
                j.HasKey("AuthorId", "BookId");
                j.ToTable("BookAuthors", "lm");
            }
            );


        // Book - BookStocks ilişkisi
        builder
            .HasMany(b => b.BookStocks)
            .WithOne(bs => bs.Book)
            .HasForeignKey(bs => bs.BookId)
            .OnDelete(DeleteBehavior.Restrict);

        // Book - Publisher ilişkisi

        builder.HasOne(b => b.Publisher)
               .WithMany(p => p.Books)
               .HasForeignKey(b => b.PublisherId)
               .OnDelete(DeleteBehavior.Restrict);



        // Book - Borrows ilişkisi
        builder
            .HasMany(b => b.Borrows)
            .WithOne(br => br.Book)
            .HasForeignKey(br => br.BookId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
