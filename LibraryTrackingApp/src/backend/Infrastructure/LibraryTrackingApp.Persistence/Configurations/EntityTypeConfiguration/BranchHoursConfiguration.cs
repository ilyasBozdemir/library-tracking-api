using LibraryTrackingApp.Domain.Entities.Library;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;

public class BranchHoursConfiguration : IEntityTypeConfiguration<BranchHour>
{
    public void Configure(EntityTypeBuilder<BranchHour> builder)
    {
        builder.ToTable("BranchHours");
        builder.HasKey(bh => bh.Id); 

      
        builder.Property(bh => bh.DayOfWeek).IsRequired();
        builder.Property(bh => bh.OpeningTime).IsRequired();
        builder.Property(bh => bh.ClosingTime).IsRequired();
    }
}