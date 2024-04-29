using LibraryTrackingApp.Domain.Entities.Library;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;

public class BookStockConfiguration : IEntityTypeConfiguration<BookStockOLD>
{
    public void Configure(EntityTypeBuilder<BookStockOLD> builder)
    {
        builder.ToTable(name: "BookStocksOLD", schema: "lm");// LibraryManagement
        builder.HasKey(bs => bs.Id);
        builder.Property(bs => bs.Id).ValueGeneratedOnAdd(); 

        builder.Property(bs => bs.Id).IsRequired();
        builder.Property(bs => bs.Quantity).IsRequired();

    }
}