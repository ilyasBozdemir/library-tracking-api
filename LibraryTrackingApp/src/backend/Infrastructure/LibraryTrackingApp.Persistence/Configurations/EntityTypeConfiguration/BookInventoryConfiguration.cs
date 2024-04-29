using LibraryTrackingApp.Domain.Entities.Library;
using LibraryTrackingApp.Domain.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;

public class BookInventoryConfiguration : IEntityTypeConfiguration<BookInventory>
{
    public void Configure(EntityTypeBuilder<BookInventory> builder)
    {
        builder.ToTable(name: "BookInventories", schema: "lm");
        builder.HasKey(be => be.Id);

        builder.Property(be => be.TransactionDateUnix).IsRequired();

     
        builder.HasIndex(bs => bs.BookNumber).IsUnique();

        builder.Property(bs => bs.BookStatus).IsRequired();
        builder.Property(bs => bs.TransactionDateUnix).IsRequired();
        builder.Property(bs => bs.BookStockTransactionType).IsRequired();


        builder.Property(bs => bs.Description).HasMaxLength(255);
        builder.Property(bs => bs.Notes).HasMaxLength(1000);

        builder
         .Property(b => b.BookStatus)
         .HasConversion(new EnumToStringConverter<BookStatus>());


        builder.HasOne(bi => bi.BookCompartment)
              .WithMany(bc => bc.BookInventoryItems)
              .HasForeignKey(bi => bi.BookCompartmentId)
              .IsRequired(false);

    }
}
