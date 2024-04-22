using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryTrackingApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("66215c93-1bd0-4111-8ebc-004d10dcf66f"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a2a2e02c-8fb5-40a9-84c6-2d45fe1fda89"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b04d4e9b-9264-446e-ac6a-c562a1c2f21b"), new Guid("3d1e7839-4d42-418f-b30b-c95a5f80b788") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("f675ac3e-b67f-42d2-9b87-cc43996410a2"), new Guid("a528e066-7a8f-4b4f-a133-bede8c5203d4") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"));

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("814b399c-1889-486b-be58-8358edb02553"), new Guid("2ee3fa5d-1c27-47b2-962f-565c4b2ebcbd") });

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: new Guid("a16a80ce-714c-4285-9a7b-e8403e0f587a"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BookReturns",
                keyColumn: "Id",
                keyValue: new Guid("816ea31b-5615-4997-b465-05b7dd320dcb"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BookStocks",
                keyColumn: "Id",
                keyValue: new Guid("b7f0dddd-ee6d-4bb2-952d-dd393f28b742"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { new Guid("2ee3fa5d-1c27-47b2-962f-565c4b2ebcbd"), new Guid("981a3a4b-d845-4599-9851-00388560d695") });

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { new Guid("2ee3fa5d-1c27-47b2-962f-565c4b2ebcbd"), new Guid("d39960dc-cb69-41b6-87b1-5af370cba3f9") });

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "Book_Tags",
                keyColumn: "Id",
                keyValue: new Guid("edc11ab3-edfc-464d-9839-1447cc74b342"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BranchHours",
                keyColumn: "Id",
                keyValue: new Guid("4548ca17-bf20-4512-9358-10d3e9d274af"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BranchHours",
                keyColumn: "Id",
                keyValue: new Guid("8e606b7e-ccb1-4fee-ad05-44a96ef056c1"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BranchHours",
                keyColumn: "Id",
                keyValue: new Guid("97045ec2-f165-4040-9741-779ea7de2dfe"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BranchHours",
                keyColumn: "Id",
                keyValue: new Guid("9eed18a7-a603-4ccc-98e6-bffa0e3ba063"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BranchHours",
                keyColumn: "Id",
                keyValue: new Guid("bfbec703-91b3-4dac-b191-9f7e21445482"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BranchHours",
                keyColumn: "Id",
                keyValue: new Guid("f09a5501-e6dc-41a8-a3b0-e1f6dd48198a"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BranchHours",
                keyColumn: "Id",
                keyValue: new Guid("f656b0f0-6829-4b5b-912a-aacaa536603a"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "LibraryBranchMembers",
                keyColumns: new[] { "LibraryBranchId", "MemberId" },
                keyValues: new object[] { new Guid("b7eacdc5-fd66-44b8-b7d7-1600781d9e3c"), new Guid("908fde15-116a-4bb3-98ec-e15c9a907609") });

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "LibraryBranchMembers",
                keyColumns: new[] { "LibraryBranchId", "MemberId" },
                keyValues: new object[] { new Guid("b7eacdc5-fd66-44b8-b7d7-1600781d9e3c"), new Guid("a4dbcebd-9e28-4669-a3d8-260de4623545") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b04d4e9b-9264-446e-ac6a-c562a1c2f21b"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f675ac3e-b67f-42d2-9b87-cc43996410a2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a528e066-7a8f-4b4f-a133-bede8c5203d4"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("814b399c-1889-486b-be58-8358edb02553"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "Book_Tags",
                keyColumn: "Id",
                keyValue: new Guid("981a3a4b-d845-4599-9851-00388560d695"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "Book_Tags",
                keyColumn: "Id",
                keyValue: new Guid("d39960dc-cb69-41b6-87b1-5af370cba3f9"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BorrowBooks",
                keyColumn: "Id",
                keyValue: new Guid("12dc9b1f-e100-4e0a-b4ac-62f14f94d094"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("908fde15-116a-4bb3-98ec-e15c9a907609"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2ee3fa5d-1c27-47b2-962f-565c4b2ebcbd"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("a4dbcebd-9e28-4669-a3d8-260de4623545"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("93f2f0c2-2514-466d-b765-df834beb9ad8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3d1e7839-4d42-418f-b30b-c95a5f80b788"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: new Guid("f5ae7646-d16f-4124-8f00-001895ad158d"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BookPublishers",
                keyColumn: "Id",
                keyValue: new Guid("009a1934-3bf0-4238-9372-ec2b4b07d196"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "LibraryBranches",
                keyColumn: "Id",
                keyValue: new Guid("b7eacdc5-fd66-44b8-b7d7-1600781d9e3c"));

            migrationBuilder.CreateTable(
                name: "MailAccounts",
                schema: "static",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Owner = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SmtpServer = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Port = table.Column<int>(type: "int", nullable: false),
                    SenderEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SenderName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    LastModifiedById = table.Column<int>(type: "int", nullable: false),
                    IsDeletedById = table.Column<int>(type: "int", nullable: false),
                    CreatedDateUnix = table.Column<long>(type: "bigint", nullable: false),
                    LastModifiedDateUnix = table.Column<long>(type: "bigint", nullable: true),
                    DeletedDateUnix = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailAccounts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "AppUserId", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("335ace0c-ea1f-4769-aae7-8c73c53e8932"), null, "609ae756-eb09-46ef-90ba-02c0585fabca", "Member", "MEMBER" },
                    { new Guid("457fc4a0-e9a7-4781-890c-db3d60ca8142"), null, "72079368-e365-4224-9b5e-410c79429425", "system", "SYSTEM" },
                    { new Guid("78c5b418-83a0-4be0-a312-1e9a5716812e"), null, "4aed9bdb-921c-4b6b-bb96-22e0a3a929c6", "Staff", "STAFF" },
                    { new Guid("add071f8-2db0-47fd-a3ab-a4f7ccf95294"), null, "c8386e8f-53aa-4f33-b76e-04a6c35e8341", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Email", "EmailConfirmed", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenEndDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("2603a422-c495-4364-8fea-1f105cc5a399"), 0, "5d83cfb0-fe21-4019-b6d9-f1f453e41d0c", new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), 0L, null, "admin@example.com", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), null, false, null, "admin", "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJrtrJJqNGlmGglCuKqq2V/H/h/R6SPPXKRSL3PRUPibvtrrzP0Xr76t85+GeHFTwA==", null, false, null, null, "", "admin", false, "admin@example.com" },
                    { new Guid("476e50e6-43ce-4a6c-a84f-a62d15b943dc"), 0, "c5e3e7a7-1846-43f9-9fbd-fac2d53a62f8", new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), 0L, null, "employee1@example.com", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), null, false, null, "admin", "EMPLOYEE2@EXAMPLE.COM", "EMPLOYEE2@EXAMPLE.COM", "AQAAAAIAAYagAAAAECmEo2CPyVnKSMBlDTaMJ82RCrc4zdoFQHgb7BJnu+ghgKZ8ca6ukB3wfJ4DOGxmJA==", null, false, null, null, "", "admin", false, "employee1@example.com" },
                    { new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), 0, "c2c14dca-cba8-43f2-b831-7ef2f7743f4a", new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, "system@domain.com", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, false, null, "system", "SYSTEM@DOMAIN.COM", "SYSTEM", "AQAAAAIAAYagAAAAEHEhxlsmcouwRtNYpXaS/YUOLv6txExamEDRsL3MbBcSaKp71mnqGuTMOQDbeepKuQ==", null, false, null, null, "", "system", false, "system" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Biography", "BirthDate", "Country", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "Surname" },
                values: new object[] { new Guid("e4e0f3e4-91d9-45f4-94eb-c8d7c51c5df4"), "Joanne Rowling, better known by her pen name J.K. Rowling, is a British author, philanthropist, film producer, television producer, and screenwriter. She is best known for writing the Harry Potter fantasy series.", new DateTime(1965, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "United Kingdom", new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), 1713736283L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), null, "J.K.", "Rowling" });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookGenres",
                columns: new[] { "Id", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsActive", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name" },
                values: new object[,]
                {
                    { new Guid("0e3e30bd-ff25-482b-bb09-41fed0ce237b"), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), 1713736283L, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), null, "Fantasy" },
                    { new Guid("87fd4231-fde5-4708-8c94-e48512d89e3e"), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), 1713736283L, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), null, "Adventure" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookPublishers",
                columns: new[] { "Id", "Address", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Email", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "PhoneNumber", "Website" },
                values: new object[] { new Guid("1f30dacb-f827-41bb-bcdf-b268bc561657"), "50 Bedford Square, London, England", new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), 1713736283L, null, "info@bloomsbury.com", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), null, "Bloomsbury Publishing", "+44 (0)20 7631 5600", "https://www.bloomsbury.com/" });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Book_Tags",
                columns: new[] { "Id", "BookId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name" },
                values: new object[,]
                {
                    { new Guid("23b1dac7-577c-4e57-b2c6-f02fa3478389"), new Guid("dedd6bab-1f24-420a-ad8c-91e6d41ff14d"), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), 1713736283L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), null, "Harry Potter" },
                    { new Guid("57dd7ad0-6607-4baa-a1bd-cbad24e23d7b"), new Guid("dedd6bab-1f24-420a-ad8c-91e6d41ff14d"), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), 1713736283L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), null, "Hogwarts" },
                    { new Guid("68e88f7e-244d-4e20-9242-5aa1e3ce2313"), new Guid("dedd6bab-1f24-420a-ad8c-91e6d41ff14d"), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), 1713736283L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), null, "Quidditch" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "LibraryBranches",
                columns: new[] { "Id", "Address", "BookId", "BranchHourId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Description", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "LibraryTransactionId", "MemberId", "Name", "PhoneNumber", "StaffId" },
                values: new object[] { new Guid("37a4f5d6-8439-40fd-9b22-b5d497153c48"), "123 Ana Cadde", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), 1713736283L, null, "Bu bir örnek kütüphane şubesidir.", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Örnek Kütüphane Şubesi", "123-456-7890", new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Members",
                columns: new[] { "Id", "Address", "BirthDate", "BorrowId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Email", "ExtensionDurationInDays", "Gender", "HasPenalty", "IsDeleted", "IsDeletedById", "IsExtensionAllowed", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "MaxLateReturnsAllowed", "MemberType", "MembershipDate", "Name", "NumberOfLateReturns", "Occupation", "PenaltyDurationInDays", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("0726ffa5-3f29-4ffb-9436-0978208d8788"), "456 Oak Street", new DateTime(1985, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), 1713736283L, null, "jane.smith@example.com", 0, "Female", true, false, new Guid("00000000-0000-0000-0000-000000000000"), false, new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), null, new Guid("37a4f5d6-8439-40fd-9b22-b5d497153c48"), 3, "Teacher", new DateTime(2024, 4, 21, 21, 51, 23, 842, DateTimeKind.Local).AddTicks(6314), "Jane Smith", 2, "Teacher", 7, "+1987654321" },
                    { new Guid("6dbfa15b-0017-49e4-8d6d-abb1bc757758"), "123 Main Street", new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), 1713736283L, null, "john.doe@example.com", 7, "Male", false, false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), null, new Guid("37a4f5d6-8439-40fd-9b22-b5d497153c48"), 3, "Adult", new DateTime(2024, 4, 21, 21, 51, 23, 842, DateTimeKind.Local).AddTicks(6308), "John Doe", 0, "Software Engineer", 0, "+1234567890" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("add071f8-2db0-47fd-a3ab-a4f7ccf95294"), new Guid("2603a422-c495-4364-8fea-1f105cc5a399"), "AppUserRole" },
                    { new Guid("78c5b418-83a0-4be0-a312-1e9a5716812e"), new Guid("476e50e6-43ce-4a6c-a84f-a62d15b943dc"), "AppUserRole" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Books",
                columns: new[] { "Id", "AuthorId", "BookFormat", "BookLanguage", "BookStatus", "BookStockBranchId", "BorrowId", "CoverImageUrl", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Description", "FavoriteListId", "GenreId", "ISBN", "IsDeleted", "IsDeletedById", "IsFeatured", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "OriginalPublicationDate", "PageCount", "PublicationDate", "PublisherId", "ReadingListId", "Title" },
                values: new object[] { new Guid("dedd6bab-1f24-420a-ad8c-91e6d41ff14d"), new Guid("e4e0f3e4-91d9-45f4-94eb-c8d7c51c5df4"), "PrintedBook", "English", "Available", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "https://m.media-amazon.com/images/I/81q77Q39nEL._SY385_.jpg", new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), 1713736283L, null, "Harry Potter has never even heard of Hogwarts when the letters start dropping on the doormat at number four, Privet Drive. Addressed in green ink on yellowish parchment with a purple seal, they are swiftly confiscated by his grisly aunt and uncle. Then, on Harry's eleventh birthday, a great beetle-eyed giant of a man called Rubeus Hagrid bursts in with some astonishing news: Harry Potter is a wizard, and he has a place at Hogwarts School of Witchcraft and Wizardry. An incredible adventure is about to begin!", null, new Guid("0e3e30bd-ff25-482b-bb09-41fed0ce237b"), "9781408855652", false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), null, new Guid("37a4f5d6-8439-40fd-9b22-b5d497153c48"), new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 352, new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1f30dacb-f827-41bb-bcdf-b268bc561657"), null, "Harry Potter and the Philosopher's Stone" });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BranchHours",
                columns: new[] { "Id", "ClosingTime", "CreatedById", "CreatedDateUnix", "DayOfWeek", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "OpeningTime" },
                values: new object[,]
                {
                    { new Guid("0d1ae988-2fef-461f-84a6-9a2852ea8ec0"), new TimeSpan(0, 0, 0, 0, 0), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), 1713736283L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), null, new Guid("37a4f5d6-8439-40fd-9b22-b5d497153c48"), new TimeSpan(0, 0, 0, 0, 0) },
                    { new Guid("4a95802b-452c-4723-8a88-8beac8ae0b54"), new TimeSpan(0, 17, 30, 0, 0), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), 1713736283L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), null, new Guid("37a4f5d6-8439-40fd-9b22-b5d497153c48"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("8ec50159-710b-49d2-995b-457bc62195e9"), new TimeSpan(0, 17, 30, 0, 0), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), 1713736283L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), null, new Guid("37a4f5d6-8439-40fd-9b22-b5d497153c48"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("8f3ded65-e8c9-4574-826e-d4b00feff0ab"), new TimeSpan(0, 17, 30, 0, 0), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), 1713736283L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), null, new Guid("37a4f5d6-8439-40fd-9b22-b5d497153c48"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("906f5859-8075-497a-95ee-b1216c33b4fb"), new TimeSpan(0, 17, 30, 0, 0), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), 1713736283L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), null, new Guid("37a4f5d6-8439-40fd-9b22-b5d497153c48"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("a266cab1-90ee-41a6-b959-53a814034d57"), new TimeSpan(0, 17, 30, 0, 0), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), 1713736283L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), null, new Guid("37a4f5d6-8439-40fd-9b22-b5d497153c48"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("be34382f-4126-4496-bb96-7d55a9640082"), new TimeSpan(0, 17, 30, 0, 0), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), 1713736283L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), null, new Guid("37a4f5d6-8439-40fd-9b22-b5d497153c48"), new TimeSpan(0, 8, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "LibraryBranchMembers",
                columns: new[] { "LibraryBranchId", "MemberId" },
                values: new object[,]
                {
                    { new Guid("37a4f5d6-8439-40fd-9b22-b5d497153c48"), new Guid("0726ffa5-3f29-4ffb-9436-0978208d8788") },
                    { new Guid("37a4f5d6-8439-40fd-9b22-b5d497153c48"), new Guid("6dbfa15b-0017-49e4-8d6d-abb1bc757758") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Staffs",
                columns: new[] { "Id", "Address", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "EmploymentDate", "IsDeleted", "IsDeletedById", "IsFullTime", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "Phone", "Salary", "UserId" },
                values: new object[] { new Guid("1c61daca-58fc-4dfe-aa14-ebb108d49cac"), "Employee Address", new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), 1713736283L, null, new DateTime(2024, 4, 21, 21, 51, 23, 842, DateTimeKind.Local).AddTicks(6352), false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), null, new Guid("37a4f5d6-8439-40fd-9b22-b5d497153c48"), "+905553331122", 3000.00m, new Guid("476e50e6-43ce-4a6c-a84f-a62d15b943dc") });

            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[] { new Guid("e4e0f3e4-91d9-45f4-94eb-c8d7c51c5df4"), new Guid("dedd6bab-1f24-420a-ad8c-91e6d41ff14d") });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookStocks",
                columns: new[] { "Id", "BookId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Quantity" },
                values: new object[] { new Guid("f7209bb8-c924-4b5a-8bca-43d38902d71a"), new Guid("dedd6bab-1f24-420a-ad8c-91e6d41ff14d"), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), 1713736283L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), null, 100 });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookTags",
                columns: new[] { "BookId", "TagId" },
                values: new object[,]
                {
                    { new Guid("dedd6bab-1f24-420a-ad8c-91e6d41ff14d"), new Guid("23b1dac7-577c-4e57-b2c6-f02fa3478389") },
                    { new Guid("dedd6bab-1f24-420a-ad8c-91e6d41ff14d"), new Guid("57dd7ad0-6607-4baa-a1bd-cbad24e23d7b") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BorrowBooks",
                columns: new[] { "Id", "BookId", "BorrowDate", "BorrowStatus", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "DueDate", "FeeAmount", "HasFee", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LenderId", "MemberId" },
                values: new object[] { new Guid("74cca1bf-1a0a-49fe-b2a1-8e4085f3b06f"), new Guid("dedd6bab-1f24-420a-ad8c-91e6d41ff14d"), new DateTime(2024, 4, 21, 21, 51, 23, 842, DateTimeKind.Local).AddTicks(6362), "Borrowed", new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), 1713736283L, null, new DateTime(2024, 5, 5, 21, 51, 23, 842, DateTimeKind.Local).AddTicks(6363), 0m, false, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), null, new Guid("1c61daca-58fc-4dfe-aa14-ebb108d49cac"), new Guid("6dbfa15b-0017-49e4-8d6d-abb1bc757758") });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookReturns",
                columns: new[] { "Id", "BookStatus", "BorrowId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "IsLate", "LastModifiedById", "LastModifiedDateUnix", "PenaltyDurationInDays", "ReturnDate" },
                values: new object[] { new Guid("a5923733-8c36-487a-8f89-460b1dfcc5c1"), 4, new Guid("74cca1bf-1a0a-49fe-b2a1-8e4085f3b06f"), new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), 1713736283L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), false, new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"), null, -13, new DateTime(2024, 4, 21, 21, 51, 23, 842, DateTimeKind.Local).AddTicks(6389) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MailAccounts",
                schema: "static");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("335ace0c-ea1f-4769-aae7-8c73c53e8932"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("457fc4a0-e9a7-4781-890c-db3d60ca8142"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("add071f8-2db0-47fd-a3ab-a4f7ccf95294"), new Guid("2603a422-c495-4364-8fea-1f105cc5a399") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("78c5b418-83a0-4be0-a312-1e9a5716812e"), new Guid("476e50e6-43ce-4a6c-a84f-a62d15b943dc") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d7248c53-7992-4d19-bd78-3eacef603a6e"));

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("e4e0f3e4-91d9-45f4-94eb-c8d7c51c5df4"), new Guid("dedd6bab-1f24-420a-ad8c-91e6d41ff14d") });

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: new Guid("87fd4231-fde5-4708-8c94-e48512d89e3e"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BookReturns",
                keyColumn: "Id",
                keyValue: new Guid("a5923733-8c36-487a-8f89-460b1dfcc5c1"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BookStocks",
                keyColumn: "Id",
                keyValue: new Guid("f7209bb8-c924-4b5a-8bca-43d38902d71a"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { new Guid("dedd6bab-1f24-420a-ad8c-91e6d41ff14d"), new Guid("23b1dac7-577c-4e57-b2c6-f02fa3478389") });

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { new Guid("dedd6bab-1f24-420a-ad8c-91e6d41ff14d"), new Guid("57dd7ad0-6607-4baa-a1bd-cbad24e23d7b") });

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "Book_Tags",
                keyColumn: "Id",
                keyValue: new Guid("68e88f7e-244d-4e20-9242-5aa1e3ce2313"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BranchHours",
                keyColumn: "Id",
                keyValue: new Guid("0d1ae988-2fef-461f-84a6-9a2852ea8ec0"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BranchHours",
                keyColumn: "Id",
                keyValue: new Guid("4a95802b-452c-4723-8a88-8beac8ae0b54"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BranchHours",
                keyColumn: "Id",
                keyValue: new Guid("8ec50159-710b-49d2-995b-457bc62195e9"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BranchHours",
                keyColumn: "Id",
                keyValue: new Guid("8f3ded65-e8c9-4574-826e-d4b00feff0ab"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BranchHours",
                keyColumn: "Id",
                keyValue: new Guid("906f5859-8075-497a-95ee-b1216c33b4fb"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BranchHours",
                keyColumn: "Id",
                keyValue: new Guid("a266cab1-90ee-41a6-b959-53a814034d57"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BranchHours",
                keyColumn: "Id",
                keyValue: new Guid("be34382f-4126-4496-bb96-7d55a9640082"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "LibraryBranchMembers",
                keyColumns: new[] { "LibraryBranchId", "MemberId" },
                keyValues: new object[] { new Guid("37a4f5d6-8439-40fd-9b22-b5d497153c48"), new Guid("0726ffa5-3f29-4ffb-9436-0978208d8788") });

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "LibraryBranchMembers",
                keyColumns: new[] { "LibraryBranchId", "MemberId" },
                keyValues: new object[] { new Guid("37a4f5d6-8439-40fd-9b22-b5d497153c48"), new Guid("6dbfa15b-0017-49e4-8d6d-abb1bc757758") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("78c5b418-83a0-4be0-a312-1e9a5716812e"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("add071f8-2db0-47fd-a3ab-a4f7ccf95294"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2603a422-c495-4364-8fea-1f105cc5a399"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e4e0f3e4-91d9-45f4-94eb-c8d7c51c5df4"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "Book_Tags",
                keyColumn: "Id",
                keyValue: new Guid("23b1dac7-577c-4e57-b2c6-f02fa3478389"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "Book_Tags",
                keyColumn: "Id",
                keyValue: new Guid("57dd7ad0-6607-4baa-a1bd-cbad24e23d7b"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BorrowBooks",
                keyColumn: "Id",
                keyValue: new Guid("74cca1bf-1a0a-49fe-b2a1-8e4085f3b06f"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("0726ffa5-3f29-4ffb-9436-0978208d8788"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("dedd6bab-1f24-420a-ad8c-91e6d41ff14d"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("6dbfa15b-0017-49e4-8d6d-abb1bc757758"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("1c61daca-58fc-4dfe-aa14-ebb108d49cac"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("476e50e6-43ce-4a6c-a84f-a62d15b943dc"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: new Guid("0e3e30bd-ff25-482b-bb09-41fed0ce237b"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BookPublishers",
                keyColumn: "Id",
                keyValue: new Guid("1f30dacb-f827-41bb-bcdf-b268bc561657"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "LibraryBranches",
                keyColumn: "Id",
                keyValue: new Guid("37a4f5d6-8439-40fd-9b22-b5d497153c48"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "AppUserId", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("66215c93-1bd0-4111-8ebc-004d10dcf66f"), null, "30eee71d-f1c4-45b7-a378-b750af9fdeeb", "Member", "MEMBER" },
                    { new Guid("a2a2e02c-8fb5-40a9-84c6-2d45fe1fda89"), null, "bac6a768-ed86-4598-8ff8-982733161227", "system", "SYSTEM" },
                    { new Guid("b04d4e9b-9264-446e-ac6a-c562a1c2f21b"), null, "59cf93e7-3e1a-4d6b-acf1-34d096c18dc1", "Staff", "STAFF" },
                    { new Guid("f675ac3e-b67f-42d2-9b87-cc43996410a2"), null, "74f79e71-fc3e-458c-ba02-eeddcf09c757", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Email", "EmailConfirmed", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenEndDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), 0, "9203e025-7fd7-4e5e-bfe2-b9a3d6307c46", new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, "system@domain.com", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, false, null, "system", "SYSTEM@DOMAIN.COM", "SYSTEM", "AQAAAAIAAYagAAAAEFib4kPOrhRQelsUYlAsUkSN9gOjy0XQPbSiML1NLEw0u6lMvN2/5aVgvuv1XJFHXw==", null, false, null, null, "", "system", false, "system" },
                    { new Guid("3d1e7839-4d42-418f-b30b-c95a5f80b788"), 0, "cf7363c1-062f-43e7-b709-6023d1951f49", new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), 0L, null, "employee1@example.com", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), null, false, null, "admin", "EMPLOYEE2@EXAMPLE.COM", "EMPLOYEE2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKslK8kYbm5Dhyp9ELXXboGrS92Cn9EwR/nNXvOAYet3iEEjt9dpm5vaZBH+NDpc1A==", null, false, null, null, "", "admin", false, "employee1@example.com" },
                    { new Guid("a528e066-7a8f-4b4f-a133-bede8c5203d4"), 0, "741449ec-1561-4fde-946e-d970e9e944c5", new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), 0L, null, "admin@example.com", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), null, false, null, "admin", "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOD0ouNmqtdMM55WRkOrAlD7MJpme1AGSMGKi3BmbORawR1sJhQ2KkHUU5qwJr0jYg==", null, false, null, null, "", "admin", false, "admin@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Biography", "BirthDate", "Country", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "Surname" },
                values: new object[] { new Guid("814b399c-1889-486b-be58-8358edb02553"), "Joanne Rowling, better known by her pen name J.K. Rowling, is a British author, philanthropist, film producer, television producer, and screenwriter. She is best known for writing the Harry Potter fantasy series.", new DateTime(1965, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "United Kingdom", new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), 1713733893L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), null, "J.K.", "Rowling" });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookGenres",
                columns: new[] { "Id", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsActive", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name" },
                values: new object[,]
                {
                    { new Guid("a16a80ce-714c-4285-9a7b-e8403e0f587a"), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), 1713733893L, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), null, "Adventure" },
                    { new Guid("f5ae7646-d16f-4124-8f00-001895ad158d"), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), 1713733893L, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), null, "Fantasy" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookPublishers",
                columns: new[] { "Id", "Address", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Email", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "PhoneNumber", "Website" },
                values: new object[] { new Guid("009a1934-3bf0-4238-9372-ec2b4b07d196"), "50 Bedford Square, London, England", new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), 1713733893L, null, "info@bloomsbury.com", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), null, "Bloomsbury Publishing", "+44 (0)20 7631 5600", "https://www.bloomsbury.com/" });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Book_Tags",
                columns: new[] { "Id", "BookId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name" },
                values: new object[,]
                {
                    { new Guid("981a3a4b-d845-4599-9851-00388560d695"), new Guid("2ee3fa5d-1c27-47b2-962f-565c4b2ebcbd"), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), 1713733893L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), null, "Hogwarts" },
                    { new Guid("d39960dc-cb69-41b6-87b1-5af370cba3f9"), new Guid("2ee3fa5d-1c27-47b2-962f-565c4b2ebcbd"), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), 1713733893L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), null, "Harry Potter" },
                    { new Guid("edc11ab3-edfc-464d-9839-1447cc74b342"), new Guid("2ee3fa5d-1c27-47b2-962f-565c4b2ebcbd"), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), 1713733893L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), null, "Quidditch" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "LibraryBranches",
                columns: new[] { "Id", "Address", "BookId", "BranchHourId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Description", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "LibraryTransactionId", "MemberId", "Name", "PhoneNumber", "StaffId" },
                values: new object[] { new Guid("b7eacdc5-fd66-44b8-b7d7-1600781d9e3c"), "123 Ana Cadde", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), 1713733893L, null, "Bu bir örnek kütüphane şubesidir.", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Örnek Kütüphane Şubesi", "123-456-7890", new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Members",
                columns: new[] { "Id", "Address", "BirthDate", "BorrowId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Email", "ExtensionDurationInDays", "Gender", "HasPenalty", "IsDeleted", "IsDeletedById", "IsExtensionAllowed", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "MaxLateReturnsAllowed", "MemberType", "MembershipDate", "Name", "NumberOfLateReturns", "Occupation", "PenaltyDurationInDays", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("908fde15-116a-4bb3-98ec-e15c9a907609"), "456 Oak Street", new DateTime(1985, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), 1713733893L, null, "jane.smith@example.com", 0, "Female", true, false, new Guid("00000000-0000-0000-0000-000000000000"), false, new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), null, new Guid("b7eacdc5-fd66-44b8-b7d7-1600781d9e3c"), 3, "Teacher", new DateTime(2024, 4, 21, 21, 11, 33, 591, DateTimeKind.Local).AddTicks(3002), "Jane Smith", 2, "Teacher", 7, "+1987654321" },
                    { new Guid("a4dbcebd-9e28-4669-a3d8-260de4623545"), "123 Main Street", new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), 1713733893L, null, "john.doe@example.com", 7, "Male", false, false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), null, new Guid("b7eacdc5-fd66-44b8-b7d7-1600781d9e3c"), 3, "Adult", new DateTime(2024, 4, 21, 21, 11, 33, 591, DateTimeKind.Local).AddTicks(2995), "John Doe", 0, "Software Engineer", 0, "+1234567890" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("b04d4e9b-9264-446e-ac6a-c562a1c2f21b"), new Guid("3d1e7839-4d42-418f-b30b-c95a5f80b788"), "AppUserRole" },
                    { new Guid("f675ac3e-b67f-42d2-9b87-cc43996410a2"), new Guid("a528e066-7a8f-4b4f-a133-bede8c5203d4"), "AppUserRole" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Books",
                columns: new[] { "Id", "AuthorId", "BookFormat", "BookLanguage", "BookStatus", "BookStockBranchId", "BorrowId", "CoverImageUrl", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Description", "FavoriteListId", "GenreId", "ISBN", "IsDeleted", "IsDeletedById", "IsFeatured", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "OriginalPublicationDate", "PageCount", "PublicationDate", "PublisherId", "ReadingListId", "Title" },
                values: new object[] { new Guid("2ee3fa5d-1c27-47b2-962f-565c4b2ebcbd"), new Guid("814b399c-1889-486b-be58-8358edb02553"), "PrintedBook", "English", "Available", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "https://m.media-amazon.com/images/I/81q77Q39nEL._SY385_.jpg", new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), 1713733893L, null, "Harry Potter has never even heard of Hogwarts when the letters start dropping on the doormat at number four, Privet Drive. Addressed in green ink on yellowish parchment with a purple seal, they are swiftly confiscated by his grisly aunt and uncle. Then, on Harry's eleventh birthday, a great beetle-eyed giant of a man called Rubeus Hagrid bursts in with some astonishing news: Harry Potter is a wizard, and he has a place at Hogwarts School of Witchcraft and Wizardry. An incredible adventure is about to begin!", null, new Guid("f5ae7646-d16f-4124-8f00-001895ad158d"), "9781408855652", false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), null, new Guid("b7eacdc5-fd66-44b8-b7d7-1600781d9e3c"), new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 352, new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("009a1934-3bf0-4238-9372-ec2b4b07d196"), null, "Harry Potter and the Philosopher's Stone" });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BranchHours",
                columns: new[] { "Id", "ClosingTime", "CreatedById", "CreatedDateUnix", "DayOfWeek", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "OpeningTime" },
                values: new object[,]
                {
                    { new Guid("4548ca17-bf20-4512-9358-10d3e9d274af"), new TimeSpan(0, 17, 30, 0, 0), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), 1713733893L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), null, new Guid("b7eacdc5-fd66-44b8-b7d7-1600781d9e3c"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("8e606b7e-ccb1-4fee-ad05-44a96ef056c1"), new TimeSpan(0, 17, 30, 0, 0), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), 1713733893L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), null, new Guid("b7eacdc5-fd66-44b8-b7d7-1600781d9e3c"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("97045ec2-f165-4040-9741-779ea7de2dfe"), new TimeSpan(0, 0, 0, 0, 0), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), 1713733893L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), null, new Guid("b7eacdc5-fd66-44b8-b7d7-1600781d9e3c"), new TimeSpan(0, 0, 0, 0, 0) },
                    { new Guid("9eed18a7-a603-4ccc-98e6-bffa0e3ba063"), new TimeSpan(0, 17, 30, 0, 0), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), 1713733893L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), null, new Guid("b7eacdc5-fd66-44b8-b7d7-1600781d9e3c"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("bfbec703-91b3-4dac-b191-9f7e21445482"), new TimeSpan(0, 17, 30, 0, 0), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), 1713733893L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), null, new Guid("b7eacdc5-fd66-44b8-b7d7-1600781d9e3c"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("f09a5501-e6dc-41a8-a3b0-e1f6dd48198a"), new TimeSpan(0, 17, 30, 0, 0), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), 1713733893L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), null, new Guid("b7eacdc5-fd66-44b8-b7d7-1600781d9e3c"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("f656b0f0-6829-4b5b-912a-aacaa536603a"), new TimeSpan(0, 17, 30, 0, 0), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), 1713733893L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), null, new Guid("b7eacdc5-fd66-44b8-b7d7-1600781d9e3c"), new TimeSpan(0, 8, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "LibraryBranchMembers",
                columns: new[] { "LibraryBranchId", "MemberId" },
                values: new object[,]
                {
                    { new Guid("b7eacdc5-fd66-44b8-b7d7-1600781d9e3c"), new Guid("908fde15-116a-4bb3-98ec-e15c9a907609") },
                    { new Guid("b7eacdc5-fd66-44b8-b7d7-1600781d9e3c"), new Guid("a4dbcebd-9e28-4669-a3d8-260de4623545") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Staffs",
                columns: new[] { "Id", "Address", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "EmploymentDate", "IsDeleted", "IsDeletedById", "IsFullTime", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "Phone", "Salary", "UserId" },
                values: new object[] { new Guid("93f2f0c2-2514-466d-b765-df834beb9ad8"), "Employee Address", new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), 1713733893L, null, new DateTime(2024, 4, 21, 21, 11, 33, 591, DateTimeKind.Local).AddTicks(3053), false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), null, new Guid("b7eacdc5-fd66-44b8-b7d7-1600781d9e3c"), "+905553331122", 3000.00m, new Guid("3d1e7839-4d42-418f-b30b-c95a5f80b788") });

            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[] { new Guid("814b399c-1889-486b-be58-8358edb02553"), new Guid("2ee3fa5d-1c27-47b2-962f-565c4b2ebcbd") });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookStocks",
                columns: new[] { "Id", "BookId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Quantity" },
                values: new object[] { new Guid("b7f0dddd-ee6d-4bb2-952d-dd393f28b742"), new Guid("2ee3fa5d-1c27-47b2-962f-565c4b2ebcbd"), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), 1713733893L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), null, 100 });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookTags",
                columns: new[] { "BookId", "TagId" },
                values: new object[,]
                {
                    { new Guid("2ee3fa5d-1c27-47b2-962f-565c4b2ebcbd"), new Guid("981a3a4b-d845-4599-9851-00388560d695") },
                    { new Guid("2ee3fa5d-1c27-47b2-962f-565c4b2ebcbd"), new Guid("d39960dc-cb69-41b6-87b1-5af370cba3f9") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BorrowBooks",
                columns: new[] { "Id", "BookId", "BorrowDate", "BorrowStatus", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "DueDate", "FeeAmount", "HasFee", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LenderId", "MemberId" },
                values: new object[] { new Guid("12dc9b1f-e100-4e0a-b4ac-62f14f94d094"), new Guid("2ee3fa5d-1c27-47b2-962f-565c4b2ebcbd"), new DateTime(2024, 4, 21, 21, 11, 33, 591, DateTimeKind.Local).AddTicks(3060), "Borrowed", new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), 1713733893L, null, new DateTime(2024, 5, 5, 21, 11, 33, 591, DateTimeKind.Local).AddTicks(3061), 0m, false, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), null, new Guid("93f2f0c2-2514-466d-b765-df834beb9ad8"), new Guid("a4dbcebd-9e28-4669-a3d8-260de4623545") });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookReturns",
                columns: new[] { "Id", "BookStatus", "BorrowId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "IsLate", "LastModifiedById", "LastModifiedDateUnix", "PenaltyDurationInDays", "ReturnDate" },
                values: new object[] { new Guid("816ea31b-5615-4997-b465-05b7dd320dcb"), 4, new Guid("12dc9b1f-e100-4e0a-b4ac-62f14f94d094"), new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), 1713733893L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), false, new Guid("0c5e5f84-ae4b-4894-97b2-f365bf16f9ae"), null, -13, new DateTime(2024, 4, 21, 21, 11, 33, 591, DateTimeKind.Local).AddTicks(3085) });
        }
    }
}
