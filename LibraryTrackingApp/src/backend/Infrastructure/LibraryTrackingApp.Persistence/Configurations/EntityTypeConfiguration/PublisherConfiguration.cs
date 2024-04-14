using LibraryTrackingApp.Domain.Entities.Library;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;

public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
{
    public void Configure(EntityTypeBuilder<Publisher> builder)
    {
        builder.ToTable(name: "Publishers", schema: "lm");// LibraryManagement

        builder.HasKey(p => p.Id); 

        builder.Property(p => p.Name).IsRequired();
        builder.Property(p => p.Address).IsRequired();
        builder.Property(p => p.Email).IsRequired();

    
    }
}
