using LibraryTrackingApp.Domain.Entities.Library;
using LibraryTrackingApp.Domain.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;

public class LibraryTransactionConfiguration : IEntityTypeConfiguration<LibraryTransaction>
{
    public void Configure(EntityTypeBuilder<LibraryTransaction> builder)
    {
        builder.ToTable(name: "LibraryTransactions", schema: "lm");// LibraryManagement

        builder.HasKey(lt => lt.Id);

    
        builder.Property(lt => lt.TransactionDate).IsRequired();
        builder.Property(lt => lt.TransactionType).IsRequired();
        builder.Property(lt => lt.Details).IsRequired();

        builder
            .Property(b => b.TransactionType)
            .HasConversion(new EnumToStringConverter<TransactionType>());

        builder.HasOne(lt => lt.LibraryBranch)
               .WithMany(lb => lb.Transactions)
               .HasForeignKey(lt => lt.LibraryBranchId);
    }
}
