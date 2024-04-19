using LibraryTrackingApp.Domain.Entities.Library;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;

// eklenecek daha
public class ReadingListConfiguration : IEntityTypeConfiguration<ReadingList>
{
    public void Configure(EntityTypeBuilder<ReadingList> builder)
    {
        builder.ToTable(name: "ReadingLists", schema: "lm");
        builder.HasKey(rl => rl.Id);
    }
}
