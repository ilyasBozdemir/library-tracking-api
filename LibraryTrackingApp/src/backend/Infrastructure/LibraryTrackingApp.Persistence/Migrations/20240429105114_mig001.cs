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
                name: "BookCompartments",
                schema: "lm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ShelfId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                name: "Books",
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
                    BookCompartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_BookCompartments_BookCompartmentId",
                        column: x => x.BookCompartmentId,
                        principalSchema: "lm",
                        principalTable: "BookCompartments",
                        principalColumn: "Id");
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
                        name: "FK_Books_FavoriteLists_FavoriteListId",
                        column: x => x.FavoriteListId,
                        principalSchema: "lm",
                        principalTable: "FavoriteLists",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Books_LibraryBranches_LibraryBranchId",
                        column: x => x.LibraryBranchId,
                        principalSchema: "lm",
                        principalTable: "LibraryBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_ReadingLists_ReadingListId",
                        column: x => x.ReadingListId,
                        principalSchema: "lm",
                        principalTable: "ReadingLists",
                        principalColumn: "Id");
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
                        name: "FK_BookAuthors_Books_BookId",
                        column: x => x.BookId,
                        principalSchema: "lm",
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookEntry",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookStatus = table.Column<int>(type: "int", nullable: false),
                    BookFormat = table.Column<int>(type: "int", nullable: false),
                    BookLanguage = table.Column<int>(type: "int", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    table.PrimaryKey("PK_BookEntry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookEntry_Books_BookId",
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
                        name: "FK_BorrowLends_Books_BookId",
                        column: x => x.BookId,
                        principalSchema: "lm",
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    { new Guid("5ad3b527-d475-445b-a9b0-a6462f7cd987"), null, "93a13c75-620d-4510-ad7d-d0b91ee0a2f0", "system", "SYSTEM" },
                    { new Guid("b966a17e-8090-4061-bb79-f811020145dd"), null, "dcd0ec78-61d1-41f1-816b-4d6fa7856a8f", "Staff", "STAFF" },
                    { new Guid("d541ad6c-d990-4160-b430-c4ed048242a5"), null, "339f4420-bf36-42f1-a167-a67a7312611f", "Admin", "ADMIN" },
                    { new Guid("dab47e78-67e8-4b99-baa0-031b37e43b57"), null, "9b74dc13-3ae0-407f-ba96-ccd99502b8a1", "Member", "MEMBER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "ConcurrencyStamp", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Email", "EmailConfirmed", "Gender", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "RefreshToken", "RefreshTokenEndDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("2e9a9efc-1e1c-4eba-8b03-1dad31d459b9"), 0, "789 Employee St.", new DateTime(1990, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "70525978-70f4-4c26-8269-f12c77c6b50b", new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), 0L, null, "employee1@example.com", true, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), null, false, null, "Employee", "EMPLOYEE1@EXAMPLE.COM", "EMPLOYEE1@EXAMPLE.COM", "AQAAAAIAAYagAAAAELdxogC/bcwLrivYLnqbTKIjp/H1jaWT4XMTOUFLCmYnHG2vX39q9h2rWQFU1hEbhA==", null, false, new byte[0], null, null, "", "One", false, "employee1@example.com" },
                    { new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), 0, "123 System St.", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6db92d3b-8b49-424d-86a1-0ed7e1db1652", new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, "system@domain.com", true, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, false, null, "System", "SYSTEM@DOMAIN.COM", "SYSTEM", "AQAAAAIAAYagAAAAECY88merkbGr1WK1Y3uo+BD5yd7s3l6bBfJ9ESjJVvlD6oJ33Rr2ZLpRqpnfpiK7Vg==", null, false, new byte[0], null, null, "", "Admin", false, "system" },
                    { new Guid("46236d25-f9e8-4b9e-9577-68cbceedfdca"), 0, "123 Main Street", new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "240a9024-0c8e-4c92-8401-cc6b9e1134c1", new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), 0L, null, "john.doe@example.com", true, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), null, false, null, "John", "JOHN.DOE@EXAMPLE.COM", "JOHN.DOE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEM5ai2wz1GK/Fh3tE0TY0xFlbNR1CFfoJPpY5bklnVuvGzZnFVrdA46pqz8cyoo55w==", null, false, new byte[0], null, null, "", "Doe", false, "john.doe@example.com" },
                    { new Guid("77cf39ea-87a9-481b-929f-9abf80a7c1d7"), 0, "456 Admin St.", new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "60a3ae43-ac5e-4c6d-aaca-5c4ef8f8b64e", new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), 0L, null, "admin@example.com", true, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), null, false, null, "Admin", "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEArkj6N65dBOXg7veenD4YPpcr1PNEOPSTUlld5nkkS+wU0MwtcmRVSsK6yB5atsig==", null, false, new byte[0], null, null, "", "Admin", false, "admin@example.com" },
                    { new Guid("a8604411-9fbd-41c0-8cc9-fe2f96e7609c"), 0, "456 Oak Street", new DateTime(1985, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "fb4f5583-ab84-402f-a947-6b4c50226c1d", new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), 0L, null, "jane.smith@example.com", true, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), null, false, null, "Jane", "JANE.SMITH@EXAMPLE.COM", "JANE.SMITH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAG2aeEHR3NtH4IMc5GBO9+PxAEKCW3gMo6u2siRyGvv5ST2XQWqDJRgPbgN+FqZ6g==", null, false, new byte[0], null, null, "", "Smith", false, "jane.smith@example.com" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Authors",
                columns: new[] { "Id", "Biography", "BirthDate", "Country", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "Surname" },
                values: new object[] { new Guid("083ecb57-f36b-4f12-8c77-39d2343dd4a9"), "Joanne Rowling, better known by her pen name J.K. Rowling, is a British author, philanthropist, film producer, television producer, and screenwriter. She is best known for writing the Harry Potter fantasy series.", new DateTime(1965, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "United Kingdom", new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), 1714398673L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), null, "J.K.", "Rowling" });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookGenres",
                columns: new[] { "Id", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsActive", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name" },
                values: new object[,]
                {
                    { new Guid("00191e89-4992-4fd5-aae9-73797b1ccc76"), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), 1714398673L, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), null, "Adventure" },
                    { new Guid("086a66f7-1be6-46cb-a490-7d28badd16a7"), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), 1714398673L, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), null, "Fantasy" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookPublishers",
                columns: new[] { "Id", "Address", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Email", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "PhoneNumber", "Website" },
                values: new object[] { new Guid("f71b05af-21b6-4439-9b4a-9119e1970a8e"), "50 Bedford Square, London, England", new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), 1714398673L, null, "info@bloomsbury.com", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), null, "Bloomsbury Publishing", "+44 (0)20 7631 5600", "https://www.bloomsbury.com/" });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Book_Tags",
                columns: new[] { "Id", "BookId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name" },
                values: new object[,]
                {
                    { new Guid("238d37b1-41c2-470c-ae0a-6a47c7a17842"), new Guid("a56ce706-f92e-4c22-b9ab-b2b2ecd32008"), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), 1714398673L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), null, "Quidditch" },
                    { new Guid("e34fc271-a8f3-48aa-9a7d-d9db8b6ae7a9"), new Guid("a56ce706-f92e-4c22-b9ab-b2b2ecd32008"), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), 1714398673L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), null, "Harry Potter" },
                    { new Guid("fb7816ca-3443-422a-a498-5cbbb24bfc45"), new Guid("a56ce706-f92e-4c22-b9ab-b2b2ecd32008"), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), 1714398673L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), null, "Hogwarts" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "LibraryBranches",
                columns: new[] { "Id", "Address", "BookId", "BranchHourId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Description", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "LibraryTransactionId", "MemberId", "Name", "PhoneNumber", "StaffId" },
                values: new object[] { new Guid("282ac419-5495-4e92-a109-b51055b8b631"), "123 Ana Cadde", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), 1714398673L, null, "Bu bir örnek kütüphane şubesidir.", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Örnek Kütüphane Şubesi", "123-456-7890", new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("b966a17e-8090-4061-bb79-f811020145dd"), new Guid("2e9a9efc-1e1c-4eba-8b03-1dad31d459b9"), "AppUserRole" },
                    { new Guid("d541ad6c-d990-4160-b430-c4ed048242a5"), new Guid("77cf39ea-87a9-481b-929f-9abf80a7c1d7"), "AppUserRole" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Books",
                columns: new[] { "Id", "AudioFilePath", "AuthorId", "BookCompartmentId", "BookFormat", "BookLanguage", "BookStatus", "BookStockId", "CoverImageUrl", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Description", "FavoriteListId", "FilePath", "GenreId", "ISBN", "IsDeleted", "IsDeletedById", "IsFeatured", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "OriginalPublicationDate", "PageCount", "PublicationDate", "PublisherId", "ReadingListId", "Title" },
                values: new object[] { new Guid("a56ce706-f92e-4c22-b9ab-b2b2ecd32008"), null, new Guid("083ecb57-f36b-4f12-8c77-39d2343dd4a9"), null, "PrintedBook", "English", "Active", new Guid("e5d6c73a-e865-412c-98d9-e4bfd147784b"), "https://m.media-amazon.com/images/I/81q77Q39nEL._SY385_.jpg", new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), 1714398673L, null, "Harry Potter has never even heard of Hogwarts when the letters start dropping on the doormat at number four, Privet Drive. Addressed in green ink on yellowish parchment with a purple seal, they are swiftly confiscated by his grisly aunt and uncle. Then, on Harry's eleventh birthday, a great beetle-eyed giant of a man called Rubeus Hagrid bursts in with some astonishing news: Harry Potter is a wizard, and he has a place at Hogwarts School of Witchcraft and Wizardry. An incredible adventure is about to begin!", null, null, new Guid("086a66f7-1be6-46cb-a490-7d28badd16a7"), "9781408855652", false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), null, new Guid("282ac419-5495-4e92-a109-b51055b8b631"), new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 352, new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f71b05af-21b6-4439-9b4a-9119e1970a8e"), null, "Harry Potter and the Philosopher's Stone" });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BranchHours",
                columns: new[] { "Id", "ClosingTime", "CreatedById", "CreatedDateUnix", "DayOfWeek", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "OpeningTime" },
                values: new object[,]
                {
                    { new Guid("1ec6b73a-487c-4dfd-8280-2939d0417327"), new TimeSpan(0, 17, 30, 0, 0), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), 1714398673L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), null, new Guid("282ac419-5495-4e92-a109-b51055b8b631"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("2107ba2f-cb43-4de6-9d7b-e6d40be6c766"), new TimeSpan(0, 0, 0, 0, 0), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), 1714398673L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), null, new Guid("282ac419-5495-4e92-a109-b51055b8b631"), new TimeSpan(0, 0, 0, 0, 0) },
                    { new Guid("366adfd4-877c-4b48-af6b-a1d8064520fc"), new TimeSpan(0, 17, 30, 0, 0), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), 1714398673L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), null, new Guid("282ac419-5495-4e92-a109-b51055b8b631"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("45ce0949-c5ae-412c-9157-d28060cc9229"), new TimeSpan(0, 17, 30, 0, 0), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), 1714398673L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), null, new Guid("282ac419-5495-4e92-a109-b51055b8b631"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("889b3e3a-176c-41c5-a09e-e0e5d2c8065b"), new TimeSpan(0, 17, 30, 0, 0), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), 1714398673L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), null, new Guid("282ac419-5495-4e92-a109-b51055b8b631"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("e5efdaf7-d680-4733-9554-82ecf5cb1445"), new TimeSpan(0, 17, 30, 0, 0), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), 1714398673L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), null, new Guid("282ac419-5495-4e92-a109-b51055b8b631"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("f075bd9f-5a05-40d0-91d7-63a279baa5b6"), new TimeSpan(0, 17, 30, 0, 0), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), 1714398673L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), null, new Guid("282ac419-5495-4e92-a109-b51055b8b631"), new TimeSpan(0, 8, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Members",
                columns: new[] { "Id", "BorrowId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "ExtensionDurationInDays", "Gender", "HasPenalty", "IsDeleted", "IsDeletedById", "IsExtensionAllowed", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "MaxLateReturnsAllowed", "MemberType", "MembershipDate", "NumberOfLateReturns", "Occupation", "PenaltyDurationInDays", "UserId" },
                values: new object[,]
                {
                    { new Guid("74faad27-6421-4829-8b6a-9c6e02bd6fa6"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), 1714398673L, null, 0, "Female", true, false, new Guid("00000000-0000-0000-0000-000000000000"), false, new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), null, new Guid("282ac419-5495-4e92-a109-b51055b8b631"), 3, "Teacher", new DateTime(2024, 4, 29, 13, 51, 13, 966, DateTimeKind.Local).AddTicks(1171), 2, "Teacher", 7, new Guid("a8604411-9fbd-41c0-8cc9-fe2f96e7609c") },
                    { new Guid("9acc5bc2-c342-4a7d-b9a8-dbc2f93fa786"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), 1714398673L, null, 7, "Male", false, false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), null, new Guid("282ac419-5495-4e92-a109-b51055b8b631"), 3, "Adult", new DateTime(2024, 4, 29, 13, 51, 13, 966, DateTimeKind.Local).AddTicks(1165), 0, "Software Engineer", 0, new Guid("46236d25-f9e8-4b9e-9577-68cbceedfdca") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Staffs",
                columns: new[] { "Id", "Address", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "EmploymentDate", "IsDeleted", "IsDeletedById", "IsFullTime", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "Phone", "Salary", "UserId" },
                values: new object[] { new Guid("a94c2719-ea2b-4b0c-be99-fd7268afb2f5"), "Employee Address", new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), 1714398673L, null, new DateTime(2024, 4, 29, 13, 51, 13, 966, DateTimeKind.Local).AddTicks(1220), false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), null, new Guid("282ac419-5495-4e92-a109-b51055b8b631"), "+905553331122", 3000.00m, new Guid("2e9a9efc-1e1c-4eba-8b03-1dad31d459b9") });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookAuthors",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[] { new Guid("083ecb57-f36b-4f12-8c77-39d2343dd4a9"), new Guid("a56ce706-f92e-4c22-b9ab-b2b2ecd32008") });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookStocks",
                columns: new[] { "Id", "BookId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Quantity" },
                values: new object[] { new Guid("e5d6c73a-e865-412c-98d9-e4bfd147784b"), new Guid("a56ce706-f92e-4c22-b9ab-b2b2ecd32008"), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), 1714398673L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), null, 100 });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BookTags",
                columns: new[] { "BookId", "TagId" },
                values: new object[,]
                {
                    { new Guid("a56ce706-f92e-4c22-b9ab-b2b2ecd32008"), new Guid("e34fc271-a8f3-48aa-9a7d-d9db8b6ae7a9") },
                    { new Guid("a56ce706-f92e-4c22-b9ab-b2b2ecd32008"), new Guid("fb7816ca-3443-422a-a498-5cbbb24bfc45") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BorrowLends",
                columns: new[] { "Id", "BookId", "BorrowDate", "BorrowStatus", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "DueDate", "FeeAmount", "HasFee", "IsDeleted", "IsDeletedById", "IsLate", "LastModifiedById", "LastModifiedDateUnix", "LateDurationInDays", "LenderId", "MemberId", "ReturnDate" },
                values: new object[,]
                {
                    { new Guid("3b565299-2fdc-490c-a700-4a0cca5cc877"), new Guid("a56ce706-f92e-4c22-b9ab-b2b2ecd32008"), new DateTime(2024, 4, 19, 13, 51, 13, 966, DateTimeKind.Local).AddTicks(1268), "DelayedReturn", new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), 1714398673L, null, new DateTime(2024, 4, 28, 13, 51, 13, 966, DateTimeKind.Local).AddTicks(1295), 0m, false, false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), null, 1, new Guid("a94c2719-ea2b-4b0c-be99-fd7268afb2f5"), new Guid("74faad27-6421-4829-8b6a-9c6e02bd6fa6"), new DateTime(2024, 4, 29, 13, 51, 13, 966, DateTimeKind.Local).AddTicks(1306) },
                    { new Guid("f0eac556-a732-47d7-8a0a-30bace0331f2"), new Guid("a56ce706-f92e-4c22-b9ab-b2b2ecd32008"), new DateTime(2024, 4, 19, 13, 51, 13, 966, DateTimeKind.Local).AddTicks(1228), "Returned", new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), 1714398673L, null, new DateTime(2024, 4, 29, 13, 51, 13, 966, DateTimeKind.Local).AddTicks(1245), 0m, false, false, new Guid("00000000-0000-0000-0000-000000000000"), false, new Guid("44073bfd-0b99-48e7-a951-2c9203e7340e"), null, 0, new Guid("a94c2719-ea2b-4b0c-be99-fd7268afb2f5"), new Guid("9acc5bc2-c342-4a7d-b9a8-dbc2f93fa786"), new DateTime(2024, 4, 29, 13, 51, 13, 966, DateTimeKind.Local).AddTicks(1245) }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "LibraryBranchMembers",
                columns: new[] { "LibraryBranchId", "MemberId" },
                values: new object[,]
                {
                    { new Guid("282ac419-5495-4e92-a109-b51055b8b631"), new Guid("74faad27-6421-4829-8b6a-9c6e02bd6fa6") },
                    { new Guid("282ac419-5495-4e92-a109-b51055b8b631"), new Guid("9acc5bc2-c342-4a7d-b9a8-dbc2f93fa786") }
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
                name: "IX_BookCompartments_ShelfId",
                schema: "lm",
                table: "BookCompartments",
                column: "ShelfId");

            migrationBuilder.CreateIndex(
                name: "IX_BookEntry_BookId",
                table: "BookEntry",
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
                name: "IX_Books_BookCompartmentId",
                schema: "lm",
                table: "Books",
                column: "BookCompartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_FavoriteListId",
                schema: "lm",
                table: "Books",
                column: "FavoriteListId");

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
                name: "IX_Books_ReadingListId",
                schema: "lm",
                table: "Books",
                column: "ReadingListId");

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
                name: "BookEntry");

            migrationBuilder.DropTable(
                name: "BookReviews",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "BookStocks",
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
                name: "Books",
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
                name: "BookCompartments",
                schema: "lm");

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
                name: "LibraryBranches",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Shelves",
                schema: "lm");
        }
    }
}
