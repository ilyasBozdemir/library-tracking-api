using LibraryTrackingApp.Domain.Entities.Library;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;

public class LibraryBranchConfiguration : IEntityTypeConfiguration<LibraryBranch>
{
    public void Configure(EntityTypeBuilder<LibraryBranch> builder)
    {
        builder.ToTable(name: "LibraryBranches", schema: "lm");// LibraryManagement

        builder.HasKey(lb => lb.Id);
        builder.HasIndex(b => b.Name).IsUnique();


        builder.Property(lb => lb.Name).IsRequired();
        builder.Property(lb => lb.Address).IsRequired();
        builder.Property(lb => lb.PhoneNumber).IsRequired();
        builder.Property(lb => lb.OpeningDate).IsRequired();
        builder.Property(lb => lb.Description).IsRequired();

        builder
            .HasMany(lb => lb.Books)
            .WithOne(b => b.LibraryBranch)
            .HasForeignKey(b => b.LibraryBranchId);


        builder
            .HasMany(b => b.Members)
            .WithMany(t => t.LibraryBranches)
            .UsingEntity<Dictionary<string, object>>(
            "LibraryBranchMembers",
            j => j
            .HasOne<Member>()
            .WithMany()
            .HasForeignKey("MemberId"),
            j => j
            .HasOne<LibraryBranch>()
            .WithMany()
            .HasForeignKey("LibraryBranchId"),
            j =>
            {
                j.HasKey("MemberId", "LibraryBranchId");
                j.ToTable("LibraryBranchMembers");
            }
            );




        builder.HasMany(lb => lb.BranchHours)
               .WithOne(bh => bh.LibraryBranch)
               .HasForeignKey(bh => bh.LibraryBranchId)
               .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasMany(lb => lb.Books)
            .WithOne(b => b.LibraryBranch)
            .HasForeignKey(b => b.LibraryBranchId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasMany(lb => lb.Staffs)
            .WithOne(s => s.LibraryBranch)
            .HasForeignKey(s => s.LibraryBranchId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasMany(lb => lb.Transactions)
            .WithOne(t => t.LibraryBranch)
            .HasForeignKey(t => t.LibraryBranchId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
