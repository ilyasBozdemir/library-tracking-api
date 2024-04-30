using LibraryTrackingApp.Domain.Entities.Library;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;


public class EditionConfiguration : IEntityTypeConfiguration<Edition>
{
    public void Configure(EntityTypeBuilder<Edition> builder)
    {
        builder.ToTable("Editions", schema: "lm");

        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).IsRequired();

        builder.Property(e => e.WorkCatalogId).IsRequired();

        builder.HasOne(e => e.WorkCatalog)
            .WithMany(c => c.Editions)
            .HasForeignKey(e => e.WorkCatalogId)
            .OnDelete(DeleteBehavior.Cascade);


        builder.Property(e => e.PublisherId)
            .IsRequired();
        builder.HasOne(e => e.Publisher)
            .WithMany()
            .HasForeignKey(e => e.PublisherId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(e => e.EditionNumber).IsRequired();
        builder.Property(e => e.PublicationDate).IsRequired();
        builder.Property(e => e.Notes).IsRequired();
    }
}

