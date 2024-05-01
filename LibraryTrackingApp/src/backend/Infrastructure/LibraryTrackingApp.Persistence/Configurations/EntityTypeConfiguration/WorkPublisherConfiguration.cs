using LibraryTrackingApp.Domain.Entities.Library;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;

public class WorkPublisherConfiguration : IEntityTypeConfiguration<WorkPublisher>
{
    public void Configure(EntityTypeBuilder<WorkPublisher> builder)
    {
        builder.ToTable(name: "WorkPublishers", schema: "lm");// LibraryManagement

        builder.HasKey(p => p.Id);
        builder.HasIndex(p => p.Email).IsUnique();
        builder.HasIndex(p => p.Name);

        builder.Property(p => p.Name).IsRequired();
        builder.Property(p => p.Address).IsRequired();
        builder.Property(p => p.Email).IsRequired();

    
    }
}
