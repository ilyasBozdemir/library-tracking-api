using LibraryTrackingApp.Domain.Entities.Configuration;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace LibraryTrackingApp.Persistence.Configurations.EntityTypeConfiguration;

public class MailAccountTypeConfiguration : IEntityTypeConfiguration<MailAccountConfiguration>
{
    public void Configure(EntityTypeBuilder<MailAccountConfiguration> builder)
    {
        builder.ToTable("MailAccounts", schema: "static");// Veritabanında tablo adı
        builder.HasKey(ms => ms.Id); // Primary key olarak Id'yi kullanma
        builder.Property(ms => ms.Owner).IsRequired().HasMaxLength(100); // Owner özelliği zorunlu ve maksimum 100 karakter olmalı
        builder.Property(ms => ms.SmtpServer).IsRequired().HasMaxLength(100); // SmtpServer özelliği zorunlu ve maksimum 100 karakter olmalı
        builder.Property(ms => ms.Port).IsRequired(); // Port özelliği zorunlu
        builder.Property(ms => ms.SenderEmail).IsRequired().HasMaxLength(100); // SenderEmail özelliği zorunlu ve maksimum 100 karakter olmalı
        builder.Property(ms => ms.SenderName).IsRequired().HasMaxLength(100); // SenderName özelliği zorunlu ve maksimum 100 karakter olmalı
        builder.Property(ms => ms.Username).IsRequired().HasMaxLength(100); // Username özelliği zorunlu ve maksimum 100 karakter olmalı
        builder.Property(ms => ms.Password).IsRequired().HasMaxLength(100); // Password özelliği zorunlu ve maksimum 100 karakter olmalı
    }
}