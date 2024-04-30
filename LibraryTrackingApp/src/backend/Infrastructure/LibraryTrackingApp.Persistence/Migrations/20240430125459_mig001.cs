using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryTrackingApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "lm");

            migrationBuilder.EnsureSchema(
                name: "static");

            migrationBuilder.EnsureSchema(
                name: "identity");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    ProfilePicture = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeletedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateUnix = table.Column<long>(type: "bigint", nullable: false),
                    LastModifiedDateUnix = table.Column<long>(type: "bigint", nullable: true),
                    DeletedDateUnix = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
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
                schema: "lm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "FavoriteLists",
                schema: "lm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_FavoriteLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JwtSettingConfigurations",
                schema: "static",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Issuer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Audience = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecretKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccessTokenExpirationMinutes = table.Column<int>(type: "int", nullable: false),
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_JwtSettingConfigurations", x => x.Id);
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
                    MaxCheckoutLimit = table.Column<int>(type: "int", nullable: false),
                    MinCheckoutDurationInDays = table.Column<int>(type: "int", nullable: false),
                    MaxCheckoutDurationInDays = table.Column<int>(type: "int", nullable: false),
                    CriticalLevelThreshold = table.Column<int>(type: "int", nullable: false),
                    NotifyOnBookOrBlogComment = table.Column<bool>(type: "bit", nullable: false),
                    TopMembersReportLimit = table.Column<int>(type: "int", nullable: false),
                    TopBooksReportLimit = table.Column<int>(type: "int", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "ReadingLists",
                schema: "lm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_ReadingLists", x => x.Id);
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
                name: "Members",
                schema: "lm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MembershipDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemberType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MembershipStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_Members_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "Shelves",
                schema: "lm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LibraryBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
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
                    table.PrimaryKey("PK_Shelves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shelves_LibraryBranches_LibraryBranchId",
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
                name: "BookCatalogs",
                schema: "lm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EditionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PublisherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LibraryBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookStockId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CoverImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PageCount = table.Column<int>(type: "int", nullable: false),
                    AudioFilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OriginalPublicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookFormat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkLanguage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsBorrowable = table.Column<bool>(type: "bit", nullable: false),
                    Translator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Editor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasTagPrinted = table.Column<bool>(type: "bit", nullable: false),
                    FavoriteListId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReadingListId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_BookCatalogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookCatalogs_BookGenres_GenreId",
                        column: x => x.GenreId,
                        principalSchema: "lm",
                        principalTable: "BookGenres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookCatalogs_BookPublishers_PublisherId",
                        column: x => x.PublisherId,
                        principalSchema: "lm",
                        principalTable: "BookPublishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookCatalogs_FavoriteLists_FavoriteListId",
                        column: x => x.FavoriteListId,
                        principalSchema: "lm",
                        principalTable: "FavoriteLists",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookCatalogs_LibraryBranches_LibraryBranchId",
                        column: x => x.LibraryBranchId,
                        principalSchema: "lm",
                        principalTable: "LibraryBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookCatalogs_ReadingLists_ReadingListId",
                        column: x => x.ReadingListId,
                        principalSchema: "lm",
                        principalTable: "ReadingLists",
                        principalColumn: "Id");
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
                name: "BookCompartments",
                schema: "lm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookInventoryItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShelfId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
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
                    table.PrimaryKey("PK_BookCompartments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookCompartments_Shelves_ShelfId",
                        column: x => x.ShelfId,
                        principalSchema: "lm",
                        principalTable: "Shelves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookAuthors",
                schema: "lm",
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
                        principalSchema: "lm",
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookAuthors_BookCatalogs_BookId",
                        column: x => x.BookId,
                        principalSchema: "lm",
                        principalTable: "BookCatalogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookStocksOLD",
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
                    table.PrimaryKey("PK_BookStocksOLD", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookStocksOLD_BookCatalogs_BookId",
                        column: x => x.BookId,
                        principalSchema: "lm",
                        principalTable: "BookCatalogs",
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
                        name: "FK_BookTags_BookCatalogs_BookId",
                        column: x => x.BookId,
                        principalSchema: "lm",
                        principalTable: "BookCatalogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookTags_Book_Tags_TagId",
                        column: x => x.TagId,
                        principalSchema: "lm",
                        principalTable: "Book_Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Editions",
                schema: "lm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkCatalogId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PublisherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EditionNumber = table.Column<int>(type: "int", nullable: false),
                    PublicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkPublisherId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_Editions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Editions_BookCatalogs_WorkCatalogId",
                        column: x => x.WorkCatalogId,
                        principalSchema: "lm",
                        principalTable: "BookCatalogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Editions_BookPublishers_PublisherId",
                        column: x => x.PublisherId,
                        principalSchema: "lm",
                        principalTable: "BookPublishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Editions_BookPublishers_WorkPublisherId",
                        column: x => x.WorkPublisherId,
                        principalSchema: "lm",
                        principalTable: "BookPublishers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BookInventories",
                schema: "lm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BorrowLendId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShelfId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BookCompartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BookNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BookStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    Donor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookStockTransactionType = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
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
                    table.PrimaryKey("PK_BookInventories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookInventories_BookCatalogs_BookId",
                        column: x => x.BookId,
                        principalSchema: "lm",
                        principalTable: "BookCatalogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookInventories_BookCompartments_BookCompartmentId",
                        column: x => x.BookCompartmentId,
                        principalSchema: "lm",
                        principalTable: "BookCompartments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookInventories_Shelves_ShelfId",
                        column: x => x.ShelfId,
                        principalSchema: "lm",
                        principalTable: "Shelves",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BorrowLends",
                schema: "lm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BorrowDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BorrowStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasFee = table.Column<bool>(type: "bit", nullable: false),
                    FeeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsLate = table.Column<bool>(type: "bit", nullable: true),
                    LateDurationInDays = table.Column<int>(type: "int", nullable: true),
                    WorkInventoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_BorrowLends", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BorrowLends_BookCatalogs_BookId",
                        column: x => x.BookId,
                        principalSchema: "lm",
                        principalTable: "BookCatalogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BorrowLends_BookInventories_WorkInventoryId",
                        column: x => x.WorkInventoryId,
                        principalSchema: "lm",
                        principalTable: "BookInventories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BorrowLends_Members_MemberId",
                        column: x => x.MemberId,
                        principalSchema: "lm",
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BorrowLends_Staffs_LenderId",
                        column: x => x.LenderId,
                        principalSchema: "lm",
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "AppUserId", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("82dec015-6a6b-433f-818d-3f2c8baaef44"), null, "fb86be81-f57e-4e0a-b461-fa6d9162e413", "Member", "MEMBER" },
                    { new Guid("b994d775-1367-466c-b039-802c4174e2d6"), null, "8158ff5f-8ec5-44cc-beca-0683b78fb173", "Staff", "STAFF" },
                    { new Guid("d01fa4e0-da99-4d99-bf36-fe0eea689811"), null, "59d56dbb-4316-463f-9eab-7c687a7aaaab", "system", "SYSTEM" },
                    { new Guid("eb48937a-7da9-445b-8275-4ed5f9bb23bf"), null, "a0177a2e-a402-4334-89db-9e51eb43b4ed", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "ConcurrencyStamp", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Email", "EmailConfirmed", "Gender", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "RefreshToken", "RefreshTokenEndDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("25fa4123-7633-4ea2-8325-55ab0751173c"), 0, "456 Oak Street", new DateTime(1985, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "e0179ad9-c86e-4430-89ef-bb88ca5f1808", new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 0L, null, "jane.smith@example.com", true, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, false, null, "Jane", "JANE.SMITH@EXAMPLE.COM", "JANE.SMITH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKzb6T5zCYEeJJCS/4LnwzT4w4lIc+KcDp/cfQKxZCr4J/4xnwNN3UI6t106UBZ7Mg==", null, false, new byte[0], null, null, "", "Smith", false, "jane.smith@example.com" },
                    { new Guid("55963a81-5054-497f-ae70-e71b4ed1d003"), 0, "456 Admin St.", new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "1f31a432-0ab5-41b6-96f3-a54d5a19bf33", new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 0L, null, "admin@example.com", true, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, false, null, "Admin", "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHc3xd9btimLZRnpYBrr7sglBR2ARn/Dz1Yi8qv7ZPPU+gaGHNJh8on8666S0YgHIQ==", null, false, new byte[0], null, null, "", "Admin", false, "admin@example.com" },
                    { new Guid("61e38689-3d65-4fc9-955a-42888608fd94"), 0, "123 Main Street", new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "465582c8-630a-4f2a-b75a-0148b88406fb", new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 0L, null, "john.doe@example.com", true, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, false, null, "John", "JOHN.DOE@EXAMPLE.COM", "JOHN.DOE@EXAMPLE.COM", "AQAAAAIAAYagAAAAELBmsH5gRDKPogLJvnO0P1YwBXaRdVED1e0Ibc/quWgG8293M5PyLE6NgG4nI4DwnA==", null, false, new byte[0], null, null, "", "Doe", false, "john.doe@example.com" },
                    { new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 0, "123 System St.", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f308807e-29e6-408e-a1bb-be76cc4ca8db", new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, "system@domain.com", true, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, false, null, "System", "SYSTEM@DOMAIN.COM", "SYSTEM", "AQAAAAIAAYagAAAAEPIdzj6wrPjQJ2UF9jmjd30ZFSIBGB0VBo/cv7qY8loH33gfPwarTvY+O1I2yxgz4Q==", null, false, new byte[0], null, null, "", "Admin", false, "system" },
                    { new Guid("71f28683-6b41-449a-b339-19843cf94ccd"), 0, "789 Employee St.", new DateTime(1990, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ff3b9446-7b56-4929-af01-02a8c4b7ec2c", new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 0L, null, "employee1@example.com", true, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, false, null, "Employee", "EMPLOYEE1@EXAMPLE.COM", "EMPLOYEE1@EXAMPLE.COM", "AQAAAAIAAYagAAAAECNyW6HqquU2Q9Fe3Jm3UdpynR/y0+7GbN4qYMRMyjgFoTY6ktrF0XfE/knZpabgnQ==", null, false, new byte[0], null, null, "", "One", false, "employee1@example.com" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Authors",
                columns: new[] { "Id", "Biography", "BirthDate", "Country", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "Surname", "Website" },
                values: new object[] { new Guid("7ae2f954-c852-4c7b-b1c7-5031ae9720fa"), "Joanne Rowling, better known by her pen name J.K. Rowling, is a British author, philanthropist, film producer, television producer, and screenwriter. She is best known for writing the Harry Potter fantasy series.", new DateTime(1965, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "United Kingdom", new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, "J.K.", "Rowling", "www.example.com" });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookGenres",
                columns: new[] { "Id", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsActive", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name" },
                values: new object[,]
                {
                    { new Guid("09e7635a-d8de-45b2-9838-728f0fa35270"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, "Adventure" },
                    { new Guid("7d272c7c-0971-49d6-b7c9-cf2a25ff8f6b"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, "Fantasy" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookPublishers",
                columns: new[] { "Id", "Address", "City", "Country", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Email", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "PhoneNumber", "Website" },
                values: new object[,]
                {
                    { new Guid("01afa494-bd26-4a73-a169-8df3544ce444"), "80 Strand, London, England", "London", "England", new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, "info@penguin.co.uk", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, "Penguin Books", "+44 (0)20 7139 3000", "https://www.penguin.co.uk/" },
                    { new Guid("2b9c42bc-a700-423f-8a60-e3ba1a4ac1b9"), "1745 Broadway, New York, NY, USA", "New York", "USA", new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, "info@randomhouse.com", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, "Random House", "+1 212-782-9000", "https://www.randomhousebooks.com/" },
                    { new Guid("7e14efb5-89a6-4198-b1b2-cdf212b8410a"), "50 Bedford Square, London, England", "London", "England", new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, "info@bloomsbury.com", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, "Bloomsbury Publishing", "+44 (0)20 7631 5600", "https://www.bloomsbury.com/" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Book_Tags",
                columns: new[] { "Id", "BookId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name" },
                values: new object[,]
                {
                    { new Guid("28c76785-a127-4068-9c2a-7c21f2669465"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, "Harry Potter" },
                    { new Guid("4df87216-5e26-49d5-a501-8a369bae8278"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, "Quidditch" },
                    { new Guid("ce667051-8fbe-49d5-8ff7-05f26b97f019"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, "Hogwarts" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "LibraryBranches",
                columns: new[] { "Id", "Address", "CreatedById", "CreatedDateUnix", "CriticalLevelThreshold", "DeletedDateUnix", "Description", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "MaxCheckoutDurationInDays", "MaxCheckoutLimit", "MinCheckoutDurationInDays", "Name", "NotifyOnBookOrBlogComment", "PhoneNumber", "TopBooksReportLimit", "TopMembersReportLimit" },
                values: new object[,]
                {
                    { new Guid("8ec4862a-84c6-44d3-8cef-152f568f1555"), "789 Üçüncü Bulvar, No: 23", new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, 8, null, "Yıldızlar Kütüphanesi, gökyüzünü aşkın kitaplarla dolu bir yerdir.", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, 14, 10, 3, "Yıldızlar Kütüphanesi", false, "+90 (212) 987 6543", 10, 10 },
                    { new Guid("f6f06490-f941-4735-b491-ccc78b8609c8"), "456 İkinci Sokak, No: 15", new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, 6, null, "Ana Kütüphane Şubesi, şehrin kalbindeki kitapseverler için bir buluşma noktasıdır.", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, 10, 7, 4, "Ana Kütüphane Şubesi", true, "+90 (212) 123 4567", 7, 7 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("eb48937a-7da9-445b-8275-4ed5f9bb23bf"), new Guid("55963a81-5054-497f-ae70-e71b4ed1d003"), "AppUserRole" },
                    { new Guid("b994d775-1367-466c-b039-802c4174e2d6"), new Guid("71f28683-6b41-449a-b339-19843cf94ccd"), "AppUserRole" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookCatalogs",
                columns: new[] { "Id", "AudioFilePath", "AuthorId", "BookFormat", "BookStatus", "BookStockId", "CoverImageUrl", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "EditionId", "Editor", "FavoriteListId", "FilePath", "GenreId", "HasTagPrinted", "ISBN", "IsBorrowable", "IsDeleted", "IsDeletedById", "IsFeatured", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "OriginalPublicationDate", "PageCount", "PublicationDate", "PublisherId", "ReadingListId", "Summary", "Title", "Translator", "WorkLanguage" },
                values: new object[] { new Guid("d5064d80-e964-4801-8905-312b83f303a3"), null, new Guid("7ae2f954-c852-4c7b-b1c7-5031ae9720fa"), "PrintedBook", "Active", new Guid("09af2a90-6dc9-4294-a913-a4d2a1dce1ef"), "https://m.media-amazon.com/images/I/81q77Q39nEL._SY385_.jpg", new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, new Guid("00000000-0000-0000-0000-000000000000"), null, null, null, new Guid("7d272c7c-0971-49d6-b7c9-cf2a25ff8f6b"), false, "9781408855652", true, false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, new Guid("f6f06490-f941-4735-b491-ccc78b8609c8"), new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 352, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7e14efb5-89a6-4198-b1b2-cdf212b8410a"), null, "Harry Potter has never even heard of Hogwarts when the letters start dropping on the doormat at number four, Privet Drive.\r\nAddressed in green ink on yellowish parchment with a purple seal, they are swiftly confiscated by his grisly aunt and uncle.\r\nThen, on Harry's eleventh birthday, a great beetle-eyed giant of a man called Rubeus Hagrid bursts in with some astonishing news: Harry Potter is a wizard, and he has a place at Hogwarts School of Witchcraft and Wizardry. An incredible adventure is about to begin!", "Harry Potter and the Philosopher's Stone", null, "English" });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BranchHours",
                columns: new[] { "Id", "ClosingTime", "CreatedById", "CreatedDateUnix", "DayOfWeek", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "OpeningTime" },
                values: new object[,]
                {
                    { new Guid("482ed29d-b8a0-443f-a2c6-423b81583a7a"), new TimeSpan(0, 17, 30, 0, 0), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, new Guid("f6f06490-f941-4735-b491-ccc78b8609c8"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("68737e44-f898-43d9-be9c-b6889bb28892"), new TimeSpan(0, 17, 30, 0, 0), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, new Guid("f6f06490-f941-4735-b491-ccc78b8609c8"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("6d7fdb2e-b6fd-4d09-b38a-76abce9ad2c0"), new TimeSpan(0, 17, 30, 0, 0), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, new Guid("f6f06490-f941-4735-b491-ccc78b8609c8"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("758b1d74-f49d-4d53-8d90-4b023c9c7658"), new TimeSpan(0, 0, 0, 0, 0), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, new Guid("f6f06490-f941-4735-b491-ccc78b8609c8"), new TimeSpan(0, 0, 0, 0, 0) },
                    { new Guid("7f12bfbc-68f2-40c7-af95-f8f28c65b1bb"), new TimeSpan(0, 17, 30, 0, 0), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, new Guid("f6f06490-f941-4735-b491-ccc78b8609c8"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("8e654811-170a-4c1b-9390-2f30f155c6ac"), new TimeSpan(0, 17, 30, 0, 0), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, new Guid("f6f06490-f941-4735-b491-ccc78b8609c8"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("99710526-b728-4c31-afb4-cd8e7db564d7"), new TimeSpan(0, 17, 30, 0, 0), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, new Guid("f6f06490-f941-4735-b491-ccc78b8609c8"), new TimeSpan(0, 8, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Members",
                columns: new[] { "Id", "BorrowId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "ExtensionDurationInDays", "Gender", "HasPenalty", "IsDeleted", "IsDeletedById", "IsExtensionAllowed", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "MaxLateReturnsAllowed", "MemberType", "MembershipDate", "MembershipStatus", "NumberOfLateReturns", "Occupation", "PenaltyDurationInDays", "UserId" },
                values: new object[,]
                {
                    { new Guid("1cfb3314-b9fb-4c4f-9c70-86b87d029d0d"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, 7, "Male", false, false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, new Guid("f6f06490-f941-4735-b491-ccc78b8609c8"), 3, "Adult", new DateTime(2024, 4, 30, 15, 54, 58, 711, DateTimeKind.Local).AddTicks(1088), "Active", 0, "Software Engineer", 0, new Guid("61e38689-3d65-4fc9-955a-42888608fd94") },
                    { new Guid("a5a8479c-ef8c-41bd-ad71-00b016706a1c"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, 0, "Female", true, false, new Guid("00000000-0000-0000-0000-000000000000"), false, new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, new Guid("f6f06490-f941-4735-b491-ccc78b8609c8"), 3, "Teacher", new DateTime(2024, 4, 30, 15, 54, 58, 711, DateTimeKind.Local).AddTicks(1139), "Active", 2, "Teacher", 7, new Guid("25fa4123-7633-4ea2-8325-55ab0751173c") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Shelves",
                columns: new[] { "Id", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "Name" },
                values: new object[,]
                {
                    { new Guid("1ace9259-ac96-4c92-b7b6-a60521463424"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, new Guid("f6f06490-f941-4735-b491-ccc78b8609c8"), "Shelf 1" },
                    { new Guid("82de509d-1319-4611-b70f-242b07a7621f"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, new Guid("f6f06490-f941-4735-b491-ccc78b8609c8"), "Shelf 2" },
                    { new Guid("de07780d-da9f-46af-b57e-337c95a031c6"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, new Guid("f6f06490-f941-4735-b491-ccc78b8609c8"), "Shelf 4" },
                    { new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, new Guid("f6f06490-f941-4735-b491-ccc78b8609c8"), "Shelf 3" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Staffs",
                columns: new[] { "Id", "Address", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "EmploymentDate", "IsDeleted", "IsDeletedById", "IsFullTime", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "Phone", "Salary", "UserId" },
                values: new object[] { new Guid("39a56cda-2c7b-4bc2-aae1-28bbe891f44b"), "Employee Address", new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, new DateTime(2024, 4, 30, 15, 54, 58, 711, DateTimeKind.Local).AddTicks(1180), false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, new Guid("f6f06490-f941-4735-b491-ccc78b8609c8"), "+905553331122", 3000.00m, new Guid("71f28683-6b41-449a-b339-19843cf94ccd") });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookAuthors",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[] { new Guid("7ae2f954-c852-4c7b-b1c7-5031ae9720fa"), new Guid("d5064d80-e964-4801-8905-312b83f303a3") });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookCompartments",
                columns: new[] { "Id", "BookInventoryItemId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "ShelfId" },
                values: new object[,]
                {
                    { new Guid("04c47342-5d6c-4cae-83e6-2b6d3b0b4f66"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, "Compartment 5", new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, "Compartment 1", new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, "Compartment 2", new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("1cb48142-63bd-4324-817e-a5fb99f8a1da"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, "Compartment 3", new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("26d32e6e-bd9f-4e5a-9c70-7849dd7f7889"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, "Compartment 2", new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("439bf713-08c3-463d-b97f-ca9b96264b80"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, "Compartment 1", new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("453ddee7-510a-4aa3-8966-8f724c44645c"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, "Compartment 2", new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("608384e2-71e7-4a68-ac1d-17380ce22c92"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, "Compartment 4", new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, "Compartment 5", new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("693e4b0d-b718-4e1d-b93a-0edad78a8ddc"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, "Compartment 4", new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, "Compartment 3", new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("aa7baf3e-5008-4485-9b43-ca542dcc18ee"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, "Compartment 3", new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("ba18df92-32d5-4246-9b86-2f74cf8eabba"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, "Compartment 3", new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("bee31592-2db8-43b6-9f76-7b8ced18e9cf"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, "Compartment 1", new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("c0377ff3-1cf8-40eb-8383-becf27aa162c"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, "Compartment 1", new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("d0cc7fd8-6328-4389-9ff7-4b226d0a11ad"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, "Compartment 5", new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, "Compartment 4", new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("e576c423-6c8a-4b76-b86a-9ceab2506089"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, "Compartment 2", new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("e7d5c3cc-2f73-413e-93d0-e93868bc9fb4"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, "Compartment 4", new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("ea6f488e-e897-417b-8231-4e948b523a19"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, "Compartment 5", new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookStocksOLD",
                columns: new[] { "Id", "BookId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Quantity" },
                values: new object[] { new Guid("09af2a90-6dc9-4294-a913-a4d2a1dce1ef"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, 100 });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookTags",
                columns: new[] { "BookId", "TagId" },
                values: new object[,]
                {
                    { new Guid("d5064d80-e964-4801-8905-312b83f303a3"), new Guid("28c76785-a127-4068-9c2a-7c21f2669465") },
                    { new Guid("d5064d80-e964-4801-8905-312b83f303a3"), new Guid("ce667051-8fbe-49d5-8ff7-05f26b97f019") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BorrowLends",
                columns: new[] { "Id", "BookId", "BorrowDate", "BorrowStatus", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "DueDate", "FeeAmount", "HasFee", "IsDeleted", "IsDeletedById", "IsLate", "LastModifiedById", "LastModifiedDateUnix", "LateDurationInDays", "LenderId", "MemberId", "ReturnDate", "WorkInventoryId" },
                values: new object[,]
                {
                    { new Guid("972b27d6-9c73-4179-bf4d-ce4b744ac63f"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), new DateTime(2024, 4, 20, 15, 54, 58, 711, DateTimeKind.Local).AddTicks(1193), "Returned", new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, new DateTime(2024, 4, 30, 15, 54, 58, 711, DateTimeKind.Local).AddTicks(1231), 0m, false, false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, 0, new Guid("39a56cda-2c7b-4bc2-aae1-28bbe891f44b"), new Guid("1cfb3314-b9fb-4c4f-9c70-86b87d029d0d"), new DateTime(2024, 4, 30, 15, 54, 58, 711, DateTimeKind.Local).AddTicks(1232), null },
                    { new Guid("f2503734-64f3-4a87-84b3-e9b2fcc404b6"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), new DateTime(2024, 4, 20, 15, 54, 58, 711, DateTimeKind.Local).AddTicks(1316), "DelayedReturn", new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, new DateTime(2024, 4, 29, 15, 54, 58, 711, DateTimeKind.Local).AddTicks(1319), 0m, false, false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, 1, new Guid("39a56cda-2c7b-4bc2-aae1-28bbe891f44b"), new Guid("a5a8479c-ef8c-41bd-ad71-00b016706a1c"), new DateTime(2024, 4, 30, 15, 54, 58, 711, DateTimeKind.Local).AddTicks(1321), null }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Editions",
                columns: new[] { "Id", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "EditionNumber", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Notes", "PublicationDate", "PublisherId", "WorkCatalogId", "WorkPublisherId" },
                values: new object[,]
                {
                    { new Guid("8b76666d-88ef-44a6-9b3b-ecd7c8a53ea5"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, 3, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Third edition of Harry Potter and the Philosopher's Stone.", new DateTime(1999, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2b9c42bc-a700-423f-8a60-e3ba1a4ac1b9"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), null },
                    { new Guid("956f049f-87d0-4c15-98c9-9780a4f99fa6"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, 2, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Second edition of Harry Potter and the Philosopher's Stone.", new DateTime(1998, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("01afa494-bd26-4a73-a169-8df3544ce444"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), null },
                    { new Guid("ceaa91b7-db88-46fa-addb-62b54495bfd7"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "First edition of Harry Potter and the Philosopher's Stone.", new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7e14efb5-89a6-4198-b1b2-cdf212b8410a"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), null }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "LibraryBranchMembers",
                columns: new[] { "LibraryBranchId", "MemberId" },
                values: new object[,]
                {
                    { new Guid("f6f06490-f941-4735-b491-ccc78b8609c8"), new Guid("1cfb3314-b9fb-4c4f-9c70-86b87d029d0d") },
                    { new Guid("8ec4862a-84c6-44d3-8cef-152f568f1555"), new Guid("a5a8479c-ef8c-41bd-ad71-00b016706a1c") },
                    { new Guid("f6f06490-f941-4735-b491-ccc78b8609c8"), new Guid("a5a8479c-ef8c-41bd-ad71-00b016706a1c") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookInventories",
                columns: new[] { "Id", "BookCompartmentId", "BookId", "BookNumber", "BookStatus", "BookStockTransactionType", "BorrowLendId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Description", "Donor", "IsAvailable", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Notes", "ShelfId" },
                values: new object[,]
                {
                    { new Guid("008744b4-07f9-42b8-99a9-04ae9acb75ed"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-29", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("054b4f3c-e9f8-4a35-93b7-1e8772828b6c"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-87", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("05a77c0a-4712-4420-bedf-d57e8897e398"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-188", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("05b8c1ee-2497-4f95-9326-4ef0692935e8"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-125", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("068be04f-2228-4c0a-ab97-aa364c3a23c1"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-185", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("07df4644-0e3a-452b-b4cd-563bffacc460"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-132", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("08c14464-8f60-403e-b582-0d61055a9d54"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-186", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("09ebaff5-5769-4a35-bf61-ffb01c104b32"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-145", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("0add9a04-14eb-41cc-9431-1ab6fe3eddc9"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-34", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("0bccd304-cbb9-489f-9345-1a58dcbf4e07"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-172", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("0c68d0cc-b73d-487d-9a70-5480411e6749"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-171", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("0fe71994-0006-4989-97a9-90cc51cab8f3"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-13", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("11cb3bb1-b7ca-4208-aa7f-51d69d78901c"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-161", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("12bcd3ed-1071-4c29-ab31-a32904f25add"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-198", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("12cf972e-014e-4308-ba8d-ebeb3e58cbf3"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-14", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("140d5ddb-90bf-438b-8002-80e9b406b049"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-77", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("14e47d7f-3e85-48ae-ab4c-9cfd80f81150"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-189", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("18eb5e16-bc0c-4f9d-a926-127e07fd7fde"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-3", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("193795b0-6309-4ea6-ae09-66adf4ae7626"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-176", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("1a5ce7dc-9f7d-4e32-99f7-c6fcc3dfb1dd"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-112", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("1a5f1ffe-a212-49e4-a225-7351b045cdcb"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-96", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("1c0a53d1-1aea-4f5e-b73d-30132780ae4f"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-20", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("1cd8a8cf-fc26-4a06-9926-6a4de7a9c211"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-38", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("1cfa6af2-5034-4ade-910f-45c023dadf44"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-27", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("1d9a84b8-e70f-49ef-b9c1-3ceb1017ada5"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-92", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("1eaf5ee2-3f90-433a-b54e-972fd3ef9a30"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-76", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("1ef7d176-6586-4ece-8a82-e886fba5c518"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-166", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("1f2cd5d6-353b-4566-97f5-8743a4268cb9"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-139", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("209f64df-5669-445e-8bf4-4656f97f18b2"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-15", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("23b50072-11c3-43df-bf85-823fbae39221"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-142", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("259328f9-48f8-495d-801f-e31662992d9e"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-103", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("268fc15f-e884-42a3-9fac-525e08ae69f9"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-28", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("27a865ab-b22d-4834-b26e-551e83dfe8d2"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-153", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("28e45759-5cc7-48c8-95cd-bdc1d5ff2fdb"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-126", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("31320de0-7705-48e9-9216-f1ff0e1ebcfb"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-110", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("31741453-f078-4030-b6de-c99d1f03579d"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-184", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("31c9cd64-61ad-47d9-99fe-e575917ae6e8"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-121", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("345b4175-abfe-4609-97ab-e45d5442a3d4"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-61", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("34bc676b-e757-47b2-8d8e-de016f37859b"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-89", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("366426ee-b734-4603-a894-c437b1566064"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-175", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("36a69021-a32a-4ca9-b91b-f07eb4413ba1"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-190", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("372134a8-473d-43aa-b68c-a649646643e6"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-135", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("384a2881-75f6-40c9-9894-eeda05d39ecd"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-181", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("3876e1bc-0c49-4395-ac52-3e275b4d4701"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-33", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("3a4c9ed3-70ad-4121-9921-6bd93a2eb745"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-88", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("3af32198-67d9-4ddb-815b-e36bc242a645"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-108", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("3d7b77ea-e504-4dae-a3fc-ce63c6220ed5"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-9", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("3f231388-9079-47b9-b79f-f99277932fd1"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-97", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("3fe13a2d-47b9-44b5-ad28-a297b434c756"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-149", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("4122b864-8332-4532-ab7a-a468aa75456f"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-59", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("4132a7d8-58c6-4c28-98dc-a03537c10939"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-32", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("4334e76e-ff57-45cd-a74f-14c0f7ecec84"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-21", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("4606b545-a865-404d-a128-e9d8d6b1772c"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-19", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("4795ac2d-c1df-4acd-9197-3da17faeeabd"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-160", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("48b7a27f-3f41-4961-8c6b-3a1171d00e30"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-78", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("4cd86239-5af4-4af3-80fa-852cd82f8509"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-45", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("4cdfa5c2-3d5b-43f8-914c-d86ebb2526d0"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-119", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("4d70d2d3-a6f4-4216-91c3-6ab5299b5111"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-58", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("4e22505d-526f-4372-a3f4-82c074aa86ae"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-99", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("54334dee-dab7-469f-8c37-1a149cc19000"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-57", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("5714417f-688c-4a5e-b0d1-a460e78a3c69"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-100", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("57e00077-a706-49e5-bb99-e221a97994f7"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-54", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("57e6776e-162c-4f7a-a5b2-9c6dbe76756a"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-73", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("594324ac-1f6c-4f9f-80af-43d5f0deed02"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-193", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("5b715b4c-c522-4685-aeca-a8092b977f6b"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-140", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("5daa4e6a-7ead-4f6e-9319-049f9027c57c"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-31", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("5db2b0c0-3b85-4b69-86ac-06e6e4578ba8"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-105", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("5ddd543c-a5c2-4f07-93d3-4adfa315c42f"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-155", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("5e0c7a1b-fef9-4126-85eb-41e8a236a19a"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-191", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("5f776372-1934-45f9-87a0-7999e2927320"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-51", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("619df7ed-02c3-425d-ac91-03ba8cdbf696"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-66", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("6290b6aa-fa17-4118-bb8f-fbbe3d9cb0c0"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-177", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("62c855be-e0ff-4862-a4ca-5afa4bd2a22d"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-109", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("62d68c4f-62b9-4de4-8b2d-70f0873d6fc4"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-43", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("64e8445d-2eec-4fe7-baaa-9d0e8c904cb8"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-44", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("65164c37-c575-48dc-95b0-bdaf12616891"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-144", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("655139ef-137f-42f4-9267-117df135c3be"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-168", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("6773c628-8ef2-479e-bfdb-ea7fcf9d3e57"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-95", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("68d01333-519a-4eb3-b768-a78e067c497c"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-159", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("6a89e41c-9d4d-4b4f-9d0d-25c8d379a0f0"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-127", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("6b280b3d-1796-4895-9865-4dd858dd4aaf"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-6", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("6b4e4ad8-f74d-4047-b63c-f6817738f940"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-70", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("6c957879-e29c-490f-b961-7ea5129bc01c"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-93", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("6d663977-bad9-49c5-9125-1948a82daaab"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-180", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("6e02b199-02ae-440a-ac11-2ca1db81da83"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-30", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("71b8213e-4ea1-4e3b-8967-4590eff187d3"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-35", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("71ca727b-202b-44b7-a3d8-cdc180291c41"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-7", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("71fcd53b-ee82-40ef-a0e9-46cfa231b180"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-53", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("72aac011-1fd9-4cac-af45-65a4280b351b"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-148", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("73620bf3-5548-462c-986c-095d13a7bda1"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-98", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("73af8ea8-1ab4-43c4-b058-53d307a6ff8c"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-60", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("73ec6718-e302-4654-a827-109e81b7d9e8"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-152", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("752d4757-bc84-4c7a-b97f-51b00bcec505"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-50", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("756deede-1f13-43ec-86e1-ac4a9b6c4143"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-150", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("761d4584-4608-492c-b967-bdcd6260795d"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-40", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("7a584349-9543-41d7-82df-044857c9263d"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-71", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("7ade640b-c9b0-424e-8e8c-043885e31a6f"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-64", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("7cf7b476-a7b8-4e37-8492-e42b3c27f8b9"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-158", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("811ba5d2-6ac4-4802-8b5a-ae318a348083"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-129", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("82aa7cac-2a79-47ca-92cb-487f64e71cf3"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-56", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("85d021de-64c3-4683-9fa5-7c3016fe76a3"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-68", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("85f2fd8e-c5d3-4fe4-b3bc-96865cced68f"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-2", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("865cdb4b-b4b5-4e03-a278-0ad7fe5d8dc6"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-146", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("86789c7d-953d-41ad-b979-d05e0f19b85c"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-156", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("89c1ea20-de5f-43c9-b8de-d676eeb002ba"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-104", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("8a0c7368-8af3-427c-8a64-dc06aca953e4"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-128", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("8cf29691-9a16-4713-a257-f12f349d5967"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-94", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("8e0d91f7-f7fd-415a-8063-17649babef0c"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-11", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("9013c82c-f9ae-4fbc-b983-9c7dafc801b8"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-170", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("90618c93-d52b-4e36-bbe2-036880624d20"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-23", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("912e4dfe-4796-44fe-bb86-1578beb34b58"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-167", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("916909dd-005b-49a7-86da-f44c4e9e7e0a"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-101", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("9363d9ee-d2e0-4a87-bdcf-413240b2ca75"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-72", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("94f6e758-0f23-4d15-a14c-709a6f0b5c5c"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-151", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("967979f7-fa0b-4054-840b-5e4afd841889"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-116", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("9847e332-4b0c-4af3-945b-74a5d6a554df"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-42", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("99acd089-9862-4588-ac79-50bf0a9f0eb2"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-165", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("9a17fcdb-a84e-491b-9c85-70dd1d5b762d"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-194", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("9ae8e33a-85f6-4ea1-ab6d-f4f615008fdd"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-115", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("9b85052b-670b-4bbe-96bb-4caf42b41549"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-102", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("9c244339-c3bc-4f51-954a-a42350e5eca5"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-195", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("9c9269d7-7038-4a78-8efd-4eb58a8ca0b8"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-192", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("9d057b7b-1508-47fa-b338-32874073e06b"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-16", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("9dc06382-7720-44e2-846a-8f44b47c6a7d"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-26", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("9e4e582a-6063-4cfc-9c20-363ccb694008"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-12", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("a0cae173-3552-459f-afb4-9ef377a77d70"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-183", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("a13e79d1-4829-4e88-8f0b-64877f32edb7"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-67", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("a14ea7c7-1e2d-49dd-a7a4-75a6951a656d"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-187", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("a154b772-67a2-469c-bc4a-f6e8a2c89c76"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-91", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("a1c46697-706a-4d7b-b403-3f04f1324081"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-55", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("a1e2be07-4dc6-4f6a-b650-eeec7dcbbf2b"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-79", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("a1ef9e76-862d-41bd-b9bf-9a40696658ce"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-39", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("a3361af7-0323-43bf-b1a2-4a8e8cd89e06"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-37", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("a3537514-eee2-4b5a-8abb-a19b2b10ae23"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-117", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("a4f1963e-8c85-416b-aa61-901d10a37c25"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-18", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("aa5a83b5-7da3-42e5-84a7-fde3ddbf7bc3"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-162", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("aa94b6b6-92f5-49e6-9fa0-b0017c31c213"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-143", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("aafda5c2-f1aa-4e33-9807-cf52f715405e"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-124", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("ac3aae04-bdf2-4621-8c0c-4f4620b2fc5a"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-47", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("acba56bb-7b38-4ea1-b592-bc4994dc215c"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-134", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("ae41210f-32ca-441f-a6c8-fe4560fbd4f5"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-4", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("b00d99d2-59b9-4137-8f1f-c3984f351665"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-122", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("b0f560f7-66dc-4264-a500-1ba39318f392"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-17", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("b1cee827-1f0e-44f4-a17e-2aa1c93b0370"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-69", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("b308175a-956f-4677-b3ef-79e552692fbe"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-111", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("b549a822-28df-4931-8f4e-d05a6de2b7b0"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-10", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("baf5a45d-3fbe-429d-a6a6-0bb9f6293899"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-182", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("bb138b64-85e2-4d48-8f28-e1a3bdd474b0"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-82", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("bdf88adc-85f3-4771-9b88-9a6ddf6de389"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-83", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("c147efb2-fe04-4d8e-8bc4-1d445485f5e5"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-36", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("c239ce71-d3ab-467a-97c0-2f56d80a4554"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-118", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("c3fc5cfe-651f-475f-9ff7-2ff122703849"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-106", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("c4979172-6d9d-48d2-91a2-d074f25eb41f"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-131", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("c664b3be-222c-4579-97d2-3b65b11470df"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-157", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("c89f6ac0-78d8-459e-a20d-6cb7b9fbcb7b"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-163", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("c9126905-0e36-416f-b456-6b25ef6234c9"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-75", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("cb0e7ff4-c6a8-4778-b9a4-2c76c001bf6b"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-164", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("cb5c7a5c-ce57-45bb-9ec5-07131f08d657"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-113", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("cf6846ca-d874-4a80-a6e3-fa37f71c9f58"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-80", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("d0f506f7-ca18-44a8-b277-c5ee1ade78bb"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-196", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("d116c63d-ce88-45d2-a4a6-847ced622d98"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-46", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("d1d97b4d-5950-4a50-be9a-5766fa6bbdab"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-107", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("d3652169-0d9e-47a9-a3b0-49fdb3df076d"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-49", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("d39600c4-a3a9-4215-8aa6-bc0b4a8cbf66"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-179", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("d4020a74-9203-4537-9804-71c393203409"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-169", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("d4d29800-9d41-4ba4-aa2a-e468ed01cbb5"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-133", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("d5716719-168b-44d3-aaee-d3d6696b238d"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-120", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("d64b43d2-578e-4ede-a0f2-87b9419e972a"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-81", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("d8988e48-b995-414c-8be5-265a6d14d345"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-41", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("d8aa31d1-0fcb-4973-b1b1-7bc8ed9ec296"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-138", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("d90563b6-8ff0-4e9b-8c6e-6859fbcd5066"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-63", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("da563ef8-5608-43d3-b220-ed58f7274fee"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-114", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("db1a197a-ba13-4c0d-b3cc-c90d4ea17528"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-178", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("dc84768b-829b-421f-b469-7dc5dfca4d5b"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-62", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("dee5cac4-47c0-4930-af33-5247a7509fe0"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-174", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("e217e1d7-1fe4-41eb-8c90-4d293320676a"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-84", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("e4c26d8b-e45a-4338-8549-7da940a33757"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-147", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("e50dd523-27e3-42d0-8c3d-1ce27e349013"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-85", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("e558c2dc-680f-472b-bdc8-1e484856fed4"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-130", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("e7395131-4050-450e-b029-73f966981583"), new Guid("16136288-a4bb-4500-80e2-c702ae439dbe"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-65", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("e7f71e72-25e7-4d7c-bb54-7a6450c14817"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-74", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("e9b48628-8cbd-4981-a0f5-312f2b77be36"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-173", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("ea8ebbdc-0107-4fea-ade6-ec83403ca223"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-52", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("ebf4a631-e56c-42b4-a807-5282b78e4227"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-199", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("ec152a04-92f9-454b-a77e-7abbe1b48698"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-141", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("ec28389b-87ef-4aeb-9f9d-864818fc8d3c"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-154", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("ecaaa021-8657-4d99-94a6-71adfdbacba7"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-25", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("ef6fcdae-ca95-4e3a-90ea-3110d140564e"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-86", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("efb31477-2a7a-4503-a543-acdddd8840aa"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-90", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("82de509d-1319-4611-b70f-242b07a7621f") },
                    { new Guid("f081d7cc-270e-4841-940c-b483bb800232"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-197", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("f122debb-229b-4a49-94e5-23f41e1d3e22"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-48", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("f12c0e7d-516b-4527-a82d-47ba72bb916f"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-137", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("f1631ad4-445c-4267-84f2-7d2b9ed5e7c3"), new Guid("672ad222-a288-4fa1-9369-5b717d4d0e55"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-200", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("de07780d-da9f-46af-b57e-337c95a031c6") },
                    { new Guid("f2e46b4b-d4b7-4acf-8c3f-2efe13c5a58c"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-5", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("f49887da-0fa2-42f9-b4e8-7a790bfeb6ad"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-1", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("f4f4d836-003a-43c7-9831-87f1ffad294a"), new Guid("e3b83403-ec27-4c17-8ab7-93189f8a9bd0"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-136", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("f675bbb2-3c10-4c10-873e-27a1d0d62980"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-123", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("f26474fb-8420-4a42-b2c5-7facec5ff074") },
                    { new Guid("f7e7fbad-de37-43cc-94ba-4ee23c842b54"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-22", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("f8f15dcf-7aff-41e7-a1b0-fb017b1223d1"), new Guid("74ffdaca-5630-4b15-9e40-cc461e0b5471"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-24", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") },
                    { new Guid("fb52f5ad-7b3e-4ee3-9123-8b89c8b22600"), new Guid("062f20f1-3330-4641-bf27-4750df62e762"), new Guid("d5064d80-e964-4801-8905-312b83f303a3"), "HP-8", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), 1714492498L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("63af37b7-ff05-4b45-8d0e-002a06362045"), null, null, new Guid("1ace9259-ac96-4c92-b7b6-a60521463424") }
                });

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
                schema: "lm",
                table: "BookAuthors",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookCatalogs_FavoriteListId",
                schema: "lm",
                table: "BookCatalogs",
                column: "FavoriteListId");

            migrationBuilder.CreateIndex(
                name: "IX_BookCatalogs_GenreId",
                schema: "lm",
                table: "BookCatalogs",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_BookCatalogs_ISBN",
                schema: "lm",
                table: "BookCatalogs",
                column: "ISBN");

            migrationBuilder.CreateIndex(
                name: "IX_BookCatalogs_LibraryBranchId",
                schema: "lm",
                table: "BookCatalogs",
                column: "LibraryBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_BookCatalogs_PublisherId",
                schema: "lm",
                table: "BookCatalogs",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_BookCatalogs_ReadingListId",
                schema: "lm",
                table: "BookCatalogs",
                column: "ReadingListId");

            migrationBuilder.CreateIndex(
                name: "IX_BookCatalogs_Title",
                schema: "lm",
                table: "BookCatalogs",
                column: "Title");

            migrationBuilder.CreateIndex(
                name: "IX_BookCompartments_ShelfId",
                schema: "lm",
                table: "BookCompartments",
                column: "ShelfId");

            migrationBuilder.CreateIndex(
                name: "IX_BookInventories_BookCompartmentId",
                schema: "lm",
                table: "BookInventories",
                column: "BookCompartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_BookInventories_BookId",
                schema: "lm",
                table: "BookInventories",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookInventories_BookNumber",
                schema: "lm",
                table: "BookInventories",
                column: "BookNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookInventories_ShelfId",
                schema: "lm",
                table: "BookInventories",
                column: "ShelfId");

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
                name: "IX_BookStocksOLD_BookId",
                schema: "lm",
                table: "BookStocksOLD",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookTags_BookId",
                schema: "lm",
                table: "BookTags",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowLends_BookId",
                schema: "lm",
                table: "BorrowLends",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowLends_BorrowDate",
                schema: "lm",
                table: "BorrowLends",
                column: "BorrowDate");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowLends_DueDate",
                schema: "lm",
                table: "BorrowLends",
                column: "DueDate");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowLends_LenderId",
                schema: "lm",
                table: "BorrowLends",
                column: "LenderId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowLends_MemberId",
                schema: "lm",
                table: "BorrowLends",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowLends_WorkInventoryId",
                schema: "lm",
                table: "BorrowLends",
                column: "WorkInventoryId");

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
                name: "IX_Editions_PublisherId",
                schema: "lm",
                table: "Editions",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Editions_WorkCatalogId",
                schema: "lm",
                table: "Editions",
                column: "WorkCatalogId");

            migrationBuilder.CreateIndex(
                name: "IX_Editions_WorkPublisherId",
                schema: "lm",
                table: "Editions",
                column: "WorkPublisherId");

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
                name: "IX_Members_UserId",
                schema: "lm",
                table: "Members",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_ScopeId",
                schema: "identity",
                table: "RolePermissions",
                column: "ScopeId");

            migrationBuilder.CreateIndex(
                name: "IX_Shelves_LibraryBranchId",
                schema: "lm",
                table: "Shelves",
                column: "LibraryBranchId");

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
                name: "BookAuthors",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "BookReviews",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "BookStocksOLD",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "BookTags",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "BorrowLends",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "BranchHours",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "Editions",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "JwtSettingConfigurations",
                schema: "static");

            migrationBuilder.DropTable(
                name: "LibraryBranchMembers",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "LibraryTransactions",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "MailAccounts",
                schema: "static");

            migrationBuilder.DropTable(
                name: "RolePermissions",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "Authors",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "Book_Tags",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "BookInventories",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "Staffs",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "Members",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Scopes",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "BookCatalogs",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "BookCompartments",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "BookGenres",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "BookPublishers",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "FavoriteLists",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "ReadingLists",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "Shelves",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "LibraryBranches",
                schema: "lm");
        }
    }
}
