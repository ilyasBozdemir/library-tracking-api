using LibraryTrackingApp.Domain.Entities.Library;
using LibraryTrackingApp.Domain.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;

public class WorkCatalogConfiguration : IEntityTypeConfiguration<WorkCatalog>
{
    public void Configure(EntityTypeBuilder<WorkCatalog> builder)
    {
        builder.ToTable(name: "WorkCatalogs", schema: "lm"); // LibraryManagement
        builder.HasKey(b => b.Id);
        builder.Property(b => b.Title).IsRequired();
        builder.Property(b => b.ISBN).IsRequired();
        builder.Property(lb => lb.Summary).IsRequired();

        builder.HasOne(b => b.Publisher).WithMany(p => p.WorkCatalogs).HasForeignKey(b => b.Id);

        builder.Property(b => b.WorkStatus).HasConversion(new EnumToStringConverter<WorkStatus>());

        builder.Property(b => b.WorkFormat).HasConversion(new EnumToStringConverter<WorkFormat>());

        //WorkInventory ile olan ilişkiyi tanımlama bir katalogun birden fazla örneği olabilir.
        builder
            .HasMany(b => b.WorkInventories)
            .WithOne(be => be.WorkCatalog)
            .HasForeignKey(be => be.BookId)
            .OnDelete(DeleteBehavior.Cascade);

        // WorkCatalog - Publisher ilişkisi

        builder
            .HasOne(b => b.Publisher)
            .WithMany(p => p.WorkCatalogs)
            .HasForeignKey(b => b.PublisherId)
            .OnDelete(DeleteBehavior.Cascade);

        // Book - Authors ilişkisi


        builder
            .HasMany(a => a.Authors)
            .WithMany(wc => wc.WorkCatalogs)
            .UsingEntity<AuthorWorkCatalog>(
                j => j.HasOne(awc => awc.Author).WithMany().HasForeignKey(awc => awc.AuthorId),
                j =>
                    j.HasOne(awc => awc.WorkCatalog)
                        .WithMany()
                        .HasForeignKey(awc => awc.WorkCatalogId),
                j =>
                {
                    j.HasKey(wa => new { wa.WorkCatalogId, wa.AuthorId });
                    j.ToTable("Author_WorkCatalogs", "lm");
                }
            );

        // Book - Tags ilişkisi


        builder
            .HasMany(t => t.Tags)
            .WithMany(wc => wc.WorkCatalogs)
            .UsingEntity<WorkCatalogTag>(
                j => j.HasOne(twc => twc.Tag).WithMany().HasForeignKey(twc => twc.TagId),
                j =>
                    j.HasOne(twc => twc.WorkCatalog)
                        .WithMany()
                        .HasForeignKey(twc => twc.WorkCatalogId),
                j =>
                {
                    j.HasKey(wt => new { wt.WorkCatalogId, wt.TagId });
                    j.ToTable("Tag_WorkCatalogs", "lm");
                }
            );
    }
}
