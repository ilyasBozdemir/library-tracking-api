using LibraryTrackingApp.Domain.Entities.Library;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;

public class LibraryTransactionConfiguration : IEntityTypeConfiguration<LibraryTransaction>
{
    public void Configure(EntityTypeBuilder<LibraryTransaction> builder)
    {
        builder.ToTable("LibraryTransactions"); // Tablo adını belirt
        builder.HasKey(lt => lt.Id); // Birincil anahtarı belirt

        // Diğer özellikleri yapılandır
        builder.Property(lt => lt.TransactionDate).IsRequired();
        builder.Property(lt => lt.TransactionType).IsRequired();
        builder.Property(lt => lt.Details).IsRequired();

        // İlişkiyi belirt
        builder.HasOne(lt => lt.LibraryBranch)
               .WithMany(lb => lb.Transactions)
               .HasForeignKey(lt => lt.LibraryBranchId);
    }
}
