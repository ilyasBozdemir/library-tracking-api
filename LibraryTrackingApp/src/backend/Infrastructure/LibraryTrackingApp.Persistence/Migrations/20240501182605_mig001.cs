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
                    WorkCatalogId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                        name: "FK_WorkInventories_WorkCatalogs_WorkCatalogId",
                        column: x => x.WorkCatalogId,
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
                    { new Guid("13f5c29d-33a9-4cdf-b216-5b42c36c19d5"), null, "89094ff0-b3df-4437-a5a3-6d869b715dcc", "system", "SYSTEM" },
                    { new Guid("1f347ab8-9c12-4f19-b189-668666f6baf8"), null, "3f673a35-cdce-4fb5-ad14-79438fee789b", "Member", "MEMBER" },
                    { new Guid("3adfa666-b1eb-4e68-b064-ad62d8b4fee2"), null, "ef60ee62-b721-4022-a75b-f1ae98ff022e", "Admin", "ADMIN" },
                    { new Guid("3faa18d9-14f9-4529-8768-1b924f2e9dff"), null, "098f6eb8-e3ed-47e1-8f28-8f8fa69af39f", "Staff", "STAFF" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "ConcurrencyStamp", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Email", "EmailConfirmed", "Gender", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "RefreshToken", "RefreshTokenEndDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0a3b5daa-af78-422d-8818-d03a0f4bd5e7"), 0, "456 Oak Street", new DateTime(1985, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "fbd35ccd-e1ce-464b-83a1-0372eaffb685", new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 0L, null, "jane.smith@example.com", true, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, false, null, "Jane", "JANE.SMITH@EXAMPLE.COM", "JANE.SMITH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEByCuM0S4BvNlvv9eNaqPnBNIgOP+JoUpRFD0URywus8wvX6yv+gUMN4Z452JFvXeQ==", null, false, new byte[0], null, null, "", "Smith", false, "jane.smith@example.com" },
                    { new Guid("6c4e4ce0-be88-4442-ad7a-091a6bee3547"), 0, "789 Employee St.", new DateTime(1990, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "cfe00560-39c3-482d-9cc6-83dfbe628192", new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 0L, null, "employee1@example.com", true, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, false, null, "Employee", "EMPLOYEE1@EXAMPLE.COM", "EMPLOYEE1@EXAMPLE.COM", "AQAAAAIAAYagAAAAENNrI+2Qjqg308zY5t7jDqQuiqkhHa8hdnbl0xmqLVXjnkkePn6iOePbKwoT5bdUCg==", null, false, new byte[0], null, null, "", "One", false, "employee1@example.com" },
                    { new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 0, "123 System St.", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5a4d1751-4b01-46d2-9f4f-97a546b72732", new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, "system@domain.com", true, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, false, null, "System", "SYSTEM@DOMAIN.COM", "SYSTEM", "AQAAAAIAAYagAAAAEIoLn1hlBrQidarQxN9AKrwyv1JuexwYUFtVy9QNacP4IoPIhefMdwinB8QlHyuhhQ==", null, false, new byte[0], null, null, "", "Admin", false, "system" },
                    { new Guid("9cb26a43-1d33-429b-86ec-9ed7aa3229bc"), 0, "456 Admin St.", new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "e186cf0c-9048-4bfe-80ed-c1e6b46b011c", new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 0L, null, "admin@example.com", true, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, false, null, "Admin", "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ10lje9xyWBbqa/Db64xKWxpgK4vdsR0fm+mCMNL8Dsn36xW/Ihr5BfR6kfFz3JkQ==", null, false, new byte[0], null, null, "", "Admin", false, "admin@example.com" },
                    { new Guid("fe2c853b-7b4d-4aca-95f4-971be25a9ab6"), 0, "123 Main Street", new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "48cdd1ac-0286-4654-91ed-8fc5263e2f63", new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 0L, null, "john.doe@example.com", true, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, false, null, "John", "JOHN.DOE@EXAMPLE.COM", "JOHN.DOE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGZOaAQEuU8V2262U+U0g7QE9LgioBJOxs7SVYglByL6MsjyeILlX4kbO6ShBSU2cA==", null, false, new byte[0], null, null, "", "Doe", false, "john.doe@example.com" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Authors",
                columns: new[] { "Id", "Biography", "BirthDate", "Country", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "Surname", "Website" },
                values: new object[] { new Guid("22297362-649f-4473-9df1-8ae1ffaf6c3e"), "Joanne Rowling, better known by her pen name J.K. Rowling, is a British author, philanthropist, film producer, television producer, and screenwriter. She is best known for writing the Harry Potter fantasy series.", new DateTime(1965, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "United Kingdom", new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, "J.K.", "Rowling", "www.example.com" });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "LibraryBranches",
                columns: new[] { "Id", "Address", "AppUserId", "CreatedById", "CreatedDateUnix", "CriticalLevelThreshold", "DeletedDateUnix", "Description", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "MaxCheckoutDurationInDays", "MaxCheckoutLimit", "MinCheckoutDurationInDays", "Name", "NotifyOnBookOrBlogComment", "PhoneNumber", "TopBooksReportLimit", "TopMembersReportLimit" },
                values: new object[,]
                {
                    { new Guid("3f2b9227-e53c-49df-b934-7f4c97e2f994"), "456 İkinci Sokak, No: 15", null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, 6, null, "Ana Kütüphane Şubesi, şehrin kalbindeki kitapseverler için bir buluşma noktasıdır.", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, 10, 7, 4, "Ana Kütüphane Şubesi", true, "+90 (212) 123 4567", 7, 7 },
                    { new Guid("94b4c46b-ff79-4991-b76c-3080a7c0ab87"), "789 Üçüncü Bulvar, No: 23", null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, 8, null, "Yıldızlar Kütüphanesi, gökyüzünü aşkın kitaplarla dolu bir yerdir.", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, 14, 10, 3, "Yıldızlar Kütüphanesi", false, "+90 (212) 987 6543", 10, 10 }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "WorkGenres",
                columns: new[] { "Id", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsActive", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name" },
                values: new object[,]
                {
                    { new Guid("51b706db-7fdc-45e4-87a7-2e21823ce940"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, "Adventure" },
                    { new Guid("ee22b6e0-4f38-496b-aa86-2a4e370bf098"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, "Fantasy" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "WorkPublishers",
                columns: new[] { "Id", "Address", "City", "Country", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Email", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "PhoneNumber", "Website" },
                values: new object[,]
                {
                    { new Guid("186e42f5-fdfb-46ce-8d4f-6fbd5121c167"), "1745 Broadway, New York, NY, USA", "New York", "USA", new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, "info@randomhouse.com", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, "Random House", "+1 212-782-9000", "https://www.randomhousebooks.com/" },
                    { new Guid("e0138691-a585-4713-bf0a-a1479c0ba48e"), "80 Strand, London, England", "London", "England", new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, "info@penguin.co.uk", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, "Penguin Books", "+44 (0)20 7139 3000", "https://www.penguin.co.uk/" },
                    { new Guid("ff3a6541-3074-48bf-a3e5-6e2405747224"), "50 Bedford Square, London, England", "London", "England", new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, "info@bloomsbury.com", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, "Bloomsbury Publishing", "+44 (0)20 7631 5600", "https://www.bloomsbury.com/" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "WorkTags",
                columns: new[] { "Id", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "WorkCatalogId" },
                values: new object[,]
                {
                    { new Guid("1bc39e57-1ba9-4fd4-ab56-4fa57b745cfe"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, "Hogwarts", new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("a17ee5ac-7ad0-407d-b6e7-a5e0113a9928"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, "Harry Potter", new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("b05891b6-9e81-4752-b423-59de18424e1c"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, "Quidditch", new Guid("93386e81-e153-4af0-a190-c66f5210c433") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("3faa18d9-14f9-4529-8768-1b924f2e9dff"), new Guid("6c4e4ce0-be88-4442-ad7a-091a6bee3547"), "AppUserRole" },
                    { new Guid("3adfa666-b1eb-4e68-b064-ad62d8b4fee2"), new Guid("9cb26a43-1d33-429b-86ec-9ed7aa3229bc"), "AppUserRole" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BranchHours",
                columns: new[] { "Id", "ClosingTime", "CreatedById", "CreatedDateUnix", "DayOfWeek", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "OpeningTime" },
                values: new object[,]
                {
                    { new Guid("14446dc0-699b-4e5f-a6e3-7cd5a50307e8"), new TimeSpan(0, 17, 30, 0, 0), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, new Guid("3f2b9227-e53c-49df-b934-7f4c97e2f994"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("4e2892ee-d505-4f3e-b85b-f5fab2959e06"), new TimeSpan(0, 17, 30, 0, 0), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, new Guid("3f2b9227-e53c-49df-b934-7f4c97e2f994"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("6180d1dc-7ddf-4797-abd4-f2a621ff89a6"), new TimeSpan(0, 17, 30, 0, 0), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, new Guid("3f2b9227-e53c-49df-b934-7f4c97e2f994"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("6d4d8224-0cba-4054-af56-a0a370b682b6"), new TimeSpan(0, 17, 30, 0, 0), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, new Guid("3f2b9227-e53c-49df-b934-7f4c97e2f994"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("7326d06d-3c07-4987-8998-5fa3c6dbb12b"), new TimeSpan(0, 17, 30, 0, 0), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, new Guid("3f2b9227-e53c-49df-b934-7f4c97e2f994"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("97d00173-cd5e-4212-a7c4-d9f42cb83b85"), new TimeSpan(0, 17, 30, 0, 0), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, new Guid("3f2b9227-e53c-49df-b934-7f4c97e2f994"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("b1bd150c-6251-40f9-94eb-bdde165c6ed7"), new TimeSpan(0, 0, 0, 0, 0), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, new Guid("3f2b9227-e53c-49df-b934-7f4c97e2f994"), new TimeSpan(0, 0, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Editions",
                columns: new[] { "Id", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "EditionNumber", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Notes", "PublicationDate", "PublisherId", "WorkInventoryId", "WorkPublisherId" },
                values: new object[,]
                {
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "First edition of Harry Potter and the Philosopher's Stone.", new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ff3a6541-3074-48bf-a3e5-6e2405747224"), new Guid("93386e81-e153-4af0-a190-c66f5210c433"), null },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, 2, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Second edition of Harry Potter and the Philosopher's Stone.", new DateTime(1998, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e0138691-a585-4713-bf0a-a1479c0ba48e"), new Guid("93386e81-e153-4af0-a190-c66f5210c433"), null },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, 3, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Third edition of Harry Potter and the Philosopher's Stone.", new DateTime(1999, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("186e42f5-fdfb-46ce-8d4f-6fbd5121c167"), new Guid("93386e81-e153-4af0-a190-c66f5210c433"), null }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Members",
                columns: new[] { "Id", "BorrowId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "ExtensionDurationInDays", "Gender", "HasPenalty", "IsDeleted", "IsDeletedById", "IsExtensionAllowed", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "MaxLateReturnsAllowed", "MemberType", "MembershipDate", "MembershipStatus", "NumberOfLateReturns", "Occupation", "PenaltyDurationInDays", "UserId" },
                values: new object[,]
                {
                    { new Guid("0a52b851-58a9-470c-8105-6bf1041f2902"), null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, 7, "Male", false, false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, new Guid("3f2b9227-e53c-49df-b934-7f4c97e2f994"), 3, "Adult", new DateTime(2024, 5, 1, 21, 26, 4, 458, DateTimeKind.Local).AddTicks(6335), "Active", 0, "Software Engineer", 0, new Guid("fe2c853b-7b4d-4aca-95f4-971be25a9ab6") },
                    { new Guid("f8010f1f-827e-49bd-b8b6-a928708d754c"), null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, 0, "Female", true, false, new Guid("00000000-0000-0000-0000-000000000000"), false, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, new Guid("3f2b9227-e53c-49df-b934-7f4c97e2f994"), 3, "Teacher", new DateTime(2024, 5, 1, 21, 26, 4, 458, DateTimeKind.Local).AddTicks(6340), "Active", 2, "Teacher", 7, new Guid("0a3b5daa-af78-422d-8818-d03a0f4bd5e7") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Shelves",
                columns: new[] { "Id", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "Name" },
                values: new object[,]
                {
                    { new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, new Guid("3f2b9227-e53c-49df-b934-7f4c97e2f994"), "Shelf 2" },
                    { new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, new Guid("3f2b9227-e53c-49df-b934-7f4c97e2f994"), "Shelf 4" },
                    { new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, new Guid("3f2b9227-e53c-49df-b934-7f4c97e2f994"), "Shelf 3" },
                    { new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, new Guid("3f2b9227-e53c-49df-b934-7f4c97e2f994"), "Shelf 1" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Staffs",
                columns: new[] { "Id", "Address", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "EmploymentDate", "IsDeleted", "IsDeletedById", "IsFullTime", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "Phone", "Salary", "UserId" },
                values: new object[] { new Guid("334b40cf-ef4e-4ace-a4b4-4b05aace6a1a"), "Employee Address", new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, new DateTime(2024, 5, 1, 21, 26, 4, 458, DateTimeKind.Local).AddTicks(6379), false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, new Guid("3f2b9227-e53c-49df-b934-7f4c97e2f994"), "+905553331122", 3000.00m, new Guid("6c4e4ce0-be88-4442-ad7a-091a6bee3547") });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "WorkCatalogs",
                columns: new[] { "Id", "AudioFilePath", "AuthorId", "CoverImageUrl", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "DeweyCode", "Editor", "FavoriteListId", "FilePath", "GenreId", "HasTagPrinted", "ISBN", "IsApproved", "IsBorrowable", "IsDeleted", "IsDeletedById", "IsFeatured", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "OriginalPublicationDate", "PageCount", "PublicationDate", "PublisherId", "ReadingListId", "Summary", "Title", "Translator", "WorkFormat", "WorkLanguage", "WorkStatus" },
                values: new object[] { new Guid("93386e81-e153-4af0-a190-c66f5210c433"), null, new Guid("22297362-649f-4473-9df1-8ae1ffaf6c3e"), "https://m.media-amazon.com/images/I/81q77Q39nEL._SY385_.jpg", new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, "800", null, null, null, new Guid("ee22b6e0-4f38-496b-aa86-2a4e370bf098"), false, "9781408855652", true, true, false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, new Guid("3f2b9227-e53c-49df-b934-7f4c97e2f994"), new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 352, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ff3a6541-3074-48bf-a3e5-6e2405747224"), null, "Harry Potter has never even heard of Hogwarts when the letters start dropping on the doormat at number four, Privet Drive.\r\nAddressed in green ink on yellowish parchment with a purple seal, they are swiftly confiscated by his grisly aunt and uncle.\r\nThen, on Harry's eleventh birthday, a great beetle-eyed giant of a man called Rubeus Hagrid bursts in with some astonishing news: Harry Potter is a wizard, and he has a place at Hogwarts School of Witchcraft and Wizardry. An incredible adventure is about to begin!", "Harry Potter and the Philosopher's Stone", null, "PrintedBook", "English", "Active" });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Author_WorkCatalogs",
                columns: new[] { "AuthorId", "WorkCatalogId" },
                values: new object[] { new Guid("22297362-649f-4473-9df1-8ae1ffaf6c3e"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "LibraryBranch_Member",
                columns: new[] { "LibraryBranchId", "MemberId" },
                values: new object[,]
                {
                    { new Guid("3f2b9227-e53c-49df-b934-7f4c97e2f994"), new Guid("0a52b851-58a9-470c-8105-6bf1041f2902") },
                    { new Guid("3f2b9227-e53c-49df-b934-7f4c97e2f994"), new Guid("f8010f1f-827e-49bd-b8b6-a928708d754c") },
                    { new Guid("94b4c46b-ff79-4991-b76c-3080a7c0ab87"), new Guid("f8010f1f-827e-49bd-b8b6-a928708d754c") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Tag_WorkCatalogs",
                columns: new[] { "TagId", "WorkCatalogId" },
                values: new object[,]
                {
                    { new Guid("1bc39e57-1ba9-4fd4-ab56-4fa57b745cfe"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("a17ee5ac-7ad0-407d-b6e7-a5e0113a9928"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("b05891b6-9e81-4752-b423-59de18424e1c"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "WorkCompartments",
                columns: new[] { "Id", "BookInventoryItemId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "ShelfId" },
                values: new object[,]
                {
                    { new Guid("07f406f3-1dcf-4526-9c3c-17722e16ed13"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, "Compartment 1", new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087") },
                    { new Guid("09d87f52-c979-4a24-b2b4-98e56d5a8703"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, "Compartment 3", new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084") },
                    { new Guid("0e21d166-ac26-44d3-85d9-cf1f19c468a5"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, "Compartment 5", new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084") },
                    { new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, "Compartment 3", new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2") },
                    { new Guid("2e6b91bc-b359-41b5-ae61-49febf49ed4c"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, "Compartment 4", new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084") },
                    { new Guid("2eda58c8-de7f-4db5-8064-5f6d6eb36eea"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, "Compartment 2", new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084") },
                    { new Guid("30c50ea5-9b59-4fc9-9786-5e56586663b4"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, "Compartment 2", new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8") },
                    { new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, "Compartment 2", new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2") },
                    { new Guid("36d29d09-5463-48ff-b95d-c079539126cd"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, "Compartment 3", new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087") },
                    { new Guid("5325803b-4625-43a6-8e8b-105e945df512"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, "Compartment 1", new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8") },
                    { new Guid("5712d335-e2dc-4b22-a810-4325f00fa0de"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, "Compartment 5", new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087") },
                    { new Guid("6e643751-d86b-4239-89ab-338bd89373ed"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, "Compartment 1", new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084") },
                    { new Guid("793b0092-f546-462d-9e28-b6a96744949e"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, "Compartment 4", new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2") },
                    { new Guid("7f7cac21-dbbc-4f76-9de2-54cbaabdffa8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, "Compartment 4", new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8") },
                    { new Guid("85f71474-5376-4ccd-a447-df9d783720c4"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, "Compartment 5", new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8") },
                    { new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, "Compartment 5", new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2") },
                    { new Guid("94e3c932-ae28-40b1-b8be-013e14496614"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, "Compartment 2", new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087") },
                    { new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, "Compartment 1", new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2") },
                    { new Guid("e9151013-0bf2-4f09-8164-231ccae06200"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, "Compartment 4", new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087") },
                    { new Guid("f6efa15e-ba38-4be2-80fc-d551c43cf011"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, "Compartment 3", new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "WorkInventories",
                columns: new[] { "Id", "BookCompartmentId", "BookNumber", "BookStatus", "BookStockTransactionType", "BorrowLendId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Description", "Donor", "EditionId", "IsAvailable", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Notes", "ShelfId", "WorkCatalogId" },
                values: new object[,]
                {
                    { new Guid("043bc03e-ff53-4754-93f8-87851b55d1ca"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-180", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("0459cf70-b1bd-4db9-81c7-84db786cd582"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-133", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("07223d49-cfee-4117-884f-c05ab090dd6e"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-17", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("07636ab9-a8af-4496-95b0-f62a3e96cf69"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-58", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("082a66ec-b26a-4d2b-9c4b-ee6a42b40e73"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-120", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("08b8505b-f898-4143-b6b0-a086ada7e099"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-123", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("09004dcf-38ce-49ae-8ef2-8bbf3836fafb"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-85", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("09ca92ab-3c1f-4605-9f16-e80112516d8d"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-64", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("0a88304d-1334-4171-aa90-4137abc33698"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-112", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("0b4712a8-c875-49b7-a001-3a7283f1c87e"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-196", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("0c1bbd50-fc3a-4d53-a18f-816aa403dde0"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-9", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("0d928aec-70bf-4803-824d-0ffa8b8df959"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-122", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("0df871bb-68f1-4d04-8310-cb611f922068"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-146", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("0eb12faa-e79a-41ec-aeb1-d86734554997"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-79", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("0f3f39be-71ad-4569-9432-5bed9a698fa7"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-194", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("0f449291-d7f7-47e5-9b8e-e737231354dc"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-27", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("125d1502-8218-4487-bd82-66c750d6d725"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-23", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("160955cd-316d-4cad-ac47-e6739d62f76c"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-108", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("16ac8b0c-a9f4-4fe3-bd7b-a925ce89bdc1"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-84", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("179efc4d-cc7b-47ac-b440-f2cf907de5b3"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-104", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("18ef3409-4ed9-4501-8b38-f4e17938969a"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-151", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("1985c61c-6d23-4cac-8464-731d4ac9c3c9"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-177", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("1b04e7e6-1e2a-40b0-af1b-81e3c3384e8e"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-115", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("1e0ff314-da46-40c8-b9f7-19fce67d753e"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-181", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("1f26625d-e01d-42d8-941a-56ea6ecd5cd4"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-161", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("2010f496-ba1c-4bac-b081-fb2a37bb2579"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-75", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("213ce899-e1d5-4bee-801d-326e0aa9d090"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-149", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("21fd3b87-b44e-4577-abb7-09db603a5eb6"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-38", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("223fe8b4-2c8e-4566-ad25-7bc2f2a53846"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-90", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("238d626d-2f2f-434f-a380-2c46d43bf8fd"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-183", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("26e9444a-002c-4435-b105-8e1395bd38fa"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-163", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("2765a047-4a05-48ca-b705-56808b85665f"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-35", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("27e86885-925d-4d6f-b897-810816de7b27"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-102", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("2b771377-7611-493f-8ecf-4edf4ddd8f25"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-129", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("2b97e25d-97ba-402a-a002-efc9d2bf365b"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-116", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("2c030a58-681c-495a-934d-ad106df0eaae"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-6", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("2c2aa99e-b59b-42e8-b5e0-747e5638f026"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-12", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("2d226d0d-61ff-4a19-85ed-3c75f1cc3cdc"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-50", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("2d654848-8ec7-470a-8216-b4510a2ed262"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-197", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("2dc37efb-0a8e-4abe-ad8b-2d46e4e2f6bc"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-125", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("2e3fe1b6-94a4-4c4d-8e3e-373d90fcdcc6"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-98", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("2e7c41fc-6b85-4553-9b40-34e6f28a811a"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-153", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("313d1383-60a8-40fa-aebf-c4ba800bcd4c"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-33", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("329743b1-9cea-437e-bf5c-7561dea58415"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-29", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("32a1b88b-feb2-4733-9024-b377e3b62a23"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-117", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("33017d8e-8731-40d2-af5a-9b39a8b1abb6"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-106", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("3558e621-f43f-488e-8c63-8b3fdc23492a"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-143", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("358250c8-937c-4f78-8e9a-37d31819379d"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-111", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("37625e49-6fb9-4478-a1c8-6854e7c9acfc"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-94", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("377f6fc8-f087-43e1-9352-ec8341cc393e"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-136", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("38e6cdfc-4c1d-411f-8f75-ef18b06520af"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-16", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("3bb06b4d-84a8-4266-917f-dc98b25d6764"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-72", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("3d2ebd46-da0d-42d0-bb02-ab09f092115d"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-24", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("3f488e87-fca4-4c56-aba0-00c3b2bab605"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-44", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("40ad12f4-4996-41cb-9111-156a47feff70"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-135", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("442588ef-c63f-4137-bd7c-dcc787ce082b"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-171", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("44be6661-925d-480c-a803-f341d5d300ab"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-114", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("4541ace7-bb80-4e7a-a25c-6103c3c58193"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-32", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("45f2f538-c362-4157-a73c-9fe2f3f0a109"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-54", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("4655e0ab-311c-4876-9327-35a4f6b11dbe"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-52", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("46bef8fe-970a-434a-b86b-3144201495ea"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-15", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("48ba8fa4-96a6-4293-b10a-e9c146d59d5e"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-69", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("48fd7f3e-05f3-46c5-95c9-eceff844e59c"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-165", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("4965db90-4179-4297-a421-5c1ea8e4fc50"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-198", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("49947dcc-91d9-4433-ab60-0f240dbceb92"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-130", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("49eb307e-4a3f-43c1-bdaf-da7ee8020b7f"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-74", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("4a5b5dd6-0378-4e7b-a643-4e5aebbedbfc"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-14", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("4af42d68-019f-4fe2-ba21-e33107ab3570"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-131", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("4bf8a285-ecee-4786-938b-c22e3c7843cf"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-4", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("4f308676-f1a4-4f26-bff7-f6b1752fd35c"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-46", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("4f566db2-a4f1-4de4-af2b-c94403a571d0"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-124", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("4fc46ee2-c739-45ea-a15b-1b718141756e"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-175", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("5287fc76-6dea-4eae-9fbb-1d91cfe70c6b"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-86", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("541a31e2-bb03-42be-95fd-dbbfa0125b4d"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-134", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("54c8ba52-ef3b-41af-892e-829d49bbdbcb"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-178", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("55eccf50-44c1-4e70-b323-1e82aab13037"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-103", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("5815a21a-214b-484a-a54b-19ff31445e6d"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-101", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("58ab03bd-f6d4-4f1a-baf5-9185733821c3"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-41", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("58e6df3c-a5b5-42aa-91e3-ff6086fb2db6"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-179", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("59a142a7-1033-4495-8785-d3dbd3907a37"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-138", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("5d6ac73d-8c14-4d84-8f9e-f4932bcf58c2"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-18", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("5f9ccbb0-82de-4014-9e08-21f436cfad2c"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-126", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("5fc9be19-b651-454e-9b0c-c2b761522121"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-83", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("6053e92f-ee7a-45ee-b4da-af18fd486e68"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-73", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("61106be8-77f6-44a2-887a-6bde8eccf73b"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-76", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("611c88d5-7d70-42b4-9508-591568ab7df4"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-55", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("61b3a28b-419c-4170-84f8-e890a725a728"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-167", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("61f9738b-f8e6-4829-be2f-804bb7fff40e"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-95", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("63aac367-9ac5-4dc9-ae96-14d860a03f19"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-169", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("64930d87-d819-4e53-9a43-ba9781a5d88e"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-158", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("666cbf5c-f227-43c6-a5e4-0b46d3069f65"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-132", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("66e6c10a-f39d-4d59-9839-11bf3e71552c"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-3", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("687090a2-4066-4466-a66f-f0354a1420a5"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-168", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("689d05b4-0ce9-426a-a6b8-ee09f5027e21"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-140", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("6a31ef9b-9fdc-4b26-bd1c-a3f87a06b8a7"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-154", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("6adde0ab-5077-47f6-99fc-c67321ffd1b6"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-68", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("6af4f908-1442-4064-92f9-b8642b5020e5"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-195", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("6cd687eb-df78-4538-a726-e3dd2d615f6f"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-150", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("6deb362a-690d-47f7-a312-c965e9b6c90d"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-100", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("6ee5506e-1a3b-43ea-938f-ceccff0fadd2"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-88", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("70418e8e-ee78-4144-af39-1c973286eaaa"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-147", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("716f2b3d-0c09-480e-a4ad-bbbf12f77016"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-182", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("71d718fe-e626-40e1-97b8-e28c4eb561da"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-160", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("72ad3299-3ed5-487d-b256-9c2d3f91c41a"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-62", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("7398aed3-65c8-4425-bdf6-41b8c13f49c0"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-49", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("75f0496d-d1bf-459a-bce7-2246da53b609"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-63", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("775f8028-8524-4603-a2f9-1a0e5ba23230"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-191", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("785966d6-b3a8-43ac-b292-8fc5654d4b41"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-105", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("787aa6c7-eaf2-4c03-8540-231a7cb41fc0"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-39", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("7d28da3e-3bce-4f92-beb8-52621c8a4ddf"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-77", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("82255f85-e046-4644-9090-88dacb3e9a90"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-65", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("830a85a3-2975-47d0-9c05-32cc05b4f05e"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-89", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("83106ffe-a658-40b7-91fe-fe2bf8ed882d"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-20", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("83493076-412e-45b0-8ad9-9c1bb645f384"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-81", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("84520422-ecd8-4f0a-aa47-fcd730c6fb05"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-47", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("847331b6-5cdf-4162-8703-9e771f730d64"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-7", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("87007bab-56de-4301-9592-145c0e595f22"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-172", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("8ae98fc3-75f3-463a-a3f3-427cd7542b6b"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-113", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("8b5e1ec1-1d05-4b80-8627-b1652497a232"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-121", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("8b978676-ec06-4985-9a24-2859e588a0c5"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-78", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("8d6c7ddc-b585-44c9-bdcf-4f516ac00170"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-60", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("8e35a916-8be3-4837-9673-6d77029685e1"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-93", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("8e9b0804-5cac-42bf-85eb-cb9fe50d6108"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-61", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("8ec4e221-bb3b-4936-9da5-b81ee5d5c12a"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-173", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("8f28d5b3-0901-4581-9e9f-3bb72152b391"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-164", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("90c35989-5890-4a5b-82f4-43bfdb5c44d3"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-200", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("9110330a-941c-4b7d-92b0-ed8ae8523d81"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-166", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("9120f4b7-1083-446e-8b97-86a7306bbc12"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-119", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("93f1b876-e1ff-4173-8361-4013d98d5c4b"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-70", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("95e2ffd2-ff4f-4408-b9c0-ee78eba05a74"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-157", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("9867a970-8f20-4537-bfdc-0d060af33dbf"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-96", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("995d6ab1-9477-4b71-a236-ddbab6cef352"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-144", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("998df2b0-fcdb-42b5-8af4-78621b3f4225"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-36", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("9b0b1ee0-9af9-464b-85e9-b6a68b8ead08"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-53", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("9cd41ddd-82c2-4ab5-b5ff-7a2ed6818fb4"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-142", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("9d58ebc2-af8a-4ceb-bbb8-fd069e75dfcd"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-5", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("9e1f878f-8e0d-4d54-a770-e643c609b0e4"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-43", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("9f63c80a-2290-47b6-b702-f668e44ed8c0"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-141", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("9f688e9e-4fa1-41a8-a947-e9304839bdfe"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-127", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("a2ab83c3-1681-47b2-a95d-250f4c12268b"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-192", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("a42e6bfd-d89f-4627-8cc6-ac20a1c34d44"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-118", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("a5f5b3d4-c3a6-4933-9f67-47dd6e24b1c5"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-137", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("a60fa37b-ed2d-4a9c-8563-683f7e17ad28"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-71", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("a66a7d3a-8eeb-4c51-b540-bf2cc2738cf1"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-162", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("a756269e-60bf-46b5-ab5f-a90ba04bfb7d"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-155", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("a765d0db-82f1-44c1-995b-f0c85b5bba41"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-40", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("a8cc027b-1c82-4b7a-b646-fbcaa609fe6e"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-186", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("a98b4822-0959-414c-9497-97bc42d05b58"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-189", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("ab0f3925-12a5-43db-b8a8-03178dbf6488"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-110", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("ad74ce6f-c9e8-4130-be53-61e73cad057f"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-156", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("b009309c-1420-4f63-9749-fd9978e32da2"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-148", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("b186b8c6-7e39-4fdf-8e1e-38b29ec4f0cb"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-92", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("b51e0f50-cf53-4bc6-b0eb-b7bdd40c7224"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-56", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("b85694b4-fa61-4945-9ba3-0e73956c3812"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-80", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("bef79182-8380-4587-83cc-e6e7bcf6eb48"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-91", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("bf9224dc-2166-4638-a681-467ec5622124"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-1", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("c107bf5a-047b-4927-af16-7f4a7a10fbc2"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-45", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("c12d19b9-f7fa-4819-b064-bec9d8a00fa4"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-199", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("c152dade-e413-47d6-8c1d-2ed9b1e23a42"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-22", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("c415a761-7a91-48e2-a742-727a174161f7"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-176", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("c54e1f56-c3e2-4113-9dc0-b83b56627ded"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-139", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("c6024252-cae3-49bc-9808-b1ecced933dd"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-193", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("c6212e97-2bed-4852-990b-f31438b7f98a"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-19", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("c7011e0c-915e-46bf-9ec9-694c1ad0956b"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-26", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("c8187025-1c5c-4455-80dc-d681b6fd0eae"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-2", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("c9350533-35db-49de-94ed-65a371e43248"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-187", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("c9efd7a4-99a4-4124-bf45-990781471032"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-87", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("ca17343f-26ca-4922-a036-bffb456918f0"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-185", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("ca414129-6658-46a4-9708-971f73cc3616"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-159", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("cab10885-2d9c-48ae-9306-f9d07290953f"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-99", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("cc638689-6fcf-483d-9fe0-6913913421cc"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-30", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("d23c8efa-a2de-40a4-81d4-55caf85aedcf"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-57", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("d4a2c18e-9255-489e-a588-26f2dd7c6255"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-28", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("d5476484-68e7-4351-b2c9-11e5e79c458a"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-145", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("d5c9d9bf-7604-46e9-82ad-264eb71245f8"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-13", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("da3beeec-0bf7-4f99-9fe9-4a664117c541"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-67", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("da6227dd-7179-454c-b654-f267622455ae"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-37", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("dc7adfb9-232c-43ca-95c6-f3fbb8136164"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-21", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("e3d733f3-a977-4b2d-8624-87370fdeed77"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-42", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("e3eb10f1-ed77-4a3b-8157-af9612eed256"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-188", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("e4c6d766-57cc-42e8-b488-4ba80e520a3a"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-25", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("e5091fba-9732-4083-a7cd-b2e270f749ce"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-34", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("e55d91a3-2953-47b6-b05f-df5c6502cb32"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-31", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("e68f3a0f-3f56-4f1a-8bc8-9a7f3279004a"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-170", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("e75c12a0-bae8-4186-87a1-f194de5ec477"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-66", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("e810fe6c-03fe-4895-8b59-9182cd6a41bb"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-107", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("eae9323a-1757-4bfa-b502-69ba792d5198"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-184", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("ec03856c-3460-4fff-91c9-3fe16e7e39cb"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-128", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("ee43063b-2a30-4e7b-a024-d0c25e803a81"), new Guid("36769ea7-0df0-4e74-aea2-25097aa929c1"), "HP-11", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("ef9af11d-d63e-4617-8a10-ed86f049f022"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-97", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("f129fa8b-a508-4af8-8c61-bb315d4f88e2"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-190", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("f4a8131d-a39c-4e73-9082-3c37205e88f3"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-59", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("f4fbfc08-593d-4f47-b17f-c967749c646a"), new Guid("2579198f-ee45-46de-aca0-791b9339b0b4"), "HP-174", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("f514cdc8-7545-4f7e-a00c-e2f87d72e603"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-10", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("f7d4840f-cb8b-4673-b26d-ed2791bcefa4"), new Guid("8e02ac32-0d1d-4eb3-9713-08cca3d0c220"), "HP-48", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("fb0eb65c-4e48-45af-ae2c-890ab3379483"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-51", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("fbf2b975-ed37-4b0e-b793-9ec3547a84e5"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-8", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("98e24329-6d10-4264-b90b-dc0188ef74e2"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("fd06bba9-f75c-4679-abe2-ce455ebaa86e"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-152", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("49f4a13c-9de3-4fbc-9830-4f92263b5cc8"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("fd0be251-42b7-4117-9af6-d554974e4f84"), new Guid("d11207c4-89c7-4e52-8376-e88e11a0984e"), "HP-109", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("7cf757ac-c8c5-414f-bda8-296d49a20084"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") },
                    { new Guid("ff6c896d-800d-4087-a965-fa31e013227a"), new Guid("793b0092-f546-462d-9e28-b6a96744949e"), "HP-82", "Active", 0, null, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, null, new Guid("4541075b-5ca9-4569-8748-3a5fd17ab087"), new Guid("93386e81-e153-4af0-a190-c66f5210c433") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BorrowLends",
                columns: new[] { "Id", "BorrowDate", "BorrowStatus", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "DueDate", "FeeAmount", "HasFee", "IsDeleted", "IsDeletedById", "IsLate", "LastModifiedById", "LastModifiedDateUnix", "LateDurationInDays", "MemberId", "ReturnDate", "StaffLenderId", "WorkCatalogId", "WorkInventoryId" },
                values: new object[,]
                {
                    { new Guid("4b942281-5ab1-4a81-b5e8-74bd238be178"), new DateTime(2024, 4, 21, 21, 26, 4, 458, DateTimeKind.Local).AddTicks(6485), "Returned", new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, new DateTime(2024, 5, 1, 21, 26, 4, 458, DateTimeKind.Local).AddTicks(6516), 0m, false, false, new Guid("00000000-0000-0000-0000-000000000000"), false, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, 0, new Guid("0a52b851-58a9-470c-8105-6bf1041f2902"), new DateTime(2024, 5, 1, 21, 26, 4, 458, DateTimeKind.Local).AddTicks(6516), new Guid("334b40cf-ef4e-4ace-a4b4-4b05aace6a1a"), new Guid("93386e81-e153-4af0-a190-c66f5210c433"), new Guid("9d58ebc2-af8a-4ceb-bbb8-fd069e75dfcd") },
                    { new Guid("600df8d0-0954-471a-96a3-5f361ea2883f"), new DateTime(2024, 4, 21, 21, 26, 4, 458, DateTimeKind.Local).AddTicks(6606), "Borrowed", new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, new DateTime(2024, 5, 2, 21, 26, 4, 458, DateTimeKind.Local).AddTicks(6610), 0m, false, false, new Guid("00000000-0000-0000-0000-000000000000"), false, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, 0, new Guid("f8010f1f-827e-49bd-b8b6-a928708d754c"), null, new Guid("334b40cf-ef4e-4ace-a4b4-4b05aace6a1a"), new Guid("93386e81-e153-4af0-a190-c66f5210c433"), new Guid("46bef8fe-970a-434a-b86b-3144201495ea") },
                    { new Guid("c3606be6-30cc-4023-b81d-a2271f1ca4d1"), new DateTime(2024, 4, 21, 21, 26, 4, 458, DateTimeKind.Local).AddTicks(6568), "DelayedReturn", new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), 1714598764L, null, new DateTime(2024, 4, 30, 21, 26, 4, 458, DateTimeKind.Local).AddTicks(6571), 0m, false, false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("77e3db66-0f8a-468a-8578-b54fcfc8d74b"), null, 1, new Guid("f8010f1f-827e-49bd-b8b6-a928708d754c"), new DateTime(2024, 5, 1, 21, 26, 4, 458, DateTimeKind.Local).AddTicks(6572), new Guid("334b40cf-ef4e-4ace-a4b4-4b05aace6a1a"), new Guid("93386e81-e153-4af0-a190-c66f5210c433"), new Guid("f514cdc8-7545-4f7e-a00c-e2f87d72e603") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Edition_WorkInventories",
                columns: new[] { "EditionId", "WorkInventoryId" },
                values: new object[,]
                {
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("043bc03e-ff53-4754-93f8-87851b55d1ca") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("043bc03e-ff53-4754-93f8-87851b55d1ca") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("043bc03e-ff53-4754-93f8-87851b55d1ca") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("0459cf70-b1bd-4db9-81c7-84db786cd582") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("0459cf70-b1bd-4db9-81c7-84db786cd582") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("0459cf70-b1bd-4db9-81c7-84db786cd582") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("07223d49-cfee-4117-884f-c05ab090dd6e") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("07223d49-cfee-4117-884f-c05ab090dd6e") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("07223d49-cfee-4117-884f-c05ab090dd6e") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("07636ab9-a8af-4496-95b0-f62a3e96cf69") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("07636ab9-a8af-4496-95b0-f62a3e96cf69") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("07636ab9-a8af-4496-95b0-f62a3e96cf69") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("082a66ec-b26a-4d2b-9c4b-ee6a42b40e73") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("082a66ec-b26a-4d2b-9c4b-ee6a42b40e73") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("082a66ec-b26a-4d2b-9c4b-ee6a42b40e73") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("08b8505b-f898-4143-b6b0-a086ada7e099") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("08b8505b-f898-4143-b6b0-a086ada7e099") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("08b8505b-f898-4143-b6b0-a086ada7e099") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("09004dcf-38ce-49ae-8ef2-8bbf3836fafb") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("09004dcf-38ce-49ae-8ef2-8bbf3836fafb") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("09004dcf-38ce-49ae-8ef2-8bbf3836fafb") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("09ca92ab-3c1f-4605-9f16-e80112516d8d") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("09ca92ab-3c1f-4605-9f16-e80112516d8d") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("09ca92ab-3c1f-4605-9f16-e80112516d8d") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("0a88304d-1334-4171-aa90-4137abc33698") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("0a88304d-1334-4171-aa90-4137abc33698") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("0a88304d-1334-4171-aa90-4137abc33698") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("0b4712a8-c875-49b7-a001-3a7283f1c87e") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("0b4712a8-c875-49b7-a001-3a7283f1c87e") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("0b4712a8-c875-49b7-a001-3a7283f1c87e") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("0c1bbd50-fc3a-4d53-a18f-816aa403dde0") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("0c1bbd50-fc3a-4d53-a18f-816aa403dde0") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("0c1bbd50-fc3a-4d53-a18f-816aa403dde0") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("0d928aec-70bf-4803-824d-0ffa8b8df959") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("0d928aec-70bf-4803-824d-0ffa8b8df959") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("0d928aec-70bf-4803-824d-0ffa8b8df959") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("0df871bb-68f1-4d04-8310-cb611f922068") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("0df871bb-68f1-4d04-8310-cb611f922068") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("0df871bb-68f1-4d04-8310-cb611f922068") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("0eb12faa-e79a-41ec-aeb1-d86734554997") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("0eb12faa-e79a-41ec-aeb1-d86734554997") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("0eb12faa-e79a-41ec-aeb1-d86734554997") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("0f3f39be-71ad-4569-9432-5bed9a698fa7") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("0f3f39be-71ad-4569-9432-5bed9a698fa7") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("0f3f39be-71ad-4569-9432-5bed9a698fa7") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("0f449291-d7f7-47e5-9b8e-e737231354dc") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("0f449291-d7f7-47e5-9b8e-e737231354dc") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("0f449291-d7f7-47e5-9b8e-e737231354dc") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("125d1502-8218-4487-bd82-66c750d6d725") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("125d1502-8218-4487-bd82-66c750d6d725") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("125d1502-8218-4487-bd82-66c750d6d725") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("160955cd-316d-4cad-ac47-e6739d62f76c") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("160955cd-316d-4cad-ac47-e6739d62f76c") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("160955cd-316d-4cad-ac47-e6739d62f76c") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("16ac8b0c-a9f4-4fe3-bd7b-a925ce89bdc1") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("16ac8b0c-a9f4-4fe3-bd7b-a925ce89bdc1") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("16ac8b0c-a9f4-4fe3-bd7b-a925ce89bdc1") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("179efc4d-cc7b-47ac-b440-f2cf907de5b3") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("179efc4d-cc7b-47ac-b440-f2cf907de5b3") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("179efc4d-cc7b-47ac-b440-f2cf907de5b3") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("18ef3409-4ed9-4501-8b38-f4e17938969a") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("18ef3409-4ed9-4501-8b38-f4e17938969a") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("18ef3409-4ed9-4501-8b38-f4e17938969a") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("1985c61c-6d23-4cac-8464-731d4ac9c3c9") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("1985c61c-6d23-4cac-8464-731d4ac9c3c9") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("1985c61c-6d23-4cac-8464-731d4ac9c3c9") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("1b04e7e6-1e2a-40b0-af1b-81e3c3384e8e") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("1b04e7e6-1e2a-40b0-af1b-81e3c3384e8e") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("1b04e7e6-1e2a-40b0-af1b-81e3c3384e8e") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("1e0ff314-da46-40c8-b9f7-19fce67d753e") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("1e0ff314-da46-40c8-b9f7-19fce67d753e") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("1e0ff314-da46-40c8-b9f7-19fce67d753e") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("1f26625d-e01d-42d8-941a-56ea6ecd5cd4") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("1f26625d-e01d-42d8-941a-56ea6ecd5cd4") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("1f26625d-e01d-42d8-941a-56ea6ecd5cd4") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("2010f496-ba1c-4bac-b081-fb2a37bb2579") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("2010f496-ba1c-4bac-b081-fb2a37bb2579") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("2010f496-ba1c-4bac-b081-fb2a37bb2579") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("213ce899-e1d5-4bee-801d-326e0aa9d090") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("213ce899-e1d5-4bee-801d-326e0aa9d090") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("213ce899-e1d5-4bee-801d-326e0aa9d090") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("21fd3b87-b44e-4577-abb7-09db603a5eb6") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("21fd3b87-b44e-4577-abb7-09db603a5eb6") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("21fd3b87-b44e-4577-abb7-09db603a5eb6") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("223fe8b4-2c8e-4566-ad25-7bc2f2a53846") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("223fe8b4-2c8e-4566-ad25-7bc2f2a53846") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("223fe8b4-2c8e-4566-ad25-7bc2f2a53846") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("238d626d-2f2f-434f-a380-2c46d43bf8fd") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("238d626d-2f2f-434f-a380-2c46d43bf8fd") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("238d626d-2f2f-434f-a380-2c46d43bf8fd") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("26e9444a-002c-4435-b105-8e1395bd38fa") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("26e9444a-002c-4435-b105-8e1395bd38fa") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("26e9444a-002c-4435-b105-8e1395bd38fa") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("2765a047-4a05-48ca-b705-56808b85665f") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("2765a047-4a05-48ca-b705-56808b85665f") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("2765a047-4a05-48ca-b705-56808b85665f") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("27e86885-925d-4d6f-b897-810816de7b27") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("27e86885-925d-4d6f-b897-810816de7b27") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("27e86885-925d-4d6f-b897-810816de7b27") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("2b771377-7611-493f-8ecf-4edf4ddd8f25") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("2b771377-7611-493f-8ecf-4edf4ddd8f25") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("2b771377-7611-493f-8ecf-4edf4ddd8f25") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("2b97e25d-97ba-402a-a002-efc9d2bf365b") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("2b97e25d-97ba-402a-a002-efc9d2bf365b") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("2b97e25d-97ba-402a-a002-efc9d2bf365b") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("2c030a58-681c-495a-934d-ad106df0eaae") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("2c030a58-681c-495a-934d-ad106df0eaae") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("2c030a58-681c-495a-934d-ad106df0eaae") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("2c2aa99e-b59b-42e8-b5e0-747e5638f026") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("2c2aa99e-b59b-42e8-b5e0-747e5638f026") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("2c2aa99e-b59b-42e8-b5e0-747e5638f026") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("2d226d0d-61ff-4a19-85ed-3c75f1cc3cdc") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("2d226d0d-61ff-4a19-85ed-3c75f1cc3cdc") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("2d226d0d-61ff-4a19-85ed-3c75f1cc3cdc") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("2d654848-8ec7-470a-8216-b4510a2ed262") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("2d654848-8ec7-470a-8216-b4510a2ed262") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("2d654848-8ec7-470a-8216-b4510a2ed262") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("2dc37efb-0a8e-4abe-ad8b-2d46e4e2f6bc") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("2dc37efb-0a8e-4abe-ad8b-2d46e4e2f6bc") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("2dc37efb-0a8e-4abe-ad8b-2d46e4e2f6bc") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("2e3fe1b6-94a4-4c4d-8e3e-373d90fcdcc6") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("2e3fe1b6-94a4-4c4d-8e3e-373d90fcdcc6") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("2e3fe1b6-94a4-4c4d-8e3e-373d90fcdcc6") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("2e7c41fc-6b85-4553-9b40-34e6f28a811a") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("2e7c41fc-6b85-4553-9b40-34e6f28a811a") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("2e7c41fc-6b85-4553-9b40-34e6f28a811a") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("313d1383-60a8-40fa-aebf-c4ba800bcd4c") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("313d1383-60a8-40fa-aebf-c4ba800bcd4c") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("313d1383-60a8-40fa-aebf-c4ba800bcd4c") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("329743b1-9cea-437e-bf5c-7561dea58415") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("329743b1-9cea-437e-bf5c-7561dea58415") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("329743b1-9cea-437e-bf5c-7561dea58415") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("32a1b88b-feb2-4733-9024-b377e3b62a23") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("32a1b88b-feb2-4733-9024-b377e3b62a23") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("32a1b88b-feb2-4733-9024-b377e3b62a23") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("33017d8e-8731-40d2-af5a-9b39a8b1abb6") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("33017d8e-8731-40d2-af5a-9b39a8b1abb6") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("33017d8e-8731-40d2-af5a-9b39a8b1abb6") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("3558e621-f43f-488e-8c63-8b3fdc23492a") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("3558e621-f43f-488e-8c63-8b3fdc23492a") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("3558e621-f43f-488e-8c63-8b3fdc23492a") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("358250c8-937c-4f78-8e9a-37d31819379d") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("358250c8-937c-4f78-8e9a-37d31819379d") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("358250c8-937c-4f78-8e9a-37d31819379d") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("37625e49-6fb9-4478-a1c8-6854e7c9acfc") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("37625e49-6fb9-4478-a1c8-6854e7c9acfc") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("37625e49-6fb9-4478-a1c8-6854e7c9acfc") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("377f6fc8-f087-43e1-9352-ec8341cc393e") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("377f6fc8-f087-43e1-9352-ec8341cc393e") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("377f6fc8-f087-43e1-9352-ec8341cc393e") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("38e6cdfc-4c1d-411f-8f75-ef18b06520af") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("38e6cdfc-4c1d-411f-8f75-ef18b06520af") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("38e6cdfc-4c1d-411f-8f75-ef18b06520af") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("3bb06b4d-84a8-4266-917f-dc98b25d6764") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("3bb06b4d-84a8-4266-917f-dc98b25d6764") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("3bb06b4d-84a8-4266-917f-dc98b25d6764") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("3d2ebd46-da0d-42d0-bb02-ab09f092115d") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("3d2ebd46-da0d-42d0-bb02-ab09f092115d") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("3d2ebd46-da0d-42d0-bb02-ab09f092115d") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("3f488e87-fca4-4c56-aba0-00c3b2bab605") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("3f488e87-fca4-4c56-aba0-00c3b2bab605") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("3f488e87-fca4-4c56-aba0-00c3b2bab605") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("40ad12f4-4996-41cb-9111-156a47feff70") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("40ad12f4-4996-41cb-9111-156a47feff70") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("40ad12f4-4996-41cb-9111-156a47feff70") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("442588ef-c63f-4137-bd7c-dcc787ce082b") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("442588ef-c63f-4137-bd7c-dcc787ce082b") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("442588ef-c63f-4137-bd7c-dcc787ce082b") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("44be6661-925d-480c-a803-f341d5d300ab") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("44be6661-925d-480c-a803-f341d5d300ab") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("44be6661-925d-480c-a803-f341d5d300ab") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("4541ace7-bb80-4e7a-a25c-6103c3c58193") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("4541ace7-bb80-4e7a-a25c-6103c3c58193") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("4541ace7-bb80-4e7a-a25c-6103c3c58193") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("45f2f538-c362-4157-a73c-9fe2f3f0a109") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("45f2f538-c362-4157-a73c-9fe2f3f0a109") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("45f2f538-c362-4157-a73c-9fe2f3f0a109") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("4655e0ab-311c-4876-9327-35a4f6b11dbe") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("4655e0ab-311c-4876-9327-35a4f6b11dbe") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("4655e0ab-311c-4876-9327-35a4f6b11dbe") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("46bef8fe-970a-434a-b86b-3144201495ea") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("46bef8fe-970a-434a-b86b-3144201495ea") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("46bef8fe-970a-434a-b86b-3144201495ea") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("48ba8fa4-96a6-4293-b10a-e9c146d59d5e") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("48ba8fa4-96a6-4293-b10a-e9c146d59d5e") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("48ba8fa4-96a6-4293-b10a-e9c146d59d5e") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("48fd7f3e-05f3-46c5-95c9-eceff844e59c") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("48fd7f3e-05f3-46c5-95c9-eceff844e59c") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("48fd7f3e-05f3-46c5-95c9-eceff844e59c") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("4965db90-4179-4297-a421-5c1ea8e4fc50") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("4965db90-4179-4297-a421-5c1ea8e4fc50") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("4965db90-4179-4297-a421-5c1ea8e4fc50") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("49947dcc-91d9-4433-ab60-0f240dbceb92") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("49947dcc-91d9-4433-ab60-0f240dbceb92") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("49947dcc-91d9-4433-ab60-0f240dbceb92") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("49eb307e-4a3f-43c1-bdaf-da7ee8020b7f") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("49eb307e-4a3f-43c1-bdaf-da7ee8020b7f") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("49eb307e-4a3f-43c1-bdaf-da7ee8020b7f") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("4a5b5dd6-0378-4e7b-a643-4e5aebbedbfc") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("4a5b5dd6-0378-4e7b-a643-4e5aebbedbfc") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("4a5b5dd6-0378-4e7b-a643-4e5aebbedbfc") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("4af42d68-019f-4fe2-ba21-e33107ab3570") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("4af42d68-019f-4fe2-ba21-e33107ab3570") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("4af42d68-019f-4fe2-ba21-e33107ab3570") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("4bf8a285-ecee-4786-938b-c22e3c7843cf") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("4bf8a285-ecee-4786-938b-c22e3c7843cf") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("4bf8a285-ecee-4786-938b-c22e3c7843cf") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("4f308676-f1a4-4f26-bff7-f6b1752fd35c") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("4f308676-f1a4-4f26-bff7-f6b1752fd35c") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("4f308676-f1a4-4f26-bff7-f6b1752fd35c") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("4f566db2-a4f1-4de4-af2b-c94403a571d0") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("4f566db2-a4f1-4de4-af2b-c94403a571d0") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("4f566db2-a4f1-4de4-af2b-c94403a571d0") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("4fc46ee2-c739-45ea-a15b-1b718141756e") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("4fc46ee2-c739-45ea-a15b-1b718141756e") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("4fc46ee2-c739-45ea-a15b-1b718141756e") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("5287fc76-6dea-4eae-9fbb-1d91cfe70c6b") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("5287fc76-6dea-4eae-9fbb-1d91cfe70c6b") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("5287fc76-6dea-4eae-9fbb-1d91cfe70c6b") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("541a31e2-bb03-42be-95fd-dbbfa0125b4d") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("541a31e2-bb03-42be-95fd-dbbfa0125b4d") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("541a31e2-bb03-42be-95fd-dbbfa0125b4d") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("54c8ba52-ef3b-41af-892e-829d49bbdbcb") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("54c8ba52-ef3b-41af-892e-829d49bbdbcb") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("54c8ba52-ef3b-41af-892e-829d49bbdbcb") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("55eccf50-44c1-4e70-b323-1e82aab13037") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("55eccf50-44c1-4e70-b323-1e82aab13037") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("55eccf50-44c1-4e70-b323-1e82aab13037") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("5815a21a-214b-484a-a54b-19ff31445e6d") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("5815a21a-214b-484a-a54b-19ff31445e6d") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("5815a21a-214b-484a-a54b-19ff31445e6d") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("58ab03bd-f6d4-4f1a-baf5-9185733821c3") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("58ab03bd-f6d4-4f1a-baf5-9185733821c3") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("58ab03bd-f6d4-4f1a-baf5-9185733821c3") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("58e6df3c-a5b5-42aa-91e3-ff6086fb2db6") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("58e6df3c-a5b5-42aa-91e3-ff6086fb2db6") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("58e6df3c-a5b5-42aa-91e3-ff6086fb2db6") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("59a142a7-1033-4495-8785-d3dbd3907a37") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("59a142a7-1033-4495-8785-d3dbd3907a37") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("59a142a7-1033-4495-8785-d3dbd3907a37") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("5d6ac73d-8c14-4d84-8f9e-f4932bcf58c2") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("5d6ac73d-8c14-4d84-8f9e-f4932bcf58c2") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("5d6ac73d-8c14-4d84-8f9e-f4932bcf58c2") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("5f9ccbb0-82de-4014-9e08-21f436cfad2c") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("5f9ccbb0-82de-4014-9e08-21f436cfad2c") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("5f9ccbb0-82de-4014-9e08-21f436cfad2c") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("5fc9be19-b651-454e-9b0c-c2b761522121") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("5fc9be19-b651-454e-9b0c-c2b761522121") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("5fc9be19-b651-454e-9b0c-c2b761522121") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("6053e92f-ee7a-45ee-b4da-af18fd486e68") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("6053e92f-ee7a-45ee-b4da-af18fd486e68") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("6053e92f-ee7a-45ee-b4da-af18fd486e68") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("61106be8-77f6-44a2-887a-6bde8eccf73b") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("61106be8-77f6-44a2-887a-6bde8eccf73b") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("61106be8-77f6-44a2-887a-6bde8eccf73b") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("611c88d5-7d70-42b4-9508-591568ab7df4") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("611c88d5-7d70-42b4-9508-591568ab7df4") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("611c88d5-7d70-42b4-9508-591568ab7df4") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("61b3a28b-419c-4170-84f8-e890a725a728") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("61b3a28b-419c-4170-84f8-e890a725a728") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("61b3a28b-419c-4170-84f8-e890a725a728") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("61f9738b-f8e6-4829-be2f-804bb7fff40e") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("61f9738b-f8e6-4829-be2f-804bb7fff40e") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("61f9738b-f8e6-4829-be2f-804bb7fff40e") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("63aac367-9ac5-4dc9-ae96-14d860a03f19") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("63aac367-9ac5-4dc9-ae96-14d860a03f19") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("63aac367-9ac5-4dc9-ae96-14d860a03f19") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("64930d87-d819-4e53-9a43-ba9781a5d88e") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("64930d87-d819-4e53-9a43-ba9781a5d88e") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("64930d87-d819-4e53-9a43-ba9781a5d88e") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("666cbf5c-f227-43c6-a5e4-0b46d3069f65") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("666cbf5c-f227-43c6-a5e4-0b46d3069f65") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("666cbf5c-f227-43c6-a5e4-0b46d3069f65") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("66e6c10a-f39d-4d59-9839-11bf3e71552c") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("66e6c10a-f39d-4d59-9839-11bf3e71552c") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("66e6c10a-f39d-4d59-9839-11bf3e71552c") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("687090a2-4066-4466-a66f-f0354a1420a5") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("687090a2-4066-4466-a66f-f0354a1420a5") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("687090a2-4066-4466-a66f-f0354a1420a5") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("689d05b4-0ce9-426a-a6b8-ee09f5027e21") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("689d05b4-0ce9-426a-a6b8-ee09f5027e21") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("689d05b4-0ce9-426a-a6b8-ee09f5027e21") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("6a31ef9b-9fdc-4b26-bd1c-a3f87a06b8a7") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("6a31ef9b-9fdc-4b26-bd1c-a3f87a06b8a7") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("6a31ef9b-9fdc-4b26-bd1c-a3f87a06b8a7") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("6adde0ab-5077-47f6-99fc-c67321ffd1b6") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("6adde0ab-5077-47f6-99fc-c67321ffd1b6") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("6adde0ab-5077-47f6-99fc-c67321ffd1b6") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("6af4f908-1442-4064-92f9-b8642b5020e5") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("6af4f908-1442-4064-92f9-b8642b5020e5") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("6af4f908-1442-4064-92f9-b8642b5020e5") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("6cd687eb-df78-4538-a726-e3dd2d615f6f") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("6cd687eb-df78-4538-a726-e3dd2d615f6f") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("6cd687eb-df78-4538-a726-e3dd2d615f6f") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("6deb362a-690d-47f7-a312-c965e9b6c90d") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("6deb362a-690d-47f7-a312-c965e9b6c90d") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("6deb362a-690d-47f7-a312-c965e9b6c90d") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("6ee5506e-1a3b-43ea-938f-ceccff0fadd2") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("6ee5506e-1a3b-43ea-938f-ceccff0fadd2") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("6ee5506e-1a3b-43ea-938f-ceccff0fadd2") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("70418e8e-ee78-4144-af39-1c973286eaaa") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("70418e8e-ee78-4144-af39-1c973286eaaa") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("70418e8e-ee78-4144-af39-1c973286eaaa") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("716f2b3d-0c09-480e-a4ad-bbbf12f77016") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("716f2b3d-0c09-480e-a4ad-bbbf12f77016") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("716f2b3d-0c09-480e-a4ad-bbbf12f77016") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("71d718fe-e626-40e1-97b8-e28c4eb561da") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("71d718fe-e626-40e1-97b8-e28c4eb561da") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("71d718fe-e626-40e1-97b8-e28c4eb561da") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("72ad3299-3ed5-487d-b256-9c2d3f91c41a") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("72ad3299-3ed5-487d-b256-9c2d3f91c41a") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("72ad3299-3ed5-487d-b256-9c2d3f91c41a") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("7398aed3-65c8-4425-bdf6-41b8c13f49c0") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("7398aed3-65c8-4425-bdf6-41b8c13f49c0") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("7398aed3-65c8-4425-bdf6-41b8c13f49c0") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("75f0496d-d1bf-459a-bce7-2246da53b609") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("75f0496d-d1bf-459a-bce7-2246da53b609") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("75f0496d-d1bf-459a-bce7-2246da53b609") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("775f8028-8524-4603-a2f9-1a0e5ba23230") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("775f8028-8524-4603-a2f9-1a0e5ba23230") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("775f8028-8524-4603-a2f9-1a0e5ba23230") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("785966d6-b3a8-43ac-b292-8fc5654d4b41") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("785966d6-b3a8-43ac-b292-8fc5654d4b41") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("785966d6-b3a8-43ac-b292-8fc5654d4b41") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("787aa6c7-eaf2-4c03-8540-231a7cb41fc0") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("787aa6c7-eaf2-4c03-8540-231a7cb41fc0") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("787aa6c7-eaf2-4c03-8540-231a7cb41fc0") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("7d28da3e-3bce-4f92-beb8-52621c8a4ddf") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("7d28da3e-3bce-4f92-beb8-52621c8a4ddf") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("7d28da3e-3bce-4f92-beb8-52621c8a4ddf") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("82255f85-e046-4644-9090-88dacb3e9a90") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("82255f85-e046-4644-9090-88dacb3e9a90") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("82255f85-e046-4644-9090-88dacb3e9a90") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("830a85a3-2975-47d0-9c05-32cc05b4f05e") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("830a85a3-2975-47d0-9c05-32cc05b4f05e") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("830a85a3-2975-47d0-9c05-32cc05b4f05e") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("83106ffe-a658-40b7-91fe-fe2bf8ed882d") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("83106ffe-a658-40b7-91fe-fe2bf8ed882d") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("83106ffe-a658-40b7-91fe-fe2bf8ed882d") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("83493076-412e-45b0-8ad9-9c1bb645f384") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("83493076-412e-45b0-8ad9-9c1bb645f384") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("83493076-412e-45b0-8ad9-9c1bb645f384") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("84520422-ecd8-4f0a-aa47-fcd730c6fb05") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("84520422-ecd8-4f0a-aa47-fcd730c6fb05") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("84520422-ecd8-4f0a-aa47-fcd730c6fb05") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("847331b6-5cdf-4162-8703-9e771f730d64") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("847331b6-5cdf-4162-8703-9e771f730d64") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("847331b6-5cdf-4162-8703-9e771f730d64") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("87007bab-56de-4301-9592-145c0e595f22") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("87007bab-56de-4301-9592-145c0e595f22") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("87007bab-56de-4301-9592-145c0e595f22") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("8ae98fc3-75f3-463a-a3f3-427cd7542b6b") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("8ae98fc3-75f3-463a-a3f3-427cd7542b6b") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("8ae98fc3-75f3-463a-a3f3-427cd7542b6b") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("8b5e1ec1-1d05-4b80-8627-b1652497a232") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("8b5e1ec1-1d05-4b80-8627-b1652497a232") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("8b5e1ec1-1d05-4b80-8627-b1652497a232") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("8b978676-ec06-4985-9a24-2859e588a0c5") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("8b978676-ec06-4985-9a24-2859e588a0c5") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("8b978676-ec06-4985-9a24-2859e588a0c5") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("8d6c7ddc-b585-44c9-bdcf-4f516ac00170") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("8d6c7ddc-b585-44c9-bdcf-4f516ac00170") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("8d6c7ddc-b585-44c9-bdcf-4f516ac00170") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("8e35a916-8be3-4837-9673-6d77029685e1") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("8e35a916-8be3-4837-9673-6d77029685e1") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("8e35a916-8be3-4837-9673-6d77029685e1") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("8e9b0804-5cac-42bf-85eb-cb9fe50d6108") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("8e9b0804-5cac-42bf-85eb-cb9fe50d6108") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("8e9b0804-5cac-42bf-85eb-cb9fe50d6108") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("8ec4e221-bb3b-4936-9da5-b81ee5d5c12a") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("8ec4e221-bb3b-4936-9da5-b81ee5d5c12a") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("8ec4e221-bb3b-4936-9da5-b81ee5d5c12a") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("8f28d5b3-0901-4581-9e9f-3bb72152b391") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("8f28d5b3-0901-4581-9e9f-3bb72152b391") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("8f28d5b3-0901-4581-9e9f-3bb72152b391") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("90c35989-5890-4a5b-82f4-43bfdb5c44d3") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("90c35989-5890-4a5b-82f4-43bfdb5c44d3") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("90c35989-5890-4a5b-82f4-43bfdb5c44d3") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("9110330a-941c-4b7d-92b0-ed8ae8523d81") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("9110330a-941c-4b7d-92b0-ed8ae8523d81") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("9110330a-941c-4b7d-92b0-ed8ae8523d81") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("9120f4b7-1083-446e-8b97-86a7306bbc12") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("9120f4b7-1083-446e-8b97-86a7306bbc12") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("9120f4b7-1083-446e-8b97-86a7306bbc12") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("93f1b876-e1ff-4173-8361-4013d98d5c4b") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("93f1b876-e1ff-4173-8361-4013d98d5c4b") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("93f1b876-e1ff-4173-8361-4013d98d5c4b") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("95e2ffd2-ff4f-4408-b9c0-ee78eba05a74") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("95e2ffd2-ff4f-4408-b9c0-ee78eba05a74") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("95e2ffd2-ff4f-4408-b9c0-ee78eba05a74") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("9867a970-8f20-4537-bfdc-0d060af33dbf") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("9867a970-8f20-4537-bfdc-0d060af33dbf") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("9867a970-8f20-4537-bfdc-0d060af33dbf") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("995d6ab1-9477-4b71-a236-ddbab6cef352") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("995d6ab1-9477-4b71-a236-ddbab6cef352") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("995d6ab1-9477-4b71-a236-ddbab6cef352") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("998df2b0-fcdb-42b5-8af4-78621b3f4225") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("998df2b0-fcdb-42b5-8af4-78621b3f4225") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("998df2b0-fcdb-42b5-8af4-78621b3f4225") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("9b0b1ee0-9af9-464b-85e9-b6a68b8ead08") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("9b0b1ee0-9af9-464b-85e9-b6a68b8ead08") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("9b0b1ee0-9af9-464b-85e9-b6a68b8ead08") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("9cd41ddd-82c2-4ab5-b5ff-7a2ed6818fb4") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("9cd41ddd-82c2-4ab5-b5ff-7a2ed6818fb4") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("9cd41ddd-82c2-4ab5-b5ff-7a2ed6818fb4") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("9d58ebc2-af8a-4ceb-bbb8-fd069e75dfcd") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("9d58ebc2-af8a-4ceb-bbb8-fd069e75dfcd") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("9d58ebc2-af8a-4ceb-bbb8-fd069e75dfcd") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("9e1f878f-8e0d-4d54-a770-e643c609b0e4") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("9e1f878f-8e0d-4d54-a770-e643c609b0e4") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("9e1f878f-8e0d-4d54-a770-e643c609b0e4") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("9f63c80a-2290-47b6-b702-f668e44ed8c0") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("9f63c80a-2290-47b6-b702-f668e44ed8c0") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("9f63c80a-2290-47b6-b702-f668e44ed8c0") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("9f688e9e-4fa1-41a8-a947-e9304839bdfe") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("9f688e9e-4fa1-41a8-a947-e9304839bdfe") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("9f688e9e-4fa1-41a8-a947-e9304839bdfe") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("a2ab83c3-1681-47b2-a95d-250f4c12268b") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("a2ab83c3-1681-47b2-a95d-250f4c12268b") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("a2ab83c3-1681-47b2-a95d-250f4c12268b") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("a42e6bfd-d89f-4627-8cc6-ac20a1c34d44") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("a42e6bfd-d89f-4627-8cc6-ac20a1c34d44") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("a42e6bfd-d89f-4627-8cc6-ac20a1c34d44") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("a5f5b3d4-c3a6-4933-9f67-47dd6e24b1c5") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("a5f5b3d4-c3a6-4933-9f67-47dd6e24b1c5") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("a5f5b3d4-c3a6-4933-9f67-47dd6e24b1c5") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("a60fa37b-ed2d-4a9c-8563-683f7e17ad28") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("a60fa37b-ed2d-4a9c-8563-683f7e17ad28") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("a60fa37b-ed2d-4a9c-8563-683f7e17ad28") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("a66a7d3a-8eeb-4c51-b540-bf2cc2738cf1") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("a66a7d3a-8eeb-4c51-b540-bf2cc2738cf1") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("a66a7d3a-8eeb-4c51-b540-bf2cc2738cf1") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("a756269e-60bf-46b5-ab5f-a90ba04bfb7d") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("a756269e-60bf-46b5-ab5f-a90ba04bfb7d") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("a756269e-60bf-46b5-ab5f-a90ba04bfb7d") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("a765d0db-82f1-44c1-995b-f0c85b5bba41") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("a765d0db-82f1-44c1-995b-f0c85b5bba41") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("a765d0db-82f1-44c1-995b-f0c85b5bba41") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("a8cc027b-1c82-4b7a-b646-fbcaa609fe6e") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("a8cc027b-1c82-4b7a-b646-fbcaa609fe6e") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("a8cc027b-1c82-4b7a-b646-fbcaa609fe6e") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("a98b4822-0959-414c-9497-97bc42d05b58") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("a98b4822-0959-414c-9497-97bc42d05b58") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("a98b4822-0959-414c-9497-97bc42d05b58") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("ab0f3925-12a5-43db-b8a8-03178dbf6488") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("ab0f3925-12a5-43db-b8a8-03178dbf6488") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("ab0f3925-12a5-43db-b8a8-03178dbf6488") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("ad74ce6f-c9e8-4130-be53-61e73cad057f") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("ad74ce6f-c9e8-4130-be53-61e73cad057f") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("ad74ce6f-c9e8-4130-be53-61e73cad057f") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("b009309c-1420-4f63-9749-fd9978e32da2") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("b009309c-1420-4f63-9749-fd9978e32da2") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("b009309c-1420-4f63-9749-fd9978e32da2") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("b186b8c6-7e39-4fdf-8e1e-38b29ec4f0cb") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("b186b8c6-7e39-4fdf-8e1e-38b29ec4f0cb") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("b186b8c6-7e39-4fdf-8e1e-38b29ec4f0cb") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("b51e0f50-cf53-4bc6-b0eb-b7bdd40c7224") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("b51e0f50-cf53-4bc6-b0eb-b7bdd40c7224") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("b51e0f50-cf53-4bc6-b0eb-b7bdd40c7224") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("b85694b4-fa61-4945-9ba3-0e73956c3812") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("b85694b4-fa61-4945-9ba3-0e73956c3812") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("b85694b4-fa61-4945-9ba3-0e73956c3812") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("bef79182-8380-4587-83cc-e6e7bcf6eb48") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("bef79182-8380-4587-83cc-e6e7bcf6eb48") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("bef79182-8380-4587-83cc-e6e7bcf6eb48") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("bf9224dc-2166-4638-a681-467ec5622124") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("bf9224dc-2166-4638-a681-467ec5622124") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("bf9224dc-2166-4638-a681-467ec5622124") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("c107bf5a-047b-4927-af16-7f4a7a10fbc2") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("c107bf5a-047b-4927-af16-7f4a7a10fbc2") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("c107bf5a-047b-4927-af16-7f4a7a10fbc2") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("c12d19b9-f7fa-4819-b064-bec9d8a00fa4") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("c12d19b9-f7fa-4819-b064-bec9d8a00fa4") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("c12d19b9-f7fa-4819-b064-bec9d8a00fa4") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("c152dade-e413-47d6-8c1d-2ed9b1e23a42") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("c152dade-e413-47d6-8c1d-2ed9b1e23a42") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("c152dade-e413-47d6-8c1d-2ed9b1e23a42") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("c415a761-7a91-48e2-a742-727a174161f7") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("c415a761-7a91-48e2-a742-727a174161f7") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("c415a761-7a91-48e2-a742-727a174161f7") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("c54e1f56-c3e2-4113-9dc0-b83b56627ded") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("c54e1f56-c3e2-4113-9dc0-b83b56627ded") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("c54e1f56-c3e2-4113-9dc0-b83b56627ded") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("c6024252-cae3-49bc-9808-b1ecced933dd") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("c6024252-cae3-49bc-9808-b1ecced933dd") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("c6024252-cae3-49bc-9808-b1ecced933dd") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("c6212e97-2bed-4852-990b-f31438b7f98a") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("c6212e97-2bed-4852-990b-f31438b7f98a") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("c6212e97-2bed-4852-990b-f31438b7f98a") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("c7011e0c-915e-46bf-9ec9-694c1ad0956b") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("c7011e0c-915e-46bf-9ec9-694c1ad0956b") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("c7011e0c-915e-46bf-9ec9-694c1ad0956b") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("c8187025-1c5c-4455-80dc-d681b6fd0eae") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("c8187025-1c5c-4455-80dc-d681b6fd0eae") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("c8187025-1c5c-4455-80dc-d681b6fd0eae") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("c9350533-35db-49de-94ed-65a371e43248") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("c9350533-35db-49de-94ed-65a371e43248") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("c9350533-35db-49de-94ed-65a371e43248") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("c9efd7a4-99a4-4124-bf45-990781471032") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("c9efd7a4-99a4-4124-bf45-990781471032") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("c9efd7a4-99a4-4124-bf45-990781471032") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("ca17343f-26ca-4922-a036-bffb456918f0") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("ca17343f-26ca-4922-a036-bffb456918f0") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("ca17343f-26ca-4922-a036-bffb456918f0") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("ca414129-6658-46a4-9708-971f73cc3616") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("ca414129-6658-46a4-9708-971f73cc3616") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("ca414129-6658-46a4-9708-971f73cc3616") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("cab10885-2d9c-48ae-9306-f9d07290953f") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("cab10885-2d9c-48ae-9306-f9d07290953f") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("cab10885-2d9c-48ae-9306-f9d07290953f") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("cc638689-6fcf-483d-9fe0-6913913421cc") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("cc638689-6fcf-483d-9fe0-6913913421cc") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("cc638689-6fcf-483d-9fe0-6913913421cc") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("d23c8efa-a2de-40a4-81d4-55caf85aedcf") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("d23c8efa-a2de-40a4-81d4-55caf85aedcf") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("d23c8efa-a2de-40a4-81d4-55caf85aedcf") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("d4a2c18e-9255-489e-a588-26f2dd7c6255") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("d4a2c18e-9255-489e-a588-26f2dd7c6255") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("d4a2c18e-9255-489e-a588-26f2dd7c6255") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("d5476484-68e7-4351-b2c9-11e5e79c458a") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("d5476484-68e7-4351-b2c9-11e5e79c458a") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("d5476484-68e7-4351-b2c9-11e5e79c458a") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("d5c9d9bf-7604-46e9-82ad-264eb71245f8") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("d5c9d9bf-7604-46e9-82ad-264eb71245f8") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("d5c9d9bf-7604-46e9-82ad-264eb71245f8") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("da3beeec-0bf7-4f99-9fe9-4a664117c541") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("da3beeec-0bf7-4f99-9fe9-4a664117c541") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("da3beeec-0bf7-4f99-9fe9-4a664117c541") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("da6227dd-7179-454c-b654-f267622455ae") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("da6227dd-7179-454c-b654-f267622455ae") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("da6227dd-7179-454c-b654-f267622455ae") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("dc7adfb9-232c-43ca-95c6-f3fbb8136164") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("dc7adfb9-232c-43ca-95c6-f3fbb8136164") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("dc7adfb9-232c-43ca-95c6-f3fbb8136164") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("e3d733f3-a977-4b2d-8624-87370fdeed77") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("e3d733f3-a977-4b2d-8624-87370fdeed77") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("e3d733f3-a977-4b2d-8624-87370fdeed77") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("e3eb10f1-ed77-4a3b-8157-af9612eed256") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("e3eb10f1-ed77-4a3b-8157-af9612eed256") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("e3eb10f1-ed77-4a3b-8157-af9612eed256") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("e4c6d766-57cc-42e8-b488-4ba80e520a3a") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("e4c6d766-57cc-42e8-b488-4ba80e520a3a") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("e4c6d766-57cc-42e8-b488-4ba80e520a3a") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("e5091fba-9732-4083-a7cd-b2e270f749ce") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("e5091fba-9732-4083-a7cd-b2e270f749ce") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("e5091fba-9732-4083-a7cd-b2e270f749ce") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("e55d91a3-2953-47b6-b05f-df5c6502cb32") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("e55d91a3-2953-47b6-b05f-df5c6502cb32") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("e55d91a3-2953-47b6-b05f-df5c6502cb32") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("e68f3a0f-3f56-4f1a-8bc8-9a7f3279004a") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("e68f3a0f-3f56-4f1a-8bc8-9a7f3279004a") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("e68f3a0f-3f56-4f1a-8bc8-9a7f3279004a") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("e75c12a0-bae8-4186-87a1-f194de5ec477") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("e75c12a0-bae8-4186-87a1-f194de5ec477") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("e75c12a0-bae8-4186-87a1-f194de5ec477") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("e810fe6c-03fe-4895-8b59-9182cd6a41bb") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("e810fe6c-03fe-4895-8b59-9182cd6a41bb") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("e810fe6c-03fe-4895-8b59-9182cd6a41bb") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("eae9323a-1757-4bfa-b502-69ba792d5198") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("eae9323a-1757-4bfa-b502-69ba792d5198") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("eae9323a-1757-4bfa-b502-69ba792d5198") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("ec03856c-3460-4fff-91c9-3fe16e7e39cb") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("ec03856c-3460-4fff-91c9-3fe16e7e39cb") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("ec03856c-3460-4fff-91c9-3fe16e7e39cb") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("ee43063b-2a30-4e7b-a024-d0c25e803a81") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("ee43063b-2a30-4e7b-a024-d0c25e803a81") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("ee43063b-2a30-4e7b-a024-d0c25e803a81") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("ef9af11d-d63e-4617-8a10-ed86f049f022") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("ef9af11d-d63e-4617-8a10-ed86f049f022") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("ef9af11d-d63e-4617-8a10-ed86f049f022") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("f129fa8b-a508-4af8-8c61-bb315d4f88e2") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("f129fa8b-a508-4af8-8c61-bb315d4f88e2") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("f129fa8b-a508-4af8-8c61-bb315d4f88e2") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("f4a8131d-a39c-4e73-9082-3c37205e88f3") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("f4a8131d-a39c-4e73-9082-3c37205e88f3") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("f4a8131d-a39c-4e73-9082-3c37205e88f3") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("f4fbfc08-593d-4f47-b17f-c967749c646a") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("f4fbfc08-593d-4f47-b17f-c967749c646a") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("f4fbfc08-593d-4f47-b17f-c967749c646a") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("f514cdc8-7545-4f7e-a00c-e2f87d72e603") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("f514cdc8-7545-4f7e-a00c-e2f87d72e603") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("f514cdc8-7545-4f7e-a00c-e2f87d72e603") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("f7d4840f-cb8b-4673-b26d-ed2791bcefa4") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("f7d4840f-cb8b-4673-b26d-ed2791bcefa4") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("f7d4840f-cb8b-4673-b26d-ed2791bcefa4") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("fb0eb65c-4e48-45af-ae2c-890ab3379483") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("fb0eb65c-4e48-45af-ae2c-890ab3379483") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("fb0eb65c-4e48-45af-ae2c-890ab3379483") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("fbf2b975-ed37-4b0e-b793-9ec3547a84e5") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("fbf2b975-ed37-4b0e-b793-9ec3547a84e5") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("fbf2b975-ed37-4b0e-b793-9ec3547a84e5") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("fd06bba9-f75c-4679-abe2-ce455ebaa86e") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("fd06bba9-f75c-4679-abe2-ce455ebaa86e") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("fd06bba9-f75c-4679-abe2-ce455ebaa86e") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("fd0be251-42b7-4117-9af6-d554974e4f84") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("fd0be251-42b7-4117-9af6-d554974e4f84") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("fd0be251-42b7-4117-9af6-d554974e4f84") },
                    { new Guid("633a48b0-094b-460c-9074-e96bcc4c6d07"), new Guid("ff6c896d-800d-4087-a965-fa31e013227a") },
                    { new Guid("b3766ddd-d286-406a-8f75-1ca586e9262b"), new Guid("ff6c896d-800d-4087-a965-fa31e013227a") },
                    { new Guid("db8d3de7-77d9-41bc-a7f5-a3137cdb5d4d"), new Guid("ff6c896d-800d-4087-a965-fa31e013227a") }
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
