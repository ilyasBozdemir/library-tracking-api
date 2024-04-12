using LibraryTrackingApp.Domain.Entities.Library;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;

public class MemberConfiguration : IEntityTypeConfiguration<Member>
{
    public void Configure(EntityTypeBuilder<Member> builder)
    {
        builder.ToTable("Members"); 
        builder.HasKey(m => m.Id);
        builder.Property(m => m.Id).ValueGeneratedOnAdd();

        builder.Property(m => m.Name).IsRequired(); 
        builder.Property(m => m.Email).IsRequired();
        builder.Property(m => m.Address);
        builder.Property(m => m.PhoneNumber);
        builder.Property(m => m.BirthDate).IsRequired();
        builder.Property(m => m.Gender);
        builder.Property(m => m.Occupation);
        builder.Property(m => m.NumberOfLateReturns).IsRequired(); 
        builder.Property(m => m.MaxLateReturnsAllowed).IsRequired(); 
        builder.Property(m => m.HasPenalty).IsRequired(); 
        builder.Property(m => m.PenaltyDurationInDays).IsRequired();
        builder.Property(m => m.IsExtensionAllowed).IsRequired(); 
        builder.Property(m => m.ExtensionDurationInDays).IsRequired();
    }
}

