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
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BorrowLendId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EditionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_WorkInventories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkInventories_Shelves_ShelfId",
                        column: x => x.ShelfId,
                        principalSchema: "lm",
                        principalTable: "Shelves",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WorkInventories_WorkCatalogs_BookId",
                        column: x => x.BookId,
                        principalSchema: "lm",
                        principalTable: "WorkCatalogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkInventories_WorkCompartments_BookCompartmentId",
                        column: x => x.BookCompartmentId,
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
                    { new Guid("1571ce3b-399b-446e-ba69-529e3c2d0c96"), null, "27a90fd9-d7f1-4ccc-a341-50ab46c7dbab", "Member", "MEMBER" },
                    { new Guid("22a5a7c6-3196-449f-ab3a-0ffbea44d029"), null, "cf085311-deb0-49f4-9355-3d65bbf2355d", "Admin", "ADMIN" },
                    { new Guid("3e824d56-1369-4f17-b061-815208647b9b"), null, "5993d4e5-3f9d-4f67-b898-ff9eeab92e0d", "system", "SYSTEM" },
                    { new Guid("a2eb03b8-1711-44e9-ad5f-95352b90b9fd"), null, "f9e46371-861e-448b-ba85-3b2e782d8c38", "Staff", "STAFF" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "ConcurrencyStamp", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Email", "EmailConfirmed", "Gender", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "RefreshToken", "RefreshTokenEndDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("3d13b95f-0743-48e9-84f8-4b2ae1b93b3f"), 0, "789 Employee St.", new DateTime(1990, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "b370beee-c47b-4e3b-ab9a-2d847dbe3495", new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 0L, null, "employee1@example.com", true, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, false, null, "Employee", "EMPLOYEE1@EXAMPLE.COM", "EMPLOYEE1@EXAMPLE.COM", "AQAAAAIAAYagAAAAECUbW4QaOuWPandjzaA5bbtDfvzyVacKJpYri3eZSWshuYR909LHpNZMjvZURZJP5g==", null, false, new byte[0], null, null, "", "One", false, "employee1@example.com" },
                    { new Guid("8624b610-5f17-4317-b237-e25895f13ec4"), 0, "123 Main Street", new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "89b6378e-410e-473b-92f2-fd6ce59541c3", new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 0L, null, "john.doe@example.com", true, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, false, null, "John", "JOHN.DOE@EXAMPLE.COM", "JOHN.DOE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEL2gF5hB4uGYTY8w0seq4RGgzd5tEHuQTIr6pIUdbUU7c+fFP7Z2YJpgfvVpbx4UUQ==", null, false, new byte[0], null, null, "", "Doe", false, "john.doe@example.com" },
                    { new Guid("a3ee9353-af86-4da1-8fcd-46ff242c0459"), 0, "456 Admin St.", new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "082483d7-10b5-4b78-8693-f1a9a6cf3b87", new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 0L, null, "admin@example.com", true, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, false, null, "Admin", "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGeA0JHl09/zFXXaQACdMwI6aaT4monrt+Y91SEkpl/M2oh/mKbES1z5PFRx58xfPQ==", null, false, new byte[0], null, null, "", "Admin", false, "admin@example.com" },
                    { new Guid("cd806e7b-dd6a-4920-b793-f8b492aeca18"), 0, "456 Oak Street", new DateTime(1985, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "6570faad-be40-4b42-9863-b88cb262411a", new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 0L, null, "jane.smith@example.com", true, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, false, null, "Jane", "JANE.SMITH@EXAMPLE.COM", "JANE.SMITH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKXRe0Ah/BeVixKUAUaOazxcyuwfhyyoog897d7xvqE2mNfbo+8RKecwxOxFv+uW1w==", null, false, new byte[0], null, null, "", "Smith", false, "jane.smith@example.com" },
                    { new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 0, "123 System St.", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "827c4a71-a2c4-43db-bcc0-803dd3b2a1ce", new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, "system@domain.com", true, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, false, null, "System", "SYSTEM@DOMAIN.COM", "SYSTEM", "AQAAAAIAAYagAAAAEFnVv4B+hyFkOupsmCtS3BihmWYHQ/Iqg8lLbHcxH57NQMPO06KXmWIklLZz2EZFbA==", null, false, new byte[0], null, null, "", "Admin", false, "system" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Authors",
                columns: new[] { "Id", "Biography", "BirthDate", "Country", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "Surname", "Website" },
                values: new object[] { new Guid("5d80ecd1-a9ad-4d49-a44e-1eae7e588d29"), "Joanne Rowling, better known by her pen name J.K. Rowling, is a British author, philanthropist, film producer, television producer, and screenwriter. She is best known for writing the Harry Potter fantasy series.", new DateTime(1965, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "United Kingdom", new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, "J.K.", "Rowling", "www.example.com" });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "LibraryBranches",
                columns: new[] { "Id", "Address", "AppUserId", "CreatedById", "CreatedDateUnix", "CriticalLevelThreshold", "DeletedDateUnix", "Description", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "MaxCheckoutDurationInDays", "MaxCheckoutLimit", "MinCheckoutDurationInDays", "Name", "NotifyOnBookOrBlogComment", "PhoneNumber", "TopBooksReportLimit", "TopMembersReportLimit" },
                values: new object[,]
                {
                    { new Guid("d49dc7e0-4d60-40ba-bd0d-4da81754ce14"), "789 Üçüncü Bulvar, No: 23", null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, 8, null, "Yıldızlar Kütüphanesi, gökyüzünü aşkın kitaplarla dolu bir yerdir.", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, 14, 10, 3, "Yıldızlar Kütüphanesi", false, "+90 (212) 987 6543", 10, 10 },
                    { new Guid("f1ea5c5a-ede8-42e1-8f59-67d70b8e486d"), "456 İkinci Sokak, No: 15", null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, 6, null, "Ana Kütüphane Şubesi, şehrin kalbindeki kitapseverler için bir buluşma noktasıdır.", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, 10, 7, 4, "Ana Kütüphane Şubesi", true, "+90 (212) 123 4567", 7, 7 }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "WorkGenres",
                columns: new[] { "Id", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsActive", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name" },
                values: new object[,]
                {
                    { new Guid("10a8c77d-eb06-4b02-b1e4-c753c8aece0a"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, "Fantasy" },
                    { new Guid("6b9148b9-73bc-42aa-b77b-f92f93d3c6d1"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, "Adventure" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "WorkPublishers",
                columns: new[] { "Id", "Address", "City", "Country", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Email", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "PhoneNumber", "Website" },
                values: new object[,]
                {
                    { new Guid("7906d383-58dd-49de-bade-fc51049ddf16"), "50 Bedford Square, London, England", "London", "England", new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, "info@bloomsbury.com", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, "Bloomsbury Publishing", "+44 (0)20 7631 5600", "https://www.bloomsbury.com/" },
                    { new Guid("b8499496-3dfa-42ee-b2ee-f14e75169192"), "1745 Broadway, New York, NY, USA", "New York", "USA", new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, "info@randomhouse.com", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, "Random House", "+1 212-782-9000", "https://www.randomhousebooks.com/" },
                    { new Guid("e5aca9af-a9ae-49b9-92bd-9602a6544dce"), "80 Strand, London, England", "London", "England", new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, "info@penguin.co.uk", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, "Penguin Books", "+44 (0)20 7139 3000", "https://www.penguin.co.uk/" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "WorkTags",
                columns: new[] { "Id", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "WorkCatalogId" },
                values: new object[,]
                {
                    { new Guid("68eeec58-9d3d-496f-9ad4-affdbc3bc60d"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, "Hogwarts", new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9") },
                    { new Guid("def21e12-d2e0-41f0-a73c-d1d905a3b0bd"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, "Harry Potter", new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9") },
                    { new Guid("eb1090fa-ac84-4433-a1d0-74311bbc4ffa"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, "Quidditch", new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("a2eb03b8-1711-44e9-ad5f-95352b90b9fd"), new Guid("3d13b95f-0743-48e9-84f8-4b2ae1b93b3f"), "AppUserRole" },
                    { new Guid("22a5a7c6-3196-449f-ab3a-0ffbea44d029"), new Guid("a3ee9353-af86-4da1-8fcd-46ff242c0459"), "AppUserRole" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BranchHours",
                columns: new[] { "Id", "ClosingTime", "CreatedById", "CreatedDateUnix", "DayOfWeek", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "OpeningTime" },
                values: new object[,]
                {
                    { new Guid("0cbef449-5fa3-46ac-ad21-062ce6f89d50"), new TimeSpan(0, 17, 30, 0, 0), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, new Guid("f1ea5c5a-ede8-42e1-8f59-67d70b8e486d"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("26cfd8dc-18fb-4501-95e2-7b448e827fc8"), new TimeSpan(0, 0, 0, 0, 0), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, new Guid("f1ea5c5a-ede8-42e1-8f59-67d70b8e486d"), new TimeSpan(0, 0, 0, 0, 0) },
                    { new Guid("2e69e19f-75f3-409f-a27c-32f817d82d30"), new TimeSpan(0, 17, 30, 0, 0), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, new Guid("f1ea5c5a-ede8-42e1-8f59-67d70b8e486d"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("4f6f476e-573b-4cd9-bf16-17e08ef158e9"), new TimeSpan(0, 17, 30, 0, 0), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, new Guid("f1ea5c5a-ede8-42e1-8f59-67d70b8e486d"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("511be4f3-23bc-403a-bcbd-a52f25013a0a"), new TimeSpan(0, 17, 30, 0, 0), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, new Guid("f1ea5c5a-ede8-42e1-8f59-67d70b8e486d"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("eccc477d-eaf3-4365-8f96-8e2a3db50a0e"), new TimeSpan(0, 17, 30, 0, 0), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, new Guid("f1ea5c5a-ede8-42e1-8f59-67d70b8e486d"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("ff5d73bf-62b3-42d4-82c8-1a7b8daa8337"), new TimeSpan(0, 17, 30, 0, 0), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, new Guid("f1ea5c5a-ede8-42e1-8f59-67d70b8e486d"), new TimeSpan(0, 8, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Editions",
                columns: new[] { "Id", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "EditionNumber", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Notes", "PublicationDate", "PublisherId", "WorkInventoryId", "WorkPublisherId" },
                values: new object[,]
                {
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "First edition of Harry Potter and the Philosopher's Stone.", new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7906d383-58dd-49de-bade-fc51049ddf16"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), null },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, 2, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Second edition of Harry Potter and the Philosopher's Stone.", new DateTime(1998, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5aca9af-a9ae-49b9-92bd-9602a6544dce"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), null },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, 3, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Third edition of Harry Potter and the Philosopher's Stone.", new DateTime(1999, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8499496-3dfa-42ee-b2ee-f14e75169192"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), null }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Members",
                columns: new[] { "Id", "BorrowId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "ExtensionDurationInDays", "Gender", "HasPenalty", "IsDeleted", "IsDeletedById", "IsExtensionAllowed", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "MaxLateReturnsAllowed", "MemberType", "MembershipDate", "MembershipStatus", "NumberOfLateReturns", "Occupation", "PenaltyDurationInDays", "UserId" },
                values: new object[,]
                {
                    { new Guid("650b5c5c-2833-4539-805b-c055e87ae21e"), null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, 0, "Female", true, false, new Guid("00000000-0000-0000-0000-000000000000"), false, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, new Guid("f1ea5c5a-ede8-42e1-8f59-67d70b8e486d"), 3, "Teacher", new DateTime(2024, 5, 1, 18, 7, 25, 121, DateTimeKind.Local).AddTicks(6810), "Active", 2, "Teacher", 7, new Guid("cd806e7b-dd6a-4920-b793-f8b492aeca18") },
                    { new Guid("c3181c17-0116-495b-9fd9-cda9ae7bca9c"), null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, 7, "Male", false, false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, new Guid("f1ea5c5a-ede8-42e1-8f59-67d70b8e486d"), 3, "Adult", new DateTime(2024, 5, 1, 18, 7, 25, 121, DateTimeKind.Local).AddTicks(6804), "Active", 0, "Software Engineer", 0, new Guid("8624b610-5f17-4317-b237-e25895f13ec4") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Shelves",
                columns: new[] { "Id", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "Name" },
                values: new object[,]
                {
                    { new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, new Guid("f1ea5c5a-ede8-42e1-8f59-67d70b8e486d"), "Shelf 1" },
                    { new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, new Guid("f1ea5c5a-ede8-42e1-8f59-67d70b8e486d"), "Shelf 4" },
                    { new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, new Guid("f1ea5c5a-ede8-42e1-8f59-67d70b8e486d"), "Shelf 3" },
                    { new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, new Guid("f1ea5c5a-ede8-42e1-8f59-67d70b8e486d"), "Shelf 2" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Staffs",
                columns: new[] { "Id", "Address", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "EmploymentDate", "IsDeleted", "IsDeletedById", "IsFullTime", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "Phone", "Salary", "UserId" },
                values: new object[] { new Guid("f0290ada-2668-48af-898c-a87a2cb14f28"), "Employee Address", new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, new DateTime(2024, 5, 1, 18, 7, 25, 121, DateTimeKind.Local).AddTicks(6846), false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, new Guid("f1ea5c5a-ede8-42e1-8f59-67d70b8e486d"), "+905553331122", 3000.00m, new Guid("3d13b95f-0743-48e9-84f8-4b2ae1b93b3f") });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "WorkCatalogs",
                columns: new[] { "Id", "AudioFilePath", "AuthorId", "CoverImageUrl", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "DeweyCode", "Editor", "FavoriteListId", "FilePath", "GenreId", "HasTagPrinted", "ISBN", "IsApproved", "IsBorrowable", "IsDeleted", "IsDeletedById", "IsFeatured", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "OriginalPublicationDate", "PageCount", "PublicationDate", "PublisherId", "ReadingListId", "Summary", "Title", "Translator", "WorkFormat", "WorkLanguage", "WorkStatus" },
                values: new object[] { new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), null, new Guid("5d80ecd1-a9ad-4d49-a44e-1eae7e588d29"), "https://m.media-amazon.com/images/I/81q77Q39nEL._SY385_.jpg", new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, "800", null, null, null, new Guid("10a8c77d-eb06-4b02-b1e4-c753c8aece0a"), false, "9781408855652", true, true, false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, new Guid("f1ea5c5a-ede8-42e1-8f59-67d70b8e486d"), new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 352, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7906d383-58dd-49de-bade-fc51049ddf16"), null, "Harry Potter has never even heard of Hogwarts when the letters start dropping on the doormat at number four, Privet Drive.\r\nAddressed in green ink on yellowish parchment with a purple seal, they are swiftly confiscated by his grisly aunt and uncle.\r\nThen, on Harry's eleventh birthday, a great beetle-eyed giant of a man called Rubeus Hagrid bursts in with some astonishing news: Harry Potter is a wizard, and he has a place at Hogwarts School of Witchcraft and Wizardry. An incredible adventure is about to begin!", "Harry Potter and the Philosopher's Stone", null, "PrintedBook", "English", "Active" });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Author_WorkCatalogs",
                columns: new[] { "AuthorId", "WorkCatalogId" },
                values: new object[] { new Guid("5d80ecd1-a9ad-4d49-a44e-1eae7e588d29"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9") });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "LibraryBranch_Member",
                columns: new[] { "LibraryBranchId", "MemberId" },
                values: new object[,]
                {
                    { new Guid("d49dc7e0-4d60-40ba-bd0d-4da81754ce14"), new Guid("650b5c5c-2833-4539-805b-c055e87ae21e") },
                    { new Guid("f1ea5c5a-ede8-42e1-8f59-67d70b8e486d"), new Guid("650b5c5c-2833-4539-805b-c055e87ae21e") },
                    { new Guid("f1ea5c5a-ede8-42e1-8f59-67d70b8e486d"), new Guid("c3181c17-0116-495b-9fd9-cda9ae7bca9c") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Tag_WorkCatalogs",
                columns: new[] { "TagId", "WorkCatalogId" },
                values: new object[,]
                {
                    { new Guid("68eeec58-9d3d-496f-9ad4-affdbc3bc60d"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9") },
                    { new Guid("def21e12-d2e0-41f0-a73c-d1d905a3b0bd"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9") },
                    { new Guid("eb1090fa-ac84-4433-a1d0-74311bbc4ffa"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "WorkCompartments",
                columns: new[] { "Id", "BookInventoryItemId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "ShelfId" },
                values: new object[,]
                {
                    { new Guid("18c3f44e-ff44-469d-bb24-7a6c2c8985f9"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, "Compartment 3", new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("323e9041-7f8a-4346-9296-a3863f9ab1c1"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, "Compartment 3", new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("3d95da36-43ef-4e70-a458-d0a182e66dcf"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, "Compartment 4", new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, "Compartment 1", new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, "Compartment 5", new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("66f04430-c2f9-45fb-8afc-7874bf3b85f3"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, "Compartment 1", new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, "Compartment 3", new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("7c2fa5c6-acb6-4e69-ba07-9bf459d9c64b"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, "Compartment 1", new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, "Compartment 4", new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("8b9c4f77-9fcc-4184-a99b-df2489db71d6"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, "Compartment 4", new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("9375fe2c-da0a-4f13-b596-33796fdae9a3"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, "Compartment 3", new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("a5e147ca-a189-4586-b415-db5d0775baf1"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, "Compartment 5", new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("c09c40ee-cced-44f5-ba18-ca305c2a5179"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, "Compartment 2", new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("c295011e-9aea-48ef-91ea-f902fb6382e0"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, "Compartment 2", new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("c2ef6902-83c7-4875-99c3-e8b7e2e09627"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, "Compartment 1", new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("c39b6b84-b94c-476d-9846-8d31744fa954"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, "Compartment 5", new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, "Compartment 2", new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("d6f7f24d-2be7-446d-a072-ec78f3eed5ae"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, "Compartment 2", new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("e40a36bb-af73-4ade-9b1f-7ef682b1ae31"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, "Compartment 5", new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("e5d805dd-f169-45f1-a3c5-99311c4c7016"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, "Compartment 4", new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "WorkInventories",
                columns: new[] { "Id", "BookCompartmentId", "BookId", "BookNumber", "BookStatus", "BookStockTransactionType", "BorrowLendId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Description", "Donor", "EditionId", "IsAvailable", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Notes", "ShelfId" },
                values: new object[,]
                {
                    { new Guid("00e107c6-a505-4840-9062-c51bf8f2e6eb"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-74", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("034a9188-e681-422c-b1bc-627366d4f552"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-73", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("03e55897-2a15-49d2-ad76-f906e5c7f6e9"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-121", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("04757b70-5a00-4a66-a024-5be7c9d3738b"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-97", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("065711d8-c1b1-4cb5-a4f4-34cc54ac3648"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-34", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("09928f85-004f-4b7f-8168-1af079e557d7"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-81", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("0a1df5f0-652c-4af8-92f7-c6451fc02601"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-29", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("0c2e8b24-5fd4-4aa0-b002-7bbbf2300bb5"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-99", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("0c95266e-2d54-49d0-b6a8-a727af27165c"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-3", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("0cb6af86-d4f3-4e61-9a4d-9124379644da"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-119", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("0d2884bf-3bf2-433e-9742-2a6ccbc8ac1b"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-179", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("0d568200-ac80-45be-8c75-399b9471ca02"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-102", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("0dbac186-e155-4aff-bbce-fd62c0eaab1c"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-72", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("0e1a8071-7c31-410d-b38b-83330c55b044"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-63", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("0f1f0aff-f449-43e8-8fbb-2e53b38f30e2"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-10", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("0f5e00a8-dc5d-4b38-b26c-96905900b232"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-116", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("1101d667-087b-4b96-bcae-c1c4d9e129db"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-155", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("12c081a3-62a7-4656-b620-f5b53aa65a38"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-171", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("12e736b2-368d-4fe7-9191-995f6c12eb52"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-37", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("12f438df-64e2-45bb-a379-568e3500933a"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-84", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("131fa718-b850-46eb-b0fd-cece0e420875"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-54", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("1454eb56-d435-4610-b23c-ee40bd437215"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-117", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("155fb4e6-7bf0-4ee8-8c70-983c6bb31a55"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-174", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("1674c3f6-0cfb-49ac-9548-811c0fbb5b66"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-6", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("17bf37bc-9e03-4ef4-ba59-8cc7ece5e8d4"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-91", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("183e0cc3-6cfb-4cfb-b436-0280030660dc"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-93", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("19f89ed0-b319-44dd-a6a3-1c7055ede531"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-160", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("19f8d096-00f2-432b-bb24-4e84d462a6f2"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-180", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("1a4ae726-26c9-42cf-9f18-018fba6bd315"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-46", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("1aa1a4d7-c1d1-4249-9146-46ee040e8bd5"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-83", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("1c458204-e5a2-432d-bfe3-fae6fcd7c218"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-181", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("2006bf3b-213e-43ba-9411-38e51925f1f5"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-167", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("2093209a-8898-4b1f-bbe3-5de8f1991bbb"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-107", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("222ef5b7-c98a-4c25-81aa-730193249108"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-112", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("22be3bfa-c2f4-45fc-a18c-fb2ea2dd3810"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-96", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("234729bc-e29d-495e-9d1b-87fb236d8a5b"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-38", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("235303c7-8985-4ffb-962f-b182e718a8de"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-132", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("237dc3bb-1bc5-4443-8ca4-6e870243503b"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-194", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("24903cd7-b7a6-47ee-be62-f001a975cbe0"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-67", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("2c6edac6-087b-49de-bf43-371393da0409"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-199", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("2cbb1298-f828-40f4-9d11-1a794606da97"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-125", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("2e335d71-c894-4fed-897a-f44d31dc3bd3"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-33", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("2f8b7551-8ac8-467b-8e2e-ed4ff0b92786"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-69", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("301b3944-d368-42f7-95ea-93acfd8182aa"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-86", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("33ac04b5-9382-48b4-99e1-a8a89bc36ba4"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-103", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("369bc41e-8a8e-4f98-8fa6-1a7d805a0c57"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-157", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("375c0328-eeaf-4f7c-9a1e-7e6d2fd30215"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-172", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("39cee64c-886a-4a0a-91a3-42d0afc419a5"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-176", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("3b3115e4-e493-4ea1-9406-01d656cd1189"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-128", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("3b7e0b1f-363f-417f-9b04-1639089ab476"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-149", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("3cea29f7-b21d-4105-a0bc-95c622ef9e2b"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-169", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("3e6cdab7-7a8e-45c9-8e53-020b54248a06"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-124", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("3fcc3b5b-d230-4433-bc7c-adbba9ebeac4"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-153", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("41c8a235-28a6-47df-93ad-db758ca47015"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-51", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("41fe867d-54db-4b65-b44d-e1d6bb008acf"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-94", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("4288761b-be53-4abc-b9f1-adce58973489"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-105", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("44ffb661-8d90-4031-a984-a661733bb063"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-123", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("455e5219-148f-4493-a484-fc9eed732bfc"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-188", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("47a6643c-23bc-4006-b43f-10cef807ceb6"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-14", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("4868206d-e067-4ced-816e-1046f02c0b9d"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-161", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("4af45f35-dcf6-4bcf-92a5-f6dc0a1ff6cc"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-131", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("4bb334c7-5d3b-4e61-8563-82dfdede7d5c"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-163", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("4be33054-28d0-4b6c-92ab-87f0a245a327"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-190", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("4d32715c-1dd9-4dda-b7fe-f36876197eb7"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-78", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("4d80d5d9-9a1d-4325-a9b2-98fe3ec8513a"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-114", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("4da4784e-e863-4f6f-b95b-5123246ef314"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-183", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("4db59d81-0d2c-46de-9e68-0fee7dd4a1b9"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-195", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("4e96eb2d-ac3c-4392-b3e0-4af9efdd2a47"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-110", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("4fc572a4-3950-4922-8d9b-bbcdcd077f4d"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-1", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("544b6598-9c9c-4974-ac8d-436b0374e85f"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-88", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("549b349a-2f08-4f11-9b6a-9c9b411785a8"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-98", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("57510cd7-737b-4e1c-897b-d3f498acb429"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-41", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("5a30e6ef-3047-4bfd-b6f9-98f2c6829d32"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-158", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("5ac3d2ef-c4d2-4377-ae63-1d7286c0ff77"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-152", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("5db7f5ab-4b98-4df7-82bd-b7329401f915"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-191", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("5f10fc96-64f1-4fb5-a750-9348766590a3"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-162", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("600b6fac-1742-43e4-a6d1-2c72007e7f2b"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-173", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("60c45917-63b5-460e-b30b-e37d4fd7fb83"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-159", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("63143432-e40b-4805-8ef4-bf9df37748e4"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-49", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("648a605a-5011-4f34-8aa8-4877ad303e54"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-175", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("64ebdc42-f2be-47e0-87d0-b447174492f3"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-145", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("672b6b2a-d2e6-4364-a4b6-549bc2517834"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-147", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("6941f0b4-45d4-4cfc-bc74-a14261ceb993"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-20", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("6cb3aad1-356b-4435-8753-e57b498ca4c4"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-24", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("71e16121-6d38-413a-8dbd-ca8bbe000a35"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-192", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("722237f9-bf1f-4a49-a447-2395ee181795"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-200", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("725a7940-0cf8-4fdd-a7c8-2f75e9b3ff28"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-143", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("7326aca7-5041-438f-a0b4-9f56c520023a"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-133", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("73649381-e9b7-43a3-94a7-9eb547645806"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-59", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("75146d89-a464-44f1-ae95-bcbdc3b943de"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-66", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("775726fe-2aa3-48df-9e93-866c19bd996a"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-13", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("78167945-078c-4a60-b1c3-841f3709ccac"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-48", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("791ddfbb-216f-4ace-801b-86381b4ab75d"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-56", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("792b78bb-9679-445b-8892-21e85e36c3da"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-2", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("7ad48c24-cb83-451b-91ae-f9e7f70195fd"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-120", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("7d46e770-86d2-4bb6-b2c0-1a2179efece1"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-144", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("7e50a191-016f-46f6-8d4b-e86520327666"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-111", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("7e6bec3b-aa8d-4085-b925-1c02c1a69b98"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-60", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("7fa25c63-4d96-4e8c-83f8-e6ed6241a193"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-77", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("835df545-19b5-465a-b318-265c1a2b9100"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-23", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("89655a9e-48e3-46c4-909f-47abe889b643"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-122", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("89dc88f4-5fc6-48da-8c55-3dffb560548b"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-198", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("8c2e5db4-ae68-480f-84cb-7b8a4824a0dc"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-7", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("8d786851-3a43-41d0-80af-5487c3237693"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-148", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("8e0c06df-c4fe-46b2-9137-db57f8bad3b4"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-31", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("8ed128ac-38ef-4570-84a3-6546d06d1d0f"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-16", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("8f7ec91d-53c5-4727-8fbc-c81fa362f584"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-70", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("919a33f8-0788-40db-a5a3-98d9b4abd172"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-139", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("91a05d83-cd18-485d-8ef7-2d5f685cf0a9"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-9", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("9477e69d-e096-4588-ac15-d795aaa8310c"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-42", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("95f96325-16c6-4cb9-8217-4fd20f8e2ec1"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-109", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("98fea8eb-9e8f-4eb1-a256-0553a947478a"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-26", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("9a3bf4ba-98a0-441c-9c88-ef567939ac5d"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-35", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("9a8fbf3e-b11e-438c-a299-d3ae7f43b9af"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-113", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("9c3190c9-6a1b-4b98-91f5-cb22a5ab92a8"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-101", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("9c93db4c-a6e1-43ea-8b95-028f10196e2c"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-193", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("9cd59022-9580-4a73-a21f-f2b217a75436"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-129", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("9e8fd25a-a602-47e9-913a-94b413d3eb0a"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-100", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("9ee289f6-00f9-4d49-9724-53d52ee555ae"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-189", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("9f2a1d24-7e82-4c96-95ca-fc6b4447f45c"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-154", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("a1429e97-5a23-4cb9-989a-c44f1940c839"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-108", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("a1597b83-643a-40dc-8b47-243fb43c6584"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-65", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("a3644880-b624-4d8d-a05e-89f37bc0e3cb"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-12", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("a4a7c03e-9a1c-48d1-a847-d6e75cce66e2"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-21", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("a54b0471-287c-4c32-b5ce-eff67f0efd09"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-182", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("a5c583de-e031-41b9-8f38-3491050ae321"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-64", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("a76dca57-69e6-4bda-9f2d-6c98d27cb1ec"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-57", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("a82214b3-d412-4dff-8663-7b8db391ed4d"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-19", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("a970d5c2-5468-47d6-9088-27422ff1ea43"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-45", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("aacc5e3b-4253-4631-aeaf-9b3a7c1e4910"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-90", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("ab27dedc-1b46-4844-b02d-e678b8c7621f"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-170", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("ab69c29f-ac7f-4357-b515-f34bc2993251"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-138", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("ae660485-06fa-4cba-b856-972a1fa7225e"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-76", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("af815875-898d-4501-b956-425737101725"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-68", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("afa24be7-b23a-4e12-87b7-a226a2fc8512"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-25", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("aff2e6b5-7e68-41da-bca0-d7bda6576c3c"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-166", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("b2a2bb11-01c3-4907-adee-67b66c45c6d6"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-197", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("b3a0a72c-f3d8-4fd4-bb35-ac06ab8e3235"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-4", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("b413c7b5-8d32-4ae5-93a9-67eef825c3e9"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-40", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("b468ebf5-e900-49a4-8ff1-d11e8074486e"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-22", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("b6f02257-431c-4f49-b6bf-a7d2e523ee0b"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-156", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("b7c931c5-98b4-4a4c-9bd6-7c959a6cd789"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-17", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("b8e110a5-8a33-42c0-9202-c2d1b0092793"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-15", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("b9bf432c-8317-432c-b737-74fbc7fe2174"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-115", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("ba704ad5-3701-41bf-8c0b-73b4b0ead2a0"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-39", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("bbe543ee-1736-49d3-a99a-39d60510873b"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-82", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("bc369b8b-ad13-4fce-a4d8-0fa3af33677b"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-104", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("bdbb5035-9296-449f-8031-0416f67330d3"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-89", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("be372ccb-ddb0-4831-96cb-c3da7eb710e9"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-135", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("bfe57479-bede-46f7-8241-b9a3901d7e35"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-141", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("c0c0381d-953f-42fa-a3f7-75d52b37366c"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-186", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("c1299cab-53ee-48ec-bad8-0e2daaabb72c"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-127", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("c1d79d3c-5a74-46ac-9f0d-32ed6be5695c"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-177", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("c21b7663-ab35-4e26-93a0-e3ee871fa7fa"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-50", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("c240ff63-f2c1-4abc-b52e-d1563af091c5"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-165", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("c3047815-83f4-4e6a-89b6-f73398d664f2"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-8", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("c5878d16-6f89-4950-9512-3c9a22d2390c"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-79", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("c66d3bc7-3989-4973-80c8-98d5d0cfd0c3"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-18", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("c6aa873d-b8f6-4159-a3c3-b7749608cc8e"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-58", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("cafd5bfd-18ee-4b57-b522-3bee56c23639"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-28", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("cfb5547a-8e5c-47b0-85b2-0470ab1665fe"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-75", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("d2c9b079-f973-4894-afbd-605cb1ca5aa9"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-47", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("d46faf8e-ac78-439a-af5f-982876451809"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-87", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("d535450a-f276-494c-bfe5-f4ef690cb7e1"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-92", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("d73bf0be-dea2-4cb4-a2a3-d5e2da30d91c"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-32", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("d74ba646-5a55-4799-bff2-9f99070d3bba"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-142", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("d8ba923f-b2b2-4f52-97d3-607029250ec6"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-137", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("d9a8fa29-1bdf-4529-a157-799b89c51669"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-184", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("dcbfbc9f-6d43-4c39-9a5f-8e5d6381e039"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-164", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("dd34dadd-cc2d-43a5-9d9a-5aa6deefefc7"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-44", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("dde24248-d933-4811-ae4a-0639efa57150"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-126", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("de28a8ba-132b-48d0-a6aa-390754f06838"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-106", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("e2c0b5de-9db9-4320-be64-c831996714e5"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-136", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("e407e004-c38d-47d5-99b7-ddcbf7c9eb14"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-55", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("e4ae3a64-3dbb-4443-9263-344bff0bcc0b"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-187", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("e512a5df-3ab9-42aa-b6c1-f2e345dd6427"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-140", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("e6c82700-f8b7-407c-abad-a311a6ab7126"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-134", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("e7f21b0c-2315-4f1a-81f4-1c8d4b6a8fe6"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-27", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("e8ac4309-802b-4093-b051-783721e3fa4d"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-52", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("ea565302-21f6-4379-a444-298d635eee74"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-151", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("ec5c1c11-50df-47d6-af0c-d4259f878d77"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-61", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("edb8e025-c60f-4adf-9a5b-c1ace73cb7aa"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-185", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("ee5d7c3a-5e00-4f10-a75b-6a9175f9fb55"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-178", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("eea6569f-4485-4111-86cb-0b3d81684b32"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-130", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("f0bcf8ad-d01b-4f7a-ad19-614a3e51a8db"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-53", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("f0ee7d6b-3118-4fa8-a75f-67386a637489"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-43", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("f0f96b1f-4371-426b-8ebb-dfb06ddaf40e"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-196", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("f2268ce4-adb1-4185-8059-72aa2de7faa6"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-80", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("f25c2c9e-5aa0-4c96-bbab-b78be8a11340"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-118", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("f285ea90-73fd-4e06-bb8d-22eb1943ca59"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-11", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("f31ee530-2706-4ab2-9583-616cdf0b86b2"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-36", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("f3482ec4-ffe6-4cec-8b31-70c114e6544a"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-62", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("f4012e1f-9090-4e05-8770-9c2c75dd3d10"), new Guid("495bb669-1f9f-4f0d-8cc4-f2b0637032c5"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-5", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") },
                    { new Guid("f4d0dce8-27de-42ce-bb30-edb1ec650090"), new Guid("8ad4bd9c-4085-4771-b3db-6f4697ec2fc2"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-85", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("fa8b52a1-f8f6-45e0-aded-15e817fe23b9"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-146", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("fb64710e-e858-49a1-87f8-3597b46cf973"), new Guid("d44937dd-2b8d-4cf9-ba10-cbdf458df0db"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-168", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4c700425-20cf-45db-b25d-0eeb2e5d57c5") },
                    { new Guid("fc364525-c09f-4dcb-a051-cad96f65fd1b"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-150", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("72481c79-1d5d-4e93-b1d1-0f0545ec01fb") },
                    { new Guid("fd0d0d0f-8714-4007-8f61-e01097aeb176"), new Guid("53b652d0-1b8a-4a72-a45d-f2dadb5ce2d9"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-95", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("fd0e2552-c4d7-4686-b951-1d0840ccd7e2"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-71", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("f66c5b81-4fdd-4bea-951e-a3fbd16b9d3b") },
                    { new Guid("ff86c0c3-29ce-4d44-8541-c965b5a6a00f"), new Guid("7266fbd5-0e7e-4bd0-9794-efd4d4771bdf"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), "HP-30", "Active", 0, null, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, null, new Guid("4a5eb835-0ca8-453b-a790-e2404671ff42") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BorrowLends",
                columns: new[] { "Id", "BorrowDate", "BorrowStatus", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "DueDate", "FeeAmount", "HasFee", "IsDeleted", "IsDeletedById", "IsLate", "LastModifiedById", "LastModifiedDateUnix", "LateDurationInDays", "MemberId", "ReturnDate", "StaffLenderId", "WorkCatalogId", "WorkInventoryId" },
                values: new object[,]
                {
                    { new Guid("4afb9a57-d250-48ba-b520-8fc09b1ecd48"), new DateTime(2024, 4, 21, 18, 7, 25, 121, DateTimeKind.Local).AddTicks(6947), "Returned", new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, new DateTime(2024, 5, 1, 18, 7, 25, 121, DateTimeKind.Local).AddTicks(6984), 0m, false, false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, 0, new Guid("c3181c17-0116-495b-9fd9-cda9ae7bca9c"), new DateTime(2024, 5, 1, 18, 7, 25, 121, DateTimeKind.Local).AddTicks(6985), new Guid("f0290ada-2668-48af-898c-a87a2cb14f28"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), new Guid("f4012e1f-9090-4e05-8770-9c2c75dd3d10") },
                    { new Guid("77f8a7c2-fa3a-40ab-82c6-f519b2cd46c6"), new DateTime(2024, 4, 21, 18, 7, 25, 121, DateTimeKind.Local).AddTicks(7064), "Borrowed", new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, new DateTime(2024, 4, 30, 18, 7, 25, 121, DateTimeKind.Local).AddTicks(7066), 0m, false, false, new Guid("00000000-0000-0000-0000-000000000000"), false, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, 0, new Guid("650b5c5c-2833-4539-805b-c055e87ae21e"), null, new Guid("f0290ada-2668-48af-898c-a87a2cb14f28"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), new Guid("b8e110a5-8a33-42c0-9202-c2d1b0092793") },
                    { new Guid("f3959019-63cf-475c-8eed-a2590d355512"), new DateTime(2024, 4, 21, 18, 7, 25, 121, DateTimeKind.Local).AddTicks(7049), "DelayedReturn", new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), 1714586845L, null, new DateTime(2024, 4, 30, 18, 7, 25, 121, DateTimeKind.Local).AddTicks(7052), 0m, false, false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("fa7f4b6d-2de7-42a6-a69c-0631e879983c"), null, 1, new Guid("650b5c5c-2833-4539-805b-c055e87ae21e"), new DateTime(2024, 5, 1, 18, 7, 25, 121, DateTimeKind.Local).AddTicks(7053), new Guid("f0290ada-2668-48af-898c-a87a2cb14f28"), new Guid("8fa9a7f6-4285-4e41-9b72-5713e75abfa9"), new Guid("0f1f0aff-f449-43e8-8fbb-2e53b38f30e2") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Edition_WorkInventories",
                columns: new[] { "EditionId", "WorkInventoryId" },
                values: new object[,]
                {
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("00e107c6-a505-4840-9062-c51bf8f2e6eb") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("00e107c6-a505-4840-9062-c51bf8f2e6eb") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("00e107c6-a505-4840-9062-c51bf8f2e6eb") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("034a9188-e681-422c-b1bc-627366d4f552") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("034a9188-e681-422c-b1bc-627366d4f552") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("034a9188-e681-422c-b1bc-627366d4f552") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("03e55897-2a15-49d2-ad76-f906e5c7f6e9") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("03e55897-2a15-49d2-ad76-f906e5c7f6e9") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("03e55897-2a15-49d2-ad76-f906e5c7f6e9") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("04757b70-5a00-4a66-a024-5be7c9d3738b") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("04757b70-5a00-4a66-a024-5be7c9d3738b") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("04757b70-5a00-4a66-a024-5be7c9d3738b") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("065711d8-c1b1-4cb5-a4f4-34cc54ac3648") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("065711d8-c1b1-4cb5-a4f4-34cc54ac3648") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("065711d8-c1b1-4cb5-a4f4-34cc54ac3648") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("09928f85-004f-4b7f-8168-1af079e557d7") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("09928f85-004f-4b7f-8168-1af079e557d7") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("09928f85-004f-4b7f-8168-1af079e557d7") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("0a1df5f0-652c-4af8-92f7-c6451fc02601") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("0a1df5f0-652c-4af8-92f7-c6451fc02601") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("0a1df5f0-652c-4af8-92f7-c6451fc02601") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("0c2e8b24-5fd4-4aa0-b002-7bbbf2300bb5") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("0c2e8b24-5fd4-4aa0-b002-7bbbf2300bb5") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("0c2e8b24-5fd4-4aa0-b002-7bbbf2300bb5") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("0c95266e-2d54-49d0-b6a8-a727af27165c") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("0c95266e-2d54-49d0-b6a8-a727af27165c") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("0c95266e-2d54-49d0-b6a8-a727af27165c") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("0cb6af86-d4f3-4e61-9a4d-9124379644da") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("0cb6af86-d4f3-4e61-9a4d-9124379644da") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("0cb6af86-d4f3-4e61-9a4d-9124379644da") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("0d2884bf-3bf2-433e-9742-2a6ccbc8ac1b") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("0d2884bf-3bf2-433e-9742-2a6ccbc8ac1b") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("0d2884bf-3bf2-433e-9742-2a6ccbc8ac1b") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("0d568200-ac80-45be-8c75-399b9471ca02") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("0d568200-ac80-45be-8c75-399b9471ca02") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("0d568200-ac80-45be-8c75-399b9471ca02") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("0dbac186-e155-4aff-bbce-fd62c0eaab1c") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("0dbac186-e155-4aff-bbce-fd62c0eaab1c") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("0dbac186-e155-4aff-bbce-fd62c0eaab1c") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("0e1a8071-7c31-410d-b38b-83330c55b044") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("0e1a8071-7c31-410d-b38b-83330c55b044") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("0e1a8071-7c31-410d-b38b-83330c55b044") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("0f1f0aff-f449-43e8-8fbb-2e53b38f30e2") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("0f1f0aff-f449-43e8-8fbb-2e53b38f30e2") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("0f1f0aff-f449-43e8-8fbb-2e53b38f30e2") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("0f5e00a8-dc5d-4b38-b26c-96905900b232") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("0f5e00a8-dc5d-4b38-b26c-96905900b232") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("0f5e00a8-dc5d-4b38-b26c-96905900b232") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("1101d667-087b-4b96-bcae-c1c4d9e129db") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("1101d667-087b-4b96-bcae-c1c4d9e129db") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("1101d667-087b-4b96-bcae-c1c4d9e129db") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("12c081a3-62a7-4656-b620-f5b53aa65a38") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("12c081a3-62a7-4656-b620-f5b53aa65a38") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("12c081a3-62a7-4656-b620-f5b53aa65a38") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("12e736b2-368d-4fe7-9191-995f6c12eb52") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("12e736b2-368d-4fe7-9191-995f6c12eb52") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("12e736b2-368d-4fe7-9191-995f6c12eb52") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("12f438df-64e2-45bb-a379-568e3500933a") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("12f438df-64e2-45bb-a379-568e3500933a") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("12f438df-64e2-45bb-a379-568e3500933a") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("131fa718-b850-46eb-b0fd-cece0e420875") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("131fa718-b850-46eb-b0fd-cece0e420875") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("131fa718-b850-46eb-b0fd-cece0e420875") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("1454eb56-d435-4610-b23c-ee40bd437215") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("1454eb56-d435-4610-b23c-ee40bd437215") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("1454eb56-d435-4610-b23c-ee40bd437215") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("155fb4e6-7bf0-4ee8-8c70-983c6bb31a55") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("155fb4e6-7bf0-4ee8-8c70-983c6bb31a55") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("155fb4e6-7bf0-4ee8-8c70-983c6bb31a55") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("1674c3f6-0cfb-49ac-9548-811c0fbb5b66") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("1674c3f6-0cfb-49ac-9548-811c0fbb5b66") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("1674c3f6-0cfb-49ac-9548-811c0fbb5b66") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("17bf37bc-9e03-4ef4-ba59-8cc7ece5e8d4") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("17bf37bc-9e03-4ef4-ba59-8cc7ece5e8d4") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("17bf37bc-9e03-4ef4-ba59-8cc7ece5e8d4") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("183e0cc3-6cfb-4cfb-b436-0280030660dc") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("183e0cc3-6cfb-4cfb-b436-0280030660dc") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("183e0cc3-6cfb-4cfb-b436-0280030660dc") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("19f89ed0-b319-44dd-a6a3-1c7055ede531") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("19f89ed0-b319-44dd-a6a3-1c7055ede531") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("19f89ed0-b319-44dd-a6a3-1c7055ede531") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("19f8d096-00f2-432b-bb24-4e84d462a6f2") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("19f8d096-00f2-432b-bb24-4e84d462a6f2") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("19f8d096-00f2-432b-bb24-4e84d462a6f2") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("1a4ae726-26c9-42cf-9f18-018fba6bd315") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("1a4ae726-26c9-42cf-9f18-018fba6bd315") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("1a4ae726-26c9-42cf-9f18-018fba6bd315") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("1aa1a4d7-c1d1-4249-9146-46ee040e8bd5") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("1aa1a4d7-c1d1-4249-9146-46ee040e8bd5") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("1aa1a4d7-c1d1-4249-9146-46ee040e8bd5") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("1c458204-e5a2-432d-bfe3-fae6fcd7c218") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("1c458204-e5a2-432d-bfe3-fae6fcd7c218") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("1c458204-e5a2-432d-bfe3-fae6fcd7c218") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("2006bf3b-213e-43ba-9411-38e51925f1f5") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("2006bf3b-213e-43ba-9411-38e51925f1f5") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("2006bf3b-213e-43ba-9411-38e51925f1f5") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("2093209a-8898-4b1f-bbe3-5de8f1991bbb") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("2093209a-8898-4b1f-bbe3-5de8f1991bbb") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("2093209a-8898-4b1f-bbe3-5de8f1991bbb") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("222ef5b7-c98a-4c25-81aa-730193249108") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("222ef5b7-c98a-4c25-81aa-730193249108") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("222ef5b7-c98a-4c25-81aa-730193249108") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("22be3bfa-c2f4-45fc-a18c-fb2ea2dd3810") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("22be3bfa-c2f4-45fc-a18c-fb2ea2dd3810") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("22be3bfa-c2f4-45fc-a18c-fb2ea2dd3810") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("234729bc-e29d-495e-9d1b-87fb236d8a5b") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("234729bc-e29d-495e-9d1b-87fb236d8a5b") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("234729bc-e29d-495e-9d1b-87fb236d8a5b") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("235303c7-8985-4ffb-962f-b182e718a8de") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("235303c7-8985-4ffb-962f-b182e718a8de") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("235303c7-8985-4ffb-962f-b182e718a8de") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("237dc3bb-1bc5-4443-8ca4-6e870243503b") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("237dc3bb-1bc5-4443-8ca4-6e870243503b") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("237dc3bb-1bc5-4443-8ca4-6e870243503b") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("24903cd7-b7a6-47ee-be62-f001a975cbe0") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("24903cd7-b7a6-47ee-be62-f001a975cbe0") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("24903cd7-b7a6-47ee-be62-f001a975cbe0") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("2c6edac6-087b-49de-bf43-371393da0409") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("2c6edac6-087b-49de-bf43-371393da0409") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("2c6edac6-087b-49de-bf43-371393da0409") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("2cbb1298-f828-40f4-9d11-1a794606da97") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("2cbb1298-f828-40f4-9d11-1a794606da97") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("2cbb1298-f828-40f4-9d11-1a794606da97") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("2e335d71-c894-4fed-897a-f44d31dc3bd3") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("2e335d71-c894-4fed-897a-f44d31dc3bd3") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("2e335d71-c894-4fed-897a-f44d31dc3bd3") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("2f8b7551-8ac8-467b-8e2e-ed4ff0b92786") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("2f8b7551-8ac8-467b-8e2e-ed4ff0b92786") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("2f8b7551-8ac8-467b-8e2e-ed4ff0b92786") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("301b3944-d368-42f7-95ea-93acfd8182aa") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("301b3944-d368-42f7-95ea-93acfd8182aa") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("301b3944-d368-42f7-95ea-93acfd8182aa") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("33ac04b5-9382-48b4-99e1-a8a89bc36ba4") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("33ac04b5-9382-48b4-99e1-a8a89bc36ba4") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("33ac04b5-9382-48b4-99e1-a8a89bc36ba4") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("369bc41e-8a8e-4f98-8fa6-1a7d805a0c57") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("369bc41e-8a8e-4f98-8fa6-1a7d805a0c57") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("369bc41e-8a8e-4f98-8fa6-1a7d805a0c57") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("375c0328-eeaf-4f7c-9a1e-7e6d2fd30215") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("375c0328-eeaf-4f7c-9a1e-7e6d2fd30215") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("375c0328-eeaf-4f7c-9a1e-7e6d2fd30215") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("39cee64c-886a-4a0a-91a3-42d0afc419a5") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("39cee64c-886a-4a0a-91a3-42d0afc419a5") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("39cee64c-886a-4a0a-91a3-42d0afc419a5") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("3b3115e4-e493-4ea1-9406-01d656cd1189") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("3b3115e4-e493-4ea1-9406-01d656cd1189") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("3b3115e4-e493-4ea1-9406-01d656cd1189") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("3b7e0b1f-363f-417f-9b04-1639089ab476") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("3b7e0b1f-363f-417f-9b04-1639089ab476") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("3b7e0b1f-363f-417f-9b04-1639089ab476") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("3cea29f7-b21d-4105-a0bc-95c622ef9e2b") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("3cea29f7-b21d-4105-a0bc-95c622ef9e2b") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("3cea29f7-b21d-4105-a0bc-95c622ef9e2b") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("3e6cdab7-7a8e-45c9-8e53-020b54248a06") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("3e6cdab7-7a8e-45c9-8e53-020b54248a06") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("3e6cdab7-7a8e-45c9-8e53-020b54248a06") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("3fcc3b5b-d230-4433-bc7c-adbba9ebeac4") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("3fcc3b5b-d230-4433-bc7c-adbba9ebeac4") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("3fcc3b5b-d230-4433-bc7c-adbba9ebeac4") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("41c8a235-28a6-47df-93ad-db758ca47015") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("41c8a235-28a6-47df-93ad-db758ca47015") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("41c8a235-28a6-47df-93ad-db758ca47015") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("41fe867d-54db-4b65-b44d-e1d6bb008acf") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("41fe867d-54db-4b65-b44d-e1d6bb008acf") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("41fe867d-54db-4b65-b44d-e1d6bb008acf") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("4288761b-be53-4abc-b9f1-adce58973489") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("4288761b-be53-4abc-b9f1-adce58973489") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("4288761b-be53-4abc-b9f1-adce58973489") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("44ffb661-8d90-4031-a984-a661733bb063") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("44ffb661-8d90-4031-a984-a661733bb063") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("44ffb661-8d90-4031-a984-a661733bb063") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("455e5219-148f-4493-a484-fc9eed732bfc") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("455e5219-148f-4493-a484-fc9eed732bfc") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("455e5219-148f-4493-a484-fc9eed732bfc") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("47a6643c-23bc-4006-b43f-10cef807ceb6") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("47a6643c-23bc-4006-b43f-10cef807ceb6") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("47a6643c-23bc-4006-b43f-10cef807ceb6") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("4868206d-e067-4ced-816e-1046f02c0b9d") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("4868206d-e067-4ced-816e-1046f02c0b9d") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("4868206d-e067-4ced-816e-1046f02c0b9d") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("4af45f35-dcf6-4bcf-92a5-f6dc0a1ff6cc") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("4af45f35-dcf6-4bcf-92a5-f6dc0a1ff6cc") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("4af45f35-dcf6-4bcf-92a5-f6dc0a1ff6cc") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("4bb334c7-5d3b-4e61-8563-82dfdede7d5c") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("4bb334c7-5d3b-4e61-8563-82dfdede7d5c") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("4bb334c7-5d3b-4e61-8563-82dfdede7d5c") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("4be33054-28d0-4b6c-92ab-87f0a245a327") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("4be33054-28d0-4b6c-92ab-87f0a245a327") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("4be33054-28d0-4b6c-92ab-87f0a245a327") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("4d32715c-1dd9-4dda-b7fe-f36876197eb7") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("4d32715c-1dd9-4dda-b7fe-f36876197eb7") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("4d32715c-1dd9-4dda-b7fe-f36876197eb7") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("4d80d5d9-9a1d-4325-a9b2-98fe3ec8513a") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("4d80d5d9-9a1d-4325-a9b2-98fe3ec8513a") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("4d80d5d9-9a1d-4325-a9b2-98fe3ec8513a") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("4da4784e-e863-4f6f-b95b-5123246ef314") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("4da4784e-e863-4f6f-b95b-5123246ef314") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("4da4784e-e863-4f6f-b95b-5123246ef314") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("4db59d81-0d2c-46de-9e68-0fee7dd4a1b9") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("4db59d81-0d2c-46de-9e68-0fee7dd4a1b9") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("4db59d81-0d2c-46de-9e68-0fee7dd4a1b9") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("4e96eb2d-ac3c-4392-b3e0-4af9efdd2a47") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("4e96eb2d-ac3c-4392-b3e0-4af9efdd2a47") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("4e96eb2d-ac3c-4392-b3e0-4af9efdd2a47") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("4fc572a4-3950-4922-8d9b-bbcdcd077f4d") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("4fc572a4-3950-4922-8d9b-bbcdcd077f4d") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("4fc572a4-3950-4922-8d9b-bbcdcd077f4d") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("544b6598-9c9c-4974-ac8d-436b0374e85f") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("544b6598-9c9c-4974-ac8d-436b0374e85f") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("544b6598-9c9c-4974-ac8d-436b0374e85f") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("549b349a-2f08-4f11-9b6a-9c9b411785a8") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("549b349a-2f08-4f11-9b6a-9c9b411785a8") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("549b349a-2f08-4f11-9b6a-9c9b411785a8") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("57510cd7-737b-4e1c-897b-d3f498acb429") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("57510cd7-737b-4e1c-897b-d3f498acb429") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("57510cd7-737b-4e1c-897b-d3f498acb429") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("5a30e6ef-3047-4bfd-b6f9-98f2c6829d32") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("5a30e6ef-3047-4bfd-b6f9-98f2c6829d32") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("5a30e6ef-3047-4bfd-b6f9-98f2c6829d32") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("5ac3d2ef-c4d2-4377-ae63-1d7286c0ff77") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("5ac3d2ef-c4d2-4377-ae63-1d7286c0ff77") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("5ac3d2ef-c4d2-4377-ae63-1d7286c0ff77") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("5db7f5ab-4b98-4df7-82bd-b7329401f915") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("5db7f5ab-4b98-4df7-82bd-b7329401f915") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("5db7f5ab-4b98-4df7-82bd-b7329401f915") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("5f10fc96-64f1-4fb5-a750-9348766590a3") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("5f10fc96-64f1-4fb5-a750-9348766590a3") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("5f10fc96-64f1-4fb5-a750-9348766590a3") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("600b6fac-1742-43e4-a6d1-2c72007e7f2b") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("600b6fac-1742-43e4-a6d1-2c72007e7f2b") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("600b6fac-1742-43e4-a6d1-2c72007e7f2b") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("60c45917-63b5-460e-b30b-e37d4fd7fb83") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("60c45917-63b5-460e-b30b-e37d4fd7fb83") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("60c45917-63b5-460e-b30b-e37d4fd7fb83") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("63143432-e40b-4805-8ef4-bf9df37748e4") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("63143432-e40b-4805-8ef4-bf9df37748e4") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("63143432-e40b-4805-8ef4-bf9df37748e4") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("648a605a-5011-4f34-8aa8-4877ad303e54") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("648a605a-5011-4f34-8aa8-4877ad303e54") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("648a605a-5011-4f34-8aa8-4877ad303e54") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("64ebdc42-f2be-47e0-87d0-b447174492f3") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("64ebdc42-f2be-47e0-87d0-b447174492f3") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("64ebdc42-f2be-47e0-87d0-b447174492f3") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("672b6b2a-d2e6-4364-a4b6-549bc2517834") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("672b6b2a-d2e6-4364-a4b6-549bc2517834") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("672b6b2a-d2e6-4364-a4b6-549bc2517834") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("6941f0b4-45d4-4cfc-bc74-a14261ceb993") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("6941f0b4-45d4-4cfc-bc74-a14261ceb993") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("6941f0b4-45d4-4cfc-bc74-a14261ceb993") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("6cb3aad1-356b-4435-8753-e57b498ca4c4") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("6cb3aad1-356b-4435-8753-e57b498ca4c4") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("6cb3aad1-356b-4435-8753-e57b498ca4c4") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("71e16121-6d38-413a-8dbd-ca8bbe000a35") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("71e16121-6d38-413a-8dbd-ca8bbe000a35") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("71e16121-6d38-413a-8dbd-ca8bbe000a35") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("722237f9-bf1f-4a49-a447-2395ee181795") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("722237f9-bf1f-4a49-a447-2395ee181795") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("722237f9-bf1f-4a49-a447-2395ee181795") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("725a7940-0cf8-4fdd-a7c8-2f75e9b3ff28") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("725a7940-0cf8-4fdd-a7c8-2f75e9b3ff28") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("725a7940-0cf8-4fdd-a7c8-2f75e9b3ff28") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("7326aca7-5041-438f-a0b4-9f56c520023a") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("7326aca7-5041-438f-a0b4-9f56c520023a") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("7326aca7-5041-438f-a0b4-9f56c520023a") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("73649381-e9b7-43a3-94a7-9eb547645806") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("73649381-e9b7-43a3-94a7-9eb547645806") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("73649381-e9b7-43a3-94a7-9eb547645806") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("75146d89-a464-44f1-ae95-bcbdc3b943de") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("75146d89-a464-44f1-ae95-bcbdc3b943de") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("75146d89-a464-44f1-ae95-bcbdc3b943de") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("775726fe-2aa3-48df-9e93-866c19bd996a") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("775726fe-2aa3-48df-9e93-866c19bd996a") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("775726fe-2aa3-48df-9e93-866c19bd996a") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("78167945-078c-4a60-b1c3-841f3709ccac") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("78167945-078c-4a60-b1c3-841f3709ccac") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("78167945-078c-4a60-b1c3-841f3709ccac") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("791ddfbb-216f-4ace-801b-86381b4ab75d") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("791ddfbb-216f-4ace-801b-86381b4ab75d") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("791ddfbb-216f-4ace-801b-86381b4ab75d") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("792b78bb-9679-445b-8892-21e85e36c3da") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("792b78bb-9679-445b-8892-21e85e36c3da") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("792b78bb-9679-445b-8892-21e85e36c3da") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("7ad48c24-cb83-451b-91ae-f9e7f70195fd") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("7ad48c24-cb83-451b-91ae-f9e7f70195fd") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("7ad48c24-cb83-451b-91ae-f9e7f70195fd") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("7d46e770-86d2-4bb6-b2c0-1a2179efece1") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("7d46e770-86d2-4bb6-b2c0-1a2179efece1") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("7d46e770-86d2-4bb6-b2c0-1a2179efece1") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("7e50a191-016f-46f6-8d4b-e86520327666") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("7e50a191-016f-46f6-8d4b-e86520327666") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("7e50a191-016f-46f6-8d4b-e86520327666") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("7e6bec3b-aa8d-4085-b925-1c02c1a69b98") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("7e6bec3b-aa8d-4085-b925-1c02c1a69b98") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("7e6bec3b-aa8d-4085-b925-1c02c1a69b98") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("7fa25c63-4d96-4e8c-83f8-e6ed6241a193") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("7fa25c63-4d96-4e8c-83f8-e6ed6241a193") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("7fa25c63-4d96-4e8c-83f8-e6ed6241a193") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("835df545-19b5-465a-b318-265c1a2b9100") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("835df545-19b5-465a-b318-265c1a2b9100") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("835df545-19b5-465a-b318-265c1a2b9100") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("89655a9e-48e3-46c4-909f-47abe889b643") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("89655a9e-48e3-46c4-909f-47abe889b643") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("89655a9e-48e3-46c4-909f-47abe889b643") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("89dc88f4-5fc6-48da-8c55-3dffb560548b") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("89dc88f4-5fc6-48da-8c55-3dffb560548b") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("89dc88f4-5fc6-48da-8c55-3dffb560548b") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("8c2e5db4-ae68-480f-84cb-7b8a4824a0dc") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("8c2e5db4-ae68-480f-84cb-7b8a4824a0dc") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("8c2e5db4-ae68-480f-84cb-7b8a4824a0dc") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("8d786851-3a43-41d0-80af-5487c3237693") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("8d786851-3a43-41d0-80af-5487c3237693") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("8d786851-3a43-41d0-80af-5487c3237693") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("8e0c06df-c4fe-46b2-9137-db57f8bad3b4") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("8e0c06df-c4fe-46b2-9137-db57f8bad3b4") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("8e0c06df-c4fe-46b2-9137-db57f8bad3b4") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("8ed128ac-38ef-4570-84a3-6546d06d1d0f") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("8ed128ac-38ef-4570-84a3-6546d06d1d0f") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("8ed128ac-38ef-4570-84a3-6546d06d1d0f") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("8f7ec91d-53c5-4727-8fbc-c81fa362f584") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("8f7ec91d-53c5-4727-8fbc-c81fa362f584") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("8f7ec91d-53c5-4727-8fbc-c81fa362f584") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("919a33f8-0788-40db-a5a3-98d9b4abd172") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("919a33f8-0788-40db-a5a3-98d9b4abd172") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("919a33f8-0788-40db-a5a3-98d9b4abd172") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("91a05d83-cd18-485d-8ef7-2d5f685cf0a9") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("91a05d83-cd18-485d-8ef7-2d5f685cf0a9") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("91a05d83-cd18-485d-8ef7-2d5f685cf0a9") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("9477e69d-e096-4588-ac15-d795aaa8310c") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("9477e69d-e096-4588-ac15-d795aaa8310c") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("9477e69d-e096-4588-ac15-d795aaa8310c") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("95f96325-16c6-4cb9-8217-4fd20f8e2ec1") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("95f96325-16c6-4cb9-8217-4fd20f8e2ec1") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("95f96325-16c6-4cb9-8217-4fd20f8e2ec1") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("98fea8eb-9e8f-4eb1-a256-0553a947478a") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("98fea8eb-9e8f-4eb1-a256-0553a947478a") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("98fea8eb-9e8f-4eb1-a256-0553a947478a") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("9a3bf4ba-98a0-441c-9c88-ef567939ac5d") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("9a3bf4ba-98a0-441c-9c88-ef567939ac5d") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("9a3bf4ba-98a0-441c-9c88-ef567939ac5d") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("9a8fbf3e-b11e-438c-a299-d3ae7f43b9af") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("9a8fbf3e-b11e-438c-a299-d3ae7f43b9af") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("9a8fbf3e-b11e-438c-a299-d3ae7f43b9af") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("9c3190c9-6a1b-4b98-91f5-cb22a5ab92a8") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("9c3190c9-6a1b-4b98-91f5-cb22a5ab92a8") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("9c3190c9-6a1b-4b98-91f5-cb22a5ab92a8") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("9c93db4c-a6e1-43ea-8b95-028f10196e2c") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("9c93db4c-a6e1-43ea-8b95-028f10196e2c") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("9c93db4c-a6e1-43ea-8b95-028f10196e2c") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("9cd59022-9580-4a73-a21f-f2b217a75436") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("9cd59022-9580-4a73-a21f-f2b217a75436") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("9cd59022-9580-4a73-a21f-f2b217a75436") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("9e8fd25a-a602-47e9-913a-94b413d3eb0a") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("9e8fd25a-a602-47e9-913a-94b413d3eb0a") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("9e8fd25a-a602-47e9-913a-94b413d3eb0a") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("9ee289f6-00f9-4d49-9724-53d52ee555ae") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("9ee289f6-00f9-4d49-9724-53d52ee555ae") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("9ee289f6-00f9-4d49-9724-53d52ee555ae") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("9f2a1d24-7e82-4c96-95ca-fc6b4447f45c") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("9f2a1d24-7e82-4c96-95ca-fc6b4447f45c") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("9f2a1d24-7e82-4c96-95ca-fc6b4447f45c") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("a1429e97-5a23-4cb9-989a-c44f1940c839") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("a1429e97-5a23-4cb9-989a-c44f1940c839") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("a1429e97-5a23-4cb9-989a-c44f1940c839") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("a1597b83-643a-40dc-8b47-243fb43c6584") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("a1597b83-643a-40dc-8b47-243fb43c6584") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("a1597b83-643a-40dc-8b47-243fb43c6584") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("a3644880-b624-4d8d-a05e-89f37bc0e3cb") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("a3644880-b624-4d8d-a05e-89f37bc0e3cb") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("a3644880-b624-4d8d-a05e-89f37bc0e3cb") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("a4a7c03e-9a1c-48d1-a847-d6e75cce66e2") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("a4a7c03e-9a1c-48d1-a847-d6e75cce66e2") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("a4a7c03e-9a1c-48d1-a847-d6e75cce66e2") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("a54b0471-287c-4c32-b5ce-eff67f0efd09") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("a54b0471-287c-4c32-b5ce-eff67f0efd09") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("a54b0471-287c-4c32-b5ce-eff67f0efd09") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("a5c583de-e031-41b9-8f38-3491050ae321") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("a5c583de-e031-41b9-8f38-3491050ae321") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("a5c583de-e031-41b9-8f38-3491050ae321") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("a76dca57-69e6-4bda-9f2d-6c98d27cb1ec") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("a76dca57-69e6-4bda-9f2d-6c98d27cb1ec") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("a76dca57-69e6-4bda-9f2d-6c98d27cb1ec") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("a82214b3-d412-4dff-8663-7b8db391ed4d") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("a82214b3-d412-4dff-8663-7b8db391ed4d") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("a82214b3-d412-4dff-8663-7b8db391ed4d") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("a970d5c2-5468-47d6-9088-27422ff1ea43") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("a970d5c2-5468-47d6-9088-27422ff1ea43") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("a970d5c2-5468-47d6-9088-27422ff1ea43") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("aacc5e3b-4253-4631-aeaf-9b3a7c1e4910") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("aacc5e3b-4253-4631-aeaf-9b3a7c1e4910") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("aacc5e3b-4253-4631-aeaf-9b3a7c1e4910") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("ab27dedc-1b46-4844-b02d-e678b8c7621f") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("ab27dedc-1b46-4844-b02d-e678b8c7621f") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("ab27dedc-1b46-4844-b02d-e678b8c7621f") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("ab69c29f-ac7f-4357-b515-f34bc2993251") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("ab69c29f-ac7f-4357-b515-f34bc2993251") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("ab69c29f-ac7f-4357-b515-f34bc2993251") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("ae660485-06fa-4cba-b856-972a1fa7225e") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("ae660485-06fa-4cba-b856-972a1fa7225e") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("ae660485-06fa-4cba-b856-972a1fa7225e") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("af815875-898d-4501-b956-425737101725") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("af815875-898d-4501-b956-425737101725") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("af815875-898d-4501-b956-425737101725") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("afa24be7-b23a-4e12-87b7-a226a2fc8512") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("afa24be7-b23a-4e12-87b7-a226a2fc8512") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("afa24be7-b23a-4e12-87b7-a226a2fc8512") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("aff2e6b5-7e68-41da-bca0-d7bda6576c3c") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("aff2e6b5-7e68-41da-bca0-d7bda6576c3c") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("aff2e6b5-7e68-41da-bca0-d7bda6576c3c") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("b2a2bb11-01c3-4907-adee-67b66c45c6d6") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("b2a2bb11-01c3-4907-adee-67b66c45c6d6") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("b2a2bb11-01c3-4907-adee-67b66c45c6d6") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("b3a0a72c-f3d8-4fd4-bb35-ac06ab8e3235") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("b3a0a72c-f3d8-4fd4-bb35-ac06ab8e3235") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("b3a0a72c-f3d8-4fd4-bb35-ac06ab8e3235") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("b413c7b5-8d32-4ae5-93a9-67eef825c3e9") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("b413c7b5-8d32-4ae5-93a9-67eef825c3e9") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("b413c7b5-8d32-4ae5-93a9-67eef825c3e9") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("b468ebf5-e900-49a4-8ff1-d11e8074486e") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("b468ebf5-e900-49a4-8ff1-d11e8074486e") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("b468ebf5-e900-49a4-8ff1-d11e8074486e") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("b6f02257-431c-4f49-b6bf-a7d2e523ee0b") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("b6f02257-431c-4f49-b6bf-a7d2e523ee0b") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("b6f02257-431c-4f49-b6bf-a7d2e523ee0b") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("b7c931c5-98b4-4a4c-9bd6-7c959a6cd789") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("b7c931c5-98b4-4a4c-9bd6-7c959a6cd789") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("b7c931c5-98b4-4a4c-9bd6-7c959a6cd789") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("b8e110a5-8a33-42c0-9202-c2d1b0092793") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("b8e110a5-8a33-42c0-9202-c2d1b0092793") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("b8e110a5-8a33-42c0-9202-c2d1b0092793") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("b9bf432c-8317-432c-b737-74fbc7fe2174") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("b9bf432c-8317-432c-b737-74fbc7fe2174") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("b9bf432c-8317-432c-b737-74fbc7fe2174") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("ba704ad5-3701-41bf-8c0b-73b4b0ead2a0") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("ba704ad5-3701-41bf-8c0b-73b4b0ead2a0") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("ba704ad5-3701-41bf-8c0b-73b4b0ead2a0") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("bbe543ee-1736-49d3-a99a-39d60510873b") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("bbe543ee-1736-49d3-a99a-39d60510873b") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("bbe543ee-1736-49d3-a99a-39d60510873b") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("bc369b8b-ad13-4fce-a4d8-0fa3af33677b") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("bc369b8b-ad13-4fce-a4d8-0fa3af33677b") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("bc369b8b-ad13-4fce-a4d8-0fa3af33677b") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("bdbb5035-9296-449f-8031-0416f67330d3") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("bdbb5035-9296-449f-8031-0416f67330d3") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("bdbb5035-9296-449f-8031-0416f67330d3") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("be372ccb-ddb0-4831-96cb-c3da7eb710e9") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("be372ccb-ddb0-4831-96cb-c3da7eb710e9") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("be372ccb-ddb0-4831-96cb-c3da7eb710e9") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("bfe57479-bede-46f7-8241-b9a3901d7e35") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("bfe57479-bede-46f7-8241-b9a3901d7e35") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("bfe57479-bede-46f7-8241-b9a3901d7e35") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("c0c0381d-953f-42fa-a3f7-75d52b37366c") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("c0c0381d-953f-42fa-a3f7-75d52b37366c") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("c0c0381d-953f-42fa-a3f7-75d52b37366c") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("c1299cab-53ee-48ec-bad8-0e2daaabb72c") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("c1299cab-53ee-48ec-bad8-0e2daaabb72c") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("c1299cab-53ee-48ec-bad8-0e2daaabb72c") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("c1d79d3c-5a74-46ac-9f0d-32ed6be5695c") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("c1d79d3c-5a74-46ac-9f0d-32ed6be5695c") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("c1d79d3c-5a74-46ac-9f0d-32ed6be5695c") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("c21b7663-ab35-4e26-93a0-e3ee871fa7fa") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("c21b7663-ab35-4e26-93a0-e3ee871fa7fa") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("c21b7663-ab35-4e26-93a0-e3ee871fa7fa") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("c240ff63-f2c1-4abc-b52e-d1563af091c5") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("c240ff63-f2c1-4abc-b52e-d1563af091c5") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("c240ff63-f2c1-4abc-b52e-d1563af091c5") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("c3047815-83f4-4e6a-89b6-f73398d664f2") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("c3047815-83f4-4e6a-89b6-f73398d664f2") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("c3047815-83f4-4e6a-89b6-f73398d664f2") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("c5878d16-6f89-4950-9512-3c9a22d2390c") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("c5878d16-6f89-4950-9512-3c9a22d2390c") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("c5878d16-6f89-4950-9512-3c9a22d2390c") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("c66d3bc7-3989-4973-80c8-98d5d0cfd0c3") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("c66d3bc7-3989-4973-80c8-98d5d0cfd0c3") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("c66d3bc7-3989-4973-80c8-98d5d0cfd0c3") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("c6aa873d-b8f6-4159-a3c3-b7749608cc8e") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("c6aa873d-b8f6-4159-a3c3-b7749608cc8e") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("c6aa873d-b8f6-4159-a3c3-b7749608cc8e") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("cafd5bfd-18ee-4b57-b522-3bee56c23639") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("cafd5bfd-18ee-4b57-b522-3bee56c23639") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("cafd5bfd-18ee-4b57-b522-3bee56c23639") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("cfb5547a-8e5c-47b0-85b2-0470ab1665fe") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("cfb5547a-8e5c-47b0-85b2-0470ab1665fe") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("cfb5547a-8e5c-47b0-85b2-0470ab1665fe") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("d2c9b079-f973-4894-afbd-605cb1ca5aa9") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("d2c9b079-f973-4894-afbd-605cb1ca5aa9") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("d2c9b079-f973-4894-afbd-605cb1ca5aa9") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("d46faf8e-ac78-439a-af5f-982876451809") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("d46faf8e-ac78-439a-af5f-982876451809") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("d46faf8e-ac78-439a-af5f-982876451809") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("d535450a-f276-494c-bfe5-f4ef690cb7e1") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("d535450a-f276-494c-bfe5-f4ef690cb7e1") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("d535450a-f276-494c-bfe5-f4ef690cb7e1") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("d73bf0be-dea2-4cb4-a2a3-d5e2da30d91c") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("d73bf0be-dea2-4cb4-a2a3-d5e2da30d91c") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("d73bf0be-dea2-4cb4-a2a3-d5e2da30d91c") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("d74ba646-5a55-4799-bff2-9f99070d3bba") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("d74ba646-5a55-4799-bff2-9f99070d3bba") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("d74ba646-5a55-4799-bff2-9f99070d3bba") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("d8ba923f-b2b2-4f52-97d3-607029250ec6") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("d8ba923f-b2b2-4f52-97d3-607029250ec6") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("d8ba923f-b2b2-4f52-97d3-607029250ec6") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("d9a8fa29-1bdf-4529-a157-799b89c51669") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("d9a8fa29-1bdf-4529-a157-799b89c51669") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("d9a8fa29-1bdf-4529-a157-799b89c51669") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("dcbfbc9f-6d43-4c39-9a5f-8e5d6381e039") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("dcbfbc9f-6d43-4c39-9a5f-8e5d6381e039") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("dcbfbc9f-6d43-4c39-9a5f-8e5d6381e039") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("dd34dadd-cc2d-43a5-9d9a-5aa6deefefc7") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("dd34dadd-cc2d-43a5-9d9a-5aa6deefefc7") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("dd34dadd-cc2d-43a5-9d9a-5aa6deefefc7") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("dde24248-d933-4811-ae4a-0639efa57150") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("dde24248-d933-4811-ae4a-0639efa57150") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("dde24248-d933-4811-ae4a-0639efa57150") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("de28a8ba-132b-48d0-a6aa-390754f06838") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("de28a8ba-132b-48d0-a6aa-390754f06838") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("de28a8ba-132b-48d0-a6aa-390754f06838") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("e2c0b5de-9db9-4320-be64-c831996714e5") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("e2c0b5de-9db9-4320-be64-c831996714e5") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("e2c0b5de-9db9-4320-be64-c831996714e5") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("e407e004-c38d-47d5-99b7-ddcbf7c9eb14") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("e407e004-c38d-47d5-99b7-ddcbf7c9eb14") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("e407e004-c38d-47d5-99b7-ddcbf7c9eb14") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("e4ae3a64-3dbb-4443-9263-344bff0bcc0b") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("e4ae3a64-3dbb-4443-9263-344bff0bcc0b") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("e4ae3a64-3dbb-4443-9263-344bff0bcc0b") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("e512a5df-3ab9-42aa-b6c1-f2e345dd6427") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("e512a5df-3ab9-42aa-b6c1-f2e345dd6427") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("e512a5df-3ab9-42aa-b6c1-f2e345dd6427") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("e6c82700-f8b7-407c-abad-a311a6ab7126") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("e6c82700-f8b7-407c-abad-a311a6ab7126") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("e6c82700-f8b7-407c-abad-a311a6ab7126") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("e7f21b0c-2315-4f1a-81f4-1c8d4b6a8fe6") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("e7f21b0c-2315-4f1a-81f4-1c8d4b6a8fe6") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("e7f21b0c-2315-4f1a-81f4-1c8d4b6a8fe6") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("e8ac4309-802b-4093-b051-783721e3fa4d") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("e8ac4309-802b-4093-b051-783721e3fa4d") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("e8ac4309-802b-4093-b051-783721e3fa4d") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("ea565302-21f6-4379-a444-298d635eee74") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("ea565302-21f6-4379-a444-298d635eee74") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("ea565302-21f6-4379-a444-298d635eee74") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("ec5c1c11-50df-47d6-af0c-d4259f878d77") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("ec5c1c11-50df-47d6-af0c-d4259f878d77") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("ec5c1c11-50df-47d6-af0c-d4259f878d77") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("edb8e025-c60f-4adf-9a5b-c1ace73cb7aa") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("edb8e025-c60f-4adf-9a5b-c1ace73cb7aa") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("edb8e025-c60f-4adf-9a5b-c1ace73cb7aa") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("ee5d7c3a-5e00-4f10-a75b-6a9175f9fb55") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("ee5d7c3a-5e00-4f10-a75b-6a9175f9fb55") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("ee5d7c3a-5e00-4f10-a75b-6a9175f9fb55") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("eea6569f-4485-4111-86cb-0b3d81684b32") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("eea6569f-4485-4111-86cb-0b3d81684b32") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("eea6569f-4485-4111-86cb-0b3d81684b32") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("f0bcf8ad-d01b-4f7a-ad19-614a3e51a8db") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("f0bcf8ad-d01b-4f7a-ad19-614a3e51a8db") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("f0bcf8ad-d01b-4f7a-ad19-614a3e51a8db") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("f0ee7d6b-3118-4fa8-a75f-67386a637489") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("f0ee7d6b-3118-4fa8-a75f-67386a637489") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("f0ee7d6b-3118-4fa8-a75f-67386a637489") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("f0f96b1f-4371-426b-8ebb-dfb06ddaf40e") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("f0f96b1f-4371-426b-8ebb-dfb06ddaf40e") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("f0f96b1f-4371-426b-8ebb-dfb06ddaf40e") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("f2268ce4-adb1-4185-8059-72aa2de7faa6") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("f2268ce4-adb1-4185-8059-72aa2de7faa6") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("f2268ce4-adb1-4185-8059-72aa2de7faa6") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("f25c2c9e-5aa0-4c96-bbab-b78be8a11340") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("f25c2c9e-5aa0-4c96-bbab-b78be8a11340") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("f25c2c9e-5aa0-4c96-bbab-b78be8a11340") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("f285ea90-73fd-4e06-bb8d-22eb1943ca59") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("f285ea90-73fd-4e06-bb8d-22eb1943ca59") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("f285ea90-73fd-4e06-bb8d-22eb1943ca59") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("f31ee530-2706-4ab2-9583-616cdf0b86b2") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("f31ee530-2706-4ab2-9583-616cdf0b86b2") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("f31ee530-2706-4ab2-9583-616cdf0b86b2") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("f3482ec4-ffe6-4cec-8b31-70c114e6544a") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("f3482ec4-ffe6-4cec-8b31-70c114e6544a") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("f3482ec4-ffe6-4cec-8b31-70c114e6544a") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("f4012e1f-9090-4e05-8770-9c2c75dd3d10") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("f4012e1f-9090-4e05-8770-9c2c75dd3d10") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("f4012e1f-9090-4e05-8770-9c2c75dd3d10") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("f4d0dce8-27de-42ce-bb30-edb1ec650090") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("f4d0dce8-27de-42ce-bb30-edb1ec650090") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("f4d0dce8-27de-42ce-bb30-edb1ec650090") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("fa8b52a1-f8f6-45e0-aded-15e817fe23b9") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("fa8b52a1-f8f6-45e0-aded-15e817fe23b9") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("fa8b52a1-f8f6-45e0-aded-15e817fe23b9") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("fb64710e-e858-49a1-87f8-3597b46cf973") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("fb64710e-e858-49a1-87f8-3597b46cf973") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("fb64710e-e858-49a1-87f8-3597b46cf973") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("fc364525-c09f-4dcb-a051-cad96f65fd1b") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("fc364525-c09f-4dcb-a051-cad96f65fd1b") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("fc364525-c09f-4dcb-a051-cad96f65fd1b") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("fd0d0d0f-8714-4007-8f61-e01097aeb176") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("fd0d0d0f-8714-4007-8f61-e01097aeb176") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("fd0d0d0f-8714-4007-8f61-e01097aeb176") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("fd0e2552-c4d7-4686-b951-1d0840ccd7e2") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("fd0e2552-c4d7-4686-b951-1d0840ccd7e2") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("fd0e2552-c4d7-4686-b951-1d0840ccd7e2") },
                    { new Guid("3990aad1-96f9-473f-9d49-7112b75c6926"), new Guid("ff86c0c3-29ce-4d44-8541-c965b5a6a00f") },
                    { new Guid("3d0c059c-ef76-46e1-98b0-7ebb7bb59216"), new Guid("ff86c0c3-29ce-4d44-8541-c965b5a6a00f") },
                    { new Guid("46763933-aaf9-4bd6-921d-bdf497c757fd"), new Guid("ff86c0c3-29ce-4d44-8541-c965b5a6a00f") }
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
                name: "IX_WorkInventories_BookCompartmentId",
                schema: "lm",
                table: "WorkInventories",
                column: "BookCompartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkInventories_BookId",
                schema: "lm",
                table: "WorkInventories",
                column: "BookId");

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
