using LibraryTrackingApp.Domain.Entities.Library;
using LibraryTrackingApp.Domain.Enums;
using LibraryTrackingApp.Persistence.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Reflection;

namespace LibraryTrackingApp.Persistence.Contexts;


public class AppIdentityDbContext : IdentityDbContext<AppUser, AppRole, Guid>
{
    public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) : base(options) { }
    
    // dbset'lere gerek yok burda generic repository pattern hallediyor.

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        bool isDev = true;//sadece dev modda veritabnını seed et
        if (isDev)
            SeedData.Seed(modelBuilder);
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

}