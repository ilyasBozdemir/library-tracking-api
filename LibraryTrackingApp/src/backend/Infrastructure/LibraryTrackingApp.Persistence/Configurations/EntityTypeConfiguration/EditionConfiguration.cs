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


        builder.Property(e => e.PublisherId)
            .IsRequired();

        builder.HasOne(e => e.Publisher)
            .WithMany()
            .HasForeignKey(e => e.PublisherId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.Property(e => e.EditionNumber).IsRequired();
        builder.Property(e => e.PublicationDate).IsRequired();
        builder.Property(e => e.Notes).IsRequired();

        builder.HasMany(e => e.WorkInventories)
            .WithMany(wi => wi.Editions) 
            .UsingEntity<EditionWorkInventory>(
                 j => j.HasOne(wi => wi.WorkInventory)
                       .WithMany()
                       .HasForeignKey(wi => wi.WorkInventoryId),
                 j => j.HasOne(e => e.Edition)
                       .WithMany()
                       .HasForeignKey(e => e.EditionId),
                    j =>
                    {
                        j.HasKey(wt => new { wt.WorkInventoryId, wt.EditionId });
                        j.ToTable("Edition_WorkInventories", "lm");
                    }
             );

    }
}

