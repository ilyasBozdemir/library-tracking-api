using LibraryTrackingApp.Domain.Entities.Library;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;

public class TagConfiguration : IEntityTypeConfiguration<Tag>
{
    public void Configure(EntityTypeBuilder<Tag> builder)
    {
        builder.ToTable(name: "Tags", schema: "lm");// LibraryManagement

        builder.HasKey(t => t.Id);
        builder.HasIndex(t => t.Name);


        builder.Property(t => t.Name).IsRequired();

    }
}
