using LibraryTrackingApp.Domain.Entities.Library;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;


public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.ToTable(name: "Authors", schema: "lm");// LibraryManagement
        builder.HasKey(a => a.Id);
        builder.Property(a => a.Name).IsRequired();
        builder.Property(a => a.Surname).IsRequired();
        builder.Property(a => a.Biography).IsRequired();
        builder.Property(a => a.BirthDate).IsRequired();
        builder.Property(a => a.Country).IsRequired();
    }
}