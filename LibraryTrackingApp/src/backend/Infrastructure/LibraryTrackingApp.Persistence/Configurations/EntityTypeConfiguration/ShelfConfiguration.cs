using LibraryTrackingApp.Domain.Entities.Library;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;

public class ShelfConfiguration : IEntityTypeConfiguration<Shelf>
{
    public void Configure(EntityTypeBuilder<Shelf> builder)
    {
        builder.ToTable(name: "Shelves", schema: "lm");// LibraryManagement

        builder.HasKey(s => s.Id);

        builder.Property(s => s.Name)
            .IsRequired()
            .HasMaxLength(100);

        // Shelf ile BookCompartment arasında birçok ilişki tanımla

        builder.HasMany(s => s.Compartments) // Shelf'in Compartments koleksiyonu ile
              .WithOne(bc => bc.Shelf) // BookCompartment'in Shelf özelliği ile
              .HasForeignKey(bc => bc.ShelfId) // ShelfId alanını dış anahtar olarak kullan
              .OnDelete(DeleteBehavior.Cascade);

    }
}