using LibraryTrackingApp.Domain.Entities.Library;
using LibraryTrackingApp.Domain.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;

public class BorrowLendConfiguration : IEntityTypeConfiguration<BorrowLend>
{
    public void Configure(EntityTypeBuilder<BorrowLend> builder)
    {
        builder.ToTable(name: "BorrowLends", schema: "lm");// LibraryManagement
        builder.HasKey(l => l.Id);
        builder.Property(l => l.BorrowDate).IsRequired();
        builder.Property(l => l.DueDate).IsRequired();

        builder.HasIndex(b => b.MemberId);
        builder.HasIndex(b => b.WorkCatalogId);
        builder.HasIndex(b => b.BorrowDate);
        builder.HasIndex(b => b.DueDate);


        builder.Property(b => b.HasFee)
            .HasColumnType("bit");

        builder.Property(b => b.FeeAmount)
            .HasColumnType("decimal(18,2)");


        builder
            .Property(b => b.BorrowStatus)
            .HasConversion(new EnumToStringConverter<BorrowStatus>());


        builder.HasOne(b => b.WorkCatalog)
             .WithMany(b => b.Borrows)
             .HasForeignKey(b => b.WorkCatalogId)
             .OnDelete(DeleteBehavior.Restrict);



        builder.HasOne(b => b.WorkInventory)
             .WithMany(b => b.BorrowLends)
             .HasForeignKey(b => b.WorkInventoryId)
             .OnDelete(DeleteBehavior.Restrict);


        builder.HasOne(b => b.Member)
               .WithMany(m => m.Borrows)
               .HasForeignKey(b => b.MemberId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(b => b.StaffLender)
               .WithMany()
               .HasForeignKey(b => b.StaffLenderId)
               .OnDelete(DeleteBehavior.Restrict);

    }
}
