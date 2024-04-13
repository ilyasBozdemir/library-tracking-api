using LibraryTrackingApp.Domain.Entities.Library;
using LibraryTrackingApp.Persistence.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Reflection;

namespace LibraryTrackingApp.Persistence.Contexts;


public class AppIdentityDbContext : IdentityDbContext<AppUser, AppRole, Guid>
{
    public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) : base(options) { }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<BookStock> BookStocks { get; set; }
    public DbSet<BranchHour> BranchHours { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<LibraryBranch> LibraryBranches { get; set; }
    public DbSet<LibraryTransaction> LibraryTransactions { get; set; }
    public DbSet<Member> Members { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
    public DbSet<Staff> Staffs { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Borrow> Borrows { get; set; }
    public DbSet<Return> Returns { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        SeedData.Seed(modelBuilder);
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

}