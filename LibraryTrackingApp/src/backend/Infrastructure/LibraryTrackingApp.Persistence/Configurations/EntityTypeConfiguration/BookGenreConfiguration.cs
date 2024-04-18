using LibraryTrackingApp.Domain.Entities.Library;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;

public class BookGenreConfiguration : IEntityTypeConfiguration<BookGenre>
{
    public void Configure(EntityTypeBuilder<BookGenre> builder)
    {
        builder.ToTable(name: "BookGenres", schema: "lm");// LibraryManagement

        builder.HasKey(g => g.Id);

        builder.Property(g => g.Name).IsRequired();
        builder.Property(g => g.IsActive).IsRequired();

       
        builder.HasMany(g => g.Books)
               .WithOne(b => b.Genre)
               .HasForeignKey(b => b.GenreId);
    }
}

