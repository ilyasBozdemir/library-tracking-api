using LibraryTrackingApp.Domain.Entities.Library;
using LibraryTrackingApp.Domain.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;

public class MemberConfiguration : IEntityTypeConfiguration<Member>
{
    public void Configure(EntityTypeBuilder<Member> builder)
    {
        builder.ToTable(name: "Members", schema: "lm");// LibraryManagement

        builder.HasKey(m => m.Id);

        builder.Property(m => m.Gender);
        builder.Property(m => m.Occupation);
        builder.Property(m => m.NumberOfLateReturns).IsRequired(); 
        builder.Property(m => m.MaxLateReturnsAllowed).IsRequired(); 
        builder.Property(m => m.HasPenalty).IsRequired(); 
        builder.Property(m => m.PenaltyDurationInDays).IsRequired();
        builder.Property(m => m.IsExtensionAllowed).IsRequired(); 
        builder.Property(m => m.ExtensionDurationInDays).IsRequired();

        builder
           .HasOne(s => s.User)
           .WithOne(u => u.Member)
           .HasForeignKey<Member>(m => m.UserId)
           .OnDelete(DeleteBehavior.Restrict);


        builder
            .Property(m => m.MemberType)
            .HasConversion(new EnumToStringConverter<MemberType>());


        builder
            .Property(m => m.Gender)
            .HasConversion(new EnumToStringConverter<GenderType>());

    }
}

