using LibraryTrackingApp.Domain.Entities.Library;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;

public class BookEntryConfiguration : IEntityTypeConfiguration<BookEntry>
{
    public void Configure(EntityTypeBuilder<BookEntry> builder)
    {
        builder.HasKey(be => be.Id);

        builder.Property(be => be.EntryDate).IsRequired();
    }
}
