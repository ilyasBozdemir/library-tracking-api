using LibraryTrackingApp.Domain.Entities.Library;
using LibraryTrackingApp.Domain.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;

public class WorkInventoryConfiguration : IEntityTypeConfiguration<WorkInventory>
{
    public void Configure(EntityTypeBuilder<WorkInventory> builder)
    {
        builder.ToTable(name: "WorkInventories", schema: "lm");
        builder.HasKey(be => be.Id);

     
        builder.HasIndex(bs => bs.BookNumber).IsUnique();

        builder.Property(bs => bs.BookStatus).IsRequired();
        builder.Property(bs => bs.BookStockTransactionType).IsRequired();


        builder.Property(bs => bs.Description).HasMaxLength(255);
        builder.Property(bs => bs.Notes).HasMaxLength(1000);

        builder
         .Property(b => b.BookStatus)
         .HasConversion(new EnumToStringConverter<WorkStatus>());


        builder.HasOne(bi => bi.WorkCompartment)
              .WithMany(bc => bc.BookInventoryItems)
              .HasForeignKey(bi => bi.WorkCompartmentId)
              .IsRequired(false);
    }
}
