using LibraryTrackingApp.Domain.Entities.Library;
using LibraryTrackingApp.Domain.Enums;

namespace LibraryTrackingApp.Persistence.Data;

// SeedData bu sınıfla beraber 1-1 1-n n-n gibi ilişkilerde güncellemelerden sonra düzelmemiş yerler kalabilir bunlar zamanla düzeltilcektir.

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
            Website = "www.example.com",
            Biography =
                "Joanne Rowling, better known by her pen name J.K. Rowling, is a British author, philanthropist, film producer, television producer, and screenwriter. She is best known for writing the Harry Potter fantasy series.",
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id,
        };

        var fantasyGenre = new WorkGenre
        {
            Id = Guid.NewGuid(),
            Name = "Fantasy",
            IsActive = true,
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id
        };

        var adventureGenre = new WorkGenre
        {
            Id = Guid.NewGuid(),
            Name = "Adventure",
            IsActive = true,
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id
        };

        var mainBranchId = Guid.NewGuid();
        var secondBranchId = Guid.NewGuid();

        var mainBranch = new LibraryBranch
        {
            Id = mainBranchId,
            Name = "Ana Kütüphane Şubesi",
            Address = "456 İkinci Sokak, No: 15",
            PhoneNumber = "+90 (212) 123 4567",
            Description =
                "Ana Kütüphane Şubesi, şehrin kalbindeki kitapseverler için bir buluşma noktasıdır.",
            MaxCheckoutLimit = 7,
            MinCheckoutDurationInDays = 4,
            MaxCheckoutDurationInDays = 10,
            CriticalLevelThreshold = 6,
            NotifyOnBookOrBlogComment = true,
            TopMembersReportLimit = 7,
            TopBooksReportLimit = 7,
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id
        };

        var secondBranch = new LibraryBranch
        {
            Id = secondBranchId,
            Name = "Yıldızlar Kütüphanesi",
            Address = "789 Üçüncü Bulvar, No: 23",
            PhoneNumber = "+90 (212) 987 6543",
            Description = "Yıldızlar Kütüphanesi, gökyüzünü aşkın kitaplarla dolu bir yerdir.",
            MaxCheckoutLimit = 10,
            MinCheckoutDurationInDays = 3,
            MaxCheckoutDurationInDays = 14,
            CriticalLevelThreshold = 8,
            NotifyOnBookOrBlogComment = false,
            TopMembersReportLimit = 10,
            TopBooksReportLimit = 10,
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id
        };

        int shelfCountPerLibrary = 4;
        int compartmentCountPerShelf = 5;
        int compartmentCountPerBook = 10;
        int bookCount = compartmentCountPerBook * shelfCountPerLibrary * compartmentCountPerShelf;

        var harryPotterBookId = Guid.NewGuid();

        var firstEditionId = Guid.NewGuid();
        var secondEditionId = Guid.NewGuid();
        var thirdEditionId = Guid.NewGuid();


        List<Shelf> shelves = new List<Shelf>();
        List<WorkCompartment> workCompartments = new List<WorkCompartment>();

        for (int i = 0; i < shelfCountPerLibrary; i++)
        {
            var shelf = new Shelf
            {
                Id = Guid.NewGuid(),
                Name = $"Shelf {i + 1}",
                LibraryBranchId = mainBranchId,
                CreatedById = systemUser.Id,
                CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
                LastModifiedById = systemUser.Id
            };

            shelves.Add(shelf);

            for (int j = 0; j < compartmentCountPerShelf; j++)
            {
                var compartment = new WorkCompartment
                {
                    Id = Guid.NewGuid(),
                    Name = $"Compartment {j + 1}",
                    ShelfId = shelf.Id,
                    CreatedById = systemUser.Id,
                    CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
                    LastModifiedById = systemUser.Id,
                };

                workCompartments.Add(compartment);
            }
        }

        List<WorkInventory> workInventories = new List<WorkInventory>();



        for (int i = 0; i < bookCount; i++)
        {

            var item = new WorkInventory
            {
                Id = Guid.NewGuid(),
                BookId = harryPotterBookId,
                BookNumber = $"HP-{i + 1}",
                BookStatus = WorkStatus.Active,
                IsAvailable = true,
                Description = null,
                Notes = null,
                Donor = null,
                BookStockTransactionType = BookStockTransactionType.Entry,
                CreatedById = systemUser.Id,
                CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
                LastModifiedById = systemUser.Id
            };
            workInventories.Add(item);
        }

        // Kitapları raf ve bölmelere dağıtma işlemi

        int bookIndex = 0;


        for (int i = 0; i < workInventories.Count; i++)
        {
            var workInventory = workInventories[i];

            int bookSequence = i + 1;

            int shelfIndex = (bookSequence - 1) / (compartmentCountPerShelf * compartmentCountPerBook);
            int compartmentIndex = ((bookSequence - 1) / compartmentCountPerBook) % compartmentCountPerShelf;

            Guid shelfId = shelves[shelfIndex].Id;
            Guid compartmentId = workCompartments[compartmentIndex].Id;


            workInventory.ShelfId = shelfId;
            workInventory.BookCompartmentId = compartmentId;
        }




        var bloomsburyPublishingPublisher = new WorkPublisher
        {
            Id = Guid.NewGuid(),
            Name = "Bloomsbury Publishing",
            Website = "https://www.bloomsbury.com/",
            Address = "50 Bedford Square, London, England",
            City = "London",
            Country = "England",
            PhoneNumber = "+44 (0)20 7631 5600",
            Email = "info@bloomsbury.com",
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id
        };

        var penguinBooksPublisher = new WorkPublisher
        {
            Id = Guid.NewGuid(),
            Name = "Penguin Books",
            Website = "https://www.penguin.co.uk/",
            Address = "80 Strand, London, England",
            City = "London",
            Country = "England",
            PhoneNumber = "+44 (0)20 7139 3000",
            Email = "info@penguin.co.uk",
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id
        };

        var randomHousePublisher = new WorkPublisher
        {
            Id = Guid.NewGuid(),
            Name = "Random House",
            Website = "https://www.randomhousebooks.com/",
            Address = "1745 Broadway, New York, NY, USA",
            City = "New York",
            Country = "USA",
            PhoneNumber = "+1 212-782-9000",
            Email = "info@randomhouse.com",
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id
        };

        var harryPotterBook = new WorkCatalog
        {
            Id = harryPotterBookId,
            GenreId = fantasyGenre.Id,
            LibraryBranchId = mainBranch.Id,
            PublisherId = bloomsburyPublishingPublisher.Id,
            AuthorId = jKRowlingAuthor.Id,
            Title = "Harry Potter and the Philosopher's Stone",
            DeweyCode = "800",
            IsApproved = true,
            ISBN = "9781408855652",
            Summary = """
                Harry Potter has never even heard of Hogwarts when the letters start dropping on the doormat at number four, Privet Drive.
                Addressed in green ink on yellowish parchment with a purple seal, they are swiftly confiscated by his grisly aunt and uncle.
                Then, on Harry's eleventh birthday, a great beetle-eyed giant of a man called Rubeus Hagrid bursts in with some astonishing news: Harry Potter is a wizard, and he has a place at Hogwarts School of Witchcraft and Wizardry. An incredible adventure is about to begin!
                """,
            CoverImageUrl = "https://m.media-amazon.com/images/I/81q77Q39nEL._SY385_.jpg",
            PageCount = 352,
            OriginalPublicationDate = new DateTime(1997, 6, 26),
            WorkStatus = WorkStatus.Active,
            WorkFormat = WorkFormat.PrintedBook,
            WorkLanguage = "English",
            AudioFilePath = null,
            FilePath = null,
            IsFeatured = true,
            Translator = null,
            Editor = null,
            IsBorrowable = true,
            HasTagPrinted = false,
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id
        };


        var firstEdition = new Edition
        {
            Id = firstEditionId,
            WorkInventoryId = harryPotterBook.Id,
            PublisherId = bloomsburyPublishingPublisher.Id,
            EditionNumber = 1,
            PublicationDate = new DateTime(1997, 6, 26),
            Notes = "First edition of Harry Potter and the Philosopher's Stone."
        };

        var secondEdition = new Edition
        {
            Id = secondEditionId,
            WorkInventoryId = harryPotterBook.Id,
            PublisherId = penguinBooksPublisher.Id,
            EditionNumber = 2,
            PublicationDate = new DateTime(1998, 7, 2),
            Notes = "Second edition of Harry Potter and the Philosopher's Stone."
        };

        var thirdEdition = new Edition
        {
            Id = thirdEditionId,
            WorkInventoryId = harryPotterBook.Id,
            PublisherId = randomHousePublisher.Id,
            EditionNumber = 3,
            PublicationDate = new DateTime(1999, 5, 5),
            Notes = "Third edition of Harry Potter and the Philosopher's Stone."
        };

        List<Edition> editions = new List<Edition>()
        {
            firstEdition,
            secondEdition,
            thirdEdition,
        };


        List<EditionWorkInventory> editionWorkInventoryList = new List<EditionWorkInventory>();


        foreach (var edition in editions)
        {
            foreach (var workInventory in workInventories)
            {
                var editionWorkInventory = new EditionWorkInventory
                {
                    EditionId = edition.Id,
                    WorkInventoryId = workInventory.Id
                };
                editionWorkInventoryList.Add(editionWorkInventory);
            }
        }

        var bookAuthor = new AuthorWorkCatalog
        {
            WorkCatalogId = harryPotterBook.Id,
            AuthorId = jKRowlingAuthor.Id
        };



        var harryPotterTag1 = new WorkTag
        {
            Id = Guid.NewGuid(),
            Name = "Hogwarts",
            WorkCatalogId = harryPotterBook.Id,
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id
        };

        var harryPotterTag2 = new WorkTag
        {
            Id = Guid.NewGuid(),
            Name = "Harry Potter",
            WorkCatalogId = harryPotterBook.Id,
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id
        };

        var harryPotterTag3 = new WorkTag
        {
            Id = Guid.NewGuid(),
            Name = "Quidditch",
            WorkCatalogId = harryPotterBook.Id,
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id
        };



        var bookTag1 = new WorkCatalogTag
        {
            WorkCatalogId = harryPotterBook.Id,
            TagId = harryPotterTag1.Id
        };

        var bookTag2 = new WorkCatalogTag
        {
            WorkCatalogId = harryPotterBook.Id,
            TagId = harryPotterTag2.Id
        };


        var bookTag3 = new WorkCatalogTag
        {
            WorkCatalogId = harryPotterBook.Id,
            TagId = harryPotterTag3.Id
        };

        var member1 = new Member
        {
            Id = Guid.NewGuid(),
            UserId = memberUser.Id,
            MembershipDate = DateTime.Now,
            Gender = GenderType.Male,
            Occupation = "Software Engineer",
            MemberType = MemberType.Adult,
            MembershipStatus = MembershipStatus.Active,
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
            MembershipStatus = MembershipStatus.Active,
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


        var memberLibraryBranch = new LibraryBranchMember
        {
            MemberId = member1.Id,
            LibraryBranchId = mainBranchId
        };


        var memberLibraryBranch2 = new LibraryBranchMember
        {
            MemberId = member2.Id,
            LibraryBranchId = mainBranchId
        };


        var memberLibraryBranch3 = new LibraryBranchMember
        {
            MemberId = member2.Id,
            LibraryBranchId = secondBranchId
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



        var hp5Inventory = workInventories.FirstOrDefault(item => item.BookNumber == "HP-5");
        var hp10Inventory = workInventories.FirstOrDefault(item => item.BookNumber == "HP-10");
        var hp15Inventory = workInventories.FirstOrDefault(item => item.BookNumber == "HP-15");


        var borrow = new BorrowLend
        {
            Id = Guid.NewGuid(),
            MemberId = member1.Id,
            WorkCatalogId = harryPotterBook.Id,
            WorkInventoryId = hp5Inventory.Id,
            StaffLenderId = staff.Id,
            BorrowDate = DateTime.Now - TimeSpan.FromDays(10),
            BorrowStatus = BorrowStatus.Borrowed,
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id
        };

        borrow.DueDate = DateTime.Now; //zamanında iade için
        borrow.ReturnDate = DateTime.Now;
        borrow.BorrowStatus = BorrowStatus.Returned;

        borrow.IsLate = borrow.ReturnDate > borrow.DueDate;
        borrow.LateDurationInDays =
            borrow.IsLate == true ? (int?)(borrow.ReturnDate - borrow.DueDate)?.TotalDays : 0;

        var borrow2 = new BorrowLend // gecikmeli iade için
        {
            Id = Guid.NewGuid(),
            MemberId = member2.Id,
            WorkCatalogId = harryPotterBook.Id,
            WorkInventoryId = hp10Inventory.Id,
            StaffLenderId = staff.Id,
            BorrowDate = DateTime.Now - TimeSpan.FromDays(10),
            BorrowStatus = BorrowStatus.Borrowed,
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id
        };

        borrow2.DueDate = DateTime.Now - TimeSpan.FromDays(1);
        borrow2.ReturnDate = DateTime.Now;
        borrow2.BorrowStatus = BorrowStatus.DelayedReturn;

        borrow2.IsLate = borrow2.ReturnDate > borrow2.DueDate;
        borrow2.LateDurationInDays =
            borrow2.IsLate == true ? (int?)(borrow2.ReturnDate - borrow2.DueDate)?.TotalDays : 0;



        var borrow3 = new BorrowLend // iade edilmemiş olan için.
        {
            Id = Guid.NewGuid(),
            MemberId = member2.Id,
            WorkCatalogId = harryPotterBook.Id,
            WorkInventoryId = hp15Inventory.Id,
            StaffLenderId = staff.Id,
            BorrowDate = DateTime.Now - TimeSpan.FromDays(10),
            BorrowStatus = BorrowStatus.Borrowed,
            CreatedById = systemUser.Id,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            LastModifiedById = systemUser.Id
        };

        borrow3.DueDate = DateTime.Now + TimeSpan.FromDays(1);

        borrow3.IsLate = borrow3.ReturnDate > borrow3.DueDate;
        borrow3.LateDurationInDays =
            borrow3.IsLate == true ? (int?)(borrow3.ReturnDate - borrow3.DueDate)?.TotalDays : 0;








        SeedEntities<AppRole>(modelBuilder, systemRole, adminRole, staffRole, memberRole);
        SeedEntities<AppUser>(
            modelBuilder,
            systemUser,
            adminUser,
            staffUser,
            memberUser,
            memberUser2
        );
        SeedEntities<AppUserRole>(modelBuilder, appUserRole, appUserRole2);
        SeedEntities<Author>(modelBuilder, jKRowlingAuthor);
        SeedEntities<WorkGenre>(modelBuilder, fantasyGenre, adventureGenre);
        SeedEntities<LibraryBranch>(modelBuilder, mainBranch, secondBranch);
        SeedEntities<BranchHour>(
            modelBuilder,
            mondaybranchHour,
            tuesdaybranchHour,
            wednesdaybranchHour,
            thursdaybranchHour,
            fridaybranchHour,
            saturdaybranchHour,
            sundaybranchHour
        );
        SeedEntities<WorkPublisher>(
            modelBuilder,
            bloomsburyPublishingPublisher,
            randomHousePublisher,
            penguinBooksPublisher
        );
        SeedEntities<Edition>(modelBuilder, firstEdition, secondEdition, thirdEdition);
        SeedEntities<WorkCatalog>(modelBuilder, harryPotterBook);
        SeedEntities<WorkTag>(modelBuilder, harryPotterTag1, harryPotterTag2, harryPotterTag3);
        SeedEntities<Member>(modelBuilder, member1, member2);
        SeedEntities<BorrowLend>(modelBuilder, borrow, borrow2, borrow3);
        SeedEntities<Staff>(modelBuilder, staff);
        SeedEntities<AuthorWorkCatalog>(modelBuilder, bookAuthor);


        SeedEntities<WorkInventory>(modelBuilder, workInventories.ToArray());
        SeedEntities<Shelf>(modelBuilder, shelves.ToArray());
        SeedEntities<WorkCompartment>(modelBuilder, workCompartments.ToArray());
        SeedEntities<EditionWorkInventory>(modelBuilder, editionWorkInventoryList.ToArray());

        SeedEntities<WorkCatalogTag>(modelBuilder, bookTag1, bookTag2, bookTag3);

        SeedEntities<LibraryBranchMember>(modelBuilder, memberLibraryBranch, memberLibraryBranch2, memberLibraryBranch3);

    }

    private static void SeedEntities<T>(ModelBuilder modelBuilder, params T[] entities)
        where T : class
    {
        modelBuilder.Entity<T>().HasData(entities);
    }
}
