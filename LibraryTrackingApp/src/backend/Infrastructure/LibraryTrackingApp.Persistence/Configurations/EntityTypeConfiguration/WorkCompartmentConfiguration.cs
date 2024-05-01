using LibraryTrackingApp.Domain.Entities.Library;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;

public class WorkCompartmentConfiguration : IEntityTypeConfiguration<WorkCompartment>
{
    public void Configure(EntityTypeBuilder<WorkCompartment> builder)
    {
        builder.ToTable(name: "WorkCompartments", schema: "lm"); // LibraryManagement

        builder.HasKey(bc => bc.Id);

        builder.Property(bc => bc.Name).IsRequired().HasMaxLength(100);

        builder
            .HasOne(bc => bc.Shelf)
            .WithMany(s => s.Compartments)
            .HasForeignKey(bc => bc.ShelfId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
