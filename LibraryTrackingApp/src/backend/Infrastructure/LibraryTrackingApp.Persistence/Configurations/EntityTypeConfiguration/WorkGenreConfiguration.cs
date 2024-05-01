using LibraryTrackingApp.Domain.Entities.Library;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;

public class WorkGenreConfiguration : IEntityTypeConfiguration<WorkGenre>
{
    public void Configure(EntityTypeBuilder<WorkGenre> builder)
    {
        builder.ToTable(name: "WorkGenres", schema: "lm");// LibraryManagement

        builder.HasKey(g => g.Id);

        builder.Property(g => g.Name).IsRequired();
        builder.Property(g => g.IsActive).IsRequired();

       
        builder.HasMany(g => g.WorkCatalogs)
               .WithOne(b => b.Genre)
               .HasForeignKey(b => b.GenreId);
    }
}

