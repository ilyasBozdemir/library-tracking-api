using LibraryTrackingApp.Domain.Entities.Library;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;

public class BookStockConfiguration : IEntityTypeConfiguration<BookStock>
{
    public void Configure(EntityTypeBuilder<BookStock> builder)
    {
        builder.ToTable("BookStocks");
        builder.HasKey(bs => bs.Id);
        builder.Property(bs => bs.Id).ValueGeneratedOnAdd(); 

        builder.Property(bs => bs.Id).IsRequired();
        builder.Property(bs => bs.Quantity).IsRequired();
    }
}