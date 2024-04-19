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
            migrationBuilder.DropForeignKey(
                name: "FK_Books_FavoriteList_FavoriteListId",
                schema: "lm",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_ReadingList_ReadingListId",
                schema: "lm",
                table: "Books");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReadingList",
                table: "ReadingList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FavoriteList",
                table: "FavoriteList");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a9d4bbf9-f2ae-4a67-ba39-85ad545d1009"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("be9eaac7-0d94-4b51-8cc8-8301b8eb793c"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("14f162d9-2056-41d1-bac4-529a9c4c8cf9"), new Guid("c97eae8a-6869-4bb8-8206-1aa3f403a5c8") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("76c6b87c-7b43-4b1d-a4c2-079871b6408a"), new Guid("f1af8f2d-0642-462e-b795-79bc7e5db203") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"));

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("9a6f6bf3-87e4-44f2-a5e0-5c75ba1f6e63"), new Guid("5a98e797-bf08-4c44-8bf4-9216149a5561") });

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: new Guid("14f90a41-2869-4641-9cd0-961a8cefdeb7"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BookReturns",
                keyColumn: "Id",
                keyValue: new Guid("09506168-765c-4783-9888-c201d95d1a8a"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BookStocks",
                keyColumn: "Id",
                keyValue: new Guid("c26ac425-12e0-4619-a2aa-046eaa5671fb"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { new Guid("5a98e797-bf08-4c44-8bf4-9216149a5561"), new Guid("0fe219e2-e773-465d-96f1-e638903cde0a") });

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { new Guid("5a98e797-bf08-4c44-8bf4-9216149a5561"), new Guid("46b1a2eb-18aa-48fa-bd10-e3f2a92d257a") });

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "Book_Tags",
                keyColumn: "Id",
                keyValue: new Guid("b5ef6668-e1c9-42a8-88ca-adf2a811f17b"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BranchHours",
                keyColumn: "Id",
                keyValue: new Guid("24dbb65c-98d3-4275-830a-9c446eadc869"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BranchHours",
                keyColumn: "Id",
                keyValue: new Guid("35bf907f-0521-45f0-a2e8-13324bb916f7"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BranchHours",
                keyColumn: "Id",
                keyValue: new Guid("5a36d31b-569e-4602-9967-82137dcb419e"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BranchHours",
                keyColumn: "Id",
                keyValue: new Guid("73bf4080-34e3-406b-b83c-074670be993e"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BranchHours",
                keyColumn: "Id",
                keyValue: new Guid("c8599575-c284-45e3-8217-3527fb88e196"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BranchHours",
                keyColumn: "Id",
                keyValue: new Guid("e679b25c-c9f8-4d4c-832f-d718d8d627af"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BranchHours",
                keyColumn: "Id",
                keyValue: new Guid("ecadd536-bd7f-403a-b5cd-b5ba086ebb82"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "LibraryBranchMembers",
                keyColumns: new[] { "LibraryBranchId", "MemberId" },
                keyValues: new object[] { new Guid("933258cc-0f09-41c2-8966-1d940edb916f"), new Guid("8406ca99-8044-49ea-8800-7ecc72bf4cab") });

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "LibraryBranchMembers",
                keyColumns: new[] { "LibraryBranchId", "MemberId" },
                keyValues: new object[] { new Guid("933258cc-0f09-41c2-8966-1d940edb916f"), new Guid("f963d4e1-743b-49a1-a550-f753bea75240") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("14f162d9-2056-41d1-bac4-529a9c4c8cf9"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("76c6b87c-7b43-4b1d-a4c2-079871b6408a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f1af8f2d-0642-462e-b795-79bc7e5db203"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9a6f6bf3-87e4-44f2-a5e0-5c75ba1f6e63"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "Book_Tags",
                keyColumn: "Id",
                keyValue: new Guid("0fe219e2-e773-465d-96f1-e638903cde0a"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "Book_Tags",
                keyColumn: "Id",
                keyValue: new Guid("46b1a2eb-18aa-48fa-bd10-e3f2a92d257a"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BorrowBooks",
                keyColumn: "Id",
                keyValue: new Guid("4046e45e-a292-4321-9d7f-1b49857d2321"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("f963d4e1-743b-49a1-a550-f753bea75240"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5a98e797-bf08-4c44-8bf4-9216149a5561"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("8406ca99-8044-49ea-8800-7ecc72bf4cab"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("07e88639-688a-47ed-a418-fc4a65f5cca0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c97eae8a-6869-4bb8-8206-1aa3f403a5c8"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: new Guid("126296b3-b373-45aa-8f27-7e0edcc271b7"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BookPublishers",
                keyColumn: "Id",
                keyValue: new Guid("d66a2589-d6ae-431a-9f00-d4d7ebd9fb3d"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "LibraryBranches",
                keyColumn: "Id",
                keyValue: new Guid("933258cc-0f09-41c2-8966-1d940edb916f"));

            migrationBuilder.RenameTable(
                name: "ReadingList",
                newName: "ReadingLists",
                newSchema: "lm");

            migrationBuilder.RenameTable(
                name: "FavoriteList",
                newName: "FavoriteLists",
                newSchema: "lm");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReadingLists",
                schema: "lm",
                table: "ReadingLists",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FavoriteLists",
                schema: "lm",
                table: "FavoriteLists",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "BookReviews",
                schema: "lm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReviewText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeletedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateUnix = table.Column<long>(type: "bigint", nullable: false),
                    LastModifiedDateUnix = table.Column<long>(type: "bigint", nullable: true),
                    DeletedDateUnix = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookReviews", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "AppUserId", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("1084b33f-ba02-45ca-8dd9-c91c43c3510e"), null, "97e9b096-c377-4590-b3d6-35fc18773c2f", "Admin", "ADMIN" },
                    { new Guid("7299c82d-32bb-43f5-9239-1b63cab58a9e"), null, "2a9c8ad5-1951-4a7b-ae82-5bf6aa367b28", "system", "SYSTEM" },
                    { new Guid("84b01ef2-5522-4829-aa8d-56700406130f"), null, "c87c0db6-2327-4ac1-92a7-2bb737467190", "Member", "MEMBER" },
                    { new Guid("a15aeebd-c576-4629-b801-4dce47d161ac"), null, "f31daf47-0f66-41dc-afc6-565a3882ec6f", "Staff", "STAFF" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Email", "EmailConfirmed", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenEndDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), 0, "778796f9-aba8-4086-90d5-981c58af3f89", new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, "system@domain.com", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, false, null, "system", "SYSTEM@DOMAIN.COM", "SYSTEM", "AQAAAAIAAYagAAAAELETGe4piixl3uwWiV0OwB8KPAWvr5Z42ljGfFVU2EQHhY9MCX1ghnxF10t/D7EbZQ==", null, false, null, null, "", "system", false, "system" },
                    { new Guid("809e966a-efe6-4bc3-9d80-72132c19cb9f"), 0, "590cd586-58f5-45f3-a999-7e61b53c8978", new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), 0L, null, "admin@example.com", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), null, false, null, "admin", "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHX3kD7g7OXmYZqfLIeCuKDuYy3EtcOhg9l9fbgS1vfv5tEQR+6MrD2vSobbDy0BfQ==", null, false, null, null, "", "admin", false, "admin@example.com" },
                    { new Guid("d76acfe6-9e63-46a7-bf5f-2bc24cba6a7a"), 0, "a1365c9c-590b-4834-949b-aee993ba1cac", new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), 0L, null, "employee1@example.com", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), null, false, null, "admin", "EMPLOYEE2@EXAMPLE.COM", "EMPLOYEE2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEP2iwnP4pIVczp6K0qw06J7FqDfYIFuShzdi3MY/dXzT1JTC593fCvfsM9p44Q+K9w==", null, false, null, null, "", "admin", false, "employee1@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Biography", "BirthDate", "Country", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "Surname" },
                values: new object[] { new Guid("fd9177ba-a2b9-4a30-a9a6-94756506d097"), "Joanne Rowling, better known by her pen name J.K. Rowling, is a British author, philanthropist, film producer, television producer, and screenwriter. She is best known for writing the Harry Potter fantasy series.", new DateTime(1965, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "United Kingdom", new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), 1713514541L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), null, "J.K.", "Rowling" });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookGenres",
                columns: new[] { "Id", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsActive", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name" },
                values: new object[,]
                {
                    { new Guid("422a4f3e-4c18-4a08-92bf-f16846d79f18"), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), 1713514541L, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), null, "Fantasy" },
                    { new Guid("f9219a60-f0f5-4663-8cf4-b361b5745eca"), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), 1713514541L, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), null, "Adventure" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookPublishers",
                columns: new[] { "Id", "Address", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Email", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "PhoneNumber", "Website" },
                values: new object[] { new Guid("41a5fabc-e23a-48e2-ad87-4ae6a3cdadd5"), "50 Bedford Square, London, England", new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), 1713514541L, null, "info@bloomsbury.com", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), null, "Bloomsbury Publishing", "+44 (0)20 7631 5600", "https://www.bloomsbury.com/" });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Book_Tags",
                columns: new[] { "Id", "BookId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name" },
                values: new object[,]
                {
                    { new Guid("344e5b79-df4c-4b4e-a308-5aa38ef18673"), new Guid("12478a4c-e879-4aea-b95e-9f53c9777d1e"), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), 1713514541L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), null, "Quidditch" },
                    { new Guid("6a486eec-1de8-414b-a730-a059e6f3098d"), new Guid("12478a4c-e879-4aea-b95e-9f53c9777d1e"), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), 1713514541L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), null, "Hogwarts" },
                    { new Guid("c758ef75-4086-499a-a879-317acf30bfd8"), new Guid("12478a4c-e879-4aea-b95e-9f53c9777d1e"), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), 1713514541L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), null, "Harry Potter" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "LibraryBranches",
                columns: new[] { "Id", "Address", "BookId", "BranchHourId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Description", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "LibraryTransactionId", "MemberId", "Name", "PhoneNumber", "StaffId" },
                values: new object[] { new Guid("69fe9a74-3c83-4492-a68c-803fa97f678a"), "123 Ana Cadde", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), 1713514541L, null, "Bu bir örnek kütüphane şubesidir.", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Örnek Kütüphane Şubesi", "123-456-7890", new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Members",
                columns: new[] { "Id", "Address", "BirthDate", "BorrowId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Email", "ExtensionDurationInDays", "Gender", "HasPenalty", "IsDeleted", "IsDeletedById", "IsExtensionAllowed", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "MaxLateReturnsAllowed", "MemberType", "MembershipDate", "Name", "NumberOfLateReturns", "Occupation", "PenaltyDurationInDays", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("2c77a59e-667b-48ba-af63-602cb4c021d5"), "123 Main Street", new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), 1713514541L, null, "john.doe@example.com", 7, "Male", false, false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), null, new Guid("69fe9a74-3c83-4492-a68c-803fa97f678a"), 3, "Adult", new DateTime(2024, 4, 19, 8, 15, 41, 820, DateTimeKind.Local).AddTicks(1090), "John Doe", 0, "Software Engineer", 0, "+1234567890" },
                    { new Guid("2e9156cb-820b-45bb-87f5-09d4a64bb344"), "456 Oak Street", new DateTime(1985, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), 1713514541L, null, "jane.smith@example.com", 0, "Female", true, false, new Guid("00000000-0000-0000-0000-000000000000"), false, new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), null, new Guid("69fe9a74-3c83-4492-a68c-803fa97f678a"), 3, "Teacher", new DateTime(2024, 4, 19, 8, 15, 41, 820, DateTimeKind.Local).AddTicks(1097), "Jane Smith", 2, "Teacher", 7, "+1987654321" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("1084b33f-ba02-45ca-8dd9-c91c43c3510e"), new Guid("809e966a-efe6-4bc3-9d80-72132c19cb9f"), "AppUserRole" },
                    { new Guid("a15aeebd-c576-4629-b801-4dce47d161ac"), new Guid("d76acfe6-9e63-46a7-bf5f-2bc24cba6a7a"), "AppUserRole" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Books",
                columns: new[] { "Id", "AuthorId", "BookFormat", "BookLanguage", "BookStatus", "BookStockBranchId", "BorrowId", "CoverImageUrl", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Description", "FavoriteListId", "GenreId", "ISBN", "IsDeleted", "IsDeletedById", "IsFeatured", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "OriginalPublicationDate", "PageCount", "PublicationDate", "PublisherId", "ReadingListId", "Title" },
                values: new object[] { new Guid("12478a4c-e879-4aea-b95e-9f53c9777d1e"), new Guid("fd9177ba-a2b9-4a30-a9a6-94756506d097"), "PrintedBook", "English", "Available", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "https://m.media-amazon.com/images/I/81q77Q39nEL._SY385_.jpg", new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), 1713514541L, null, "Harry Potter has never even heard of Hogwarts when the letters start dropping on the doormat at number four, Privet Drive. Addressed in green ink on yellowish parchment with a purple seal, they are swiftly confiscated by his grisly aunt and uncle. Then, on Harry's eleventh birthday, a great beetle-eyed giant of a man called Rubeus Hagrid bursts in with some astonishing news: Harry Potter is a wizard, and he has a place at Hogwarts School of Witchcraft and Wizardry. An incredible adventure is about to begin!", null, new Guid("422a4f3e-4c18-4a08-92bf-f16846d79f18"), "9781408855652", false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), null, new Guid("69fe9a74-3c83-4492-a68c-803fa97f678a"), new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 352, new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("41a5fabc-e23a-48e2-ad87-4ae6a3cdadd5"), null, "Harry Potter and the Philosopher's Stone" });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BranchHours",
                columns: new[] { "Id", "ClosingTime", "CreatedById", "CreatedDateUnix", "DayOfWeek", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "OpeningTime" },
                values: new object[,]
                {
                    { new Guid("1e405b0b-1b47-447d-94cf-40e1d44adf2c"), new TimeSpan(0, 17, 30, 0, 0), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), 1713514541L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), null, new Guid("69fe9a74-3c83-4492-a68c-803fa97f678a"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("8c4a5e41-20d4-49f3-a2c7-4c15678f1b6d"), new TimeSpan(0, 17, 30, 0, 0), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), 1713514541L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), null, new Guid("69fe9a74-3c83-4492-a68c-803fa97f678a"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("9266994e-90f8-487f-9d73-15605cae53ac"), new TimeSpan(0, 17, 30, 0, 0), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), 1713514541L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), null, new Guid("69fe9a74-3c83-4492-a68c-803fa97f678a"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("bea9f076-2aea-402c-b85f-bfcb6b5fc941"), new TimeSpan(0, 17, 30, 0, 0), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), 1713514541L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), null, new Guid("69fe9a74-3c83-4492-a68c-803fa97f678a"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("d5868ac8-0ebf-4456-8f76-a15329d64913"), new TimeSpan(0, 17, 30, 0, 0), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), 1713514541L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), null, new Guid("69fe9a74-3c83-4492-a68c-803fa97f678a"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("e468e7b4-d24a-4d56-be63-6c4b20088fc5"), new TimeSpan(0, 0, 0, 0, 0), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), 1713514541L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), null, new Guid("69fe9a74-3c83-4492-a68c-803fa97f678a"), new TimeSpan(0, 0, 0, 0, 0) },
                    { new Guid("e951cabf-b542-46a4-bb56-ce173093acc5"), new TimeSpan(0, 17, 30, 0, 0), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), 1713514541L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), null, new Guid("69fe9a74-3c83-4492-a68c-803fa97f678a"), new TimeSpan(0, 8, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "LibraryBranchMembers",
                columns: new[] { "LibraryBranchId", "MemberId" },
                values: new object[,]
                {
                    { new Guid("69fe9a74-3c83-4492-a68c-803fa97f678a"), new Guid("2c77a59e-667b-48ba-af63-602cb4c021d5") },
                    { new Guid("69fe9a74-3c83-4492-a68c-803fa97f678a"), new Guid("2e9156cb-820b-45bb-87f5-09d4a64bb344") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Staffs",
                columns: new[] { "Id", "Address", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "EmploymentDate", "IsDeleted", "IsDeletedById", "IsFullTime", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "Phone", "Salary", "UserId" },
                values: new object[] { new Guid("7c9d2393-d600-48eb-b46d-fc7adc7a421c"), "Employee Address", new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), 1713514541L, null, new DateTime(2024, 4, 19, 8, 15, 41, 820, DateTimeKind.Local).AddTicks(1134), false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), null, new Guid("69fe9a74-3c83-4492-a68c-803fa97f678a"), "+905553331122", 3000.00m, new Guid("d76acfe6-9e63-46a7-bf5f-2bc24cba6a7a") });

            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[] { new Guid("fd9177ba-a2b9-4a30-a9a6-94756506d097"), new Guid("12478a4c-e879-4aea-b95e-9f53c9777d1e") });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookStocks",
                columns: new[] { "Id", "BookId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Quantity" },
                values: new object[] { new Guid("c3f16244-d493-43c1-8a7e-ab75398abb6f"), new Guid("12478a4c-e879-4aea-b95e-9f53c9777d1e"), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), 1713514541L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), null, 100 });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookTags",
                columns: new[] { "BookId", "TagId" },
                values: new object[,]
                {
                    { new Guid("12478a4c-e879-4aea-b95e-9f53c9777d1e"), new Guid("6a486eec-1de8-414b-a730-a059e6f3098d") },
                    { new Guid("12478a4c-e879-4aea-b95e-9f53c9777d1e"), new Guid("c758ef75-4086-499a-a879-317acf30bfd8") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BorrowBooks",
                columns: new[] { "Id", "BookId", "BorrowDate", "BorrowStatus", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "DueDate", "FeeAmount", "HasFee", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LenderId", "MemberId" },
                values: new object[] { new Guid("4d326da9-c5e3-45f9-a4e9-d0bc1fd3228d"), new Guid("12478a4c-e879-4aea-b95e-9f53c9777d1e"), new DateTime(2024, 4, 19, 8, 15, 41, 820, DateTimeKind.Local).AddTicks(1145), "Borrowed", new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), 1713514541L, null, new DateTime(2024, 5, 3, 8, 15, 41, 820, DateTimeKind.Local).AddTicks(1145), 0m, false, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), null, new Guid("7c9d2393-d600-48eb-b46d-fc7adc7a421c"), new Guid("2c77a59e-667b-48ba-af63-602cb4c021d5") });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookReturns",
                columns: new[] { "Id", "BookStatus", "BorrowId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "IsLate", "LastModifiedById", "LastModifiedDateUnix", "PenaltyDurationInDays", "ReturnDate" },
                values: new object[] { new Guid("0711f923-7cd6-43b2-99bc-bc355e682f2e"), 4, new Guid("4d326da9-c5e3-45f9-a4e9-d0bc1fd3228d"), new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), 1713514541L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), false, new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"), null, -13, new DateTime(2024, 4, 19, 8, 15, 41, 820, DateTimeKind.Local).AddTicks(1172) });

            migrationBuilder.AddForeignKey(
                name: "FK_Books_FavoriteLists_FavoriteListId",
                schema: "lm",
                table: "Books",
                column: "FavoriteListId",
                principalSchema: "lm",
                principalTable: "FavoriteLists",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_ReadingLists_ReadingListId",
                schema: "lm",
                table: "Books",
                column: "ReadingListId",
                principalSchema: "lm",
                principalTable: "ReadingLists",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_FavoriteLists_FavoriteListId",
                schema: "lm",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_ReadingLists_ReadingListId",
                schema: "lm",
                table: "Books");

            migrationBuilder.DropTable(
                name: "BookReviews",
                schema: "lm");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReadingLists",
                schema: "lm",
                table: "ReadingLists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FavoriteLists",
                schema: "lm",
                table: "FavoriteLists");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7299c82d-32bb-43f5-9239-1b63cab58a9e"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("84b01ef2-5522-4829-aa8d-56700406130f"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("1084b33f-ba02-45ca-8dd9-c91c43c3510e"), new Guid("809e966a-efe6-4bc3-9d80-72132c19cb9f") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a15aeebd-c576-4629-b801-4dce47d161ac"), new Guid("d76acfe6-9e63-46a7-bf5f-2bc24cba6a7a") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("75c5c75c-e448-4c0b-a09d-5b53cc856695"));

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("fd9177ba-a2b9-4a30-a9a6-94756506d097"), new Guid("12478a4c-e879-4aea-b95e-9f53c9777d1e") });

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: new Guid("f9219a60-f0f5-4663-8cf4-b361b5745eca"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BookReturns",
                keyColumn: "Id",
                keyValue: new Guid("0711f923-7cd6-43b2-99bc-bc355e682f2e"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BookStocks",
                keyColumn: "Id",
                keyValue: new Guid("c3f16244-d493-43c1-8a7e-ab75398abb6f"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { new Guid("12478a4c-e879-4aea-b95e-9f53c9777d1e"), new Guid("6a486eec-1de8-414b-a730-a059e6f3098d") });

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { new Guid("12478a4c-e879-4aea-b95e-9f53c9777d1e"), new Guid("c758ef75-4086-499a-a879-317acf30bfd8") });

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "Book_Tags",
                keyColumn: "Id",
                keyValue: new Guid("344e5b79-df4c-4b4e-a308-5aa38ef18673"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BranchHours",
                keyColumn: "Id",
                keyValue: new Guid("1e405b0b-1b47-447d-94cf-40e1d44adf2c"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BranchHours",
                keyColumn: "Id",
                keyValue: new Guid("8c4a5e41-20d4-49f3-a2c7-4c15678f1b6d"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BranchHours",
                keyColumn: "Id",
                keyValue: new Guid("9266994e-90f8-487f-9d73-15605cae53ac"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BranchHours",
                keyColumn: "Id",
                keyValue: new Guid("bea9f076-2aea-402c-b85f-bfcb6b5fc941"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BranchHours",
                keyColumn: "Id",
                keyValue: new Guid("d5868ac8-0ebf-4456-8f76-a15329d64913"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BranchHours",
                keyColumn: "Id",
                keyValue: new Guid("e468e7b4-d24a-4d56-be63-6c4b20088fc5"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BranchHours",
                keyColumn: "Id",
                keyValue: new Guid("e951cabf-b542-46a4-bb56-ce173093acc5"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "LibraryBranchMembers",
                keyColumns: new[] { "LibraryBranchId", "MemberId" },
                keyValues: new object[] { new Guid("69fe9a74-3c83-4492-a68c-803fa97f678a"), new Guid("2c77a59e-667b-48ba-af63-602cb4c021d5") });

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "LibraryBranchMembers",
                keyColumns: new[] { "LibraryBranchId", "MemberId" },
                keyValues: new object[] { new Guid("69fe9a74-3c83-4492-a68c-803fa97f678a"), new Guid("2e9156cb-820b-45bb-87f5-09d4a64bb344") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1084b33f-ba02-45ca-8dd9-c91c43c3510e"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a15aeebd-c576-4629-b801-4dce47d161ac"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("809e966a-efe6-4bc3-9d80-72132c19cb9f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("fd9177ba-a2b9-4a30-a9a6-94756506d097"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "Book_Tags",
                keyColumn: "Id",
                keyValue: new Guid("6a486eec-1de8-414b-a730-a059e6f3098d"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "Book_Tags",
                keyColumn: "Id",
                keyValue: new Guid("c758ef75-4086-499a-a879-317acf30bfd8"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BorrowBooks",
                keyColumn: "Id",
                keyValue: new Guid("4d326da9-c5e3-45f9-a4e9-d0bc1fd3228d"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("2e9156cb-820b-45bb-87f5-09d4a64bb344"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("12478a4c-e879-4aea-b95e-9f53c9777d1e"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("2c77a59e-667b-48ba-af63-602cb4c021d5"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("7c9d2393-d600-48eb-b46d-fc7adc7a421c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d76acfe6-9e63-46a7-bf5f-2bc24cba6a7a"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: new Guid("422a4f3e-4c18-4a08-92bf-f16846d79f18"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "BookPublishers",
                keyColumn: "Id",
                keyValue: new Guid("41a5fabc-e23a-48e2-ad87-4ae6a3cdadd5"));

            migrationBuilder.DeleteData(
                schema: "lm",
                table: "LibraryBranches",
                keyColumn: "Id",
                keyValue: new Guid("69fe9a74-3c83-4492-a68c-803fa97f678a"));

            migrationBuilder.RenameTable(
                name: "ReadingLists",
                schema: "lm",
                newName: "ReadingList");

            migrationBuilder.RenameTable(
                name: "FavoriteLists",
                schema: "lm",
                newName: "FavoriteList");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReadingList",
                table: "ReadingList",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FavoriteList",
                table: "FavoriteList",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateUnix = table.Column<long>(type: "bigint", nullable: false),
                    DeletedDateUnix = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDeletedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedDateUnix = table.Column<long>(type: "bigint", nullable: true),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReviewText = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "AppUserId", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("14f162d9-2056-41d1-bac4-529a9c4c8cf9"), null, "bb403693-4d57-4147-a261-6ae974b518fd", "Staff", "STAFF" },
                    { new Guid("76c6b87c-7b43-4b1d-a4c2-079871b6408a"), null, "f4553e4f-3236-4455-be2e-dd85b39cd321", "Admin", "ADMIN" },
                    { new Guid("a9d4bbf9-f2ae-4a67-ba39-85ad545d1009"), null, "319f3106-038f-4d41-bcbe-f3338e38e235", "system", "SYSTEM" },
                    { new Guid("be9eaac7-0d94-4b51-8cc8-8301b8eb793c"), null, "2f0acc98-e4ed-41d4-9bbe-77fb6c0ccef7", "Member", "MEMBER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Email", "EmailConfirmed", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenEndDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), 0, "e0dc7df5-2460-4241-b4f8-60b77b42d021", new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, "system@domain.com", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, false, null, "system", "SYSTEM@DOMAIN.COM", "SYSTEM", "AQAAAAIAAYagAAAAEDbwJsE1+PVdL64xkQVm2kaND7ffOXO0GGi6BAmQ1nSH0EtkTPDu58VJSaGs3LBwKg==", null, false, null, null, "", "system", false, "system" },
                    { new Guid("c97eae8a-6869-4bb8-8206-1aa3f403a5c8"), 0, "b34c2423-ba2b-4f6a-be13-dabc79767a3b", new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), 0L, null, "employee1@example.com", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), null, false, null, "admin", "EMPLOYEE2@EXAMPLE.COM", "EMPLOYEE2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMLpL8o5lMU6GZASrWSx9wddOYzsMZ0VeWiYF/LGWViRDxsuG6de1mx1ykvYv1Nptw==", null, false, null, null, "", "admin", false, "employee1@example.com" },
                    { new Guid("f1af8f2d-0642-462e-b795-79bc7e5db203"), 0, "5d54b7e9-d996-4268-a963-8dcc4aa30fdb", new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), 0L, null, "admin@example.com", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), null, false, null, "admin", "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAENPYmzjf0T3nUL3juBLg7Ov76jX4llDqmBYJy0YFeyThuIo3R6qaPXdhOGeyv+2QVw==", null, false, null, null, "", "admin", false, "admin@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Biography", "BirthDate", "Country", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "Surname" },
                values: new object[] { new Guid("9a6f6bf3-87e4-44f2-a5e0-5c75ba1f6e63"), "Joanne Rowling, better known by her pen name J.K. Rowling, is a British author, philanthropist, film producer, television producer, and screenwriter. She is best known for writing the Harry Potter fantasy series.", new DateTime(1965, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "United Kingdom", new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), 1713514362L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), null, "J.K.", "Rowling" });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookGenres",
                columns: new[] { "Id", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsActive", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name" },
                values: new object[,]
                {
                    { new Guid("126296b3-b373-45aa-8f27-7e0edcc271b7"), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), 1713514362L, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), null, "Fantasy" },
                    { new Guid("14f90a41-2869-4641-9cd0-961a8cefdeb7"), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), 1713514362L, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), null, "Adventure" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookPublishers",
                columns: new[] { "Id", "Address", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Email", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "PhoneNumber", "Website" },
                values: new object[] { new Guid("d66a2589-d6ae-431a-9f00-d4d7ebd9fb3d"), "50 Bedford Square, London, England", new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), 1713514362L, null, "info@bloomsbury.com", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), null, "Bloomsbury Publishing", "+44 (0)20 7631 5600", "https://www.bloomsbury.com/" });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Book_Tags",
                columns: new[] { "Id", "BookId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name" },
                values: new object[,]
                {
                    { new Guid("0fe219e2-e773-465d-96f1-e638903cde0a"), new Guid("5a98e797-bf08-4c44-8bf4-9216149a5561"), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), 1713514362L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), null, "Harry Potter" },
                    { new Guid("46b1a2eb-18aa-48fa-bd10-e3f2a92d257a"), new Guid("5a98e797-bf08-4c44-8bf4-9216149a5561"), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), 1713514362L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), null, "Hogwarts" },
                    { new Guid("b5ef6668-e1c9-42a8-88ca-adf2a811f17b"), new Guid("5a98e797-bf08-4c44-8bf4-9216149a5561"), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), 1713514362L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), null, "Quidditch" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "LibraryBranches",
                columns: new[] { "Id", "Address", "BookId", "BranchHourId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Description", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "LibraryTransactionId", "MemberId", "Name", "PhoneNumber", "StaffId" },
                values: new object[] { new Guid("933258cc-0f09-41c2-8966-1d940edb916f"), "123 Ana Cadde", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), 1713514362L, null, "Bu bir örnek kütüphane şubesidir.", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Örnek Kütüphane Şubesi", "123-456-7890", new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Members",
                columns: new[] { "Id", "Address", "BirthDate", "BorrowId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Email", "ExtensionDurationInDays", "Gender", "HasPenalty", "IsDeleted", "IsDeletedById", "IsExtensionAllowed", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "MaxLateReturnsAllowed", "MemberType", "MembershipDate", "Name", "NumberOfLateReturns", "Occupation", "PenaltyDurationInDays", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("8406ca99-8044-49ea-8800-7ecc72bf4cab"), "123 Main Street", new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), 1713514362L, null, "john.doe@example.com", 7, "Male", false, false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), null, new Guid("933258cc-0f09-41c2-8966-1d940edb916f"), 3, "Adult", new DateTime(2024, 4, 19, 8, 12, 42, 560, DateTimeKind.Local).AddTicks(683), "John Doe", 0, "Software Engineer", 0, "+1234567890" },
                    { new Guid("f963d4e1-743b-49a1-a550-f753bea75240"), "456 Oak Street", new DateTime(1985, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), 1713514362L, null, "jane.smith@example.com", 0, "Female", true, false, new Guid("00000000-0000-0000-0000-000000000000"), false, new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), null, new Guid("933258cc-0f09-41c2-8966-1d940edb916f"), 3, "Teacher", new DateTime(2024, 4, 19, 8, 12, 42, 560, DateTimeKind.Local).AddTicks(689), "Jane Smith", 2, "Teacher", 7, "+1987654321" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("14f162d9-2056-41d1-bac4-529a9c4c8cf9"), new Guid("c97eae8a-6869-4bb8-8206-1aa3f403a5c8"), "AppUserRole" },
                    { new Guid("76c6b87c-7b43-4b1d-a4c2-079871b6408a"), new Guid("f1af8f2d-0642-462e-b795-79bc7e5db203"), "AppUserRole" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Books",
                columns: new[] { "Id", "AuthorId", "BookFormat", "BookLanguage", "BookStatus", "BookStockBranchId", "BorrowId", "CoverImageUrl", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Description", "FavoriteListId", "GenreId", "ISBN", "IsDeleted", "IsDeletedById", "IsFeatured", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "OriginalPublicationDate", "PageCount", "PublicationDate", "PublisherId", "ReadingListId", "Title" },
                values: new object[] { new Guid("5a98e797-bf08-4c44-8bf4-9216149a5561"), new Guid("9a6f6bf3-87e4-44f2-a5e0-5c75ba1f6e63"), "PrintedBook", "English", "Available", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "https://m.media-amazon.com/images/I/81q77Q39nEL._SY385_.jpg", new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), 1713514362L, null, "Harry Potter has never even heard of Hogwarts when the letters start dropping on the doormat at number four, Privet Drive. Addressed in green ink on yellowish parchment with a purple seal, they are swiftly confiscated by his grisly aunt and uncle. Then, on Harry's eleventh birthday, a great beetle-eyed giant of a man called Rubeus Hagrid bursts in with some astonishing news: Harry Potter is a wizard, and he has a place at Hogwarts School of Witchcraft and Wizardry. An incredible adventure is about to begin!", null, new Guid("126296b3-b373-45aa-8f27-7e0edcc271b7"), "9781408855652", false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), null, new Guid("933258cc-0f09-41c2-8966-1d940edb916f"), new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 352, new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d66a2589-d6ae-431a-9f00-d4d7ebd9fb3d"), null, "Harry Potter and the Philosopher's Stone" });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BranchHours",
                columns: new[] { "Id", "ClosingTime", "CreatedById", "CreatedDateUnix", "DayOfWeek", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "OpeningTime" },
                values: new object[,]
                {
                    { new Guid("24dbb65c-98d3-4275-830a-9c446eadc869"), new TimeSpan(0, 17, 30, 0, 0), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), 1713514362L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), null, new Guid("933258cc-0f09-41c2-8966-1d940edb916f"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("35bf907f-0521-45f0-a2e8-13324bb916f7"), new TimeSpan(0, 17, 30, 0, 0), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), 1713514362L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), null, new Guid("933258cc-0f09-41c2-8966-1d940edb916f"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("5a36d31b-569e-4602-9967-82137dcb419e"), new TimeSpan(0, 17, 30, 0, 0), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), 1713514362L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), null, new Guid("933258cc-0f09-41c2-8966-1d940edb916f"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("73bf4080-34e3-406b-b83c-074670be993e"), new TimeSpan(0, 17, 30, 0, 0), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), 1713514362L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), null, new Guid("933258cc-0f09-41c2-8966-1d940edb916f"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("c8599575-c284-45e3-8217-3527fb88e196"), new TimeSpan(0, 17, 30, 0, 0), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), 1713514362L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), null, new Guid("933258cc-0f09-41c2-8966-1d940edb916f"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("e679b25c-c9f8-4d4c-832f-d718d8d627af"), new TimeSpan(0, 17, 30, 0, 0), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), 1713514362L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), null, new Guid("933258cc-0f09-41c2-8966-1d940edb916f"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("ecadd536-bd7f-403a-b5cd-b5ba086ebb82"), new TimeSpan(0, 0, 0, 0, 0), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), 1713514362L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), null, new Guid("933258cc-0f09-41c2-8966-1d940edb916f"), new TimeSpan(0, 0, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "LibraryBranchMembers",
                columns: new[] { "LibraryBranchId", "MemberId" },
                values: new object[,]
                {
                    { new Guid("933258cc-0f09-41c2-8966-1d940edb916f"), new Guid("8406ca99-8044-49ea-8800-7ecc72bf4cab") },
                    { new Guid("933258cc-0f09-41c2-8966-1d940edb916f"), new Guid("f963d4e1-743b-49a1-a550-f753bea75240") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Staffs",
                columns: new[] { "Id", "Address", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "EmploymentDate", "IsDeleted", "IsDeletedById", "IsFullTime", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "Phone", "Salary", "UserId" },
                values: new object[] { new Guid("07e88639-688a-47ed-a418-fc4a65f5cca0"), "Employee Address", new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), 1713514362L, null, new DateTime(2024, 4, 19, 8, 12, 42, 560, DateTimeKind.Local).AddTicks(721), false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), null, new Guid("933258cc-0f09-41c2-8966-1d940edb916f"), "+905553331122", 3000.00m, new Guid("c97eae8a-6869-4bb8-8206-1aa3f403a5c8") });

            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[] { new Guid("9a6f6bf3-87e4-44f2-a5e0-5c75ba1f6e63"), new Guid("5a98e797-bf08-4c44-8bf4-9216149a5561") });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookStocks",
                columns: new[] { "Id", "BookId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Quantity" },
                values: new object[] { new Guid("c26ac425-12e0-4619-a2aa-046eaa5671fb"), new Guid("5a98e797-bf08-4c44-8bf4-9216149a5561"), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), 1713514362L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), null, 100 });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookTags",
                columns: new[] { "BookId", "TagId" },
                values: new object[,]
                {
                    { new Guid("5a98e797-bf08-4c44-8bf4-9216149a5561"), new Guid("0fe219e2-e773-465d-96f1-e638903cde0a") },
                    { new Guid("5a98e797-bf08-4c44-8bf4-9216149a5561"), new Guid("46b1a2eb-18aa-48fa-bd10-e3f2a92d257a") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BorrowBooks",
                columns: new[] { "Id", "BookId", "BorrowDate", "BorrowStatus", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "DueDate", "FeeAmount", "HasFee", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LenderId", "MemberId" },
                values: new object[] { new Guid("4046e45e-a292-4321-9d7f-1b49857d2321"), new Guid("5a98e797-bf08-4c44-8bf4-9216149a5561"), new DateTime(2024, 4, 19, 8, 12, 42, 560, DateTimeKind.Local).AddTicks(728), "Borrowed", new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), 1713514362L, null, new DateTime(2024, 5, 3, 8, 12, 42, 560, DateTimeKind.Local).AddTicks(729), 0m, false, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), null, new Guid("07e88639-688a-47ed-a418-fc4a65f5cca0"), new Guid("8406ca99-8044-49ea-8800-7ecc72bf4cab") });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookReturns",
                columns: new[] { "Id", "BookStatus", "BorrowId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "IsLate", "LastModifiedById", "LastModifiedDateUnix", "PenaltyDurationInDays", "ReturnDate" },
                values: new object[] { new Guid("09506168-765c-4783-9888-c201d95d1a8a"), 4, new Guid("4046e45e-a292-4321-9d7f-1b49857d2321"), new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), 1713514362L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), false, new Guid("3cf6feba-4602-4038-8dcf-d06bad791427"), null, -13, new DateTime(2024, 4, 19, 8, 12, 42, 560, DateTimeKind.Local).AddTicks(770) });

            migrationBuilder.AddForeignKey(
                name: "FK_Books_FavoriteList_FavoriteListId",
                schema: "lm",
                table: "Books",
                column: "FavoriteListId",
                principalTable: "FavoriteList",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_ReadingList_ReadingListId",
                schema: "lm",
                table: "Books",
                column: "ReadingListId",
                principalTable: "ReadingList",
                principalColumn: "Id");
        }
    }
}
