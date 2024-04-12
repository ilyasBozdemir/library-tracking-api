using LibraryTrackingApp.Domain.Entities.Library;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;

public class GenreConfiguration : IEntityTypeConfiguration<Genre>
{
    public void Configure(EntityTypeBuilder<Genre> builder)
    {
        builder.ToTable("Genres"); 
        builder.HasKey(g => g.Id);

    
        builder.Property(g => g.Name).IsRequired();
        builder.Property(g => g.IsActive).IsRequired();

       
        builder.HasMany(g => g.Books)
               .WithOne(b => b.Genre)
               .HasForeignKey(b => b.GenreId);
    }
}

