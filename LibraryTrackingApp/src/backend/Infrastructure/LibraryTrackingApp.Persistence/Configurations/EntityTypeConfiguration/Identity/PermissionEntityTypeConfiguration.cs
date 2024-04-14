using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
namespace PreAccountingBE.Persistence.Configurations.EntityTypes.Identity;

public class PermissionEntityTypeConfiguration : IEntityTypeConfiguration<Scope>
{
    public void Configure(EntityTypeBuilder<Scope> builder)
    {

        builder.ToTable("Scopes", schema: "identity");

        builder.HasKey(p => p.Id);

        // Diğer yapılandırma detayları
        // Örneğin, Property yapılandırmaları:
        builder.Property(p => p.Name).IsRequired().HasMaxLength(100);

        // İlişki yapılandırmaları vs.
    }
}
