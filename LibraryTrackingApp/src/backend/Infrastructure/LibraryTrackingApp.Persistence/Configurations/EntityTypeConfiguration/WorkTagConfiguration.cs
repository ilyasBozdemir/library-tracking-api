using LibraryTrackingApp.Domain.Entities.Library;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;

public class WorkTagConfiguration : IEntityTypeConfiguration<WorkTag>
{
    public void Configure(EntityTypeBuilder<WorkTag> builder)
    {
        builder.ToTable(name: "WorkTags", schema: "lm");// LibraryManagement

        builder.HasKey(t => t.Id);
        builder.HasIndex(t => t.Name);


        builder.Property(t => t.Name).IsRequired();

    }
}
