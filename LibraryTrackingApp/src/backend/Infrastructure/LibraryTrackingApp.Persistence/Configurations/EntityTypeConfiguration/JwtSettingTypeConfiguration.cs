using LibraryTrackingApp.Domain.Entities.Configuration;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;


public class JwtSettingsEntityTypeConfiguration : IEntityTypeConfiguration<JwtSettingConfiguration>
{
    public void Configure(EntityTypeBuilder<JwtSettingConfiguration> builder)
    {
        builder.ToTable("JwtSettingConfigurations", schema: "static");
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .HasColumnName("Id")
            .ValueGeneratedOnAdd();

        builder.Property(e => e.Subject)
            .HasColumnName("Subject")
            .IsRequired();

        builder.Property(e => e.Issuer)
            .HasColumnName("Issuer")
            .IsRequired();

        builder.Property(e => e.Audience)
            .HasColumnName("Audience")
            .IsRequired();

        builder.Property(e => e.SecretKey)
            .HasColumnName("SecretKey")
            .IsRequired();

        builder.Property(e => e.AccessTokenExpirationMinutes)
            .HasColumnName("AccessTokenExpirationMinutes")
            .IsRequired();

        builder.Property(e => e.Enabled)
            .HasColumnName("Enabled")
            .IsRequired();
    }
}

