using LibraryTrackingApp.Domain.Entities.Library;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;

public class LibraryTransactionConfiguration : IEntityTypeConfiguration<LibraryTransaction>
{
    public void Configure(EntityTypeBuilder<LibraryTransaction> builder)
    {
        builder.ToTable("LibraryTransactions"); 
        builder.HasKey(lt => lt.Id);

    
        builder.Property(lt => lt.TransactionDate).IsRequired();
        builder.Property(lt => lt.TransactionType).IsRequired();
        builder.Property(lt => lt.Details).IsRequired();

    
        builder.HasOne(lt => lt.LibraryBranch)
               .WithMany(lb => lb.Transactions)
               .HasForeignKey(lt => lt.LibraryBranchId);
    }
}
