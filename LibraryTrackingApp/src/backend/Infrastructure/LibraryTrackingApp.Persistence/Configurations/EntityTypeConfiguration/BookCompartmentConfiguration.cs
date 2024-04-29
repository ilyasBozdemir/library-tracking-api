using LibraryTrackingApp.Domain.Entities.Library;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;

public class BookCompartmentConfiguration : IEntityTypeConfiguration<BookCompartment>
{
    public void Configure(EntityTypeBuilder<BookCompartment> builder)
    {
        builder.ToTable(name: "BookCompartments", schema: "lm"); // LibraryManagement

        builder.HasKey(bc => bc.Id);

        builder.Property(bc => bc.Name).IsRequired().HasMaxLength(100);

        builder
            .HasOne(bc => bc.Shelf)
            .WithMany(s => s.Compartments)
            .HasForeignKey(bc => bc.ShelfId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
