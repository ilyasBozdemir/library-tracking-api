using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryTrackingApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "lm");

            migrationBuilder.EnsureSchema(
                name: "identity");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Book_Tags",
                schema: "lm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    table.PrimaryKey("PK_Book_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookGenres",
                schema: "lm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_BookGenres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookPublishers",
                schema: "lm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    table.PrimaryKey("PK_BookPublishers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LibraryBranches",
                schema: "lm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchHourId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StaffId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LibraryBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LibraryTransactionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_LibraryBranches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                schema: "lm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MembershipDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfLateReturns = table.Column<int>(type: "int", nullable: false),
                    MaxLateReturnsAllowed = table.Column<int>(type: "int", nullable: false),
                    HasPenalty = table.Column<bool>(type: "bit", nullable: false),
                    PenaltyDurationInDays = table.Column<int>(type: "int", nullable: false),
                    IsExtensionAllowed = table.Column<bool>(type: "bit", nullable: false),
                    ExtensionDurationInDays = table.Column<int>(type: "int", nullable: false),
                    BorrowId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LibraryBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_Members", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Scopes",
                schema: "identity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeletedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateUnix = table.Column<long>(type: "bigint", nullable: false),
                    LastModifiedDateUnix = table.Column<long>(type: "bigint", nullable: true),
                    DeletedDateUnix = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scopes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoles_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                schema: "lm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PublisherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LibraryBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookStockBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BorrowId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoverImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PageCount = table.Column<int>(type: "int", nullable: false),
                    PublicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OriginalPublicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookFormat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookLanguage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_BookGenres_GenreId",
                        column: x => x.GenreId,
                        principalSchema: "lm",
                        principalTable: "BookGenres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_BookPublishers_PublisherId",
                        column: x => x.PublisherId,
                        principalSchema: "lm",
                        principalTable: "BookPublishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Books_LibraryBranches_LibraryBranchId",
                        column: x => x.LibraryBranchId,
                        principalSchema: "lm",
                        principalTable: "LibraryBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BranchHours",
                schema: "lm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DayOfWeek = table.Column<int>(type: "int", nullable: false),
                    OpeningTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    ClosingTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    LibraryBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_BranchHours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BranchHours_LibraryBranches_LibraryBranchId",
                        column: x => x.LibraryBranchId,
                        principalSchema: "lm",
                        principalTable: "LibraryBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LibraryTransactions",
                schema: "lm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LibraryBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_LibraryTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LibraryTransactions_LibraryBranches_LibraryBranchId",
                        column: x => x.LibraryBranchId,
                        principalSchema: "lm",
                        principalTable: "LibraryBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                schema: "lm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LibraryBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmploymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsFullTime = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staffs_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Staffs_LibraryBranches_LibraryBranchId",
                        column: x => x.LibraryBranchId,
                        principalSchema: "lm",
                        principalTable: "LibraryBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LibraryBranchMembers",
                schema: "lm",
                columns: table => new
                {
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LibraryBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryBranchMembers", x => new { x.MemberId, x.LibraryBranchId });
                    table.ForeignKey(
                        name: "FK_LibraryBranchMembers_LibraryBranches_LibraryBranchId",
                        column: x => x.LibraryBranchId,
                        principalSchema: "lm",
                        principalTable: "LibraryBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LibraryBranchMembers_Members_MemberId",
                        column: x => x.MemberId,
                        principalSchema: "lm",
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(34)", maxLength: 34, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RolePermissions",
                schema: "identity",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScopeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeletedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateUnix = table.Column<long>(type: "bigint", nullable: false),
                    LastModifiedDateUnix = table.Column<long>(type: "bigint", nullable: true),
                    DeletedDateUnix = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissions", x => new { x.RoleId, x.ScopeId });
                    table.ForeignKey(
                        name: "FK_RolePermissions_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePermissions_Scopes_ScopeId",
                        column: x => x.ScopeId,
                        principalSchema: "identity",
                        principalTable: "Scopes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookAuthors",
                columns: table => new
                {
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthors", x => new { x.AuthorId, x.BookId });
                    table.ForeignKey(
                        name: "FK_BookAuthors_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookAuthors_Books_BookId",
                        column: x => x.BookId,
                        principalSchema: "lm",
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookStocks",
                schema: "lm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_BookStocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookStocks_Books_BookId",
                        column: x => x.BookId,
                        principalSchema: "lm",
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookTags",
                schema: "lm",
                columns: table => new
                {
                    TagId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookTags", x => new { x.TagId, x.BookId });
                    table.ForeignKey(
                        name: "FK_BookTags_Book_Tags_TagId",
                        column: x => x.TagId,
                        principalSchema: "lm",
                        principalTable: "Book_Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookTags_Books_BookId",
                        column: x => x.BookId,
                        principalSchema: "lm",
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BorrowBooks",
                schema: "lm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BorrowDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BorrowStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasFee = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_BorrowBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BorrowBooks_Books_BookId",
                        column: x => x.BookId,
                        principalSchema: "lm",
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BorrowBooks_Members_MemberId",
                        column: x => x.MemberId,
                        principalSchema: "lm",
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BorrowBooks_Staffs_LenderId",
                        column: x => x.LenderId,
                        principalSchema: "lm",
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookReturns",
                schema: "lm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BorrowId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsLate = table.Column<bool>(type: "bit", nullable: false),
                    BookStatus = table.Column<int>(type: "int", nullable: false),
                    PenaltyDurationInDays = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_BookReturns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookReturns_BorrowBooks_BorrowId",
                        column: x => x.BorrowId,
                        principalSchema: "lm",
                        principalTable: "BorrowBooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "AppUserId", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("1f5f3e4a-7552-4e65-a08f-458449cce306"), null, "6d066187-1eae-497b-b4d5-e8f3a83b7916", "Member", "MEMBER" },
                    { new Guid("288621b1-cd9f-402d-88be-74cb8034a420"), null, "c07e7168-08e7-438c-92ae-95ce65dddcd3", "system", "SYSTEM" },
                    { new Guid("6556fa23-f1f2-47fc-b060-a8a55a735177"), null, "fbaabb94-2370-4d6d-a104-eb0b60275f24", "Staff", "STAFF" },
                    { new Guid("a62ce4f1-6ff3-4e7a-b3a8-616e3bb36513"), null, "b82da569-9908-4385-8ace-b7523c793285", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "CreatedById", "CreatedDate", "DeletedDate", "Email", "EmailConfirmed", "IsDeleted", "LastModifiedBy", "LastModifiedDate", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenEndDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("b34ea5da-b9e6-4a28-9bb4-545d7406cf55"), 0, "53e9d7e3-9e76-47a7-be97-3940f2b4842e", "system", new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), new DateTime(2024, 4, 18, 21, 29, 2, 329, DateTimeKind.Local).AddTicks(6205), null, "employee1@example.com", true, false, "SYSTEM", null, false, null, "admin", "EMPLOYEE2@EXAMPLE.COM", "EMPLOYEE2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ9UNt+aUtqiMa80O4RQ50mwYu94RXbGaJx5FEXv3ts0E+MBNQHFf/RTuDI0vGgTHQ==", null, false, null, null, "", "admin", false, "employee1@example.com" },
                    { new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), 0, "187bf0e3-fac1-4c1d-b82a-3dd01798b858", "SYSTEM", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2024, 4, 18, 21, 29, 2, 240, DateTimeKind.Local).AddTicks(3084), null, "system@domain.com", true, false, "SYSTEM", null, false, null, "system", "SYSTEM@DOMAIN.COM", "SYSTEM", "AQAAAAIAAYagAAAAEEg0eDfYtVOmj6aVrueOAydNg6hPgs7VrI4kMJOc6HEeqLDRcNCbELd4wofGGAtoYw==", null, false, null, null, "", "system", false, "system" },
                    { new Guid("fcb68775-eb8a-4d96-b3bf-001997ed1f87"), 0, "875ef2b7-8ab4-46a9-aed8-973b683542e1", "system", new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), new DateTime(2024, 4, 18, 21, 29, 2, 287, DateTimeKind.Local).AddTicks(6102), null, "admin@example.com", true, false, "SYSTEM", null, false, null, "admin", "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOVaqRf75giQ3Ll6lgznXPPbi1dMzGOTAPPeq5zls0BLBPdJQJtI6OF5jktVQJc3lg==", null, false, null, null, "", "admin", false, "admin@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Biography", "BirthDate", "Country", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "Surname" },
                values: new object[] { new Guid("de5951ec-1f7d-40d1-a2a8-58c84dedead9"), "Joanne Rowling, better known by her pen name J.K. Rowling, is a British author, philanthropist, film producer, television producer, and screenwriter. She is best known for writing the Harry Potter fantasy series.", new DateTime(1965, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "United Kingdom", new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), 1713475742L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), null, "J.K.", "Rowling" });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookGenres",
                columns: new[] { "Id", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsActive", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name" },
                values: new object[,]
                {
                    { new Guid("bf60b3e8-7e68-4c64-9c77-fdc74908643d"), new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), 1713475742L, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), null, "Fantasy" },
                    { new Guid("cd91aa88-e6a3-47d8-a61e-ed245a2aadf3"), new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), 1713475742L, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), null, "Adventure" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookPublishers",
                columns: new[] { "Id", "Address", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Email", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "PhoneNumber", "Website" },
                values: new object[] { new Guid("54e898f1-26e3-47cb-b2bb-0ec5d1247b70"), "50 Bedford Square, London, England", new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), 1713475742L, null, "info@bloomsbury.com", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), null, "Bloomsbury Publishing", "+44 (0)20 7631 5600", "https://www.bloomsbury.com/" });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Book_Tags",
                columns: new[] { "Id", "BookId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name" },
                values: new object[,]
                {
                    { new Guid("3cdd38f2-ba11-453d-83a1-f41b353f95d0"), new Guid("fd434411-cae1-4a69-855b-2e25dcdce5a5"), new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), 1713475742L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), null, "Quidditch" },
                    { new Guid("96466d58-4479-4936-8430-2fa4212d8971"), new Guid("fd434411-cae1-4a69-855b-2e25dcdce5a5"), new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), 1713475742L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), null, "Hogwarts" },
                    { new Guid("dbfd4647-3a63-4da1-a636-050af9a96968"), new Guid("fd434411-cae1-4a69-855b-2e25dcdce5a5"), new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), 1713475742L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), null, "Harry Potter" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "LibraryBranches",
                columns: new[] { "Id", "Address", "BookId", "BranchHourId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Description", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "LibraryTransactionId", "MemberId", "Name", "PhoneNumber", "StaffId" },
                values: new object[] { new Guid("dc6678ea-d746-40b4-b514-3bec6aaf9404"), "123 Ana Cadde", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), 1713475742L, null, "Bu bir örnek kütüphane şubesidir.", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Örnek Kütüphane Şubesi", "123-456-7890", new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Members",
                columns: new[] { "Id", "Address", "BirthDate", "BorrowId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Email", "ExtensionDurationInDays", "Gender", "HasPenalty", "IsDeleted", "IsDeletedById", "IsExtensionAllowed", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "MaxLateReturnsAllowed", "MembershipDate", "Name", "NumberOfLateReturns", "Occupation", "PenaltyDurationInDays", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("3c0c4bff-5d46-48f9-94d5-d4142768cb08"), "456 Oak Street", new DateTime(1985, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), 1713475742L, null, "jane.smith@example.com", 0, false, true, false, new Guid("00000000-0000-0000-0000-000000000000"), false, new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), null, new Guid("dc6678ea-d746-40b4-b514-3bec6aaf9404"), 3, new DateTime(2024, 4, 18, 21, 29, 2, 374, DateTimeKind.Local).AddTicks(7496), "Jane Smith", 2, "Teacher", 7, "+1987654321" },
                    { new Guid("c82b02f4-bbdd-4643-b47d-0e8ba85c4ddf"), "123 Main Street", new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), 1713475742L, null, "john.doe@example.com", 7, true, false, false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), null, new Guid("dc6678ea-d746-40b4-b514-3bec6aaf9404"), 3, new DateTime(2024, 4, 18, 21, 29, 2, 374, DateTimeKind.Local).AddTicks(7491), "John Doe", 0, "Software Engineer", 0, "+1234567890" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("6556fa23-f1f2-47fc-b060-a8a55a735177"), new Guid("b34ea5da-b9e6-4a28-9bb4-545d7406cf55"), "AppUserRole" },
                    { new Guid("a62ce4f1-6ff3-4e7a-b3a8-616e3bb36513"), new Guid("fcb68775-eb8a-4d96-b3bf-001997ed1f87"), "AppUserRole" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Books",
                columns: new[] { "Id", "AuthorId", "BookFormat", "BookLanguage", "BookStatus", "BookStockBranchId", "BorrowId", "CoverImageUrl", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Description", "GenreId", "ISBN", "IsDeleted", "IsDeletedById", "IsFeatured", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "OriginalPublicationDate", "PageCount", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { new Guid("fd434411-cae1-4a69-855b-2e25dcdce5a5"), new Guid("de5951ec-1f7d-40d1-a2a8-58c84dedead9"), "PrintedBook", "English", "Available", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "https://m.media-amazon.com/images/I/81q77Q39nEL._SY385_.jpg", new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), 1713475742L, null, "Harry Potter has never even heard of Hogwarts when the letters start dropping on the doormat at number four, Privet Drive. Addressed in green ink on yellowish parchment with a purple seal, they are swiftly confiscated by his grisly aunt and uncle. Then, on Harry's eleventh birthday, a great beetle-eyed giant of a man called Rubeus Hagrid bursts in with some astonishing news: Harry Potter is a wizard, and he has a place at Hogwarts School of Witchcraft and Wizardry. An incredible adventure is about to begin!", new Guid("bf60b3e8-7e68-4c64-9c77-fdc74908643d"), "9781408855652", false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), null, new Guid("dc6678ea-d746-40b4-b514-3bec6aaf9404"), new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 352, new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("54e898f1-26e3-47cb-b2bb-0ec5d1247b70"), "Harry Potter and the Philosopher's Stone" });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BranchHours",
                columns: new[] { "Id", "ClosingTime", "CreatedById", "CreatedDateUnix", "DayOfWeek", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "OpeningTime" },
                values: new object[,]
                {
                    { new Guid("02f66609-1bbc-4880-94d0-6a27d0f391ee"), new TimeSpan(0, 17, 30, 0, 0), new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), 1713475742L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), null, new Guid("dc6678ea-d746-40b4-b514-3bec6aaf9404"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("040d8537-a55b-499b-8e65-02a764903b45"), new TimeSpan(0, 17, 30, 0, 0), new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), 1713475742L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), null, new Guid("dc6678ea-d746-40b4-b514-3bec6aaf9404"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("31eb4c14-c71a-4cf2-a3d7-802e78d4de94"), new TimeSpan(0, 17, 30, 0, 0), new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), 1713475742L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), null, new Guid("dc6678ea-d746-40b4-b514-3bec6aaf9404"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("83d48b86-ad88-4144-afe3-79ae7a102e45"), new TimeSpan(0, 17, 30, 0, 0), new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), 1713475742L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), null, new Guid("dc6678ea-d746-40b4-b514-3bec6aaf9404"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("87e50036-b4ec-4832-afa5-94ef434e2e76"), new TimeSpan(0, 17, 30, 0, 0), new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), 1713475742L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), null, new Guid("dc6678ea-d746-40b4-b514-3bec6aaf9404"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("c0f62571-a6ed-4197-851a-48914522323d"), new TimeSpan(0, 17, 30, 0, 0), new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), 1713475742L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), null, new Guid("dc6678ea-d746-40b4-b514-3bec6aaf9404"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("ecd95182-8bff-4953-8083-19a57a4c64b8"), new TimeSpan(0, 0, 0, 0, 0), new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), 1713475742L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), null, new Guid("dc6678ea-d746-40b4-b514-3bec6aaf9404"), new TimeSpan(0, 0, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "LibraryBranchMembers",
                columns: new[] { "LibraryBranchId", "MemberId" },
                values: new object[,]
                {
                    { new Guid("dc6678ea-d746-40b4-b514-3bec6aaf9404"), new Guid("3c0c4bff-5d46-48f9-94d5-d4142768cb08") },
                    { new Guid("dc6678ea-d746-40b4-b514-3bec6aaf9404"), new Guid("c82b02f4-bbdd-4643-b47d-0e8ba85c4ddf") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Staffs",
                columns: new[] { "Id", "Address", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "EmploymentDate", "IsDeleted", "IsDeletedById", "IsFullTime", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "Phone", "Salary", "UserId" },
                values: new object[] { new Guid("b9373aaf-4c75-4d8b-aad6-aa834b115849"), "Employee Address", new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), 1713475742L, null, new DateTime(2024, 4, 18, 21, 29, 2, 374, DateTimeKind.Local).AddTicks(7531), false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), null, new Guid("dc6678ea-d746-40b4-b514-3bec6aaf9404"), "+905553331122", 3000.00m, new Guid("b34ea5da-b9e6-4a28-9bb4-545d7406cf55") });

            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[] { new Guid("de5951ec-1f7d-40d1-a2a8-58c84dedead9"), new Guid("fd434411-cae1-4a69-855b-2e25dcdce5a5") });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookStocks",
                columns: new[] { "Id", "BookId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Quantity" },
                values: new object[] { new Guid("715074fb-7901-4eae-8c79-304d78da86c6"), new Guid("fd434411-cae1-4a69-855b-2e25dcdce5a5"), new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), 1713475742L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), null, 100 });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookTags",
                columns: new[] { "BookId", "TagId" },
                values: new object[,]
                {
                    { new Guid("fd434411-cae1-4a69-855b-2e25dcdce5a5"), new Guid("96466d58-4479-4936-8430-2fa4212d8971") },
                    { new Guid("fd434411-cae1-4a69-855b-2e25dcdce5a5"), new Guid("dbfd4647-3a63-4da1-a636-050af9a96968") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BorrowBooks",
                columns: new[] { "Id", "BookId", "BorrowDate", "BorrowStatus", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "DueDate", "HasFee", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LenderId", "MemberId" },
                values: new object[] { new Guid("8e34963f-0a3b-47a5-9314-34b821ba79de"), new Guid("fd434411-cae1-4a69-855b-2e25dcdce5a5"), new DateTime(2024, 4, 18, 21, 29, 2, 374, DateTimeKind.Local).AddTicks(7543), "Borrowed", new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), 1713475742L, null, new DateTime(2024, 5, 2, 21, 29, 2, 374, DateTimeKind.Local).AddTicks(7544), false, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), null, new Guid("b9373aaf-4c75-4d8b-aad6-aa834b115849"), new Guid("c82b02f4-bbdd-4643-b47d-0e8ba85c4ddf") });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookReturns",
                columns: new[] { "Id", "BookStatus", "BorrowId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "IsLate", "LastModifiedById", "LastModifiedDateUnix", "PenaltyDurationInDays", "ReturnDate" },
                values: new object[] { new Guid("8f2e4cb7-6d6a-41f5-b37d-a581bb1faa5c"), 4, new Guid("8e34963f-0a3b-47a5-9314-34b821ba79de"), new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), 1713475742L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), false, new Guid("c5c04fd3-6fc0-43b2-8f2e-cd99a9484bf3"), null, -13, new DateTime(2024, 4, 18, 21, 29, 2, 374, DateTimeKind.Local).AddTicks(7568) });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_AppUserId",
                table: "AspNetRoles",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Book_Tags_Name",
                schema: "lm",
                table: "Book_Tags",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthors_BookId",
                table: "BookAuthors",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookPublishers_Email",
                schema: "lm",
                table: "BookPublishers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookPublishers_Name",
                schema: "lm",
                table: "BookPublishers",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_BookReturns_BorrowId",
                schema: "lm",
                table: "BookReturns",
                column: "BorrowId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookReturns_ReturnDate",
                schema: "lm",
                table: "BookReturns",
                column: "ReturnDate");

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreId",
                schema: "lm",
                table: "Books",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_ISBN",
                schema: "lm",
                table: "Books",
                column: "ISBN");

            migrationBuilder.CreateIndex(
                name: "IX_Books_LibraryBranchId",
                schema: "lm",
                table: "Books",
                column: "LibraryBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherId",
                schema: "lm",
                table: "Books",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Title",
                schema: "lm",
                table: "Books",
                column: "Title");

            migrationBuilder.CreateIndex(
                name: "IX_BookStocks_BookId",
                schema: "lm",
                table: "BookStocks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookTags_BookId",
                schema: "lm",
                table: "BookTags",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowBooks_BookId",
                schema: "lm",
                table: "BorrowBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowBooks_BorrowDate",
                schema: "lm",
                table: "BorrowBooks",
                column: "BorrowDate");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowBooks_DueDate",
                schema: "lm",
                table: "BorrowBooks",
                column: "DueDate");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowBooks_LenderId",
                schema: "lm",
                table: "BorrowBooks",
                column: "LenderId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowBooks_MemberId",
                schema: "lm",
                table: "BorrowBooks",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchHours_ClosingTime",
                schema: "lm",
                table: "BranchHours",
                column: "ClosingTime");

            migrationBuilder.CreateIndex(
                name: "IX_BranchHours_DayOfWeek",
                schema: "lm",
                table: "BranchHours",
                column: "DayOfWeek");

            migrationBuilder.CreateIndex(
                name: "IX_BranchHours_LibraryBranchId",
                schema: "lm",
                table: "BranchHours",
                column: "LibraryBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchHours_OpeningTime",
                schema: "lm",
                table: "BranchHours",
                column: "OpeningTime");

            migrationBuilder.CreateIndex(
                name: "IX_LibraryBranches_Name",
                schema: "lm",
                table: "LibraryBranches",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LibraryBranchMembers_LibraryBranchId",
                schema: "lm",
                table: "LibraryBranchMembers",
                column: "LibraryBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_LibraryTransactions_LibraryBranchId",
                schema: "lm",
                table: "LibraryTransactions",
                column: "LibraryBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Members_Email",
                schema: "lm",
                table: "Members",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_ScopeId",
                schema: "identity",
                table: "RolePermissions",
                column: "ScopeId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_LibraryBranchId",
                schema: "lm",
                table: "Staffs",
                column: "LibraryBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_Phone",
                schema: "lm",
                table: "Staffs",
                column: "Phone");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_UserId",
                schema: "lm",
                table: "Staffs",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BookAuthors");

            migrationBuilder.DropTable(
                name: "BookReturns",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "BookStocks",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "BookTags",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "BranchHours",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "LibraryBranchMembers",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "LibraryTransactions",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "RolePermissions",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "BorrowBooks",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "Book_Tags",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Scopes",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "Books",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "Members",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "Staffs",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "BookGenres",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "BookPublishers",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "LibraryBranches",
                schema: "lm");
        }
    }
}
