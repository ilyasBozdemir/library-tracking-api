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
                name: "MailAccounts",
                schema: "static",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Purpose = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
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
                name: "WorkGenres",
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
                    table.PrimaryKey("PK_WorkGenres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkPublishers",
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
                    table.PrimaryKey("PK_WorkPublishers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkTags",
                schema: "lm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkCatalogId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_WorkTags", x => x.Id);
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
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_LibraryBranches_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Members",
                schema: "lm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BorrowId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                name: "Editions",
                schema: "lm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkInventoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        name: "FK_Editions_WorkPublishers_PublisherId",
                        column: x => x.PublisherId,
                        principalSchema: "lm",
                        principalTable: "WorkPublishers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Editions_WorkPublishers_WorkPublisherId",
                        column: x => x.WorkPublisherId,
                        principalSchema: "lm",
                        principalTable: "WorkPublishers",
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
                name: "WorkCatalogs",
                schema: "lm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PublisherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LibraryBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeweyCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoverImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PageCount = table.Column<int>(type: "int", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    AudioFilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OriginalPublicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkFormat = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_WorkCatalogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkCatalogs_FavoriteLists_FavoriteListId",
                        column: x => x.FavoriteListId,
                        principalSchema: "lm",
                        principalTable: "FavoriteLists",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WorkCatalogs_LibraryBranches_LibraryBranchId",
                        column: x => x.LibraryBranchId,
                        principalSchema: "lm",
                        principalTable: "LibraryBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkCatalogs_ReadingLists_ReadingListId",
                        column: x => x.ReadingListId,
                        principalSchema: "lm",
                        principalTable: "ReadingLists",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WorkCatalogs_WorkGenres_GenreId",
                        column: x => x.GenreId,
                        principalSchema: "lm",
                        principalTable: "WorkGenres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkCatalogs_WorkPublishers_PublisherId",
                        column: x => x.PublisherId,
                        principalSchema: "lm",
                        principalTable: "WorkPublishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LibraryBranch_Member",
                schema: "lm",
                columns: table => new
                {
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LibraryBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryBranch_Member", x => new { x.MemberId, x.LibraryBranchId });
                    table.ForeignKey(
                        name: "FK_LibraryBranch_Member_LibraryBranches_LibraryBranchId",
                        column: x => x.LibraryBranchId,
                        principalSchema: "lm",
                        principalTable: "LibraryBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LibraryBranch_Member_Members_MemberId",
                        column: x => x.MemberId,
                        principalSchema: "lm",
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkCompartments",
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
                    table.PrimaryKey("PK_WorkCompartments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkCompartments_Shelves_ShelfId",
                        column: x => x.ShelfId,
                        principalSchema: "lm",
                        principalTable: "Shelves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Author_WorkCatalogs",
                schema: "lm",
                columns: table => new
                {
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkCatalogId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author_WorkCatalogs", x => new { x.WorkCatalogId, x.AuthorId });
                    table.ForeignKey(
                        name: "FK_Author_WorkCatalogs_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalSchema: "lm",
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Author_WorkCatalogs_WorkCatalogs_WorkCatalogId",
                        column: x => x.WorkCatalogId,
                        principalSchema: "lm",
                        principalTable: "WorkCatalogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tag_WorkCatalogs",
                schema: "lm",
                columns: table => new
                {
                    TagId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkCatalogId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag_WorkCatalogs", x => new { x.WorkCatalogId, x.TagId });
                    table.ForeignKey(
                        name: "FK_Tag_WorkCatalogs_WorkCatalogs_WorkCatalogId",
                        column: x => x.WorkCatalogId,
                        principalSchema: "lm",
                        principalTable: "WorkCatalogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tag_WorkCatalogs_WorkTags_TagId",
                        column: x => x.TagId,
                        principalSchema: "lm",
                        principalTable: "WorkTags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkInventories",
                schema: "lm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkCatalogId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BorrowLendId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EditionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShelfId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WorkCompartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_WorkInventories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkInventories_Shelves_ShelfId",
                        column: x => x.ShelfId,
                        principalSchema: "lm",
                        principalTable: "Shelves",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WorkInventories_WorkCatalogs_WorkCatalogId",
                        column: x => x.WorkCatalogId,
                        principalSchema: "lm",
                        principalTable: "WorkCatalogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkInventories_WorkCompartments_WorkCompartmentId",
                        column: x => x.WorkCompartmentId,
                        principalSchema: "lm",
                        principalTable: "WorkCompartments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BorrowLends",
                schema: "lm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkCatalogId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkInventoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StaffLenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        name: "FK_BorrowLends_Members_MemberId",
                        column: x => x.MemberId,
                        principalSchema: "lm",
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BorrowLends_Staffs_StaffLenderId",
                        column: x => x.StaffLenderId,
                        principalSchema: "lm",
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BorrowLends_WorkCatalogs_WorkCatalogId",
                        column: x => x.WorkCatalogId,
                        principalSchema: "lm",
                        principalTable: "WorkCatalogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BorrowLends_WorkInventories_WorkInventoryId",
                        column: x => x.WorkInventoryId,
                        principalSchema: "lm",
                        principalTable: "WorkInventories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Edition_WorkInventories",
                schema: "lm",
                columns: table => new
                {
                    EditionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkInventoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Edition_WorkInventories", x => new { x.WorkInventoryId, x.EditionId });
                    table.ForeignKey(
                        name: "FK_Edition_WorkInventories_Editions_EditionId",
                        column: x => x.EditionId,
                        principalSchema: "lm",
                        principalTable: "Editions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Edition_WorkInventories_WorkInventories_WorkInventoryId",
                        column: x => x.WorkInventoryId,
                        principalSchema: "lm",
                        principalTable: "WorkInventories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "AppUserId", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("09c7a173-f15a-4fb8-b740-ed7f10f05206"), null, "b102930d-63e3-42f0-b301-f27a1135ab81", "system", "SYSTEM" },
                    { new Guid("0b2085bb-9fa8-4fbb-88bb-0c71f7830e77"), null, "dd9a33ef-25e6-4725-9c1f-7d6f1259d530", "Staff", "STAFF" },
                    { new Guid("4a14fe7e-f2c1-4b60-8c0c-8a9f92046308"), null, "5bb042ed-ba4b-4966-b540-758109158056", "Member", "MEMBER" },
                    { new Guid("b5a7d5ec-8dc7-447b-a7c3-d92d47407206"), null, "bf1d598d-b36e-4ae1-a9a4-e58d5816d968", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "ConcurrencyStamp", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Email", "EmailConfirmed", "Gender", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "RefreshToken", "RefreshTokenEndDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("05c1e158-54df-40c4-be72-20d774e08651"), 0, "456 Oak Street", new DateTime(1985, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "b3566395-7861-40fb-8a1b-df89087a9643", new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 0L, null, "jane.smith@example.com", true, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, false, null, "Jane", "JANE.SMITH@EXAMPLE.COM", "JANE.SMITH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDKWUyY2cBlO+rHVTIoEPeqjBNicw+r2rc71b4w3Qq+ayWV6Yitv1spYCGiH10127g==", null, false, new byte[0], null, null, "", "Smith", false, "jane.smith@example.com" },
                    { new Guid("4a8ada49-0466-465c-812f-3d55aad40d42"), 0, "456 Admin St.", new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "4304f9d9-207e-45d9-ac3e-ad6eb8457073", new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 0L, null, "admin@example.com", true, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, false, null, "Admin", "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBMz5Otz8ngoYCEFwRlZpjoiU5Rm1iRcmI0E48CsFKzLjJuk1RYWqwPqAF/4Y3cyNw==", null, false, new byte[0], null, null, "", "Admin", false, "admin@example.com" },
                    { new Guid("603eeb4a-8263-4d4c-a81d-4a6c450777d3"), 0, "789 Employee St.", new DateTime(1990, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "6f98c6af-21cd-41a0-a6a1-de9a39d6e362", new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 0L, null, "employee1@example.com", true, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, false, null, "Employee", "EMPLOYEE1@EXAMPLE.COM", "EMPLOYEE1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEElq/R04jYLmaXFr2oyJtqaRS7K/LLvf6vTVBK7R2FiAyOd1/LyWRkpzq021DHF2oA==", null, false, new byte[0], null, null, "", "One", false, "employee1@example.com" },
                    { new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 0, "123 System St.", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9e6b9984-29f5-4701-a05e-ad179a62b3eb", new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, "system@domain.com", true, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, false, null, "System", "SYSTEM@DOMAIN.COM", "SYSTEM", "AQAAAAIAAYagAAAAEJXP68wfH5AMm6oGzy4/jlXrn60YlKS8PGd5amTOtiDusmZTUy8F/knNmZRAMN9j6Q==", null, false, new byte[0], null, null, "", "Admin", false, "system" },
                    { new Guid("96279d0f-a6c7-43fa-a8bb-dc5416663d0b"), 0, "123 Main Street", new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "baf22c73-0923-4100-a2fd-c4d4d43e9c34", new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 0L, null, "john.doe@example.com", true, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, false, null, "John", "JOHN.DOE@EXAMPLE.COM", "JOHN.DOE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIx2WSEwkco8JuNYmGywrevrzNCCqATSsYH+5vGPTWJUPfDFHmm1Pmc2adgBPuwI/Q==", null, false, new byte[0], null, null, "", "Doe", false, "john.doe@example.com" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Authors",
                columns: new[] { "Id", "Biography", "BirthDate", "Country", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "Surname", "Website" },
                values: new object[] { new Guid("4bf98a4c-e048-47dc-86ce-0ecd5293f4e5"), "Joanne Rowling, better known by her pen name J.K. Rowling, is a British author, philanthropist, film producer, television producer, and screenwriter. She is best known for writing the Harry Potter fantasy series.", new DateTime(1965, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "United Kingdom", new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, "J.K.", "Rowling", "www.example.com" });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "LibraryBranches",
                columns: new[] { "Id", "Address", "AppUserId", "CreatedById", "CreatedDateUnix", "CriticalLevelThreshold", "DeletedDateUnix", "Description", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "MaxCheckoutDurationInDays", "MaxCheckoutLimit", "MinCheckoutDurationInDays", "Name", "NotifyOnBookOrBlogComment", "PhoneNumber", "TopBooksReportLimit", "TopMembersReportLimit" },
                values: new object[,]
                {
                    { new Guid("9a2a605a-5cb9-4f5a-a083-e59cdf3d3d42"), "456 İkinci Sokak, No: 15", null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, 6, null, "Ana Kütüphane Şubesi, şehrin kalbindeki kitapseverler için bir buluşma noktasıdır.", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, 10, 7, 4, "Ana Kütüphane Şubesi", true, "+90 (212) 123 4567", 7, 7 },
                    { new Guid("f8acf7c3-1f03-4a19-8780-6442bc126d92"), "789 Üçüncü Bulvar, No: 23", null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, 8, null, "Yıldızlar Kütüphanesi, gökyüzünü aşkın kitaplarla dolu bir yerdir.", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, 14, 10, 3, "Yıldızlar Kütüphanesi", false, "+90 (212) 987 6543", 10, 10 }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "WorkGenres",
                columns: new[] { "Id", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsActive", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name" },
                values: new object[,]
                {
                    { new Guid("5a0be411-c078-405d-b510-925c4f57da55"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, "Fantasy" },
                    { new Guid("5e02a2b7-8aaa-4840-baa7-72c6fd811e0a"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, "Adventure" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "WorkPublishers",
                columns: new[] { "Id", "Address", "City", "Country", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Email", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "PhoneNumber", "Website" },
                values: new object[,]
                {
                    { new Guid("4af559ee-a270-4f2b-b062-2230966f991a"), "50 Bedford Square, London, England", "London", "England", new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, "info@bloomsbury.com", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, "Bloomsbury Publishing", "+44 (0)20 7631 5600", "https://www.bloomsbury.com/" },
                    { new Guid("b3184245-4ec1-4e32-a588-13aa411cc57e"), "1745 Broadway, New York, NY, USA", "New York", "USA", new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, "info@randomhouse.com", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, "Random House", "+1 212-782-9000", "https://www.randomhousebooks.com/" },
                    { new Guid("ef721b64-5b6a-4f4e-8f04-abdee0a09e6b"), "80 Strand, London, England", "London", "England", new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, "info@penguin.co.uk", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, "Penguin Books", "+44 (0)20 7139 3000", "https://www.penguin.co.uk/" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "WorkTags",
                columns: new[] { "Id", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "WorkCatalogId" },
                values: new object[,]
                {
                    { new Guid("6d7f0ceb-b244-4995-9eff-da0870eea992"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, "Harry Potter", new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b") },
                    { new Guid("d263896e-ebbe-4527-8f53-0ba6c06ddc64"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, "Quidditch", new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b") },
                    { new Guid("e53f0c4b-321f-4f90-9770-54c9f879b8fd"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, "Hogwarts", new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("b5a7d5ec-8dc7-447b-a7c3-d92d47407206"), new Guid("4a8ada49-0466-465c-812f-3d55aad40d42"), "AppUserRole" },
                    { new Guid("0b2085bb-9fa8-4fbb-88bb-0c71f7830e77"), new Guid("603eeb4a-8263-4d4c-a81d-4a6c450777d3"), "AppUserRole" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BranchHours",
                columns: new[] { "Id", "ClosingTime", "CreatedById", "CreatedDateUnix", "DayOfWeek", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "OpeningTime" },
                values: new object[,]
                {
                    { new Guid("139af80f-75b0-49fe-8e57-39e063d57baa"), new TimeSpan(0, 0, 0, 0, 0), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, new Guid("9a2a605a-5cb9-4f5a-a083-e59cdf3d3d42"), new TimeSpan(0, 0, 0, 0, 0) },
                    { new Guid("5b09213c-f985-4169-a5de-8bc275b8406b"), new TimeSpan(0, 17, 30, 0, 0), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, new Guid("9a2a605a-5cb9-4f5a-a083-e59cdf3d3d42"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("92809f25-bc33-4480-ad0d-56a2f464c321"), new TimeSpan(0, 17, 30, 0, 0), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, new Guid("9a2a605a-5cb9-4f5a-a083-e59cdf3d3d42"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("af8e23fc-419b-48ce-aae8-8269da05ed5d"), new TimeSpan(0, 17, 30, 0, 0), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, new Guid("9a2a605a-5cb9-4f5a-a083-e59cdf3d3d42"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("d7690da9-fee8-4fa7-b391-2f74ef58bfe7"), new TimeSpan(0, 17, 30, 0, 0), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, new Guid("9a2a605a-5cb9-4f5a-a083-e59cdf3d3d42"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("d93482ff-231f-4c4d-af23-d6064bbd323d"), new TimeSpan(0, 17, 30, 0, 0), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, new Guid("9a2a605a-5cb9-4f5a-a083-e59cdf3d3d42"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("da22caea-7179-452b-b002-54b5e0875f58"), new TimeSpan(0, 17, 30, 0, 0), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, new Guid("9a2a605a-5cb9-4f5a-a083-e59cdf3d3d42"), new TimeSpan(0, 8, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Editions",
                columns: new[] { "Id", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "EditionNumber", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Notes", "PublicationDate", "PublisherId", "WorkInventoryId", "WorkPublisherId" },
                values: new object[,]
                {
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "First edition of Harry Potter and the Philosopher's Stone.", new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4af559ee-a270-4f2b-b062-2230966f991a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), null },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, 3, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Third edition of Harry Potter and the Philosopher's Stone.", new DateTime(1999, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b3184245-4ec1-4e32-a588-13aa411cc57e"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), null },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, 2, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Second edition of Harry Potter and the Philosopher's Stone.", new DateTime(1998, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ef721b64-5b6a-4f4e-8f04-abdee0a09e6b"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), null }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Members",
                columns: new[] { "Id", "BorrowId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "ExtensionDurationInDays", "Gender", "HasPenalty", "IsDeleted", "IsDeletedById", "IsExtensionAllowed", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "MaxLateReturnsAllowed", "MemberType", "MembershipDate", "MembershipStatus", "NumberOfLateReturns", "Occupation", "PenaltyDurationInDays", "UserId" },
                values: new object[,]
                {
                    { new Guid("3a4387ed-7c4a-447e-801e-27b4599b5e16"), null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, 0, "Female", true, false, new Guid("00000000-0000-0000-0000-000000000000"), false, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, new Guid("9a2a605a-5cb9-4f5a-a083-e59cdf3d3d42"), 3, "Teacher", new DateTime(2024, 5, 5, 17, 47, 48, 686, DateTimeKind.Local).AddTicks(2638), "Active", 2, "Teacher", 7, new Guid("05c1e158-54df-40c4-be72-20d774e08651") },
                    { new Guid("85f1569b-d87d-4714-9654-fd4bd6a2cdc7"), null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, 7, "Male", false, false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, new Guid("9a2a605a-5cb9-4f5a-a083-e59cdf3d3d42"), 3, "Adult", new DateTime(2024, 5, 5, 17, 47, 48, 686, DateTimeKind.Local).AddTicks(2629), "Active", 0, "Software Engineer", 0, new Guid("96279d0f-a6c7-43fa-a8bb-dc5416663d0b") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Shelves",
                columns: new[] { "Id", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "Name" },
                values: new object[,]
                {
                    { new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, new Guid("9a2a605a-5cb9-4f5a-a083-e59cdf3d3d42"), "Shelf 4" },
                    { new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, new Guid("9a2a605a-5cb9-4f5a-a083-e59cdf3d3d42"), "Shelf 1" },
                    { new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, new Guid("9a2a605a-5cb9-4f5a-a083-e59cdf3d3d42"), "Shelf 2" },
                    { new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, new Guid("9a2a605a-5cb9-4f5a-a083-e59cdf3d3d42"), "Shelf 3" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Staffs",
                columns: new[] { "Id", "Address", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "EmploymentDate", "IsDeleted", "IsDeletedById", "IsFullTime", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "Phone", "Salary", "UserId" },
                values: new object[] { new Guid("cc923cf4-c7a2-45b8-9e29-c8df3c72885f"), "Employee Address", new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, new DateTime(2024, 5, 5, 17, 47, 48, 686, DateTimeKind.Local).AddTicks(2674), false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, new Guid("9a2a605a-5cb9-4f5a-a083-e59cdf3d3d42"), "+905553331122", 3000.00m, new Guid("603eeb4a-8263-4d4c-a81d-4a6c450777d3") });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "WorkCatalogs",
                columns: new[] { "Id", "AudioFilePath", "AuthorId", "CoverImageUrl", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "DeweyCode", "Editor", "FavoriteListId", "FilePath", "GenreId", "HasTagPrinted", "ISBN", "IsApproved", "IsBorrowable", "IsDeleted", "IsDeletedById", "IsFeatured", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "OriginalPublicationDate", "PageCount", "PublicationDate", "PublisherId", "ReadingListId", "Summary", "Title", "Translator", "WorkFormat", "WorkLanguage", "WorkStatus" },
                values: new object[] { new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), null, new Guid("4bf98a4c-e048-47dc-86ce-0ecd5293f4e5"), "https://m.media-amazon.com/images/I/81q77Q39nEL._SY385_.jpg", new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, "800", null, null, null, new Guid("5a0be411-c078-405d-b510-925c4f57da55"), false, "9781408855652", true, true, false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, new Guid("9a2a605a-5cb9-4f5a-a083-e59cdf3d3d42"), new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 352, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4af559ee-a270-4f2b-b062-2230966f991a"), null, "Harry Potter has never even heard of Hogwarts when the letters start dropping on the doormat at number four, Privet Drive.\r\nAddressed in green ink on yellowish parchment with a purple seal, they are swiftly confiscated by his grisly aunt and uncle.\r\nThen, on Harry's eleventh birthday, a great beetle-eyed giant of a man called Rubeus Hagrid bursts in with some astonishing news: Harry Potter is a wizard, and he has a place at Hogwarts School of Witchcraft and Wizardry. An incredible adventure is about to begin!", "Harry Potter and the Philosopher's Stone", null, "PrintedBook", "English", "Active" });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Author_WorkCatalogs",
                columns: new[] { "AuthorId", "WorkCatalogId" },
                values: new object[] { new Guid("4bf98a4c-e048-47dc-86ce-0ecd5293f4e5"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b") });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "LibraryBranch_Member",
                columns: new[] { "LibraryBranchId", "MemberId" },
                values: new object[,]
                {
                    { new Guid("9a2a605a-5cb9-4f5a-a083-e59cdf3d3d42"), new Guid("3a4387ed-7c4a-447e-801e-27b4599b5e16") },
                    { new Guid("f8acf7c3-1f03-4a19-8780-6442bc126d92"), new Guid("3a4387ed-7c4a-447e-801e-27b4599b5e16") },
                    { new Guid("9a2a605a-5cb9-4f5a-a083-e59cdf3d3d42"), new Guid("85f1569b-d87d-4714-9654-fd4bd6a2cdc7") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Tag_WorkCatalogs",
                columns: new[] { "TagId", "WorkCatalogId" },
                values: new object[,]
                {
                    { new Guid("6d7f0ceb-b244-4995-9eff-da0870eea992"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b") },
                    { new Guid("d263896e-ebbe-4527-8f53-0ba6c06ddc64"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b") },
                    { new Guid("e53f0c4b-321f-4f90-9770-54c9f879b8fd"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "WorkCompartments",
                columns: new[] { "Id", "BookInventoryItemId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "ShelfId" },
                values: new object[,]
                {
                    { new Guid("2a1b2bc4-bd54-4c09-8bdb-6368b1999f5c"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, "Compartment 3", new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39") },
                    { new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, "Compartment 5", new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d") },
                    { new Guid("50f0c423-b37c-49ce-a3b7-4994529ecbba"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, "Compartment 1", new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39") },
                    { new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, "Compartment 4", new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d") },
                    { new Guid("5ebea65a-005f-4285-b6d1-4e60b370b805"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, "Compartment 1", new Guid("b9761955-9479-454f-a408-030562422cce") },
                    { new Guid("71a182ae-0435-467c-ae9d-073aa0c66317"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, "Compartment 3", new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a") },
                    { new Guid("7943544e-6bd2-478f-8de0-4bc7180d3298"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, "Compartment 5", new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a") },
                    { new Guid("95bc0959-2477-4a6d-9591-8f21adead2d9"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, "Compartment 3", new Guid("b9761955-9479-454f-a408-030562422cce") },
                    { new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, "Compartment 3", new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d") },
                    { new Guid("a3f970f6-6b8b-49b5-8739-324475b3d3d0"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, "Compartment 5", new Guid("b9761955-9479-454f-a408-030562422cce") },
                    { new Guid("a49a8e7c-42dc-4543-b3b8-872559fe2b3c"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, "Compartment 5", new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39") },
                    { new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, "Compartment 1", new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d") },
                    { new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, "Compartment 2", new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d") },
                    { new Guid("c871f987-0d50-47b5-a652-2d5fe0154483"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, "Compartment 2", new Guid("b9761955-9479-454f-a408-030562422cce") },
                    { new Guid("d1c0dcc9-e16f-4e00-b01d-af9b6d768032"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, "Compartment 2", new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39") },
                    { new Guid("d80601d8-83b7-44e4-a651-72bcb9e0f415"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, "Compartment 2", new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a") },
                    { new Guid("dd72b16c-9001-42e5-9ae1-1931937adf82"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, "Compartment 4", new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39") },
                    { new Guid("de21807e-e922-4d91-94fd-0dddc9d6a906"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, "Compartment 4", new Guid("b9761955-9479-454f-a408-030562422cce") },
                    { new Guid("f2069658-b9e3-4d18-99df-8436d9335bf0"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, "Compartment 1", new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a") },
                    { new Guid("f336652a-55a1-4d37-93bf-15b7ac5a5f90"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, "Compartment 4", new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "WorkInventories",
                columns: new[] { "Id", "BookNumber", "BookStatus", "BookStockTransactionType", "BorrowLendId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Description", "Donor", "EditionId", "IsAvailable", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Notes", "ShelfId", "WorkCatalogId", "WorkCompartmentId" },
                values: new object[,]
                {
                    { new Guid("021905d5-2834-4785-ae73-eca9594826f2"), "HP-27", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("046694d0-3644-4191-8b67-80faf2e7e26d"), "HP-132", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("07135a90-9d29-43a0-961d-8b0a840b4dc3"), "HP-15", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("09e69cbe-1302-4398-821a-c483db07b6fd"), "HP-33", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("0a903be6-3ae8-4556-8820-45bfde38b4ca"), "HP-156", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("0b725b35-7ffe-42a6-aa6b-febd04080db4"), "HP-38", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("0c8ad923-57a7-4ee6-b781-85d5fd9c598c"), "HP-100", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("0d122fc1-67b3-4566-8294-1b1d8dc47c75"), "HP-163", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("10cd7ce0-c3d3-4d87-928c-09740b3c5ff0"), "HP-61", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("11210346-b9ba-4dc8-bb23-c0db69f4e910"), "HP-113", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("14ebbf1f-76ea-4989-8197-6f1663a8187a"), "HP-192", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("15a7ecd1-630a-454b-a1e2-e3a7ebaaae78"), "HP-170", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("1679da03-b862-4622-be4d-19f0ddf91aba"), "HP-30", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("16f16b16-503e-4434-ba86-4eb09757b006"), "HP-85", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("17e89b0c-753e-4b81-9456-8642707f9026"), "HP-63", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("1ab1e31a-8f9a-4629-b7a0-f45aaec1b0b6"), "HP-3", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("1da3d35d-b3b9-4cbd-a6c4-6e4dd2bddb7c"), "HP-51", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("1e5c4354-da42-465d-9c7c-0ef4e9edf8bc"), "HP-72", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("1ee67546-b58e-439f-9e30-ba6a69486d25"), "HP-197", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("2249c8a0-9675-4a78-abf5-e7645a411e9d"), "HP-58", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("22b939f3-dbae-456b-9c83-e2ce300b7960"), "HP-115", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("237e63f9-0237-4387-936e-31ef9353e69d"), "HP-152", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("25549d53-ecc2-400c-a3b1-18bcc6e00923"), "HP-168", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("25f7b523-3a7c-484d-852a-42d5b8544009"), "HP-171", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("281cf835-1c2f-4ba7-8eea-0cd7334bce83"), "HP-175", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("28e523a0-597a-4ffd-83ab-fc079c4252b8"), "HP-13", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("29ee5b18-22bf-4b6d-a9dc-b72842cc548e"), "HP-189", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("2b16a1da-c15c-4753-ba87-9073e45c51cc"), "HP-34", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("2ba2b247-53ea-4fcd-a27a-5c9493b60d48"), "HP-83", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("2f608f0b-2eaa-4f49-80ef-3671347abd8d"), "HP-144", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("2ff630a8-53fb-4e98-ae37-9987daa66711"), "HP-36", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("3180e699-44dd-46e4-a646-dc2c3e4188fa"), "HP-126", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("331a9f70-bfaf-4f64-93fc-520e724a7dbd"), "HP-177", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("334de028-96e4-4c35-b3c0-eb4ee173a1e1"), "HP-77", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("340ad841-c197-448d-abfa-4ba46e63ed17"), "HP-2", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("362bfc55-c29b-49a7-98be-7e2629eef820"), "HP-199", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("3712e6c6-f4e8-411c-96b4-5d575c7707cb"), "HP-78", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("38fb1b94-cca1-4478-afef-e816e11f6459"), "HP-62", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("3a11df3d-636b-40f4-a7ac-25aabb732a80"), "HP-20", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("3a60380a-5441-4d34-b27d-58b27ee4b22c"), "HP-121", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("3a8839c1-030a-4900-a44b-bab69c55bbe7"), "HP-46", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("3ac42d8f-5030-47fd-96c7-40cbfddbd98a"), "HP-172", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("3adfad23-db6d-4eba-890e-5c6637b580b2"), "HP-5", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("3b28b122-f5a6-4c41-bf58-b4f05938a821"), "HP-106", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("3c3f0508-7cf0-48d6-abaf-0370d8844466"), "HP-32", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("3c7e97c1-57c2-4a2b-8984-ac1720c2d308"), "HP-112", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("40870924-bcdc-4786-a3a0-d20179366565"), "HP-110", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("410b1aae-fef8-47b1-b4a4-78fd89581330"), "HP-84", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("42956edb-efb1-4ae1-8a32-6692be175ee6"), "HP-117", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("43e10510-55e2-4204-b8fe-03e0282c2c91"), "HP-149", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("4494c963-4eb7-460a-9953-09337baad0de"), "HP-179", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("4a085108-209b-4cf2-a7b3-bb9221ba9753"), "HP-195", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("4a1f81dc-171a-4163-8ab7-be006a0a6718"), "HP-94", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("4b044bca-6503-44d2-a936-8b0ef7c2c600"), "HP-53", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("4bc055ee-fb32-40ab-b7e8-20a5df53437b"), "HP-17", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("4be7be5f-8f23-4db1-b710-0a6dedbc1a7b"), "HP-64", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("4c94c70f-14bf-4c8d-bb87-808de06e7e0c"), "HP-87", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("4d549603-87c8-4938-b594-4e2a860ac9a1"), "HP-42", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("4e8d9f33-f65d-4cce-bfbe-da95b4f337c7"), "HP-116", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("4f206d03-81db-4761-8269-3df44773e3a5"), "HP-165", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("550c54f3-c520-443f-93b4-a9e9a0d65414"), "HP-22", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("57e1c503-5948-4525-aa3e-36e11dbbbbd2"), "HP-159", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("58056c5f-965c-4a58-a0f3-9caee2fbe0a9"), "HP-95", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("58fd81ac-f8ab-4792-8491-c245a762e3da"), "HP-158", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("59224f04-0447-4d88-82de-8e56e262423a"), "HP-7", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("5a0bf74f-02e4-4804-9d2a-ad2429878b83"), "HP-98", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("5b1dc0c5-4f72-4462-aa86-79df6121185b"), "HP-92", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("5c71b419-761e-4980-b0df-a8171f25c192"), "HP-49", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("5f2ad2ad-1c8a-42fa-9382-543ea7332847"), "HP-67", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("6035033a-b66c-4ba5-b1c6-3180299c3600"), "HP-40", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("606e3ada-8ccc-45e1-9978-bf98a99630f5"), "HP-107", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("606fa116-b6c8-4e03-856a-f899c9e25a8f"), "HP-1", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("60cfe187-2a74-48bc-9794-9c4273f8c7d1"), "HP-81", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("61dfaab0-6d97-4a1a-ace6-f4819c8659e6"), "HP-109", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("63b76197-1200-4650-b7a4-d54be401735e"), "HP-91", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("64000674-2dc9-4706-98af-1875ca0691aa"), "HP-71", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("68c7f2f2-89d7-46f8-adf2-1e00b9d4c04c"), "HP-43", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("69c465b3-d407-40e1-992d-ccd6d1758832"), "HP-12", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("6ae90ba2-8246-45cb-8dfd-0c79a0693a59"), "HP-125", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("6bd9160e-adc6-46a2-91ec-fc28eaf0f8b2"), "HP-82", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("6be2dd3d-4139-42d7-bcb3-f1a4bd799b16"), "HP-135", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("6c66ea4a-4e33-46b8-87ac-72b04343ab8b"), "HP-145", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("6efe43c4-bd46-4d6d-8c75-c519b3fe8905"), "HP-31", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("6f21483d-5bcb-4544-b28f-a327e995df2c"), "HP-193", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("70d8125e-0d08-49ee-8236-1c13f7b570e8"), "HP-119", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("71eef9fc-e4c4-465c-a3fa-f952c239c323"), "HP-6", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("723040e3-d6bd-4b21-b74c-9d4e8ec67100"), "HP-52", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("76991592-69ca-4acc-bba4-2d760b7b440a"), "HP-157", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("7e8ca223-5051-4aad-ad7a-8dee2087f2d6"), "HP-191", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("7fc067e5-a124-44e5-b847-e8b035c0bfdf"), "HP-104", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("83e19ae9-cc2e-4364-a538-a818be246ab3"), "HP-70", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("852a20fd-c891-4dd2-8912-df68e74eb297"), "HP-194", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("8586724b-894e-4186-99d9-77a2b933bafb"), "HP-180", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("863d4b56-4404-450d-ae46-966819a96881"), "HP-47", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("86a1cbce-5deb-458f-807b-f7f0feb7fc85"), "HP-57", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("883afca8-d213-468b-981c-ee7fef4ac127"), "HP-16", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("89801a7a-624c-44bd-bc7e-7b058ca7a093"), "HP-178", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("8dbc1839-1b38-4b02-a8bc-d794975b1b35"), "HP-19", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("8de7d4a7-10d6-4a61-989b-552454d897a0"), "HP-66", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("8fd61f8b-8780-4e5a-87cc-b6688a620ea4"), "HP-21", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("908f7831-472f-40b3-b1fd-712d89743e71"), "HP-103", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("93ce27f6-0a0a-4577-80b3-549f1b4883f7"), "HP-111", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("948dc983-826d-4f91-9bc8-57b59f264a0e"), "HP-26", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("94b80567-4385-4437-8b01-70592268f8da"), "HP-154", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("97567202-439f-41aa-9764-e8b48d7fed2a"), "HP-148", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("99e185a9-a522-458a-b6c9-ce00129fcfe9"), "HP-174", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("9a6ea4ea-d22c-48e1-8be0-b12efcec3f6c"), "HP-10", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("9aeb1151-9342-431a-9480-5a5a1e870f8e"), "HP-151", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("9e7caca1-f867-4486-b8a6-942acfe7b04f"), "HP-167", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("9f8ace7e-7668-469f-b0aa-af08da1db2e1"), "HP-176", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("a0c969c5-0e16-4827-8383-62cce9bb55ca"), "HP-60", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("a1036b47-68b5-4d4f-812f-8bb55cbcc0fe"), "HP-18", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("a1d71192-373d-462e-b552-1b0b677abfaa"), "HP-97", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("a2641ff9-dd17-40ae-ab07-44ab63d46880"), "HP-48", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("a2aef767-5cb6-48f4-8232-45dc1cdf2746"), "HP-181", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("a3cd69e3-ffad-4538-b3af-1268e0e84752"), "HP-79", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("a4198497-a573-4cb6-b888-ea0d52ac4e5d"), "HP-134", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("a545e4ca-d397-429b-b1cd-a4e2faa29b55"), "HP-9", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("a5490c41-c96c-4546-8e41-40b83129e688"), "HP-25", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("a5e38c0e-49fb-4c57-90bb-2694e5a06775"), "HP-39", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("a5ea1cf1-b22d-4e69-9b0d-d128264b9e41"), "HP-37", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("a60c17f2-a877-4621-bb95-5e7f595d34bd"), "HP-114", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("a62b2871-8b2d-4acd-aa03-6dadf9f88238"), "HP-161", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("a6be439f-8ca9-40af-a926-77882cecf959"), "HP-183", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("a7a71979-9906-42d0-93b7-50501734ded5"), "HP-173", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("a801329c-cfb6-4bd1-877c-a1d1118cab6f"), "HP-185", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("a9103c49-204f-46b8-9fe9-1d44c61cda95"), "HP-150", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("ac6142f7-1aaa-464f-98df-10b6b750c4df"), "HP-54", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("adc4eafe-2fbf-454d-b67a-6cde49ad4216"), "HP-198", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("ae0756a9-1cc7-4afc-810c-1c348ef759a1"), "HP-187", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("ae31128c-6f12-4415-bb93-a723df4e5a66"), "HP-169", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("aed23a6b-ed31-46b2-afdd-adfbd0a3bf9b"), "HP-122", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("af58284a-5346-40be-aab8-e76283fd0d31"), "HP-153", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("afc537f7-3494-4ec0-85f8-bbcf682e2094"), "HP-76", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("b0a73aea-7514-4f40-a86d-9946b0f4adaa"), "HP-65", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("b2d6fa45-928a-48cc-b4fc-ec3ce26e3c6d"), "HP-56", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("b3980303-2fca-4067-bda7-1095ed1588ff"), "HP-14", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("b40c1523-aa24-4da6-b60e-b33cf3d9671c"), "HP-28", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("b5620403-a1a9-43f9-b167-d1f744f914a6"), "HP-124", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("b56edb93-2a15-4dcd-9bd2-9ca6a6ee8a1f"), "HP-44", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("b6a7a221-86df-4f46-9b0c-05ddaa0eceb5"), "HP-123", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("b700644f-38e0-4244-92dc-5ce4446561c1"), "HP-93", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("b777f3b1-3d3a-4b00-abd7-2a68270a4576"), "HP-139", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("b833b678-2994-47f6-bf17-744f51d84a23"), "HP-4", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("b8c284c9-9100-4efa-89fd-0d845099dcac"), "HP-96", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("b98ca245-7800-4c3a-842a-71e09dc8eaca"), "HP-137", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("b9f05c07-fb7f-4513-98a0-91929cb972a6"), "HP-129", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("bae2a50e-86e9-4fc5-b438-caf4eaa3a853"), "HP-59", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("bb96361e-e9fb-4176-bd96-e4717af9ec10"), "HP-147", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("bddcff9f-e39f-4fc4-8cd5-35e980eb62fa"), "HP-24", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("c0a381c2-0d04-4460-bed5-6bf627549c39"), "HP-188", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("c20f3b34-2f68-4558-b707-e373649b8f4c"), "HP-196", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("c235c803-c4b4-41a0-bf76-0c1e994cf59a"), "HP-186", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("c37463fb-8ade-4c7e-a13b-77672b708fec"), "HP-138", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("c82f45b5-cc73-40f1-b2f4-d965f9cc7f0d"), "HP-142", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("cb76c6b8-9757-4330-a4c6-d274dae3db95"), "HP-41", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("cbeb1d21-6ac3-49bf-a4d6-37db9f670929"), "HP-131", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("cc10cc3b-cdb4-45f6-b1fe-38e096448634"), "HP-35", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("cc5a2592-fb0d-420a-92f7-3305afab950a"), "HP-155", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("cc5fa47d-f911-4247-b938-f58a5ce0799e"), "HP-136", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("cf0f60a7-9f4f-46dc-a45a-54bed2d642bb"), "HP-130", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("cf1cf937-dfe8-458f-8680-c6e8ff145789"), "HP-99", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("d21d0ecd-1e27-4793-b81b-61f7f7bc2110"), "HP-160", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("d24d983b-0bda-49d6-866a-900e76286a42"), "HP-166", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("d27d2c42-f4b4-4426-8501-2bb5fa5fcc8e"), "HP-11", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("d4621abf-6f01-4157-af67-faf911afc4cb"), "HP-75", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("d4dc92b5-d652-4435-92c6-5e80be47a325"), "HP-120", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("d64c8cb6-b4c8-4fdb-b565-7f71f8f18060"), "HP-101", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("d7dff527-253e-4aaf-a2f5-acdc78fe1e66"), "HP-8", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("d8b4ea27-e5c5-4060-bb36-ef2bb65ba875"), "HP-55", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("d95f7aeb-f92b-4d97-be9c-9c4c9ba83abe"), "HP-45", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("db8f4907-94f4-44b9-abfe-c41f27955463"), "HP-102", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("dba6b276-2901-4dc8-a72a-d34c3045be61"), "HP-50", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("dcd8e2df-90c7-434f-9900-335395579374"), "HP-108", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("dfb92da2-8d63-4460-b975-d2b80f86e878"), "HP-74", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("e155fcd6-ddfb-42b3-89f0-672bc3abe607"), "HP-162", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("e39674b8-bd49-4b0e-80f8-f7f0e6c60de0"), "HP-127", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("e428fce7-ea25-4a44-968e-f385f3c27f25"), "HP-88", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("e593db3f-25c3-4630-86aa-fee42e9c6906"), "HP-140", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("e72cf005-e54d-4489-a7c4-d1b6de682c79"), "HP-128", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("e808e042-db00-4e86-9ee2-afb2fa4c3801"), "HP-105", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("a60ed312-2958-47ae-a2ea-9358b93fe7a4") },
                    { new Guid("e9dcf2ce-6e11-4c15-9cd6-38d72219cf76"), "HP-69", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("e9ed3f3d-619b-4c6f-abe2-82eac3613abc"), "HP-23", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("ea4dece2-4524-4896-aed7-39f715e52037"), "HP-90", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("eb65837a-9022-414a-b494-405c1c14a9c1"), "HP-29", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("a1ec53ea-97da-40c0-bbd7-d6c5f376928d"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("ed15a3b6-60b5-4182-b148-6d1cb255e4a5"), "HP-68", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("ed472dbb-929f-4140-8798-2654167fc049"), "HP-89", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("f0b5ad7f-311b-41f8-805a-e21d4db6c8ae"), "HP-143", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("f6ca824a-9164-4265-9d55-ef7f94c50c1c"), "HP-118", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("f7c639a9-243d-4e95-a020-1ffb9c50df3e"), "HP-182", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("f8a63f39-1370-43d9-806f-709f8207ee8b"), "HP-200", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("f9ad3726-5199-40d1-943e-93f847bfde24"), "HP-86", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("f9e6d58d-b677-417b-b139-a2cc3425711f"), "HP-133", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("fad7f69c-0207-4a1f-85a5-ba91e282b619"), "HP-73", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("fc6ebf9e-8c55-4a6c-a762-de97954e1ee7"), "HP-146", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") },
                    { new Guid("fda7df3c-2134-4f4c-a2ba-509ec6e58186"), "HP-80", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("b9761955-9479-454f-a408-030562422cce"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9ea3f36b-8e88-4f7b-a440-6a67f4ed78e5") },
                    { new Guid("fe23db85-b432-4a7d-b7ab-09f522697a91"), "HP-190", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("feffa053-2666-4f86-80a6-2da018a9b70b"), "HP-164", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("c41a8bda-ade5-4bf7-b45a-e52cedf48ce2") },
                    { new Guid("ff0534c5-1953-4909-acf2-e95ffdbe5f1a"), "HP-184", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("3fd78ddd-abb3-4537-8c42-5a3816f40c39"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("58a426d7-e78c-47c9-a9eb-314f4e7ac1b5") },
                    { new Guid("ffe9d63b-caa1-4c41-a69b-7d950d6e3a6a"), "HP-141", "Active", 0, null, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, null, new Guid("eaf165bf-7065-4869-bb90-eb3ffb11743a"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("2f073e06-8f3d-49f8-a78b-acba0e6aa9a6") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BorrowLends",
                columns: new[] { "Id", "BorrowDate", "BorrowStatus", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "DueDate", "FeeAmount", "HasFee", "IsDeleted", "IsDeletedById", "IsLate", "LastModifiedById", "LastModifiedDateUnix", "LateDurationInDays", "MemberId", "ReturnDate", "StaffLenderId", "WorkCatalogId", "WorkInventoryId" },
                values: new object[,]
                {
                    { new Guid("3fc67551-0500-4c17-8f8a-1f3dbf7f789e"), new DateTime(2024, 4, 25, 17, 47, 48, 686, DateTimeKind.Local).AddTicks(3035), "Borrowed", new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, new DateTime(2024, 5, 6, 17, 47, 48, 686, DateTimeKind.Local).AddTicks(3038), 0m, false, false, new Guid("00000000-0000-0000-0000-000000000000"), false, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, 0, new Guid("3a4387ed-7c4a-447e-801e-27b4599b5e16"), null, new Guid("cc923cf4-c7a2-45b8-9e29-c8df3c72885f"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("07135a90-9d29-43a0-961d-8b0a840b4dc3") },
                    { new Guid("bb266e22-c1a9-4c34-9570-8a015c4cdb19"), new DateTime(2024, 4, 25, 17, 47, 48, 686, DateTimeKind.Local).AddTicks(3020), "DelayedReturn", new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, new DateTime(2024, 5, 4, 17, 47, 48, 686, DateTimeKind.Local).AddTicks(3024), 0m, false, false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, 1, new Guid("3a4387ed-7c4a-447e-801e-27b4599b5e16"), new DateTime(2024, 5, 5, 17, 47, 48, 686, DateTimeKind.Local).AddTicks(3025), new Guid("cc923cf4-c7a2-45b8-9e29-c8df3c72885f"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("9a6ea4ea-d22c-48e1-8be0-b12efcec3f6c") },
                    { new Guid("d9062eb4-a6c6-43d8-a313-447489444c24"), new DateTime(2024, 4, 25, 17, 47, 48, 686, DateTimeKind.Local).AddTicks(2947), "Returned", new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), 1714931268L, null, new DateTime(2024, 5, 5, 17, 47, 48, 686, DateTimeKind.Local).AddTicks(2963), 0m, false, false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("8c4cba4e-d302-49f9-961c-c05eb0ecea4f"), null, 0, new Guid("85f1569b-d87d-4714-9654-fd4bd6a2cdc7"), new DateTime(2024, 5, 5, 17, 47, 48, 686, DateTimeKind.Local).AddTicks(2964), new Guid("cc923cf4-c7a2-45b8-9e29-c8df3c72885f"), new Guid("1c15fdd0-5980-490b-84fa-eed64ac0159b"), new Guid("3adfad23-db6d-4eba-890e-5c6637b580b2") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Edition_WorkInventories",
                columns: new[] { "EditionId", "WorkInventoryId" },
                values: new object[,]
                {
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("021905d5-2834-4785-ae73-eca9594826f2") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("021905d5-2834-4785-ae73-eca9594826f2") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("021905d5-2834-4785-ae73-eca9594826f2") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("046694d0-3644-4191-8b67-80faf2e7e26d") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("046694d0-3644-4191-8b67-80faf2e7e26d") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("046694d0-3644-4191-8b67-80faf2e7e26d") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("07135a90-9d29-43a0-961d-8b0a840b4dc3") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("07135a90-9d29-43a0-961d-8b0a840b4dc3") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("07135a90-9d29-43a0-961d-8b0a840b4dc3") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("09e69cbe-1302-4398-821a-c483db07b6fd") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("09e69cbe-1302-4398-821a-c483db07b6fd") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("09e69cbe-1302-4398-821a-c483db07b6fd") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("0a903be6-3ae8-4556-8820-45bfde38b4ca") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("0a903be6-3ae8-4556-8820-45bfde38b4ca") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("0a903be6-3ae8-4556-8820-45bfde38b4ca") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("0b725b35-7ffe-42a6-aa6b-febd04080db4") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("0b725b35-7ffe-42a6-aa6b-febd04080db4") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("0b725b35-7ffe-42a6-aa6b-febd04080db4") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("0c8ad923-57a7-4ee6-b781-85d5fd9c598c") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("0c8ad923-57a7-4ee6-b781-85d5fd9c598c") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("0c8ad923-57a7-4ee6-b781-85d5fd9c598c") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("0d122fc1-67b3-4566-8294-1b1d8dc47c75") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("0d122fc1-67b3-4566-8294-1b1d8dc47c75") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("0d122fc1-67b3-4566-8294-1b1d8dc47c75") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("10cd7ce0-c3d3-4d87-928c-09740b3c5ff0") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("10cd7ce0-c3d3-4d87-928c-09740b3c5ff0") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("10cd7ce0-c3d3-4d87-928c-09740b3c5ff0") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("11210346-b9ba-4dc8-bb23-c0db69f4e910") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("11210346-b9ba-4dc8-bb23-c0db69f4e910") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("11210346-b9ba-4dc8-bb23-c0db69f4e910") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("14ebbf1f-76ea-4989-8197-6f1663a8187a") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("14ebbf1f-76ea-4989-8197-6f1663a8187a") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("14ebbf1f-76ea-4989-8197-6f1663a8187a") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("15a7ecd1-630a-454b-a1e2-e3a7ebaaae78") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("15a7ecd1-630a-454b-a1e2-e3a7ebaaae78") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("15a7ecd1-630a-454b-a1e2-e3a7ebaaae78") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("1679da03-b862-4622-be4d-19f0ddf91aba") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("1679da03-b862-4622-be4d-19f0ddf91aba") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("1679da03-b862-4622-be4d-19f0ddf91aba") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("16f16b16-503e-4434-ba86-4eb09757b006") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("16f16b16-503e-4434-ba86-4eb09757b006") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("16f16b16-503e-4434-ba86-4eb09757b006") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("17e89b0c-753e-4b81-9456-8642707f9026") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("17e89b0c-753e-4b81-9456-8642707f9026") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("17e89b0c-753e-4b81-9456-8642707f9026") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("1ab1e31a-8f9a-4629-b7a0-f45aaec1b0b6") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("1ab1e31a-8f9a-4629-b7a0-f45aaec1b0b6") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("1ab1e31a-8f9a-4629-b7a0-f45aaec1b0b6") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("1da3d35d-b3b9-4cbd-a6c4-6e4dd2bddb7c") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("1da3d35d-b3b9-4cbd-a6c4-6e4dd2bddb7c") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("1da3d35d-b3b9-4cbd-a6c4-6e4dd2bddb7c") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("1e5c4354-da42-465d-9c7c-0ef4e9edf8bc") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("1e5c4354-da42-465d-9c7c-0ef4e9edf8bc") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("1e5c4354-da42-465d-9c7c-0ef4e9edf8bc") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("1ee67546-b58e-439f-9e30-ba6a69486d25") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("1ee67546-b58e-439f-9e30-ba6a69486d25") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("1ee67546-b58e-439f-9e30-ba6a69486d25") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("2249c8a0-9675-4a78-abf5-e7645a411e9d") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("2249c8a0-9675-4a78-abf5-e7645a411e9d") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("2249c8a0-9675-4a78-abf5-e7645a411e9d") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("22b939f3-dbae-456b-9c83-e2ce300b7960") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("22b939f3-dbae-456b-9c83-e2ce300b7960") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("22b939f3-dbae-456b-9c83-e2ce300b7960") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("237e63f9-0237-4387-936e-31ef9353e69d") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("237e63f9-0237-4387-936e-31ef9353e69d") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("237e63f9-0237-4387-936e-31ef9353e69d") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("25549d53-ecc2-400c-a3b1-18bcc6e00923") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("25549d53-ecc2-400c-a3b1-18bcc6e00923") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("25549d53-ecc2-400c-a3b1-18bcc6e00923") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("25f7b523-3a7c-484d-852a-42d5b8544009") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("25f7b523-3a7c-484d-852a-42d5b8544009") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("25f7b523-3a7c-484d-852a-42d5b8544009") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("281cf835-1c2f-4ba7-8eea-0cd7334bce83") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("281cf835-1c2f-4ba7-8eea-0cd7334bce83") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("281cf835-1c2f-4ba7-8eea-0cd7334bce83") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("28e523a0-597a-4ffd-83ab-fc079c4252b8") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("28e523a0-597a-4ffd-83ab-fc079c4252b8") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("28e523a0-597a-4ffd-83ab-fc079c4252b8") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("29ee5b18-22bf-4b6d-a9dc-b72842cc548e") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("29ee5b18-22bf-4b6d-a9dc-b72842cc548e") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("29ee5b18-22bf-4b6d-a9dc-b72842cc548e") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("2b16a1da-c15c-4753-ba87-9073e45c51cc") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("2b16a1da-c15c-4753-ba87-9073e45c51cc") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("2b16a1da-c15c-4753-ba87-9073e45c51cc") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("2ba2b247-53ea-4fcd-a27a-5c9493b60d48") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("2ba2b247-53ea-4fcd-a27a-5c9493b60d48") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("2ba2b247-53ea-4fcd-a27a-5c9493b60d48") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("2f608f0b-2eaa-4f49-80ef-3671347abd8d") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("2f608f0b-2eaa-4f49-80ef-3671347abd8d") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("2f608f0b-2eaa-4f49-80ef-3671347abd8d") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("2ff630a8-53fb-4e98-ae37-9987daa66711") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("2ff630a8-53fb-4e98-ae37-9987daa66711") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("2ff630a8-53fb-4e98-ae37-9987daa66711") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("3180e699-44dd-46e4-a646-dc2c3e4188fa") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("3180e699-44dd-46e4-a646-dc2c3e4188fa") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("3180e699-44dd-46e4-a646-dc2c3e4188fa") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("331a9f70-bfaf-4f64-93fc-520e724a7dbd") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("331a9f70-bfaf-4f64-93fc-520e724a7dbd") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("331a9f70-bfaf-4f64-93fc-520e724a7dbd") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("334de028-96e4-4c35-b3c0-eb4ee173a1e1") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("334de028-96e4-4c35-b3c0-eb4ee173a1e1") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("334de028-96e4-4c35-b3c0-eb4ee173a1e1") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("340ad841-c197-448d-abfa-4ba46e63ed17") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("340ad841-c197-448d-abfa-4ba46e63ed17") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("340ad841-c197-448d-abfa-4ba46e63ed17") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("362bfc55-c29b-49a7-98be-7e2629eef820") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("362bfc55-c29b-49a7-98be-7e2629eef820") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("362bfc55-c29b-49a7-98be-7e2629eef820") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("3712e6c6-f4e8-411c-96b4-5d575c7707cb") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("3712e6c6-f4e8-411c-96b4-5d575c7707cb") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("3712e6c6-f4e8-411c-96b4-5d575c7707cb") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("38fb1b94-cca1-4478-afef-e816e11f6459") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("38fb1b94-cca1-4478-afef-e816e11f6459") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("38fb1b94-cca1-4478-afef-e816e11f6459") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("3a11df3d-636b-40f4-a7ac-25aabb732a80") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("3a11df3d-636b-40f4-a7ac-25aabb732a80") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("3a11df3d-636b-40f4-a7ac-25aabb732a80") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("3a60380a-5441-4d34-b27d-58b27ee4b22c") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("3a60380a-5441-4d34-b27d-58b27ee4b22c") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("3a60380a-5441-4d34-b27d-58b27ee4b22c") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("3a8839c1-030a-4900-a44b-bab69c55bbe7") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("3a8839c1-030a-4900-a44b-bab69c55bbe7") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("3a8839c1-030a-4900-a44b-bab69c55bbe7") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("3ac42d8f-5030-47fd-96c7-40cbfddbd98a") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("3ac42d8f-5030-47fd-96c7-40cbfddbd98a") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("3ac42d8f-5030-47fd-96c7-40cbfddbd98a") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("3adfad23-db6d-4eba-890e-5c6637b580b2") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("3adfad23-db6d-4eba-890e-5c6637b580b2") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("3adfad23-db6d-4eba-890e-5c6637b580b2") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("3b28b122-f5a6-4c41-bf58-b4f05938a821") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("3b28b122-f5a6-4c41-bf58-b4f05938a821") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("3b28b122-f5a6-4c41-bf58-b4f05938a821") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("3c3f0508-7cf0-48d6-abaf-0370d8844466") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("3c3f0508-7cf0-48d6-abaf-0370d8844466") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("3c3f0508-7cf0-48d6-abaf-0370d8844466") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("3c7e97c1-57c2-4a2b-8984-ac1720c2d308") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("3c7e97c1-57c2-4a2b-8984-ac1720c2d308") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("3c7e97c1-57c2-4a2b-8984-ac1720c2d308") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("40870924-bcdc-4786-a3a0-d20179366565") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("40870924-bcdc-4786-a3a0-d20179366565") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("40870924-bcdc-4786-a3a0-d20179366565") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("410b1aae-fef8-47b1-b4a4-78fd89581330") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("410b1aae-fef8-47b1-b4a4-78fd89581330") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("410b1aae-fef8-47b1-b4a4-78fd89581330") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("42956edb-efb1-4ae1-8a32-6692be175ee6") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("42956edb-efb1-4ae1-8a32-6692be175ee6") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("42956edb-efb1-4ae1-8a32-6692be175ee6") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("43e10510-55e2-4204-b8fe-03e0282c2c91") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("43e10510-55e2-4204-b8fe-03e0282c2c91") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("43e10510-55e2-4204-b8fe-03e0282c2c91") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("4494c963-4eb7-460a-9953-09337baad0de") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("4494c963-4eb7-460a-9953-09337baad0de") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("4494c963-4eb7-460a-9953-09337baad0de") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("4a085108-209b-4cf2-a7b3-bb9221ba9753") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("4a085108-209b-4cf2-a7b3-bb9221ba9753") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("4a085108-209b-4cf2-a7b3-bb9221ba9753") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("4a1f81dc-171a-4163-8ab7-be006a0a6718") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("4a1f81dc-171a-4163-8ab7-be006a0a6718") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("4a1f81dc-171a-4163-8ab7-be006a0a6718") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("4b044bca-6503-44d2-a936-8b0ef7c2c600") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("4b044bca-6503-44d2-a936-8b0ef7c2c600") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("4b044bca-6503-44d2-a936-8b0ef7c2c600") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("4bc055ee-fb32-40ab-b7e8-20a5df53437b") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("4bc055ee-fb32-40ab-b7e8-20a5df53437b") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("4bc055ee-fb32-40ab-b7e8-20a5df53437b") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("4be7be5f-8f23-4db1-b710-0a6dedbc1a7b") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("4be7be5f-8f23-4db1-b710-0a6dedbc1a7b") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("4be7be5f-8f23-4db1-b710-0a6dedbc1a7b") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("4c94c70f-14bf-4c8d-bb87-808de06e7e0c") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("4c94c70f-14bf-4c8d-bb87-808de06e7e0c") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("4c94c70f-14bf-4c8d-bb87-808de06e7e0c") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("4d549603-87c8-4938-b594-4e2a860ac9a1") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("4d549603-87c8-4938-b594-4e2a860ac9a1") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("4d549603-87c8-4938-b594-4e2a860ac9a1") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("4e8d9f33-f65d-4cce-bfbe-da95b4f337c7") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("4e8d9f33-f65d-4cce-bfbe-da95b4f337c7") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("4e8d9f33-f65d-4cce-bfbe-da95b4f337c7") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("4f206d03-81db-4761-8269-3df44773e3a5") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("4f206d03-81db-4761-8269-3df44773e3a5") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("4f206d03-81db-4761-8269-3df44773e3a5") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("550c54f3-c520-443f-93b4-a9e9a0d65414") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("550c54f3-c520-443f-93b4-a9e9a0d65414") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("550c54f3-c520-443f-93b4-a9e9a0d65414") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("57e1c503-5948-4525-aa3e-36e11dbbbbd2") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("57e1c503-5948-4525-aa3e-36e11dbbbbd2") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("57e1c503-5948-4525-aa3e-36e11dbbbbd2") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("58056c5f-965c-4a58-a0f3-9caee2fbe0a9") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("58056c5f-965c-4a58-a0f3-9caee2fbe0a9") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("58056c5f-965c-4a58-a0f3-9caee2fbe0a9") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("58fd81ac-f8ab-4792-8491-c245a762e3da") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("58fd81ac-f8ab-4792-8491-c245a762e3da") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("58fd81ac-f8ab-4792-8491-c245a762e3da") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("59224f04-0447-4d88-82de-8e56e262423a") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("59224f04-0447-4d88-82de-8e56e262423a") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("59224f04-0447-4d88-82de-8e56e262423a") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("5a0bf74f-02e4-4804-9d2a-ad2429878b83") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("5a0bf74f-02e4-4804-9d2a-ad2429878b83") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("5a0bf74f-02e4-4804-9d2a-ad2429878b83") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("5b1dc0c5-4f72-4462-aa86-79df6121185b") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("5b1dc0c5-4f72-4462-aa86-79df6121185b") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("5b1dc0c5-4f72-4462-aa86-79df6121185b") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("5c71b419-761e-4980-b0df-a8171f25c192") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("5c71b419-761e-4980-b0df-a8171f25c192") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("5c71b419-761e-4980-b0df-a8171f25c192") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("5f2ad2ad-1c8a-42fa-9382-543ea7332847") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("5f2ad2ad-1c8a-42fa-9382-543ea7332847") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("5f2ad2ad-1c8a-42fa-9382-543ea7332847") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("6035033a-b66c-4ba5-b1c6-3180299c3600") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("6035033a-b66c-4ba5-b1c6-3180299c3600") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("6035033a-b66c-4ba5-b1c6-3180299c3600") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("606e3ada-8ccc-45e1-9978-bf98a99630f5") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("606e3ada-8ccc-45e1-9978-bf98a99630f5") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("606e3ada-8ccc-45e1-9978-bf98a99630f5") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("606fa116-b6c8-4e03-856a-f899c9e25a8f") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("606fa116-b6c8-4e03-856a-f899c9e25a8f") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("606fa116-b6c8-4e03-856a-f899c9e25a8f") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("60cfe187-2a74-48bc-9794-9c4273f8c7d1") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("60cfe187-2a74-48bc-9794-9c4273f8c7d1") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("60cfe187-2a74-48bc-9794-9c4273f8c7d1") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("61dfaab0-6d97-4a1a-ace6-f4819c8659e6") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("61dfaab0-6d97-4a1a-ace6-f4819c8659e6") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("61dfaab0-6d97-4a1a-ace6-f4819c8659e6") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("63b76197-1200-4650-b7a4-d54be401735e") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("63b76197-1200-4650-b7a4-d54be401735e") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("63b76197-1200-4650-b7a4-d54be401735e") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("64000674-2dc9-4706-98af-1875ca0691aa") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("64000674-2dc9-4706-98af-1875ca0691aa") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("64000674-2dc9-4706-98af-1875ca0691aa") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("68c7f2f2-89d7-46f8-adf2-1e00b9d4c04c") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("68c7f2f2-89d7-46f8-adf2-1e00b9d4c04c") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("68c7f2f2-89d7-46f8-adf2-1e00b9d4c04c") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("69c465b3-d407-40e1-992d-ccd6d1758832") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("69c465b3-d407-40e1-992d-ccd6d1758832") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("69c465b3-d407-40e1-992d-ccd6d1758832") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("6ae90ba2-8246-45cb-8dfd-0c79a0693a59") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("6ae90ba2-8246-45cb-8dfd-0c79a0693a59") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("6ae90ba2-8246-45cb-8dfd-0c79a0693a59") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("6bd9160e-adc6-46a2-91ec-fc28eaf0f8b2") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("6bd9160e-adc6-46a2-91ec-fc28eaf0f8b2") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("6bd9160e-adc6-46a2-91ec-fc28eaf0f8b2") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("6be2dd3d-4139-42d7-bcb3-f1a4bd799b16") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("6be2dd3d-4139-42d7-bcb3-f1a4bd799b16") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("6be2dd3d-4139-42d7-bcb3-f1a4bd799b16") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("6c66ea4a-4e33-46b8-87ac-72b04343ab8b") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("6c66ea4a-4e33-46b8-87ac-72b04343ab8b") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("6c66ea4a-4e33-46b8-87ac-72b04343ab8b") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("6efe43c4-bd46-4d6d-8c75-c519b3fe8905") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("6efe43c4-bd46-4d6d-8c75-c519b3fe8905") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("6efe43c4-bd46-4d6d-8c75-c519b3fe8905") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("6f21483d-5bcb-4544-b28f-a327e995df2c") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("6f21483d-5bcb-4544-b28f-a327e995df2c") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("6f21483d-5bcb-4544-b28f-a327e995df2c") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("70d8125e-0d08-49ee-8236-1c13f7b570e8") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("70d8125e-0d08-49ee-8236-1c13f7b570e8") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("70d8125e-0d08-49ee-8236-1c13f7b570e8") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("71eef9fc-e4c4-465c-a3fa-f952c239c323") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("71eef9fc-e4c4-465c-a3fa-f952c239c323") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("71eef9fc-e4c4-465c-a3fa-f952c239c323") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("723040e3-d6bd-4b21-b74c-9d4e8ec67100") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("723040e3-d6bd-4b21-b74c-9d4e8ec67100") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("723040e3-d6bd-4b21-b74c-9d4e8ec67100") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("76991592-69ca-4acc-bba4-2d760b7b440a") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("76991592-69ca-4acc-bba4-2d760b7b440a") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("76991592-69ca-4acc-bba4-2d760b7b440a") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("7e8ca223-5051-4aad-ad7a-8dee2087f2d6") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("7e8ca223-5051-4aad-ad7a-8dee2087f2d6") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("7e8ca223-5051-4aad-ad7a-8dee2087f2d6") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("7fc067e5-a124-44e5-b847-e8b035c0bfdf") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("7fc067e5-a124-44e5-b847-e8b035c0bfdf") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("7fc067e5-a124-44e5-b847-e8b035c0bfdf") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("83e19ae9-cc2e-4364-a538-a818be246ab3") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("83e19ae9-cc2e-4364-a538-a818be246ab3") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("83e19ae9-cc2e-4364-a538-a818be246ab3") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("852a20fd-c891-4dd2-8912-df68e74eb297") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("852a20fd-c891-4dd2-8912-df68e74eb297") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("852a20fd-c891-4dd2-8912-df68e74eb297") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("8586724b-894e-4186-99d9-77a2b933bafb") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("8586724b-894e-4186-99d9-77a2b933bafb") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("8586724b-894e-4186-99d9-77a2b933bafb") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("863d4b56-4404-450d-ae46-966819a96881") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("863d4b56-4404-450d-ae46-966819a96881") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("863d4b56-4404-450d-ae46-966819a96881") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("86a1cbce-5deb-458f-807b-f7f0feb7fc85") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("86a1cbce-5deb-458f-807b-f7f0feb7fc85") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("86a1cbce-5deb-458f-807b-f7f0feb7fc85") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("883afca8-d213-468b-981c-ee7fef4ac127") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("883afca8-d213-468b-981c-ee7fef4ac127") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("883afca8-d213-468b-981c-ee7fef4ac127") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("89801a7a-624c-44bd-bc7e-7b058ca7a093") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("89801a7a-624c-44bd-bc7e-7b058ca7a093") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("89801a7a-624c-44bd-bc7e-7b058ca7a093") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("8dbc1839-1b38-4b02-a8bc-d794975b1b35") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("8dbc1839-1b38-4b02-a8bc-d794975b1b35") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("8dbc1839-1b38-4b02-a8bc-d794975b1b35") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("8de7d4a7-10d6-4a61-989b-552454d897a0") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("8de7d4a7-10d6-4a61-989b-552454d897a0") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("8de7d4a7-10d6-4a61-989b-552454d897a0") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("8fd61f8b-8780-4e5a-87cc-b6688a620ea4") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("8fd61f8b-8780-4e5a-87cc-b6688a620ea4") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("8fd61f8b-8780-4e5a-87cc-b6688a620ea4") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("908f7831-472f-40b3-b1fd-712d89743e71") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("908f7831-472f-40b3-b1fd-712d89743e71") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("908f7831-472f-40b3-b1fd-712d89743e71") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("93ce27f6-0a0a-4577-80b3-549f1b4883f7") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("93ce27f6-0a0a-4577-80b3-549f1b4883f7") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("93ce27f6-0a0a-4577-80b3-549f1b4883f7") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("948dc983-826d-4f91-9bc8-57b59f264a0e") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("948dc983-826d-4f91-9bc8-57b59f264a0e") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("948dc983-826d-4f91-9bc8-57b59f264a0e") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("94b80567-4385-4437-8b01-70592268f8da") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("94b80567-4385-4437-8b01-70592268f8da") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("94b80567-4385-4437-8b01-70592268f8da") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("97567202-439f-41aa-9764-e8b48d7fed2a") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("97567202-439f-41aa-9764-e8b48d7fed2a") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("97567202-439f-41aa-9764-e8b48d7fed2a") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("99e185a9-a522-458a-b6c9-ce00129fcfe9") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("99e185a9-a522-458a-b6c9-ce00129fcfe9") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("99e185a9-a522-458a-b6c9-ce00129fcfe9") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("9a6ea4ea-d22c-48e1-8be0-b12efcec3f6c") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("9a6ea4ea-d22c-48e1-8be0-b12efcec3f6c") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("9a6ea4ea-d22c-48e1-8be0-b12efcec3f6c") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("9aeb1151-9342-431a-9480-5a5a1e870f8e") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("9aeb1151-9342-431a-9480-5a5a1e870f8e") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("9aeb1151-9342-431a-9480-5a5a1e870f8e") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("9e7caca1-f867-4486-b8a6-942acfe7b04f") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("9e7caca1-f867-4486-b8a6-942acfe7b04f") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("9e7caca1-f867-4486-b8a6-942acfe7b04f") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("9f8ace7e-7668-469f-b0aa-af08da1db2e1") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("9f8ace7e-7668-469f-b0aa-af08da1db2e1") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("9f8ace7e-7668-469f-b0aa-af08da1db2e1") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("a0c969c5-0e16-4827-8383-62cce9bb55ca") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("a0c969c5-0e16-4827-8383-62cce9bb55ca") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("a0c969c5-0e16-4827-8383-62cce9bb55ca") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("a1036b47-68b5-4d4f-812f-8bb55cbcc0fe") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("a1036b47-68b5-4d4f-812f-8bb55cbcc0fe") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("a1036b47-68b5-4d4f-812f-8bb55cbcc0fe") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("a1d71192-373d-462e-b552-1b0b677abfaa") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("a1d71192-373d-462e-b552-1b0b677abfaa") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("a1d71192-373d-462e-b552-1b0b677abfaa") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("a2641ff9-dd17-40ae-ab07-44ab63d46880") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("a2641ff9-dd17-40ae-ab07-44ab63d46880") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("a2641ff9-dd17-40ae-ab07-44ab63d46880") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("a2aef767-5cb6-48f4-8232-45dc1cdf2746") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("a2aef767-5cb6-48f4-8232-45dc1cdf2746") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("a2aef767-5cb6-48f4-8232-45dc1cdf2746") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("a3cd69e3-ffad-4538-b3af-1268e0e84752") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("a3cd69e3-ffad-4538-b3af-1268e0e84752") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("a3cd69e3-ffad-4538-b3af-1268e0e84752") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("a4198497-a573-4cb6-b888-ea0d52ac4e5d") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("a4198497-a573-4cb6-b888-ea0d52ac4e5d") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("a4198497-a573-4cb6-b888-ea0d52ac4e5d") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("a545e4ca-d397-429b-b1cd-a4e2faa29b55") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("a545e4ca-d397-429b-b1cd-a4e2faa29b55") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("a545e4ca-d397-429b-b1cd-a4e2faa29b55") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("a5490c41-c96c-4546-8e41-40b83129e688") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("a5490c41-c96c-4546-8e41-40b83129e688") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("a5490c41-c96c-4546-8e41-40b83129e688") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("a5e38c0e-49fb-4c57-90bb-2694e5a06775") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("a5e38c0e-49fb-4c57-90bb-2694e5a06775") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("a5e38c0e-49fb-4c57-90bb-2694e5a06775") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("a5ea1cf1-b22d-4e69-9b0d-d128264b9e41") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("a5ea1cf1-b22d-4e69-9b0d-d128264b9e41") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("a5ea1cf1-b22d-4e69-9b0d-d128264b9e41") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("a60c17f2-a877-4621-bb95-5e7f595d34bd") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("a60c17f2-a877-4621-bb95-5e7f595d34bd") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("a60c17f2-a877-4621-bb95-5e7f595d34bd") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("a62b2871-8b2d-4acd-aa03-6dadf9f88238") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("a62b2871-8b2d-4acd-aa03-6dadf9f88238") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("a62b2871-8b2d-4acd-aa03-6dadf9f88238") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("a6be439f-8ca9-40af-a926-77882cecf959") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("a6be439f-8ca9-40af-a926-77882cecf959") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("a6be439f-8ca9-40af-a926-77882cecf959") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("a7a71979-9906-42d0-93b7-50501734ded5") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("a7a71979-9906-42d0-93b7-50501734ded5") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("a7a71979-9906-42d0-93b7-50501734ded5") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("a801329c-cfb6-4bd1-877c-a1d1118cab6f") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("a801329c-cfb6-4bd1-877c-a1d1118cab6f") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("a801329c-cfb6-4bd1-877c-a1d1118cab6f") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("a9103c49-204f-46b8-9fe9-1d44c61cda95") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("a9103c49-204f-46b8-9fe9-1d44c61cda95") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("a9103c49-204f-46b8-9fe9-1d44c61cda95") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("ac6142f7-1aaa-464f-98df-10b6b750c4df") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("ac6142f7-1aaa-464f-98df-10b6b750c4df") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("ac6142f7-1aaa-464f-98df-10b6b750c4df") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("adc4eafe-2fbf-454d-b67a-6cde49ad4216") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("adc4eafe-2fbf-454d-b67a-6cde49ad4216") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("adc4eafe-2fbf-454d-b67a-6cde49ad4216") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("ae0756a9-1cc7-4afc-810c-1c348ef759a1") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("ae0756a9-1cc7-4afc-810c-1c348ef759a1") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("ae0756a9-1cc7-4afc-810c-1c348ef759a1") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("ae31128c-6f12-4415-bb93-a723df4e5a66") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("ae31128c-6f12-4415-bb93-a723df4e5a66") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("ae31128c-6f12-4415-bb93-a723df4e5a66") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("aed23a6b-ed31-46b2-afdd-adfbd0a3bf9b") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("aed23a6b-ed31-46b2-afdd-adfbd0a3bf9b") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("aed23a6b-ed31-46b2-afdd-adfbd0a3bf9b") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("af58284a-5346-40be-aab8-e76283fd0d31") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("af58284a-5346-40be-aab8-e76283fd0d31") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("af58284a-5346-40be-aab8-e76283fd0d31") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("afc537f7-3494-4ec0-85f8-bbcf682e2094") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("afc537f7-3494-4ec0-85f8-bbcf682e2094") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("afc537f7-3494-4ec0-85f8-bbcf682e2094") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("b0a73aea-7514-4f40-a86d-9946b0f4adaa") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("b0a73aea-7514-4f40-a86d-9946b0f4adaa") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("b0a73aea-7514-4f40-a86d-9946b0f4adaa") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("b2d6fa45-928a-48cc-b4fc-ec3ce26e3c6d") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("b2d6fa45-928a-48cc-b4fc-ec3ce26e3c6d") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("b2d6fa45-928a-48cc-b4fc-ec3ce26e3c6d") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("b3980303-2fca-4067-bda7-1095ed1588ff") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("b3980303-2fca-4067-bda7-1095ed1588ff") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("b3980303-2fca-4067-bda7-1095ed1588ff") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("b40c1523-aa24-4da6-b60e-b33cf3d9671c") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("b40c1523-aa24-4da6-b60e-b33cf3d9671c") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("b40c1523-aa24-4da6-b60e-b33cf3d9671c") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("b5620403-a1a9-43f9-b167-d1f744f914a6") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("b5620403-a1a9-43f9-b167-d1f744f914a6") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("b5620403-a1a9-43f9-b167-d1f744f914a6") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("b56edb93-2a15-4dcd-9bd2-9ca6a6ee8a1f") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("b56edb93-2a15-4dcd-9bd2-9ca6a6ee8a1f") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("b56edb93-2a15-4dcd-9bd2-9ca6a6ee8a1f") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("b6a7a221-86df-4f46-9b0c-05ddaa0eceb5") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("b6a7a221-86df-4f46-9b0c-05ddaa0eceb5") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("b6a7a221-86df-4f46-9b0c-05ddaa0eceb5") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("b700644f-38e0-4244-92dc-5ce4446561c1") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("b700644f-38e0-4244-92dc-5ce4446561c1") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("b700644f-38e0-4244-92dc-5ce4446561c1") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("b777f3b1-3d3a-4b00-abd7-2a68270a4576") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("b777f3b1-3d3a-4b00-abd7-2a68270a4576") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("b777f3b1-3d3a-4b00-abd7-2a68270a4576") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("b833b678-2994-47f6-bf17-744f51d84a23") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("b833b678-2994-47f6-bf17-744f51d84a23") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("b833b678-2994-47f6-bf17-744f51d84a23") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("b8c284c9-9100-4efa-89fd-0d845099dcac") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("b8c284c9-9100-4efa-89fd-0d845099dcac") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("b8c284c9-9100-4efa-89fd-0d845099dcac") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("b98ca245-7800-4c3a-842a-71e09dc8eaca") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("b98ca245-7800-4c3a-842a-71e09dc8eaca") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("b98ca245-7800-4c3a-842a-71e09dc8eaca") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("b9f05c07-fb7f-4513-98a0-91929cb972a6") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("b9f05c07-fb7f-4513-98a0-91929cb972a6") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("b9f05c07-fb7f-4513-98a0-91929cb972a6") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("bae2a50e-86e9-4fc5-b438-caf4eaa3a853") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("bae2a50e-86e9-4fc5-b438-caf4eaa3a853") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("bae2a50e-86e9-4fc5-b438-caf4eaa3a853") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("bb96361e-e9fb-4176-bd96-e4717af9ec10") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("bb96361e-e9fb-4176-bd96-e4717af9ec10") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("bb96361e-e9fb-4176-bd96-e4717af9ec10") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("bddcff9f-e39f-4fc4-8cd5-35e980eb62fa") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("bddcff9f-e39f-4fc4-8cd5-35e980eb62fa") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("bddcff9f-e39f-4fc4-8cd5-35e980eb62fa") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("c0a381c2-0d04-4460-bed5-6bf627549c39") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("c0a381c2-0d04-4460-bed5-6bf627549c39") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("c0a381c2-0d04-4460-bed5-6bf627549c39") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("c20f3b34-2f68-4558-b707-e373649b8f4c") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("c20f3b34-2f68-4558-b707-e373649b8f4c") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("c20f3b34-2f68-4558-b707-e373649b8f4c") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("c235c803-c4b4-41a0-bf76-0c1e994cf59a") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("c235c803-c4b4-41a0-bf76-0c1e994cf59a") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("c235c803-c4b4-41a0-bf76-0c1e994cf59a") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("c37463fb-8ade-4c7e-a13b-77672b708fec") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("c37463fb-8ade-4c7e-a13b-77672b708fec") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("c37463fb-8ade-4c7e-a13b-77672b708fec") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("c82f45b5-cc73-40f1-b2f4-d965f9cc7f0d") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("c82f45b5-cc73-40f1-b2f4-d965f9cc7f0d") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("c82f45b5-cc73-40f1-b2f4-d965f9cc7f0d") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("cb76c6b8-9757-4330-a4c6-d274dae3db95") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("cb76c6b8-9757-4330-a4c6-d274dae3db95") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("cb76c6b8-9757-4330-a4c6-d274dae3db95") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("cbeb1d21-6ac3-49bf-a4d6-37db9f670929") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("cbeb1d21-6ac3-49bf-a4d6-37db9f670929") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("cbeb1d21-6ac3-49bf-a4d6-37db9f670929") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("cc10cc3b-cdb4-45f6-b1fe-38e096448634") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("cc10cc3b-cdb4-45f6-b1fe-38e096448634") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("cc10cc3b-cdb4-45f6-b1fe-38e096448634") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("cc5a2592-fb0d-420a-92f7-3305afab950a") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("cc5a2592-fb0d-420a-92f7-3305afab950a") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("cc5a2592-fb0d-420a-92f7-3305afab950a") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("cc5fa47d-f911-4247-b938-f58a5ce0799e") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("cc5fa47d-f911-4247-b938-f58a5ce0799e") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("cc5fa47d-f911-4247-b938-f58a5ce0799e") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("cf0f60a7-9f4f-46dc-a45a-54bed2d642bb") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("cf0f60a7-9f4f-46dc-a45a-54bed2d642bb") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("cf0f60a7-9f4f-46dc-a45a-54bed2d642bb") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("cf1cf937-dfe8-458f-8680-c6e8ff145789") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("cf1cf937-dfe8-458f-8680-c6e8ff145789") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("cf1cf937-dfe8-458f-8680-c6e8ff145789") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("d21d0ecd-1e27-4793-b81b-61f7f7bc2110") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("d21d0ecd-1e27-4793-b81b-61f7f7bc2110") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("d21d0ecd-1e27-4793-b81b-61f7f7bc2110") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("d24d983b-0bda-49d6-866a-900e76286a42") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("d24d983b-0bda-49d6-866a-900e76286a42") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("d24d983b-0bda-49d6-866a-900e76286a42") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("d27d2c42-f4b4-4426-8501-2bb5fa5fcc8e") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("d27d2c42-f4b4-4426-8501-2bb5fa5fcc8e") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("d27d2c42-f4b4-4426-8501-2bb5fa5fcc8e") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("d4621abf-6f01-4157-af67-faf911afc4cb") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("d4621abf-6f01-4157-af67-faf911afc4cb") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("d4621abf-6f01-4157-af67-faf911afc4cb") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("d4dc92b5-d652-4435-92c6-5e80be47a325") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("d4dc92b5-d652-4435-92c6-5e80be47a325") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("d4dc92b5-d652-4435-92c6-5e80be47a325") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("d64c8cb6-b4c8-4fdb-b565-7f71f8f18060") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("d64c8cb6-b4c8-4fdb-b565-7f71f8f18060") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("d64c8cb6-b4c8-4fdb-b565-7f71f8f18060") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("d7dff527-253e-4aaf-a2f5-acdc78fe1e66") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("d7dff527-253e-4aaf-a2f5-acdc78fe1e66") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("d7dff527-253e-4aaf-a2f5-acdc78fe1e66") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("d8b4ea27-e5c5-4060-bb36-ef2bb65ba875") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("d8b4ea27-e5c5-4060-bb36-ef2bb65ba875") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("d8b4ea27-e5c5-4060-bb36-ef2bb65ba875") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("d95f7aeb-f92b-4d97-be9c-9c4c9ba83abe") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("d95f7aeb-f92b-4d97-be9c-9c4c9ba83abe") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("d95f7aeb-f92b-4d97-be9c-9c4c9ba83abe") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("db8f4907-94f4-44b9-abfe-c41f27955463") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("db8f4907-94f4-44b9-abfe-c41f27955463") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("db8f4907-94f4-44b9-abfe-c41f27955463") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("dba6b276-2901-4dc8-a72a-d34c3045be61") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("dba6b276-2901-4dc8-a72a-d34c3045be61") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("dba6b276-2901-4dc8-a72a-d34c3045be61") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("dcd8e2df-90c7-434f-9900-335395579374") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("dcd8e2df-90c7-434f-9900-335395579374") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("dcd8e2df-90c7-434f-9900-335395579374") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("dfb92da2-8d63-4460-b975-d2b80f86e878") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("dfb92da2-8d63-4460-b975-d2b80f86e878") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("dfb92da2-8d63-4460-b975-d2b80f86e878") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("e155fcd6-ddfb-42b3-89f0-672bc3abe607") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("e155fcd6-ddfb-42b3-89f0-672bc3abe607") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("e155fcd6-ddfb-42b3-89f0-672bc3abe607") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("e39674b8-bd49-4b0e-80f8-f7f0e6c60de0") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("e39674b8-bd49-4b0e-80f8-f7f0e6c60de0") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("e39674b8-bd49-4b0e-80f8-f7f0e6c60de0") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("e428fce7-ea25-4a44-968e-f385f3c27f25") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("e428fce7-ea25-4a44-968e-f385f3c27f25") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("e428fce7-ea25-4a44-968e-f385f3c27f25") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("e593db3f-25c3-4630-86aa-fee42e9c6906") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("e593db3f-25c3-4630-86aa-fee42e9c6906") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("e593db3f-25c3-4630-86aa-fee42e9c6906") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("e72cf005-e54d-4489-a7c4-d1b6de682c79") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("e72cf005-e54d-4489-a7c4-d1b6de682c79") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("e72cf005-e54d-4489-a7c4-d1b6de682c79") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("e808e042-db00-4e86-9ee2-afb2fa4c3801") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("e808e042-db00-4e86-9ee2-afb2fa4c3801") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("e808e042-db00-4e86-9ee2-afb2fa4c3801") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("e9dcf2ce-6e11-4c15-9cd6-38d72219cf76") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("e9dcf2ce-6e11-4c15-9cd6-38d72219cf76") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("e9dcf2ce-6e11-4c15-9cd6-38d72219cf76") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("e9ed3f3d-619b-4c6f-abe2-82eac3613abc") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("e9ed3f3d-619b-4c6f-abe2-82eac3613abc") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("e9ed3f3d-619b-4c6f-abe2-82eac3613abc") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("ea4dece2-4524-4896-aed7-39f715e52037") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("ea4dece2-4524-4896-aed7-39f715e52037") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("ea4dece2-4524-4896-aed7-39f715e52037") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("eb65837a-9022-414a-b494-405c1c14a9c1") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("eb65837a-9022-414a-b494-405c1c14a9c1") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("eb65837a-9022-414a-b494-405c1c14a9c1") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("ed15a3b6-60b5-4182-b148-6d1cb255e4a5") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("ed15a3b6-60b5-4182-b148-6d1cb255e4a5") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("ed15a3b6-60b5-4182-b148-6d1cb255e4a5") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("ed472dbb-929f-4140-8798-2654167fc049") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("ed472dbb-929f-4140-8798-2654167fc049") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("ed472dbb-929f-4140-8798-2654167fc049") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("f0b5ad7f-311b-41f8-805a-e21d4db6c8ae") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("f0b5ad7f-311b-41f8-805a-e21d4db6c8ae") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("f0b5ad7f-311b-41f8-805a-e21d4db6c8ae") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("f6ca824a-9164-4265-9d55-ef7f94c50c1c") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("f6ca824a-9164-4265-9d55-ef7f94c50c1c") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("f6ca824a-9164-4265-9d55-ef7f94c50c1c") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("f7c639a9-243d-4e95-a020-1ffb9c50df3e") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("f7c639a9-243d-4e95-a020-1ffb9c50df3e") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("f7c639a9-243d-4e95-a020-1ffb9c50df3e") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("f8a63f39-1370-43d9-806f-709f8207ee8b") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("f8a63f39-1370-43d9-806f-709f8207ee8b") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("f8a63f39-1370-43d9-806f-709f8207ee8b") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("f9ad3726-5199-40d1-943e-93f847bfde24") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("f9ad3726-5199-40d1-943e-93f847bfde24") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("f9ad3726-5199-40d1-943e-93f847bfde24") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("f9e6d58d-b677-417b-b139-a2cc3425711f") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("f9e6d58d-b677-417b-b139-a2cc3425711f") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("f9e6d58d-b677-417b-b139-a2cc3425711f") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("fad7f69c-0207-4a1f-85a5-ba91e282b619") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("fad7f69c-0207-4a1f-85a5-ba91e282b619") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("fad7f69c-0207-4a1f-85a5-ba91e282b619") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("fc6ebf9e-8c55-4a6c-a762-de97954e1ee7") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("fc6ebf9e-8c55-4a6c-a762-de97954e1ee7") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("fc6ebf9e-8c55-4a6c-a762-de97954e1ee7") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("fda7df3c-2134-4f4c-a2ba-509ec6e58186") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("fda7df3c-2134-4f4c-a2ba-509ec6e58186") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("fda7df3c-2134-4f4c-a2ba-509ec6e58186") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("fe23db85-b432-4a7d-b7ab-09f522697a91") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("fe23db85-b432-4a7d-b7ab-09f522697a91") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("fe23db85-b432-4a7d-b7ab-09f522697a91") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("feffa053-2666-4f86-80a6-2da018a9b70b") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("feffa053-2666-4f86-80a6-2da018a9b70b") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("feffa053-2666-4f86-80a6-2da018a9b70b") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("ff0534c5-1953-4909-acf2-e95ffdbe5f1a") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("ff0534c5-1953-4909-acf2-e95ffdbe5f1a") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("ff0534c5-1953-4909-acf2-e95ffdbe5f1a") },
                    { new Guid("ea8c15aa-0bcf-4721-9b25-d84af4147f64"), new Guid("ffe9d63b-caa1-4c41-a69b-7d950d6e3a6a") },
                    { new Guid("f3b14281-c259-4f0f-9535-f78115f8ba6d"), new Guid("ffe9d63b-caa1-4c41-a69b-7d950d6e3a6a") },
                    { new Guid("fc40f1e1-0ddd-4a31-9063-543dc902fe9a"), new Guid("ffe9d63b-caa1-4c41-a69b-7d950d6e3a6a") }
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
                name: "IX_Author_WorkCatalogs_AuthorId",
                schema: "lm",
                table: "Author_WorkCatalogs",
                column: "AuthorId");

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
                name: "IX_BorrowLends_MemberId",
                schema: "lm",
                table: "BorrowLends",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowLends_StaffLenderId",
                schema: "lm",
                table: "BorrowLends",
                column: "StaffLenderId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowLends_WorkCatalogId",
                schema: "lm",
                table: "BorrowLends",
                column: "WorkCatalogId");

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
                name: "IX_Edition_WorkInventories_EditionId",
                schema: "lm",
                table: "Edition_WorkInventories",
                column: "EditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Editions_PublisherId",
                schema: "lm",
                table: "Editions",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Editions_WorkPublisherId",
                schema: "lm",
                table: "Editions",
                column: "WorkPublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_LibraryBranch_Member_LibraryBranchId",
                schema: "lm",
                table: "LibraryBranch_Member",
                column: "LibraryBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_LibraryBranches_AppUserId",
                schema: "lm",
                table: "LibraryBranches",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_LibraryBranches_Name",
                schema: "lm",
                table: "LibraryBranches",
                column: "Name",
                unique: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Tag_WorkCatalogs_TagId",
                schema: "lm",
                table: "Tag_WorkCatalogs",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCatalogs_FavoriteListId",
                schema: "lm",
                table: "WorkCatalogs",
                column: "FavoriteListId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCatalogs_GenreId",
                schema: "lm",
                table: "WorkCatalogs",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCatalogs_LibraryBranchId",
                schema: "lm",
                table: "WorkCatalogs",
                column: "LibraryBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCatalogs_PublisherId",
                schema: "lm",
                table: "WorkCatalogs",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCatalogs_ReadingListId",
                schema: "lm",
                table: "WorkCatalogs",
                column: "ReadingListId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCompartments_ShelfId",
                schema: "lm",
                table: "WorkCompartments",
                column: "ShelfId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkInventories_BookNumber",
                schema: "lm",
                table: "WorkInventories",
                column: "BookNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkInventories_ShelfId",
                schema: "lm",
                table: "WorkInventories",
                column: "ShelfId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkInventories_WorkCatalogId",
                schema: "lm",
                table: "WorkInventories",
                column: "WorkCatalogId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkInventories_WorkCompartmentId",
                schema: "lm",
                table: "WorkInventories",
                column: "WorkCompartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPublishers_Email",
                schema: "lm",
                table: "WorkPublishers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkPublishers_Name",
                schema: "lm",
                table: "WorkPublishers",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_WorkTags_Name",
                schema: "lm",
                table: "WorkTags",
                column: "Name");
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
                name: "Author_WorkCatalogs",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "BookReviews",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "BorrowLends",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "BranchHours",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "Edition_WorkInventories",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "JwtSettingConfigurations",
                schema: "static");

            migrationBuilder.DropTable(
                name: "LibraryBranch_Member",
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
                name: "Tag_WorkCatalogs",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "Authors",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "Staffs",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "Editions",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "WorkInventories",
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
                name: "WorkTags",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "WorkCatalogs",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "WorkCompartments",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "FavoriteLists",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "ReadingLists",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "WorkGenres",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "WorkPublishers",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "Shelves",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "LibraryBranches",
                schema: "lm");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
