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
                name: "Shelves",
                schema: "lm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    PublisherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LibraryBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookStockId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoverImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PageCount = table.Column<int>(type: "int", nullable: false),
                    AudioFilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OriginalPublicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookFormat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookLanguage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: false),
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
                name: "BookCompartments",
                schema: "lm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookInventoryItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookInventoryItem = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                name: "BookInventories",
                schema: "lm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BorrowLendId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookCompartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BookNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BookStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    TransactionDateUnix = table.Column<long>(type: "bigint", nullable: false),
                    BookStockTransactionType = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
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
                    BookInventoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                        name: "FK_BorrowLends_BookInventories_BookInventoryId",
                        column: x => x.BookInventoryId,
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
                    { new Guid("258db1dd-6d71-41ae-bd62-3d6a5df400aa"), null, "15aeaec2-b5da-4a94-9d97-a78920841590", "Member", "MEMBER" },
                    { new Guid("9fd10230-1e18-4b3e-880f-630e8b6180f0"), null, "035663f3-ae8a-4e63-adc4-e85846ae08bc", "Admin", "ADMIN" },
                    { new Guid("ae1ba15c-e74f-484d-a400-e777c820c73a"), null, "9d3fce5b-b139-460b-b2d4-225eeda71488", "system", "SYSTEM" },
                    { new Guid("cb1745cf-fd9d-4c74-9aa1-c189a8331c0c"), null, "d9ffe135-df40-4fbe-ba20-1a4657f1b3d4", "Staff", "STAFF" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "ConcurrencyStamp", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Email", "EmailConfirmed", "Gender", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "RefreshToken", "RefreshTokenEndDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("124d66a0-7826-42f2-a93e-f456cc6332cb"), 0, "456 Oak Street", new DateTime(1985, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "801e68cf-00ce-44c4-8435-9bf6fd3a9013", new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 0L, null, "jane.smith@example.com", true, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, false, null, "Jane", "JANE.SMITH@EXAMPLE.COM", "JANE.SMITH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEERyCVHL/1Uv5nJmMxWgH/87Vtp5lwINU/D5Y416/0cVHQvOCOT3cyAD4BLhR/zTWw==", null, false, new byte[0], null, null, "", "Smith", false, "jane.smith@example.com" },
                    { new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 0, "123 System St.", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ae497bee-53c0-495f-99f9-9a61a2f3e4c9", new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, "system@domain.com", true, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, false, null, "System", "SYSTEM@DOMAIN.COM", "SYSTEM", "AQAAAAIAAYagAAAAEJgl1HpIWhhv/3C8LXeagLMF0U3aqUS5i0Vy/k0UwNlWC5NjrkVqEDv66jN85p4IqQ==", null, false, new byte[0], null, null, "", "Admin", false, "system" },
                    { new Guid("6219baba-87aa-4cbc-b506-243a37125723"), 0, "789 Employee St.", new DateTime(1990, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ccb997be-c49f-4f81-a905-2e790d2cdd72", new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 0L, null, "employee1@example.com", true, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, false, null, "Employee", "EMPLOYEE1@EXAMPLE.COM", "EMPLOYEE1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOuaNqq+FcAMoqbOOK1OW9NQYCCWUk2wb8eoLiXK9FXgDxyhD2nlcPapNzrMdQkirg==", null, false, new byte[0], null, null, "", "One", false, "employee1@example.com" },
                    { new Guid("c8eb5e83-bb71-45e5-9431-2a7aa82e039f"), 0, "456 Admin St.", new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "5c08cdf3-dc14-44d9-8aec-82f09c4ec6a9", new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 0L, null, "admin@example.com", true, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, false, null, "Admin", "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMIkbl4CGWpBWDU6Mt6RnsX+98bsW7l05rZgoVz6xm8fTIDt6tmOCDqGqIG/w6GLVw==", null, false, new byte[0], null, null, "", "Admin", false, "admin@example.com" },
                    { new Guid("d862394e-2949-4209-b8f9-6fcb4c1c1fab"), 0, "123 Main Street", new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "a855e3fd-090a-4972-a1d5-b5e19bff1cd8", new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 0L, null, "john.doe@example.com", true, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, false, null, "John", "JOHN.DOE@EXAMPLE.COM", "JOHN.DOE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDnpTv7p3rKoJpIA2nGJeamtu+Kmqu2pBKbAtRPvCNCztrNWNIaWD1M75MCN9MXnyQ==", null, false, new byte[0], null, null, "", "Doe", false, "john.doe@example.com" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Authors",
                columns: new[] { "Id", "Biography", "BirthDate", "Country", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "Surname" },
                values: new object[] { new Guid("2cd3a01b-482e-452d-b354-1cbd746caca4"), "Joanne Rowling, better known by her pen name J.K. Rowling, is a British author, philanthropist, film producer, television producer, and screenwriter. She is best known for writing the Harry Potter fantasy series.", new DateTime(1965, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "United Kingdom", new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "J.K.", "Rowling" });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookGenres",
                columns: new[] { "Id", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsActive", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name" },
                values: new object[,]
                {
                    { new Guid("c346f72a-f3e9-4c11-8646-1755b80f9e51"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "Fantasy" },
                    { new Guid("f8814cfa-37b9-4378-aea0-3692598cd9f3"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "Adventure" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookPublishers",
                columns: new[] { "Id", "Address", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Email", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "PhoneNumber", "Website" },
                values: new object[] { new Guid("8c1ac52f-3f58-44cc-ac6d-d1e1430961f4"), "50 Bedford Square, London, England", new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "info@bloomsbury.com", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "Bloomsbury Publishing", "+44 (0)20 7631 5600", "https://www.bloomsbury.com/" });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Book_Tags",
                columns: new[] { "Id", "BookId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name" },
                values: new object[,]
                {
                    { new Guid("078e80c2-9eb4-4466-8f13-ffeac5c5d7b6"), new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "Hogwarts" },
                    { new Guid("cbeb1aca-0f6a-49d0-b1be-ece0438ab8a1"), new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "Harry Potter" },
                    { new Guid("d03fb188-f628-4a20-9caf-c7d53a458af8"), new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "Quidditch" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "LibraryBranches",
                columns: new[] { "Id", "Address", "CreatedById", "CreatedDateUnix", "CriticalLevelThreshold", "DeletedDateUnix", "Description", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "MaxCheckoutDurationInDays", "MaxCheckoutLimit", "MinCheckoutDurationInDays", "Name", "NotifyOnBookOrBlogComment", "PhoneNumber", "TopBooksReportLimit", "TopMembersReportLimit" },
                values: new object[] { new Guid("480fc452-469b-437d-b20e-3cb69910b2fd"), "123 Ana Cadde", new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, 5, null, "Bu bir örnek kütüphane şubesidir.", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, 7, 5, 5, "Örnek Kütüphane Şubesi", true, "123-456-7890", 5, 5 });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Shelves",
                columns: new[] { "Id", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name" },
                values: new object[,]
                {
                    { new Guid("09382326-27ac-4f15-89a0-5b34b5ed427f"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Shelf 3" },
                    { new Guid("245dca91-f12f-424b-9e8f-1cb4b59946f7"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Shelf 1" },
                    { new Guid("8d348907-e5b1-4cad-b8eb-0667609a6e92"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Shelf 2" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("cb1745cf-fd9d-4c74-9aa1-c189a8331c0c"), new Guid("6219baba-87aa-4cbc-b506-243a37125723"), "AppUserRole" },
                    { new Guid("9fd10230-1e18-4b3e-880f-630e8b6180f0"), new Guid("c8eb5e83-bb71-45e5-9431-2a7aa82e039f"), "AppUserRole" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookCatalogs",
                columns: new[] { "Id", "AudioFilePath", "AuthorId", "BookFormat", "BookLanguage", "BookStatus", "BookStockId", "CoverImageUrl", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Description", "FavoriteListId", "FilePath", "GenreId", "ISBN", "IsDeleted", "IsDeletedById", "IsFeatured", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "OriginalPublicationDate", "PageCount", "PublicationDate", "PublisherId", "ReadingListId", "Title" },
                values: new object[] { new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), null, new Guid("2cd3a01b-482e-452d-b354-1cbd746caca4"), "PrintedBook", "English", "Active", new Guid("5eb64c5d-7871-4dd1-b65c-41cd0d8fb06d"), "https://m.media-amazon.com/images/I/81q77Q39nEL._SY385_.jpg", new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "Harry Potter has never even heard of Hogwarts when the letters start dropping on the doormat at number four, Privet Drive. Addressed in green ink on yellowish parchment with a purple seal, they are swiftly confiscated by his grisly aunt and uncle. Then, on Harry's eleventh birthday, a great beetle-eyed giant of a man called Rubeus Hagrid bursts in with some astonishing news: Harry Potter is a wizard, and he has a place at Hogwarts School of Witchcraft and Wizardry. An incredible adventure is about to begin!", null, null, new Guid("c346f72a-f3e9-4c11-8646-1755b80f9e51"), "9781408855652", false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, new Guid("480fc452-469b-437d-b20e-3cb69910b2fd"), new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 352, new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8c1ac52f-3f58-44cc-ac6d-d1e1430961f4"), null, "Harry Potter and the Philosopher's Stone" });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookCompartments",
                columns: new[] { "Id", "BookInventoryItem", "BookInventoryItemId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "ShelfId" },
                values: new object[,]
                {
                    { new Guid("02f52e31-e429-4c9c-ad23-34eebb59a096"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Compartment 2", new Guid("8d348907-e5b1-4cad-b8eb-0667609a6e92") },
                    { new Guid("2ddb12d3-4399-4c79-9aa6-bcd2e85ee7dc"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Compartment 2", new Guid("245dca91-f12f-424b-9e8f-1cb4b59946f7") },
                    { new Guid("47448b87-7a6d-4f01-82ec-f1480fae0135"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Compartment 2", new Guid("09382326-27ac-4f15-89a0-5b34b5ed427f") },
                    { new Guid("47d43a29-a5b4-4a83-a1e0-f1ebb22e57fb"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Compartment 5", new Guid("245dca91-f12f-424b-9e8f-1cb4b59946f7") },
                    { new Guid("6721cbe2-bdf7-45e8-bab8-c62403997971"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Compartment 5", new Guid("8d348907-e5b1-4cad-b8eb-0667609a6e92") },
                    { new Guid("789d17a2-e0d4-4c03-8483-b76a4c0f4fc4"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Compartment 3", new Guid("245dca91-f12f-424b-9e8f-1cb4b59946f7") },
                    { new Guid("79bbf917-918b-416e-b04a-a63b534bbdcc"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Compartment 5", new Guid("09382326-27ac-4f15-89a0-5b34b5ed427f") },
                    { new Guid("7f8dc829-4699-4769-9897-5a7067d5bc13"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Compartment 3", new Guid("8d348907-e5b1-4cad-b8eb-0667609a6e92") },
                    { new Guid("9524e374-1155-45d4-8c35-222eaecc9bf0"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Compartment 4", new Guid("09382326-27ac-4f15-89a0-5b34b5ed427f") },
                    { new Guid("a62364b5-c242-44c0-ac35-b908c5316977"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Compartment 1", new Guid("245dca91-f12f-424b-9e8f-1cb4b59946f7") },
                    { new Guid("a78c209e-befd-49e2-80ec-af77250ea95d"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Compartment 1", new Guid("8d348907-e5b1-4cad-b8eb-0667609a6e92") },
                    { new Guid("b68aa6fe-3c55-4599-b1ee-f30f59c6730c"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Compartment 4", new Guid("245dca91-f12f-424b-9e8f-1cb4b59946f7") },
                    { new Guid("ce689a8b-0b06-4694-a9f2-6debfe16bc33"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Compartment 1", new Guid("09382326-27ac-4f15-89a0-5b34b5ed427f") },
                    { new Guid("dd2c0777-dcda-4f75-84c8-0bdc0dcb05d2"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Compartment 4", new Guid("8d348907-e5b1-4cad-b8eb-0667609a6e92") },
                    { new Guid("e543780b-86af-4bbb-ba07-0eede0f93e1a"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Compartment 3", new Guid("09382326-27ac-4f15-89a0-5b34b5ed427f") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BranchHours",
                columns: new[] { "Id", "ClosingTime", "CreatedById", "CreatedDateUnix", "DayOfWeek", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "OpeningTime" },
                values: new object[,]
                {
                    { new Guid("3534a2ff-5e6d-45e1-8747-a3f7de87a3d7"), new TimeSpan(0, 17, 30, 0, 0), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, new Guid("480fc452-469b-437d-b20e-3cb69910b2fd"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("3948019f-2b16-4306-9502-2517cb3b4f18"), new TimeSpan(0, 17, 30, 0, 0), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, new Guid("480fc452-469b-437d-b20e-3cb69910b2fd"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("4fcf7f67-0a9b-4f86-8c26-d27d5aca8214"), new TimeSpan(0, 0, 0, 0, 0), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, new Guid("480fc452-469b-437d-b20e-3cb69910b2fd"), new TimeSpan(0, 0, 0, 0, 0) },
                    { new Guid("5c231d4d-08ee-4b15-8a22-85fe8522e3ff"), new TimeSpan(0, 17, 30, 0, 0), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, new Guid("480fc452-469b-437d-b20e-3cb69910b2fd"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("97769e77-a855-4523-a219-34dbd7498db5"), new TimeSpan(0, 17, 30, 0, 0), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, new Guid("480fc452-469b-437d-b20e-3cb69910b2fd"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("a5e69e85-2fe2-4d10-95f9-d542417c8324"), new TimeSpan(0, 17, 30, 0, 0), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, new Guid("480fc452-469b-437d-b20e-3cb69910b2fd"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("fd356728-6307-4a24-a61d-bf7c6d1e2c95"), new TimeSpan(0, 17, 30, 0, 0), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, new Guid("480fc452-469b-437d-b20e-3cb69910b2fd"), new TimeSpan(0, 8, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Members",
                columns: new[] { "Id", "BorrowId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "ExtensionDurationInDays", "Gender", "HasPenalty", "IsDeleted", "IsDeletedById", "IsExtensionAllowed", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "MaxLateReturnsAllowed", "MemberType", "MembershipDate", "MembershipStatus", "NumberOfLateReturns", "Occupation", "PenaltyDurationInDays", "UserId" },
                values: new object[,]
                {
                    { new Guid("9ab91798-a963-4cee-905b-c066a5c5cfb8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, 7, "Male", false, false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, new Guid("480fc452-469b-437d-b20e-3cb69910b2fd"), 3, "Adult", new DateTime(2024, 4, 30, 0, 12, 52, 703, DateTimeKind.Local).AddTicks(2274), "Active", 0, "Software Engineer", 0, new Guid("d862394e-2949-4209-b8f9-6fcb4c1c1fab") },
                    { new Guid("bc536473-9af6-4c47-a241-a54bbd73a9a3"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, 0, "Female", true, false, new Guid("00000000-0000-0000-0000-000000000000"), false, new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, new Guid("480fc452-469b-437d-b20e-3cb69910b2fd"), 3, "Teacher", new DateTime(2024, 4, 30, 0, 12, 52, 703, DateTimeKind.Local).AddTicks(2287), "Active", 2, "Teacher", 7, new Guid("124d66a0-7826-42f2-a93e-f456cc6332cb") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Staffs",
                columns: new[] { "Id", "Address", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "EmploymentDate", "IsDeleted", "IsDeletedById", "IsFullTime", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "Phone", "Salary", "UserId" },
                values: new object[] { new Guid("f8db9c7f-7052-4a3c-9154-89477d617b8a"), "Employee Address", new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, new DateTime(2024, 4, 30, 0, 12, 52, 703, DateTimeKind.Local).AddTicks(2395), false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, new Guid("480fc452-469b-437d-b20e-3cb69910b2fd"), "+905553331122", 3000.00m, new Guid("6219baba-87aa-4cbc-b506-243a37125723") });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookAuthors",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[] { new Guid("2cd3a01b-482e-452d-b354-1cbd746caca4"), new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7") });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookInventories",
                columns: new[] { "Id", "BookCompartmentId", "BookId", "BookNumber", "BookStatus", "BookStockTransactionType", "BorrowLendId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Description", "IsAvailable", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Notes", "TransactionDateUnix" },
                values: new object[,]
                {
                    { new Guid("03ac7bde-ae55-40d5-8463-072393dd2e7e"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-48", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("06cb5d75-f790-4bb9-a70e-d92e3422a70d"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-80", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("06dac086-f370-41cd-8624-27a619c6815b"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-46", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("08d75ef7-2a23-469a-83fc-9d6b0dd0fead"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-5", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("09ef3b6d-3f3b-4d79-a7e9-55a57520db74"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-97", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("0a13c9a1-570a-4140-b825-6efed90631d8"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-104", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("129b21fc-cd53-4f72-a864-8d132954ba94"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-85", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("1358237f-dcec-47db-b862-2de1a1204be5"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-49", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("14f1cb3a-8008-4a89-8900-075525b5fc4a"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-31", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("1647fa7e-77f6-4160-b9a9-1abb1557ba48"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-75", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("1ad40b60-7fc4-4b89-85e4-520269da6096"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-64", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("20cfdc6f-2ecd-4c50-81a2-5d2a19de3349"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-26", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("216abbf5-4a86-49b7-ae51-d0cece8b4142"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-58", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("21d01f77-7320-4b16-83ea-32da8ad6e3ab"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-12", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("2306e59a-59a4-4fc6-94cf-6c5910b5a2cb"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-62", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("2392a97d-2480-4962-bf00-44f177e82f5f"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-41", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("2501a4cf-b434-4c36-bb29-6ff3feb79628"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-14", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("27383240-cd1f-4f1d-8581-dde20296f99f"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-2", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("27fc2f48-8490-4a0d-bb4e-81ce08eb0693"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-83", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("28a52eda-5789-4c03-bc1c-1c9e6ff8c06b"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-11", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("2e419802-b061-40f4-afe3-b6d65b917f33"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-28", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("31fa82d6-9a50-4e4f-b5f2-638f9a3f2d9e"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-56", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("3216bd15-8c5a-4c04-8e32-f15dd6e84b3e"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-10", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("33d12e3e-41c5-4e29-9914-09eea05aae9d"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-79", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("366e2a62-37b3-4c8a-822c-4c69b707bc76"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-100", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("37514116-83d2-4bbd-84f3-ebe2e50c63c0"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-101", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("3a18785b-4cf2-42c0-89a7-193855acbd02"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-22", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("3a66471d-5010-40c8-9216-12e819d17eda"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-8", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("3c8744ce-aa66-4a7f-a5e7-2b731ab1ad56"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-66", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("3d09c54d-4955-4fc9-b858-f12298577895"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-60", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("3d0d41af-ea30-4d9b-b158-ae4ed5d09bc4"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-82", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("41490bcb-186c-46af-bddc-812853ca1f3e"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-27", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("433e47dc-4ce3-480e-bd0e-89edd74d0441"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-1", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("43c76a97-628a-40f7-9781-e015f69bb66c"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-6", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("478c417d-bfcd-438d-9b5b-fbf29ebdd356"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-102", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("4b9b8683-04cf-4cc3-8d68-5e1d39c42371"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-88", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("4bc378a9-2cb2-408d-bf09-7628d0f8293b"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-16", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("4c480a4c-fe1a-4570-b328-d1fe656dd533"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-23", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("4e88536c-f326-4610-9f48-82a0063a7f2d"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-45", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("53a70593-1a93-42c6-ae50-983f48e194cf"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-51", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("56c42545-de36-4759-874c-2bdec77b0ecb"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-61", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("57974e6f-7350-467e-a960-14acf8efbe4d"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-9", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("5ad7af76-7d38-4dc7-b0c1-56c65486eebd"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-18", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("5ed654fd-3db7-4ae1-9080-2eabfd418394"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-4", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("69cf6bd9-15b3-4951-b5ca-f40f93c6cda8"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-103", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("69ed72eb-aed1-430b-b470-a02c3907a180"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-47", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("6be8c543-d0ce-4382-a6f9-16c791629f36"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-50", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("6c5c5c87-2c3c-44ae-964a-e957febf70a8"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-93", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("6ee928ef-53b9-4576-b03e-e74359d251f6"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-17", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("748e6daa-2bce-442c-869f-a51bdb22550b"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-35", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("7ad7f62c-d775-429b-b10a-3f3ac226b56c"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-52", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("7ce24f55-314f-4c83-8983-0272b3380551"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-36", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("7de7555c-7908-4ee4-b356-c4cbe54a105d"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-7", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("7e2fd01f-c2a2-46d1-9973-5e8834d51a22"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-25", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("81bd9a83-986b-44e4-82cc-dd1438e6a973"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-87", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("81e6cee5-5c3f-48e0-9bb8-af6430a0ee80"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-19", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("872fd46a-981c-434a-ae76-010cc22f9e9d"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-15", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("8b3aca2a-04c4-4c2d-af3b-4279edcf82c9"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-53", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("8ba34160-c00e-48d9-9ead-2c8fd8e0ed1c"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-72", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("901e8f0c-2577-4553-ac1a-606891f4e7eb"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-94", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("90c961ce-3d81-4d15-adf8-94149be1f120"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-91", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("98de9322-0a4c-437f-bcc6-611fcc16d175"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-70", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("9b2a7df0-051a-40b8-bae5-8067ef7ff2a7"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-55", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("9b7b0541-8b3d-4f07-b3d0-b44b2ad1ded6"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-71", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("9db2e3b9-40f9-4813-a040-a48355c71a42"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-24", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("9dcb8899-52be-4ed5-9d66-951a9d566339"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-81", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("9fb3bc2e-b041-44d7-a85c-f0c657d936c1"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-30", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("9fb40372-70b6-431a-b9a2-f1d2fbd4747c"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-77", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("a0e00027-7717-4810-b35c-e2c1d6ff6ee7"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-95", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("a5860579-492e-4386-b929-71464f719726"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-98", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("a6d862f5-fc0f-4a00-8ee8-7d0af9607e08"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-84", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("af96f39e-ddaf-49cb-8d71-71897b6705ff"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-89", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("b0362b06-d373-4607-9f31-2e8d9388e70b"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-29", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("b5a48413-7a0a-4ed4-b1a7-5cb3044c9007"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-90", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("b5ac23fb-6f37-4c49-a1ec-e13d34d3c746"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-54", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("b5fc29eb-539f-494b-a815-247e1614c1a9"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-32", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("b63619d9-4489-4b6f-8777-8817b32a3351"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-40", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("b9540d87-a75b-48e8-9714-76c00beb14f7"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-74", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("ba6a10ad-07a7-498a-bfa8-5b86affd4d33"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-59", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("bc2258ae-5fda-4d91-b643-82d8ddda7c87"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-38", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("bde6183a-cb2e-4c9a-b56e-8886516b6f1c"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-73", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("c2e13922-2704-4927-a9b0-f87785824e76"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-42", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("c63aa10b-e5f0-42d3-8ec8-0281f971b4b2"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-65", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("c921e654-0de8-4cb1-98e3-8c9fd8e1c201"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-43", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("ce2a3bb0-7608-4aa0-8004-fc28eb50b252"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-76", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("cee963b4-3f4e-4fc1-abf2-85abd72865ca"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-57", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("cf255b3d-bae4-4421-b9c2-b1133d46f098"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-96", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("cf86a06b-fd41-42ec-9cad-44d84be0ed68"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-78", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("d19211b0-da32-4577-b0da-da60df9ca36a"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-44", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("d21d176a-d108-4b07-871d-e79a71b2b89e"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-37", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("d76e7ad3-aec5-4f64-ba75-3aab72818e8c"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-99", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("db084660-42e2-4b7c-a72c-10cd9ec75f39"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-68", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("db97f4cc-8a48-48dd-8f16-25514698e732"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-21", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("dd574e17-90d5-44de-adf7-eb8b3f23a917"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-20", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("e3211bc5-f3ba-4851-9b8f-b602b56512a4"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-69", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("e3aa7d78-b2ce-4960-8cbf-a68847c6f431"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-33", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("ec046fee-9e47-4be0-b2bb-065a8283e16c"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-34", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("ee6e9129-2dcf-4603-901e-f42e1208953e"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-39", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("f5bd92e4-d4c3-45a4-b060-85d08507cfb5"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-92", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("f7c36065-8312-48d8-b649-e22c69da2864"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-63", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("fa8c626e-6c14-4457-ab33-f4c960fc355e"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-3", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("fbb1c0af-6210-451a-adb7-6f853c8f6974"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-86", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("fbe21763-9989-4583-aa15-d77d2a86c676"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-13", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("fe3632a5-d5de-4a4f-ab8e-dd7a30c0199e"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-67", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L },
                    { new Guid("ff84d0d9-7015-44e3-b8b9-2b4bcfabcb5b"), null, new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), "HP-105", "Active", 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, "", true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, "", 1714435972L }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookStocksOLD",
                columns: new[] { "Id", "BookId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Quantity" },
                values: new object[] { new Guid("5eb64c5d-7871-4dd1-b65c-41cd0d8fb06d"), new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, 100 });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookTags",
                columns: new[] { "BookId", "TagId" },
                values: new object[,]
                {
                    { new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), new Guid("078e80c2-9eb4-4466-8f13-ffeac5c5d7b6") },
                    { new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), new Guid("cbeb1aca-0f6a-49d0-b1be-ece0438ab8a1") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BorrowLends",
                columns: new[] { "Id", "BookId", "BookInventoryId", "BorrowDate", "BorrowStatus", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "DueDate", "FeeAmount", "HasFee", "IsDeleted", "IsDeletedById", "IsLate", "LastModifiedById", "LastModifiedDateUnix", "LateDurationInDays", "LenderId", "MemberId", "ReturnDate" },
                values: new object[,]
                {
                    { new Guid("bcf6651f-3b85-49e9-a830-b03b57988549"), new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), null, new DateTime(2024, 4, 20, 0, 12, 52, 703, DateTimeKind.Local).AddTicks(2418), "Returned", new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, new DateTime(2024, 4, 30, 0, 12, 52, 703, DateTimeKind.Local).AddTicks(2442), 0m, false, false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, 0, new Guid("f8db9c7f-7052-4a3c-9154-89477d617b8a"), new Guid("9ab91798-a963-4cee-905b-c066a5c5cfb8"), new DateTime(2024, 4, 30, 0, 12, 52, 703, DateTimeKind.Local).AddTicks(2443) },
                    { new Guid("c3d1bda0-09ca-4f96-b4b9-33cf77fd8dc0"), new Guid("bc3b4a96-3235-456c-8419-5a30adb961a7"), null, new DateTime(2024, 4, 20, 0, 12, 52, 703, DateTimeKind.Local).AddTicks(2672), "DelayedReturn", new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), 1714435972L, null, new DateTime(2024, 4, 29, 0, 12, 52, 703, DateTimeKind.Local).AddTicks(2677), 0m, false, false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("4bb4a49f-0c7c-46f2-b67b-125d2843fb8f"), null, 1, new Guid("f8db9c7f-7052-4a3c-9154-89477d617b8a"), new Guid("bc536473-9af6-4c47-a241-a54bbd73a9a3"), new DateTime(2024, 4, 30, 0, 12, 52, 703, DateTimeKind.Local).AddTicks(2714) }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "LibraryBranchMembers",
                columns: new[] { "LibraryBranchId", "MemberId" },
                values: new object[,]
                {
                    { new Guid("480fc452-469b-437d-b20e-3cb69910b2fd"), new Guid("9ab91798-a963-4cee-905b-c066a5c5cfb8") },
                    { new Guid("480fc452-469b-437d-b20e-3cb69910b2fd"), new Guid("bc536473-9af6-4c47-a241-a54bbd73a9a3") }
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
                name: "IX_BorrowLends_BookInventoryId",
                schema: "lm",
                table: "BorrowLends",
                column: "BookInventoryId");

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
                name: "LibraryBranches",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "ReadingLists",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "Shelves",
                schema: "lm");
        }
    }
}
