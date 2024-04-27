using LibraryTrackingApp.Domain.Entities.Library;
using LibraryTrackingApp.Domain.Enums;

namespace LibraryTrackingApp.Persistence.Data;

public static class SeedData
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        var systemRole = new AppRole
        {
            Id = Guid.NewGuid(),
            Name = "system",
            NormalizedName = "SYSTEM",
            ConcurrencyStamp = Guid.NewGuid().ToString()
        };

        var adminRole = new AppRole
        {
            Id = Guid.NewGuid(),
            Name = "Admin",
            NormalizedName = "ADMIN",
            ConcurrencyStamp = Guid.NewGuid().ToString()
        };

        var staffRole = new AppRole
        {
            Id = Guid.NewGuid(),
            Name = "Staff",
            NormalizedName = "STAFF",
            ConcurrencyStamp = Guid.NewGuid().ToString()
        };

        var memberRole = new AppRole
        {
            Id = Guid.NewGuid(),
            Name = "Member",
            NormalizedName = "MEMBER",
            ConcurrencyStamp = Guid.NewGuid().ToString()
        };

        var hasher = new PasswordHasher<AppUser>();

        var systemUserId = Guid.NewGuid();

        var systemUser = new AppUser
        {
            Id = systemUserId,
            UserName = "system",
            NormalizedUserName = "SYSTEM",
            Name = "System",
            Surname = "Admin",
            Email = "system@domain.com",
            NormalizedEmail = "SYSTEM@DOMAIN.COM",
            EmailConfirmed = true,
            Gender = GenderType.Male,
            Address = "123 System St.",
            BirthDate = new DateTime(1980, 1, 1),
            ProfilePicture = new byte[] { },
            PasswordHash = hasher.HashPassword(null, "SYSTEM@DOMAIN.COM"),
            SecurityStamp = string.Empty,
            ConcurrencyStamp = Guid.NewGuid().ToString(),
            CreatedById = Guid.Empty,
            LastModifiedById = Guid.Empty,
        };

        var adminUser = new AppUser
        {
            Id = Guid.NewGuid(),
            UserName = "admin@example.com",
            NormalizedUserName = "ADMIN@EXAMPLE.COM",
            Email = "admin@example.com",
            NormalizedEmail = "ADMIN@EXAMPLE.COM",
            Name = "Admin",
            Surname = "Admin",
            EmailConfirmed = true,
            Gender = GenderType.Male,
            Address = "456 Admin St.",
            BirthDate = new DateTime(1985, 5, 15),
            ProfilePicture = new byte[] { },
            PasswordHash = hasher.HashPassword(null, "ADMIN@EXAMPLE.COM"),
            SecurityStamp = string.Empty,
            ConcurrencyStamp = Guid.NewGuid().ToString(),
            CreatedById = systemUserId,
            LastModifiedById = systemUserId,
        };

        var staffUser = new AppUser
        {
            Id = Guid.NewGuid(),
            UserName = "employee1@example.com",
            NormalizedUserName = "EMPLOYEE1@EXAMPLE.COM",
            Email = "employee1@example.com",
            NormalizedEmail = "EMPLOYEE1@EXAMPLE.COM",
            Name = "Employee",
            Surname = "One",
            EmailConfirmed = true,
            Gender = GenderType.Female,
            Address = "789 Employee St.",
            BirthDate = new DateTime(1990, 10, 20),
            ProfilePicture = new byte[] { },
            PasswordHash = hasher.HashPassword(null, "EMPLOYEE1@EXAMPLE.COM"),
            SecurityStamp = string.Empty,
            ConcurrencyStamp = Guid.NewGuid().ToString(),
            CreatedById = systemUserId,
            LastModifiedById = systemUserId,
        };


        var memberUser = new AppUser
        {
            Id = Guid.NewGuid(),
            UserName = "john.doe@example.com",
            NormalizedUserName = "JOHN.DOE@EXAMPLE.COM",
            Email = "john.doe@example.com",
            NormalizedEmail = "JOHN.DOE@EXAMPLE.COM",
            Name = "John",
            Surname = "Doe",
            EmailConfirmed = true,
            Gender = GenderType.Male,
            Address = "123 Main Street",
            BirthDate = new DateTime(1990, 5, 15),
            ProfilePicture = new byte[] { },
            PasswordHash = hasher.HashPassword(null, "john.doe@example.com"),
            SecurityStamp = string.Empty,
            ConcurrencyStamp = Guid.NewGuid().ToString(),
            CreatedById = systemUserId,
            LastModifiedById = systemUserId,
        };

        var memberUser2 = new AppUser
        {
            Id = Guid.NewGuid(),
            UserName = "jane.smith@example.com",
            NormalizedUserName = "JANE.SMITH@EXAMPLE.COM",
            Email = "jane.smith@example.com",
            NormalizedEmail = "JANE.SMITH@EXAMPLE.COM",
            Name = "Jane",
            Surname = "Smith",
            EmailConfirmed = true,
            Gender = GenderType.Female,
            Address = "456 Oak Street",
            BirthDate = new DateTime(1985, 8, 20),
            ProfilePicture = new byte[] { },
            PasswordHash = hasher.HashPassword(null, "jane.smith@example.com"),
            SecurityStamp = string.Empty,
            ConcurrencyStamp = Guid.NewGuid().ToString(),
            CreatedById = systemUserId,
            LastModifiedById = systemUserId,
        };

        var appUserRole = new AppUserRole() { UserId = adminUser.Id, RoleId = adminRole.Id };

        var appUserRole2 = new AppUserRole() { UserId = staffUser.Id, RoleId = staffRole.Id };

        var jKRowlingAuthor = new Author
        {
            Id = Guid.NewGuid(),
            Name = "J.K.",
            Surname = "Rowling",
            BirthDate = new DateTime(1965, 7, 31),
            Country = "United Kingdom",
            Biography =
                "Joanne Rowling, better known by her pen name J.K. Rowling, is a British author, philanthropist, film producer, television producer, and screenwriter. She is best known for writing the Harry Potter fantasy series.",
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id,
        };

        var fantasyGenre = new BookGenre
        {
            Id = Guid.NewGuid(),
            Name = "Fantasy",
            IsActive = true,
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id
        };

        var adventureGenre = new BookGenre
        {
            Id = Guid.NewGuid(),
            Name = "Adventure",
            IsActive = true,
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id
        };

        var mainBranchId = Guid.NewGuid();

        var mainBranch = new LibraryBranch
        {
            Id = mainBranchId,
            Name = "Örnek Kütüphane Şubesi",
            Address = "123 Ana Cadde",
            PhoneNumber = "123-456-7890",
            Description = "Bu bir örnek kütüphane şubesidir.",
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id
        };

        var bloomsburyPublishingPublisher = new BookPublisher
        {
            Id = Guid.NewGuid(),
            Name = "Bloomsbury Publishing",
            Website = "https://www.bloomsbury.com/",
            Address = "50 Bedford Square, London, England",
            PhoneNumber = "+44 (0)20 7631 5600",
            Email = "info@bloomsbury.com",
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id
        };

        var bookStockId = Guid.NewGuid();
        var bookBorrowId = Guid.NewGuid();

        var harryPotterBook = new Book
        {
            Id = Guid.NewGuid(),
            GenreId = fantasyGenre.Id,
            LibraryBranchId = mainBranch.Id,
            PublisherId = bloomsburyPublishingPublisher.Id,
            AuthorId = jKRowlingAuthor.Id,
            BookStockId= bookStockId,
            BorrowId= bookBorrowId,
            Title = "Harry Potter and the Philosopher's Stone",
            ISBN = "9781408855652",
            Description =
                "Harry Potter has never even heard of Hogwarts when the letters start dropping on the doormat at number four, Privet Drive. Addressed in green ink on yellowish parchment with a purple seal, they are swiftly confiscated by his grisly aunt and uncle. Then, on Harry's eleventh birthday, a great beetle-eyed giant of a man called Rubeus Hagrid bursts in with some astonishing news: Harry Potter is a wizard, and he has a place at Hogwarts School of Witchcraft and Wizardry. An incredible adventure is about to begin!",
            CoverImageUrl = "https://m.media-amazon.com/images/I/81q77Q39nEL._SY385_.jpg",
            PageCount = 352,
            PublicationDate = new DateTime(1997, 6, 26),
            OriginalPublicationDate = new DateTime(1997, 6, 26),
            BookStatus = BookStatus.Available,
            BookFormat = BookFormat.PrintedBook,
            BookLanguage = BookLanguage.English,
            IsFeatured = true,
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id
        };

        var bookAuthor = new Dictionary<string, object>
        {
            { "BookId", harryPotterBook.Id },
            { "AuthorId", jKRowlingAuthor.Id }
        };

        var harryPotterTag1 = new BookTag
        {
            Id = Guid.NewGuid(),
            Name = "Hogwarts",
            BookId = harryPotterBook.Id,
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id
        };

        var harryPotterTag2 = new BookTag
        {
            Id = Guid.NewGuid(),
            Name = "Harry Potter",
            BookId = harryPotterBook.Id,
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id
        };

        var harryPotterTag3 = new BookTag
        {
            Id = Guid.NewGuid(),
            Name = "Quidditch",
            BookId = harryPotterBook.Id,
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id
        };

        var bookTag1 = new Dictionary<string, object>
        {
            { "BookId", harryPotterBook.Id },
            { "TagId", harryPotterTag1.Id }
        };

        var bookTag2 = new Dictionary<string, object>
        {
            { "BookId", harryPotterBook.Id },
            { "TagId", harryPotterTag2.Id }
        };

        var member1 = new Member
        {
            Id = Guid.NewGuid(),
            UserId = memberUser.Id,
            MembershipDate = DateTime.Now,
            Gender = GenderType.Male,
            Occupation = "Software Engineer",
            MemberType = MemberType.Adult,
            NumberOfLateReturns = 0,
            MaxLateReturnsAllowed = 3,
            HasPenalty = false,
            PenaltyDurationInDays = 0,
            IsExtensionAllowed = true,
            ExtensionDurationInDays = 7,
            LibraryBranchId = mainBranchId,
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id
        };

        var member2 = new Member
        {
            Id = Guid.NewGuid(),
            UserId = memberUser2.Id,
            MembershipDate = DateTime.Now,
            Gender = GenderType.Female,
            LibraryBranchId = mainBranchId,
            MemberType = MemberType.Teacher,
            Occupation = "Teacher",
            NumberOfLateReturns = 2,
            MaxLateReturnsAllowed = 3,
            HasPenalty = true,
            PenaltyDurationInDays = 7,
            IsExtensionAllowed = false,
            ExtensionDurationInDays = 0,
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id
        };



        var memberLibraryBranch = new Dictionary<string, object>
        {
            { "MemberId", member1.Id },
            { "LibraryBranchId", mainBranchId }
        };

        var memberLibraryBranch2 = new Dictionary<string, object>
        {
            { "MemberId", member2.Id },
            { "LibraryBranchId", mainBranchId }
        };

        var mondaybranchHour = new BranchHour
        {
            Id = Guid.NewGuid(),
            LibraryBranchId = mainBranchId,
            OpeningTime = new TimeSpan(8, 0, 0),
            ClosingTime = new TimeSpan(17, 30, 0),
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id
        };

        var tuesdaybranchHour = new BranchHour
        {
            Id = Guid.NewGuid(),
            LibraryBranchId = mainBranchId,
            OpeningTime = new TimeSpan(8, 0, 0),
            ClosingTime = new TimeSpan(17, 30, 0),
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id
        };

        var wednesdaybranchHour = new BranchHour
        {
            Id = Guid.NewGuid(),
            LibraryBranchId = mainBranchId,
            OpeningTime = new TimeSpan(8, 0, 0),
            ClosingTime = new TimeSpan(17, 30, 0),
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id
        };

        var thursdaybranchHour = new BranchHour
        {
            Id = Guid.NewGuid(),
            LibraryBranchId = mainBranchId,
            OpeningTime = new TimeSpan(8, 0, 0),
            ClosingTime = new TimeSpan(17, 30, 0),
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id
        };

        var fridaybranchHour = new BranchHour
        {
            Id = Guid.NewGuid(),
            LibraryBranchId = mainBranchId,
            OpeningTime = new TimeSpan(8, 0, 0),
            ClosingTime = new TimeSpan(17, 30, 0),
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id
        };

        var saturdaybranchHour = new BranchHour
        {
            Id = Guid.NewGuid(),
            LibraryBranchId = mainBranchId,
            OpeningTime = new TimeSpan(8, 0, 0),
            ClosingTime = new TimeSpan(17, 30, 0),
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id
        };

        var sundaybranchHour = new BranchHour
        {
            Id = Guid.NewGuid(),
            LibraryBranchId = mainBranchId,
            OpeningTime = new TimeSpan(0, 0, 0),
            ClosingTime = new TimeSpan(0, 0, 0),
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id
        };

       
        var bookStock = new BookStock
        {
            Id = bookStockId,
            BookId = harryPotterBook.Id,
            Quantity = 100,
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id
        };

        var staff = new Staff
        {
            Id = Guid.NewGuid(),
            UserId = staffUser.Id,
            Phone = "+905553331122",
            Address = "Employee Address",
            EmploymentDate = DateTime.Now,
            Salary = 3000.00m,
            IsFullTime = true,
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id,
            LibraryBranchId = mainBranch.Id
        };

        var borrow = new BorrowBook
        {
            Id = bookBorrowId,
            MemberId = member1.Id,
            BookId = harryPotterBook.Id,
            LenderId = staff.Id,
            BorrowDate = DateTime.Now,
            DueDate = DateTime.Now.AddDays(14),
            BorrowStatus = BorrowStatus.Borrowed,
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id
        };

        var @return = new BookReturn()
        {
            Id = Guid.NewGuid(),
            BorrowId = borrow.Id,
            ReturnDate = DateTime.Now,
            IsLate = DateTime.Now > borrow.DueDate,
            BookStatus = BookStatus.Available,
            PenaltyDurationInDays = (DateTime.Now - borrow.DueDate).Days,
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id
        };



        SeedEntities<AppRole>(modelBuilder, systemRole, adminRole, staffRole, memberRole);
        SeedEntities<AppUser>(modelBuilder, systemUser, adminUser, staffUser, memberUser, memberUser2);
        SeedEntities<AppUserRole>(modelBuilder, appUserRole, appUserRole2);
        SeedEntities<Author>(modelBuilder, jKRowlingAuthor);
        SeedEntities<BookGenre>(modelBuilder, fantasyGenre, adventureGenre);
        SeedEntities<LibraryBranch>(modelBuilder, mainBranch);
        SeedEntities<BranchHour>(modelBuilder, mondaybranchHour, tuesdaybranchHour, wednesdaybranchHour, thursdaybranchHour, fridaybranchHour, saturdaybranchHour, sundaybranchHour);
        SeedEntities<BookPublisher>(modelBuilder, bloomsburyPublishingPublisher);
        SeedEntities<Book>(modelBuilder, harryPotterBook);
        SeedEntities<BookTag>(modelBuilder, harryPotterTag1, harryPotterTag2, harryPotterTag3);
        SeedEntities<Member>(modelBuilder, member1, member2);
        SeedEntities<BorrowBook>(modelBuilder, borrow);
        SeedEntities<Staff>(modelBuilder, staff);
        SeedEntities<BookStock>(modelBuilder, bookStock);
        SeedEntities<BookReturn>(modelBuilder, @return);


        modelBuilder.Entity("BookTags").HasData(bookTag1, bookTag2);
        modelBuilder.Entity("BookAuthors").HasData(bookAuthor);
        modelBuilder.Entity("LibraryBranchMembers").HasData(memberLibraryBranch, memberLibraryBranch2);
    }


    private static void SeedEntities<T>(ModelBuilder modelBuilder, params T[] entities)
        where T : class
    {
        modelBuilder.Entity<T>().HasData(entities);
    }
}
