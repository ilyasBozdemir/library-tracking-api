using LibraryTrackingApp.Domain.Entities.Library;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;

// eklenecek daha
public class ReviewConfiguration : IEntityTypeConfiguration<WorkReview>
{
    public void Configure(EntityTypeBuilder<WorkReview> builder)
    {
        builder.ToTable(name: "BookReviews", schema: "lm");
        builder.HasKey(r => r.Id);
    }
}
