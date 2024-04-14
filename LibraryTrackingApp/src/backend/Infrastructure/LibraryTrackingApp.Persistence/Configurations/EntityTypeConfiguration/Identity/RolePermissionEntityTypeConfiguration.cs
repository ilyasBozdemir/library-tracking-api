using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace PreAccountingBE.Persistence.Configurations.EntityTypes.Identity;

public class RolePermissionEntityTypeConfiguration : IEntityTypeConfiguration<RoleScope>
{
    public void Configure(EntityTypeBuilder<RoleScope> builder)
    {

        builder.ToTable("RolePermissions", schema: "identity");

        builder.HasKey(rp => new { rp.RoleId, rp.ScopeId });

        builder.HasOne(rp => rp.Role)
            .WithMany(r => r.RoleScopes)
            .HasForeignKey(rp => rp.RoleId);

        builder.HasOne(rp => rp.Scope)
            .WithMany(p => p.RoleScopes)
            .HasForeignKey(rp => rp.ScopeId);
    }

}

