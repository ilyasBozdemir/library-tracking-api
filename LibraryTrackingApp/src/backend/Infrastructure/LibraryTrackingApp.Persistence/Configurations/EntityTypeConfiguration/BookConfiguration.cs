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


        //Kitaplar ile etiketler arasındaki ilişkiyi yapılandır

        builder
       .HasMany(b => b.Tags)
       .WithMany(b => b.Books);


        // Kitap ile yazarlar arasındaki ilişkiyi yapılandır

        builder
            .HasMany(b => b.Authors)
            .WithMany(b => b.Books);



       // Book - Genre ilişkisi
       builder.HasOne(b => b.Genre)
               .WithMany(g => g.Books)
               .HasForeignKey(b => b.GenreId)
               .IsRequired();

        // Yayınevine ait kitaplar için ilişkiyi belirt
        builder.HasOne(b => b.Publisher)
               .WithMany(p => p.Books)
               .HasForeignKey(b => b.Id);

        // Book - BookStocks ilişkisi
        builder.HasMany(b => b.BookStocks)
               .WithOne(bs => bs.Book)
               .HasForeignKey(bs => bs.Id);

        // Book - Borrows ilişkisi
        builder.HasMany(b => b.Borrows)
               .WithOne(br => br.Book)
               .HasForeignKey(br => br.BookId);

    }
}
