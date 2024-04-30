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
                    { new Guid("06c32c13-ab25-4d50-9592-8a838363186f"), null, "5e7982d7-2e66-4d2f-b3b6-a1f36d98db0d", "Staff", "STAFF" },
                    { new Guid("9dee5a36-0730-4782-bc9d-e930893fd49a"), null, "e8724178-5447-4489-ac39-e111199911f0", "Admin", "ADMIN" },
                    { new Guid("fb429bd7-c3d1-4c11-ad42-d833a5397001"), null, "03f26935-95cd-4918-a7dd-5ea49401b784", "Member", "MEMBER" },
                    { new Guid("ff7795af-c2c2-4d2e-ab4c-7ddbcfa890af"), null, "b8ffed38-5543-4cd2-9462-1a35108774e9", "system", "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "ConcurrencyStamp", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Email", "EmailConfirmed", "Gender", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "RefreshToken", "RefreshTokenEndDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("25f50f06-e706-4230-99c2-15c6bb3d5841"), 0, "123 Main Street", new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "2e29bee1-5d80-4cfe-a2dd-8a883e97a157", new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 0L, null, "john.doe@example.com", true, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, false, null, "John", "JOHN.DOE@EXAMPLE.COM", "JOHN.DOE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOn47zI+IBQFIiMmpzBDPLbEnfNzYHLqLFQk1MiJSvq8UhQdAkic40/GGVgF95xukA==", null, false, new byte[0], null, null, "", "Doe", false, "john.doe@example.com" },
                    { new Guid("cd1aaf1e-86d8-46ce-9c27-acfd29d0421a"), 0, "789 Employee St.", new DateTime(1990, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "f2b284f8-adb5-4faf-aced-b6b83f0e6e60", new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 0L, null, "employee1@example.com", true, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, false, null, "Employee", "EMPLOYEE1@EXAMPLE.COM", "EMPLOYEE1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGrhQt+b4f07iarxjB+E2woCMYDwi0O4Knaq2VACbdHH0uF0APX1xrdieeFcE6t1EA==", null, false, new byte[0], null, null, "", "One", false, "employee1@example.com" },
                    { new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 0, "123 System St.", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d0e6747a-1ec5-4824-976c-4d09208ce14a", new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, "system@domain.com", true, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, false, null, "System", "SYSTEM@DOMAIN.COM", "SYSTEM", "AQAAAAIAAYagAAAAEEt2ijMb7nsoOjhheilQ8nTbiMDU3dSspsskc963Ko1r+tSzjp77WY6W36Uk1BG4pw==", null, false, new byte[0], null, null, "", "Admin", false, "system" },
                    { new Guid("e94a3b2b-9fad-422d-8460-dbe93b3a8c71"), 0, "456 Admin St.", new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "49cf2c32-67df-4a3d-a27f-1e33b99dead2", new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 0L, null, "admin@example.com", true, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, false, null, "Admin", "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKr7NyFAsnckUqHVq46qQbn6V7G5CdJ1a5xxPcrR/WbOLXkpukb65bHiuRqVo5Vu9Q==", null, false, new byte[0], null, null, "", "Admin", false, "admin@example.com" },
                    { new Guid("fc87b27e-b2b5-48d3-987f-13974a58fdca"), 0, "456 Oak Street", new DateTime(1985, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "b369361c-fe94-454e-bee2-22807cac425a", new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 0L, null, "jane.smith@example.com", true, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, false, null, "Jane", "JANE.SMITH@EXAMPLE.COM", "JANE.SMITH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEtV2YNrocB5QPWWDAnWgo9JnHd5hmYs5WS6TUZd4eoOjSAo29g84LVK5qF9x6H5ww==", null, false, new byte[0], null, null, "", "Smith", false, "jane.smith@example.com" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Authors",
                columns: new[] { "Id", "Biography", "BirthDate", "Country", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "Surname", "Website" },
                values: new object[] { new Guid("a03218ef-6fa6-4520-a2bb-6779b197f9fb"), "Joanne Rowling, better known by her pen name J.K. Rowling, is a British author, philanthropist, film producer, television producer, and screenwriter. She is best known for writing the Harry Potter fantasy series.", new DateTime(1965, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "United Kingdom", new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, "J.K.", "Rowling", "www.example.com" });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookGenres",
                columns: new[] { "Id", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsActive", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name" },
                values: new object[,]
                {
                    { new Guid("5041e2cb-026d-4c7f-800e-f8558927ee94"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, "Fantasy" },
                    { new Guid("7a65eeeb-417e-4d46-a404-bc7dc6b109f5"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, "Adventure" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookPublishers",
                columns: new[] { "Id", "Address", "City", "Country", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Email", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "PhoneNumber", "Website" },
                values: new object[,]
                {
                    { new Guid("59a61d3c-7ba1-4d31-a302-f27f73b99aa8"), "1745 Broadway, New York, NY, USA", "New York", "USA", new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, "info@randomhouse.com", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, "Random House", "+1 212-782-9000", "https://www.randomhousebooks.com/" },
                    { new Guid("6ddaf306-03be-4aee-8505-701d5f477624"), "80 Strand, London, England", "London", "England", new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, "info@penguin.co.uk", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, "Penguin Books", "+44 (0)20 7139 3000", "https://www.penguin.co.uk/" },
                    { new Guid("ae9b4852-6ba2-42a6-b8bf-ec4c18734229"), "50 Bedford Square, London, England", "London", "England", new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, "info@bloomsbury.com", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, "Bloomsbury Publishing", "+44 (0)20 7631 5600", "https://www.bloomsbury.com/" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Book_Tags",
                columns: new[] { "Id", "BookId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name" },
                values: new object[,]
                {
                    { new Guid("01649c71-135b-44c6-bb17-34064191ab59"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, "Quidditch" },
                    { new Guid("87ec76e2-d92f-4a4b-a128-3124d97f536e"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, "Hogwarts" },
                    { new Guid("bb239628-1d30-4a79-8bd3-082802ba08f1"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, "Harry Potter" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "LibraryBranches",
                columns: new[] { "Id", "Address", "CreatedById", "CreatedDateUnix", "CriticalLevelThreshold", "DeletedDateUnix", "Description", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "MaxCheckoutDurationInDays", "MaxCheckoutLimit", "MinCheckoutDurationInDays", "Name", "NotifyOnBookOrBlogComment", "PhoneNumber", "TopBooksReportLimit", "TopMembersReportLimit" },
                values: new object[,]
                {
                    { new Guid("50d2b3c7-dabb-4197-8fe2-3799ebaab86d"), "456 İkinci Sokak, No: 15", new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, 6, null, "Ana Kütüphane Şubesi, şehrin kalbindeki kitapseverler için bir buluşma noktasıdır.", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, 10, 7, 4, "Ana Kütüphane Şubesi", true, "+90 (212) 123 4567", 7, 7 },
                    { new Guid("ce3a4a2f-a544-4216-8c0b-0bfb2e223b40"), "789 Üçüncü Bulvar, No: 23", new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, 8, null, "Yıldızlar Kütüphanesi, gökyüzünü aşkın kitaplarla dolu bir yerdir.", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, 14, 10, 3, "Yıldızlar Kütüphanesi", false, "+90 (212) 987 6543", 10, 10 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("06c32c13-ab25-4d50-9592-8a838363186f"), new Guid("cd1aaf1e-86d8-46ce-9c27-acfd29d0421a"), "AppUserRole" },
                    { new Guid("9dee5a36-0730-4782-bc9d-e930893fd49a"), new Guid("e94a3b2b-9fad-422d-8460-dbe93b3a8c71"), "AppUserRole" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookCatalogs",
                columns: new[] { "Id", "AudioFilePath", "AuthorId", "BookFormat", "BookStatus", "BookStockId", "CoverImageUrl", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "EditionId", "Editor", "FavoriteListId", "FilePath", "GenreId", "HasTagPrinted", "ISBN", "IsBorrowable", "IsDeleted", "IsDeletedById", "IsFeatured", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "OriginalPublicationDate", "PageCount", "PublicationDate", "PublisherId", "ReadingListId", "Summary", "Title", "Translator", "WorkLanguage" },
                values: new object[] { new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), null, new Guid("a03218ef-6fa6-4520-a2bb-6779b197f9fb"), "PrintedBook", "Active", new Guid("9060be58-3617-4ecb-b594-871c40dafb2b"), "https://m.media-amazon.com/images/I/81q77Q39nEL._SY385_.jpg", new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, new Guid("00000000-0000-0000-0000-000000000000"), null, null, null, new Guid("5041e2cb-026d-4c7f-800e-f8558927ee94"), false, "9781408855652", true, false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, new Guid("50d2b3c7-dabb-4197-8fe2-3799ebaab86d"), new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 352, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ae9b4852-6ba2-42a6-b8bf-ec4c18734229"), null, "Harry Potter has never even heard of Hogwarts when the letters start dropping on the doormat at number four, Privet Drive.\r\nAddressed in green ink on yellowish parchment with a purple seal, they are swiftly confiscated by his grisly aunt and uncle.\r\nThen, on Harry's eleventh birthday, a great beetle-eyed giant of a man called Rubeus Hagrid bursts in with some astonishing news: Harry Potter is a wizard, and he has a place at Hogwarts School of Witchcraft and Wizardry. An incredible adventure is about to begin!", "Harry Potter and the Philosopher's Stone", null, "English" });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BranchHours",
                columns: new[] { "Id", "ClosingTime", "CreatedById", "CreatedDateUnix", "DayOfWeek", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "OpeningTime" },
                values: new object[,]
                {
                    { new Guid("473a2a11-1856-4249-a88a-7ea00c7c6c7d"), new TimeSpan(0, 17, 30, 0, 0), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, new Guid("50d2b3c7-dabb-4197-8fe2-3799ebaab86d"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("646c7742-560c-46af-b748-dfb7b7e13b23"), new TimeSpan(0, 17, 30, 0, 0), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, new Guid("50d2b3c7-dabb-4197-8fe2-3799ebaab86d"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("802f8d5b-a87d-4956-b1f7-8addbd7dc642"), new TimeSpan(0, 17, 30, 0, 0), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, new Guid("50d2b3c7-dabb-4197-8fe2-3799ebaab86d"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("9f40b4fd-7367-4627-8bbd-14c6dcce1be0"), new TimeSpan(0, 17, 30, 0, 0), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, new Guid("50d2b3c7-dabb-4197-8fe2-3799ebaab86d"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("bb44b0ce-538c-40e1-a60d-4de89a64088a"), new TimeSpan(0, 0, 0, 0, 0), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, new Guid("50d2b3c7-dabb-4197-8fe2-3799ebaab86d"), new TimeSpan(0, 0, 0, 0, 0) },
                    { new Guid("cb188318-6fa4-4f1e-87d2-7fad5da5fbe1"), new TimeSpan(0, 17, 30, 0, 0), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, new Guid("50d2b3c7-dabb-4197-8fe2-3799ebaab86d"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("f3fa6ed1-8b8d-47de-8f40-3dc13f9bbd92"), new TimeSpan(0, 17, 30, 0, 0), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, new Guid("50d2b3c7-dabb-4197-8fe2-3799ebaab86d"), new TimeSpan(0, 8, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Members",
                columns: new[] { "Id", "BorrowId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "ExtensionDurationInDays", "Gender", "HasPenalty", "IsDeleted", "IsDeletedById", "IsExtensionAllowed", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "MaxLateReturnsAllowed", "MemberType", "MembershipDate", "MembershipStatus", "NumberOfLateReturns", "Occupation", "PenaltyDurationInDays", "UserId" },
                values: new object[,]
                {
                    { new Guid("799aab7d-b064-4f88-a50c-146a7c65189c"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, 7, "Male", false, false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, new Guid("50d2b3c7-dabb-4197-8fe2-3799ebaab86d"), 3, "Adult", new DateTime(2024, 4, 30, 17, 37, 33, 733, DateTimeKind.Local).AddTicks(7955), "Active", 0, "Software Engineer", 0, new Guid("25f50f06-e706-4230-99c2-15c6bb3d5841") },
                    { new Guid("dcb32bba-016f-4698-b8bc-20f3b28ff7db"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, 0, "Female", true, false, new Guid("00000000-0000-0000-0000-000000000000"), false, new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, new Guid("50d2b3c7-dabb-4197-8fe2-3799ebaab86d"), 3, "Teacher", new DateTime(2024, 4, 30, 17, 37, 33, 733, DateTimeKind.Local).AddTicks(7962), "Active", 2, "Teacher", 7, new Guid("fc87b27e-b2b5-48d3-987f-13974a58fdca") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Shelves",
                columns: new[] { "Id", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "Name" },
                values: new object[,]
                {
                    { new Guid("54de5116-6872-46af-a4ea-550fd33f501e"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, new Guid("50d2b3c7-dabb-4197-8fe2-3799ebaab86d"), "Shelf 1" },
                    { new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, new Guid("50d2b3c7-dabb-4197-8fe2-3799ebaab86d"), "Shelf 3" },
                    { new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, new Guid("50d2b3c7-dabb-4197-8fe2-3799ebaab86d"), "Shelf 2" },
                    { new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, new Guid("50d2b3c7-dabb-4197-8fe2-3799ebaab86d"), "Shelf 4" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Staffs",
                columns: new[] { "Id", "Address", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "EmploymentDate", "IsDeleted", "IsDeletedById", "IsFullTime", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "Phone", "Salary", "UserId" },
                values: new object[] { new Guid("c67ec491-752d-49ad-9a5b-3da687301b82"), "Employee Address", new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, new DateTime(2024, 4, 30, 17, 37, 33, 733, DateTimeKind.Local).AddTicks(8010), false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, new Guid("50d2b3c7-dabb-4197-8fe2-3799ebaab86d"), "+905553331122", 3000.00m, new Guid("cd1aaf1e-86d8-46ce-9c27-acfd29d0421a") });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookAuthors",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[] { new Guid("a03218ef-6fa6-4520-a2bb-6779b197f9fb"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2") });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookCompartments",
                columns: new[] { "Id", "BookInventoryItemId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "ShelfId" },
                values: new object[,]
                {
                    { new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, "Compartment 5", new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("04ae4b4d-6663-43f2-9d62-fb3b55447e29"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, "Compartment 5", new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("105df791-6f7d-49c3-9dfe-155674134945"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, "Compartment 5", new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("1820de64-1c6e-4548-8da5-5b2bcfe80162"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, "Compartment 4", new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("2125b06f-95c6-4863-b5e4-cef9f4651a11"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, "Compartment 1", new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("2efc390c-ca95-4f90-9b2b-c8b93d2c039c"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, "Compartment 1", new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, "Compartment 2", new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("431eb031-2b98-4c08-b3e4-779e538a7957"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, "Compartment 4", new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("6bea2c19-5af9-4363-942d-5d3b64841155"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, "Compartment 2", new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("70dbabb1-da6d-4eb6-a318-86cbbf584eb5"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, "Compartment 1", new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("75202fe0-707d-434a-8e78-b65c485deb96"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, "Compartment 5", new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, "Compartment 1", new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("9c4d50f7-fdac-4254-b051-1fc7cdea08de"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, "Compartment 3", new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("a6713470-0535-4cd7-9d31-c44c076a6186"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, "Compartment 3", new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("a86986ca-506b-443c-b107-0b675ef0eb8b"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, "Compartment 3", new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("b1154f87-1b07-464f-a37e-bdb114a3817d"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, "Compartment 2", new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, "Compartment 3", new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("bd9a6fb1-23b2-45a9-afa5-0a86843921c6"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, "Compartment 4", new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("ce8d46b3-0ecf-4ba1-b3d5-de24a70c18e5"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, "Compartment 2", new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, "Compartment 4", new Guid("54de5116-6872-46af-a4ea-550fd33f501e") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookStocksOLD",
                columns: new[] { "Id", "BookId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Quantity" },
                values: new object[] { new Guid("9060be58-3617-4ecb-b594-871c40dafb2b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, 100 });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookTags",
                columns: new[] { "BookId", "TagId" },
                values: new object[,]
                {
                    { new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), new Guid("87ec76e2-d92f-4a4b-a128-3124d97f536e") },
                    { new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), new Guid("bb239628-1d30-4a79-8bd3-082802ba08f1") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BorrowLends",
                columns: new[] { "Id", "BookId", "BorrowDate", "BorrowStatus", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "DueDate", "FeeAmount", "HasFee", "IsDeleted", "IsDeletedById", "IsLate", "LastModifiedById", "LastModifiedDateUnix", "LateDurationInDays", "LenderId", "MemberId", "ReturnDate", "WorkInventoryId" },
                values: new object[,]
                {
                    { new Guid("723b7f65-76ae-419d-804b-30aca1269da0"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), new DateTime(2024, 4, 20, 17, 37, 33, 733, DateTimeKind.Local).AddTicks(8018), "Returned", new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, new DateTime(2024, 4, 30, 17, 37, 33, 733, DateTimeKind.Local).AddTicks(8031), 0m, false, false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, 0, new Guid("c67ec491-752d-49ad-9a5b-3da687301b82"), new Guid("799aab7d-b064-4f88-a50c-146a7c65189c"), new DateTime(2024, 4, 30, 17, 37, 33, 733, DateTimeKind.Local).AddTicks(8032), null },
                    { new Guid("bbbc7107-37f1-490e-ac86-0194b3592c00"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), new DateTime(2024, 4, 20, 17, 37, 33, 733, DateTimeKind.Local).AddTicks(8062), "DelayedReturn", new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, new DateTime(2024, 4, 29, 17, 37, 33, 733, DateTimeKind.Local).AddTicks(8065), 0m, false, false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, 1, new Guid("c67ec491-752d-49ad-9a5b-3da687301b82"), new Guid("dcb32bba-016f-4698-b8bc-20f3b28ff7db"), new DateTime(2024, 4, 30, 17, 37, 33, 733, DateTimeKind.Local).AddTicks(8066), null }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Editions",
                columns: new[] { "Id", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "EditionNumber", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Notes", "PublicationDate", "PublisherId", "WorkCatalogId", "WorkPublisherId" },
                values: new object[,]
                {
                    { new Guid("67759366-026d-489b-8ec8-781036069716"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "First edition of Harry Potter and the Philosopher's Stone.", new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ae9b4852-6ba2-42a6-b8bf-ec4c18734229"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), null },
                    { new Guid("ce3f9fa8-70bb-4a5d-904d-8f76f094317b"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, 3, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Third edition of Harry Potter and the Philosopher's Stone.", new DateTime(1999, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("59a61d3c-7ba1-4d31-a302-f27f73b99aa8"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), null },
                    { new Guid("eb758e4e-aaf3-44c8-96c5-ec25f293f18b"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, 2, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Second edition of Harry Potter and the Philosopher's Stone.", new DateTime(1998, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6ddaf306-03be-4aee-8505-701d5f477624"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), null }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "LibraryBranchMembers",
                columns: new[] { "LibraryBranchId", "MemberId" },
                values: new object[,]
                {
                    { new Guid("50d2b3c7-dabb-4197-8fe2-3799ebaab86d"), new Guid("799aab7d-b064-4f88-a50c-146a7c65189c") },
                    { new Guid("50d2b3c7-dabb-4197-8fe2-3799ebaab86d"), new Guid("dcb32bba-016f-4698-b8bc-20f3b28ff7db") },
                    { new Guid("ce3a4a2f-a544-4216-8c0b-0bfb2e223b40"), new Guid("dcb32bba-016f-4698-b8bc-20f3b28ff7db") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookInventories",
                columns: new[] { "Id", "BookCompartmentId", "BookId", "BookNumber", "BookStatus", "BookStockTransactionType", "BorrowLendId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Description", "Donor", "IsAvailable", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Notes", "ShelfId" },
                values: new object[,]
                {
                    { new Guid("00869f18-4956-4130-8620-37fe095baf0d"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-173", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("03157110-0db9-44fe-a970-03f85e98308e"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-69", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("043483bc-e3e5-4216-b774-301c7bd449a3"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-172", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("064d03ad-27fd-4e84-9bee-7819cd24a047"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-59", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("07b02fcb-6031-41b3-944a-8bdff2d03a47"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-141", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("0a6cb069-f5a2-44fa-bd0d-90da7abdc2a5"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-107", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("0dedaeec-7684-4fe9-9ba5-c41114bb8177"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-100", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("10b6d45d-29af-4a7b-b0d7-7ba0ec0ed391"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-19", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("10c69608-650d-495a-b60a-56fb9d6b068a"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-149", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("10f2902f-ee94-43aa-a2fe-19d7219db924"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-136", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("11597627-5a0d-4b6e-a080-5b6b0788ba6c"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-165", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("14eb9167-ea37-4678-9acd-a04961eeb7c2"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-124", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("14ff7724-32e6-42f6-b871-26c68a8a121b"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-18", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("15c999a7-c8fb-44a6-809f-79838fb7175e"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-93", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("16b04521-f048-4e88-b6f7-4a3f15e68a64"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-129", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("16b763b4-b312-4468-ace2-a2f7d7489964"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-8", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("1733a396-f18d-4e68-acc7-f3f38f032796"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-127", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("17cea1cd-302c-41e5-869f-67a867c772ef"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-103", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("1847c95c-c5fc-493f-aede-e881a717c168"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-62", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("18d7d6d6-1d95-47d7-996d-b1c1366f358a"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-2", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("1a34b330-34d6-40c2-8c28-db6c19d42486"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-169", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("1c0ca3fd-3828-4be0-98ed-53625311f5b9"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-146", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("1cd4307f-8240-41ac-b2a8-458fa86dc384"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-96", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("1d8941dd-a092-4240-84ca-1f65810958c0"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-55", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("1de2bfc8-435e-4589-aed9-0b963ab8d87a"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-58", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("1f1a0b70-5544-4d17-9ead-f3efc3f7cec0"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-78", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("1f1f975f-a6f3-4816-bc37-999e1cc2deaa"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-91", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("1f30aaf1-0986-422d-80e3-7a74f7952ba0"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-65", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("201b33e3-fdfa-4663-80bb-e92c32fae864"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-143", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("2159d44f-7fc9-4bac-87fe-af678c82a9de"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-33", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("221a9435-2efd-473a-b180-35419ee7db8f"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-153", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("22229e4a-e215-4532-916e-4c6b8c2ca57d"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-81", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("2342d9f0-5f77-41d7-bcf0-1189cf5c0144"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-139", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("250f141a-3bb8-4ceb-adb2-48764650c5d7"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-60", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("255b25cd-f5b8-4a58-b312-bbb469c26c93"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-34", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("25e6c70d-b86c-4c66-bb80-688b1763024d"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-51", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("260c2997-efe8-47a5-bdea-bf5837aaabfe"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-37", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("26b4f4d0-36c4-4cf1-a57f-24b26a0f18a5"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-43", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("26ccb19c-56b9-43b2-8d29-269efd10c8ce"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-109", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("27911c91-a4f3-44e2-983d-0959638df0c4"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-77", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("2960b7f8-ffd7-437b-ae1e-bcb8000d150b"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-185", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("29cc8d51-5a7e-4947-bf6a-7917b62abdba"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-104", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("2a25b89d-9785-45aa-abcf-508d7b8a55e8"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-74", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("2d3695e4-4996-4b13-a192-4bcb6ec25129"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-47", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("2ef84250-d130-4eb7-8b56-2d212ba96e85"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-14", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("30b3b3d2-99bc-46db-a58b-0f5b55e7c88f"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-137", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("314d4c89-86b4-4450-8102-9e8e4ff69f7b"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-92", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("31b0b137-7a68-4757-b2f8-378b983ba079"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-117", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("32699818-bb6c-40a9-8b86-f25fd13c1ab7"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-113", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("3313d831-adc9-4ab6-8e26-9280af8bc94a"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-46", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("37ba01c9-7ad1-4c1a-aa41-13e516015d02"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-98", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("3cf025ca-ad16-4993-a625-d2fbf9823f2e"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-152", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("3d1a1779-9d3d-4f83-abba-9cd00339451d"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-138", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("3d775940-c2f3-40ea-b625-cc035ac677cb"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-182", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("3e6b1b65-f67c-45ef-ba92-bcf9a8ae2336"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-57", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("3eb18073-5257-4bf8-90c6-e81c80419e3a"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-166", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("3f58bab7-fdb0-4d1d-95ee-ba316b55a4b4"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-147", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("3fa3e1ce-cbfd-4cc1-85b7-ed7ccee07f87"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-42", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("3fb116b7-e3d8-4290-bc79-4eb2dd0500fa"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-102", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("400069be-4a7a-430d-8782-fafd4833b964"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-121", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("4099c165-00ac-4846-ac26-c62ac911dc54"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-75", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("41f8a7cd-e96b-4450-99da-6814ce5ca6d0"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-135", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("421450bb-7427-4fba-9647-10d1e4a86b7f"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-158", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("43ac95ac-8561-4f4c-94ff-691282b73221"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-187", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("447111cb-0123-4b57-82e1-ea754c9fe1bd"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-150", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("4476202e-c11d-458f-a702-e5334eb2d2df"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-163", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("4702ab5d-2bca-4c65-ba7c-e4f4a3ce32c0"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-12", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("4eb52bad-eb66-4ecc-a1ec-6b6a71d19b80"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-154", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("4ee4cb3a-527f-4a46-a62f-2291a114880f"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-148", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("4f7cfa37-6fee-4a39-b630-53699235fe9e"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-168", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("4fc9d290-eb6d-45d3-bc30-a9c96bc583fd"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-131", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("50dea585-e37e-4afe-a37d-60933b387d41"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-21", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("51fad95e-8505-4449-90df-d257675c297a"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-63", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("52f3d133-8d7c-4e49-bc03-f4b64c007b38"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-30", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("541b34f9-d820-4d8d-9c64-2f248c7fad77"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-196", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("5603c482-4d8c-49ce-aed0-1d05e7de733e"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-162", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("56cb39cd-4dd1-4b5c-95eb-cc8b781021bd"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-25", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("570ab371-c4ae-4ea9-8354-d6ccf245df9c"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-134", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("583a4859-4e67-432d-a82c-a2106df6d0ad"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-5", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("588b67eb-c428-4658-b289-aad5181ff979"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-175", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("5ddf92c2-7800-43ab-b4c9-151b43a07bb2"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-38", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("6028a750-8dda-4a95-b00a-0f354a098f84"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-126", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("6086f40a-5fd5-476d-ac9d-89fb7af23290"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-130", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("616618b1-4b81-4015-a020-404ac683f076"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-122", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("6239d114-689b-4266-b05f-87c363b7ee30"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-128", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("65279ee3-aca9-41e0-897e-8e3512a206db"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-3", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("6b5abb8e-c717-46f7-a09f-b1e5956c59e5"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-86", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("6bf20e63-cbd5-4e4f-a37b-6ea098b70bdb"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-70", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("6d257a8a-07bf-4002-a3f6-bf190dddf9c2"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-186", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("708fecdc-d34e-4013-b9c7-dafe676af1db"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-191", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("70fde353-44c2-41c8-9fb3-061237b2e512"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-180", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("7288ab11-e5df-48e7-a0f6-9ed08903df96"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-179", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("72f9893b-8288-439d-9503-1bed39014369"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-23", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("7478db1a-2588-472e-a1f5-415027a4ebee"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-116", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("75478d62-e44c-4b99-80e7-12201a42e580"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-133", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("7645ab14-cf52-4796-b127-5771ecfa0882"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-160", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("780bc7ea-ca73-44ab-9bba-43658c4ccc82"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-157", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("78eecd28-ec3f-43cb-bde2-b8b2fb488d8f"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-49", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("7a270390-26bf-403d-ba51-bb91fb9254c2"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-118", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("7a4873b2-a610-41d3-be4d-8bbffd20c647"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-178", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("7b591b84-e8c3-4046-8efb-40a582a0a301"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-36", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("7ca28276-1ec6-4230-a14b-165cfafd4a69"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-48", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("7d362b8e-bfc3-4bf0-b7dc-bdc6b265e97a"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-112", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("7d818f35-9808-4f99-a56a-2308fe02e527"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-31", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("7ec2f580-6e2c-4659-a7aa-aad00d67a4f2"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-41", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("7ef15bce-6b7e-4ddb-b5e4-11c688982bae"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-56", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("84007dbc-4879-4a78-8008-b63603830ccd"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-76", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("8454575e-3535-4d5a-922e-4fba1c814e92"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-177", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("852b1171-bd46-484d-834f-8067e84991c0"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-61", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("8562ecbb-bbc6-4f0a-87c1-6e2af10bbe55"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-95", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("85851de5-8fae-4284-84ba-e1c14c515d3f"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-183", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("87b5ba98-31a2-49b2-b152-e4dbd37a1837"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-82", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("88cbe03e-0a32-4a28-9c78-0dab9ce02f2f"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-197", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("8aad506d-d24d-4378-8c95-18275da8eca4"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-79", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("8abf1b5d-8a77-4721-9092-6d3110aca53d"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-73", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("8b1272e9-4ca7-4182-9de7-e7245a484cd5"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-53", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("8c99890b-ac4e-4141-99ca-99f82622ef4a"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-71", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("8df987e8-a803-493c-9654-935851a13c52"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-120", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("8f8a0076-d97c-4182-af3a-6f6bdafce2ce"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-50", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("9730b46b-dde6-44fe-a40f-537c7de918b8"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-151", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("97ba8fd7-0a38-4fb3-8e4d-4637701d7559"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-111", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("99e07cc5-affb-468a-ad02-c9e440cc1ee7"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-16", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("9ad42bb9-02a3-4d55-b31b-530ddd534c99"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-106", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("9cc4d7bb-aed7-4c33-9801-206532fa1d22"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-99", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("9e7b709e-8c6e-4bdc-a8c4-7e59f5dd2d82"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-13", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("9f014dff-ce1e-48bf-bdc3-1efc8400de10"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-88", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("a03dc1ae-efd4-4df4-8bed-3e9ba7f48910"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-68", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("a0b46319-d838-47f7-a4cf-76bd3d598b43"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-9", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("a2f72a07-f7f3-47b5-82c1-8feb8ea2cf3b"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-156", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("a3b91dd5-5c77-48ec-8428-3257c459dd8b"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-125", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("a3cae30f-6f09-4bd0-9f80-19d3f44b8fb6"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-29", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("a4317768-6214-4122-85f2-5ba8bed9a1a0"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-184", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("a5bdc2fe-e59c-47ab-b20c-20f4428421ed"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-10", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("a67e027e-51b7-4243-8bf2-ff831ac9a771"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-140", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("aae9791b-0f53-4257-be9d-5229767608e6"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-32", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("ac6563c0-3521-4750-a5af-748176f502c3"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-119", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("ad03ff6b-6c54-4620-ab64-40cc4cec798e"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-89", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("adf77b92-6bee-4607-b23a-07c01090c880"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-97", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("aeceabe6-af41-4521-b3e0-38b2e71cf8c8"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-22", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("af1afa58-2346-4f42-98bc-823c092b5cff"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-174", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("af51afd0-90ac-4b10-a90d-907d4e9a014e"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-66", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("b0a3713f-caae-43a9-b170-a3e6a062251e"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-87", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("b151eb93-bc2a-41ef-a1d3-69b6eb988b60"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-7", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("b1c2af04-6b26-4a4a-b062-ba1824b82707"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-192", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("b208ef64-c55f-41b2-8a76-5d1b921ef202"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-6", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("b2269262-a33f-4084-9ab3-ebf0c1d241e0"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-24", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("b3e2941c-4c0d-476c-9788-751fa5b1c2e1"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-171", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("b48e033f-0412-4477-a4a4-ec0990deec85"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-4", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("b4faff7a-d0bf-4229-a454-f0040819e934"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-44", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("b8702971-495c-4e26-80d8-d6f0db9bf4ea"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-198", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("b953cbc0-89dc-4c21-aa73-83b90876a022"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-11", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("ba5d9eee-8914-49f5-a313-b419c291c21d"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-193", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("bb4e3c6d-2117-4dbf-b056-fa664987efac"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-190", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("bbcc0dfb-6019-4ad4-bd9d-9d9d31d8124a"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-200", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("bc57d5ad-6894-4558-8db9-4f9d8a4140fd"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-170", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("bd21963f-9d7b-49a8-a4ae-5631d51d6f4c"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-17", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("be48f26a-e298-47b7-92d0-32e9a387f072"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-90", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("bfc16f7a-54c2-4f2f-9391-0010c72090c1"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-84", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("c152bf8c-7dac-48a5-b5b7-9e195978739b"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-64", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("ca945004-4780-4f09-a3e1-59c0ceba03c5"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-28", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("cc1d77d0-ebdb-41d7-b739-719d3c161434"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-20", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("cd335658-b2d7-4e3d-8080-36414be52213"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-27", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("cd9b8f47-1aa5-4a3e-be01-088718fc14e6"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-199", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("cdef9d9f-20a8-488a-acb1-8ce8c9293faf"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-26", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("ce57ef88-74ef-4aa9-bdd2-7a8671b7e6e2"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-83", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("cecc6b88-296a-46c9-9da3-fb673101bd3e"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-176", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("cf413a5d-e939-47f5-af77-39ac026ddd8a"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-52", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("d2ff80b5-620b-4d2b-bcfc-65fd12334fa5"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-161", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("d43e4e0f-0140-404c-9386-36376ebf2e35"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-145", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("d60c28aa-3e4b-4150-b21d-7506e83a9b1c"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-144", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("d7815ccc-c688-490a-bd33-2cad55eb1935"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-15", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("d7dd7882-ae00-4409-a14b-0239bc2a03ea"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-110", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("d8600ab2-e57f-4472-9e3c-bd200de1514c"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-155", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("d9a5e3ad-1d96-4e6f-a9b3-c026f6c3bbc7"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-101", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("de7c061a-e0ec-4d80-b27a-17b490ab6812"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-85", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("e0c3b3d7-6b36-4965-a742-4229e32e5c0d"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-194", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("e0dcf8f4-0a7b-41c8-91a3-597b43198fc6"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-188", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("e0fc7d3f-b1ba-4df9-8c5a-ab93c9617439"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-114", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("e428f248-d1a5-42c5-8db5-333a88b55695"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-45", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("e57b7d30-f43b-4fa6-8a22-131297a77330"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-167", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("e681c926-ead6-4470-92d3-e0d290152cb8"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-94", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("e71fa5ec-9ddd-4fa1-a3ad-46e0c03c1093"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-159", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("e753f1d6-7ea0-4623-a373-0c83c809ce77"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-40", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("e7a7d7a6-7079-4706-a676-4264aafca6ce"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-108", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("e96b3efd-eb3e-4f19-8359-419295b8a6b5"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-164", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("ee5bbfff-7cd5-461f-b9a0-a62b5ef4ee89"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-67", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("f05f806d-1134-442e-8bec-1d749faf0626"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-39", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("f08d971c-cbbc-40f9-8614-ce7c6f13c758"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-189", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("f4cd13fe-f64a-4c3d-8479-973c825d5b34"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-142", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("f8703bc3-e77a-408e-b65c-44d873de01c3"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-35", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("f924bb85-c715-4bf5-a87a-cd84575b8c32"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-181", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("f9a74a24-8b4b-4a5b-b9a2-b9f046f2801f"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-72", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("fc07bce7-3e98-450e-bc42-ee2f11d21d04"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-54", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("fc5a2aae-8f60-40a8-85c8-4769b3c9fb0a"), new Guid("3f7fd0f0-3c8c-4f8c-b5de-36facfbaf3e2"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-115", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("fc6761ad-9e6f-43df-8fcd-9562eb7eee7c"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-80", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("b6a0c124-076c-445b-9a9b-3ef610e5ee4f") },
                    { new Guid("fcb59108-b36e-4587-9174-fb3df0932d09"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-105", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("fd1a40d1-e1e8-4d4a-aea9-7faa03b33cca"), new Guid("ba9beb85-482b-4dcc-bc42-2b07153ca32b"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-123", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") },
                    { new Guid("fd42d2bb-9ce9-4b36-b040-65c4724503fa"), new Guid("8bdfe684-f162-4388-a1a9-3af851147425"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-1", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("54de5116-6872-46af-a4ea-550fd33f501e") },
                    { new Guid("fd73e2c0-fa3a-4556-a66a-54257e171bc8"), new Guid("03f2ddb3-15d8-410a-9f25-e83cecdf7f32"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-195", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("d85c41de-8b7f-4398-9fbb-39d76f9e5097") },
                    { new Guid("fdfe429e-96f1-42fc-a9eb-8a4998a6f5b1"), new Guid("fa6df7ed-0262-42ac-bbc7-868c15e99f78"), new Guid("b8cb703d-6518-4e08-952f-445b085c1bb2"), "HP-132", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), 1714498653L, null, null, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e67a0ee5-ef66-4088-af5e-a1b03db079e7"), null, null, new Guid("656a19af-68e1-4112-a926-6e1a1ff57a09") }
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
