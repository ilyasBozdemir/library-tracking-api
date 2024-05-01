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
        builder.Property(lb => lb.Description).IsRequired();

        builder
            .HasMany(lb => lb.WorkCatalogs)
            .WithOne(b => b.LibraryBranch)
            .HasForeignKey(b => b.LibraryBranchId);


        builder.HasMany(lb => lb.Shelves)
               .WithOne(s => s.LibraryBranch)
               .HasForeignKey(s => s.LibraryBranchId) 
               .OnDelete(DeleteBehavior.Cascade); 




        builder.HasMany(lb => lb.BranchHours)
               .WithOne(bh => bh.LibraryBranch)
               .HasForeignKey(bh => bh.LibraryBranchId)
               .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasMany(lb => lb.WorkCatalogs)
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


       
        builder
         .HasMany(t => t.Members)
         .WithMany(wc => wc.LibraryBranches)
         .UsingEntity<LibraryBranchMember>(
         j => j.HasOne(twc => twc.Member).WithMany().HasForeignKey(twc => twc.MemberId),
         j => j.HasOne(twc => twc.LibraryBranch).WithMany().HasForeignKey(twc => twc.LibraryBranchId),
         j =>
         {
             j.HasKey(wt => new { wt.MemberId, wt.LibraryBranchId });
             j.ToTable("LibraryBranch_Member", "lm");
         }
         );
        

        // library- owner user n-n  yapılcak...



    }
}
