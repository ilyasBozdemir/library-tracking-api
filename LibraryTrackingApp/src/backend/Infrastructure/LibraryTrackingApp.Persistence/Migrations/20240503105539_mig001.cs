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
                    { new Guid("1ca4f3d3-b0fb-44ef-b612-bf5e513653dc"), null, "95d11187-250b-410d-9ea5-e34d98fc486a", "Staff", "STAFF" },
                    { new Guid("501cb1a0-73bc-487f-a682-8ea42bd5fb19"), null, "72b2a8d5-e051-43cf-81b8-d7e9ad528df5", "Member", "MEMBER" },
                    { new Guid("a815bb6a-6adc-4146-a062-19552561e729"), null, "5788c54e-0fb4-42f2-a189-57bc531ef31e", "system", "SYSTEM" },
                    { new Guid("efd1a7c5-a51c-4f44-8f5b-aba3fad798db"), null, "a5effdb5-fcaa-4259-81b5-245ccff33cfb", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "ConcurrencyStamp", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Email", "EmailConfirmed", "Gender", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "RefreshToken", "RefreshTokenEndDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 0, "123 System St.", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "75757a31-ac0c-4313-b133-fbba7d0ed867", new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, "system@domain.com", true, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, false, null, "System", "SYSTEM@DOMAIN.COM", "SYSTEM", "AQAAAAIAAYagAAAAEE5iGKqV0lKcwrBbqzvOtulsiETlbH7u+QaNehrRFrF/oHHU74OsfmGxFkms0VbCkw==", null, false, new byte[0], null, null, "", "Admin", false, "system" },
                    { new Guid("2c59a581-3627-487a-a005-e2f203d6f0e9"), 0, "456 Oak Street", new DateTime(1985, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "14dc835e-30fe-4708-8509-e8a4ddeb4c90", new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 0L, null, "jane.smith@example.com", true, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, false, null, "Jane", "JANE.SMITH@EXAMPLE.COM", "JANE.SMITH@EXAMPLE.COM", "AQAAAAIAAYagAAAAENA7IMeONyCAVOE/dFs6CZ5QBB/ufChCEFf+bZ7cB7C1nZKzvK41076geU95RI7z3Q==", null, false, new byte[0], null, null, "", "Smith", false, "jane.smith@example.com" },
                    { new Guid("46cfdabf-8076-418c-a38e-f8314240cf85"), 0, "789 Employee St.", new DateTime(1990, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "5b04ffc0-af1b-4e7d-906c-a37d285784f7", new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 0L, null, "employee1@example.com", true, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, false, null, "Employee", "EMPLOYEE1@EXAMPLE.COM", "EMPLOYEE1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEP0Oet5nhCHRNu9VGM12R3va0SbbzQ8lm4gBKGr3lFNxHtJTCCIaEAcPBmk5lobI4Q==", null, false, new byte[0], null, null, "", "One", false, "employee1@example.com" },
                    { new Guid("7874fec5-5004-4ae2-b6e2-0480d4c28516"), 0, "123 Main Street", new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "b49010c5-4eae-453f-a510-0c6102439717", new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 0L, null, "john.doe@example.com", true, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, false, null, "John", "JOHN.DOE@EXAMPLE.COM", "JOHN.DOE@EXAMPLE.COM", "AQAAAAIAAYagAAAAECPuVyfE3rLXSuj0EuWRoWAXuEPd2gsnJgHk75J9ghxSuum2ACmGr/MoXGSdNQSQMQ==", null, false, new byte[0], null, null, "", "Doe", false, "john.doe@example.com" },
                    { new Guid("e2b1920f-ad4c-4077-a855-d7a949c265ab"), 0, "456 Admin St.", new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "789c205f-dcd0-4e33-8d4e-df104a0a22b9", new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 0L, null, "admin@example.com", true, 0, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, false, null, "Admin", "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAECyfh23P2QnTIu6bjdlVcxOyY2gi207f2TdPa4PB1TZazTgjF0hjOrZ5DQY92np7Ag==", null, false, new byte[0], null, null, "", "Admin", false, "admin@example.com" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Authors",
                columns: new[] { "Id", "Biography", "BirthDate", "Country", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "Surname", "Website" },
                values: new object[] { new Guid("d1529cff-b2e4-4365-8d6a-e125295a231c"), "Joanne Rowling, better known by her pen name J.K. Rowling, is a British author, philanthropist, film producer, television producer, and screenwriter. She is best known for writing the Harry Potter fantasy series.", new DateTime(1965, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "United Kingdom", new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, "J.K.", "Rowling", "www.example.com" });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "LibraryBranches",
                columns: new[] { "Id", "Address", "AppUserId", "CreatedById", "CreatedDateUnix", "CriticalLevelThreshold", "DeletedDateUnix", "Description", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "MaxCheckoutDurationInDays", "MaxCheckoutLimit", "MinCheckoutDurationInDays", "Name", "NotifyOnBookOrBlogComment", "PhoneNumber", "TopBooksReportLimit", "TopMembersReportLimit" },
                values: new object[,]
                {
                    { new Guid("552f9308-2db6-4be3-b1e4-cd5c5357792d"), "789 Üçüncü Bulvar, No: 23", null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, 8, null, "Yıldızlar Kütüphanesi, gökyüzünü aşkın kitaplarla dolu bir yerdir.", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, 14, 10, 3, "Yıldızlar Kütüphanesi", false, "+90 (212) 987 6543", 10, 10 },
                    { new Guid("dc4e20a5-fac0-48a6-bca2-3e0ef0eebc8d"), "456 İkinci Sokak, No: 15", null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, 6, null, "Ana Kütüphane Şubesi, şehrin kalbindeki kitapseverler için bir buluşma noktasıdır.", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, 10, 7, 4, "Ana Kütüphane Şubesi", true, "+90 (212) 123 4567", 7, 7 }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "WorkGenres",
                columns: new[] { "Id", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsActive", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name" },
                values: new object[,]
                {
                    { new Guid("1f394d7f-6baa-4603-9443-9987d35dde37"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, "Adventure" },
                    { new Guid("858f344b-be54-410d-ab5c-a63fa37e1582"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, "Fantasy" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "WorkPublishers",
                columns: new[] { "Id", "Address", "City", "Country", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Email", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "PhoneNumber", "Website" },
                values: new object[,]
                {
                    { new Guid("4728e242-39a5-4bb1-a744-7722776c3d09"), "50 Bedford Square, London, England", "London", "England", new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, "info@bloomsbury.com", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, "Bloomsbury Publishing", "+44 (0)20 7631 5600", "https://www.bloomsbury.com/" },
                    { new Guid("4b01eba8-54ca-4b26-892f-7722edd25c7c"), "80 Strand, London, England", "London", "England", new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, "info@penguin.co.uk", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, "Penguin Books", "+44 (0)20 7139 3000", "https://www.penguin.co.uk/" },
                    { new Guid("d4fb1e33-d0bd-472c-8e29-1240e03298d0"), "1745 Broadway, New York, NY, USA", "New York", "USA", new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, "info@randomhouse.com", false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, "Random House", "+1 212-782-9000", "https://www.randomhousebooks.com/" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "WorkTags",
                columns: new[] { "Id", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "WorkCatalogId" },
                values: new object[,]
                {
                    { new Guid("222baba6-2830-4043-a2cd-bfb3a361b7b8"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, "Harry Potter", new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c") },
                    { new Guid("2c7fbf66-0138-4285-b295-bec7bccc928a"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, "Hogwarts", new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c") },
                    { new Guid("eb8aa1b9-0ff8-4bcc-9668-89c89179f306"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, "Quidditch", new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("1ca4f3d3-b0fb-44ef-b612-bf5e513653dc"), new Guid("46cfdabf-8076-418c-a38e-f8314240cf85"), "AppUserRole" },
                    { new Guid("efd1a7c5-a51c-4f44-8f5b-aba3fad798db"), new Guid("e2b1920f-ad4c-4077-a855-d7a949c265ab"), "AppUserRole" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BranchHours",
                columns: new[] { "Id", "ClosingTime", "CreatedById", "CreatedDateUnix", "DayOfWeek", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "OpeningTime" },
                values: new object[,]
                {
                    { new Guid("13340398-4e58-471b-8637-8cc830ed05ff"), new TimeSpan(0, 17, 30, 0, 0), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, new Guid("dc4e20a5-fac0-48a6-bca2-3e0ef0eebc8d"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("50f19430-13dc-44f4-a557-ded5fe1a301a"), new TimeSpan(0, 17, 30, 0, 0), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, new Guid("dc4e20a5-fac0-48a6-bca2-3e0ef0eebc8d"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("59d0a698-9a3f-4993-993d-00fe4449cbd0"), new TimeSpan(0, 17, 30, 0, 0), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, new Guid("dc4e20a5-fac0-48a6-bca2-3e0ef0eebc8d"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("5e81eef7-f9bb-4583-af53-589c384bc5b0"), new TimeSpan(0, 17, 30, 0, 0), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, new Guid("dc4e20a5-fac0-48a6-bca2-3e0ef0eebc8d"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("a425127f-8b5f-4c7b-a868-605930c448fa"), new TimeSpan(0, 17, 30, 0, 0), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, new Guid("dc4e20a5-fac0-48a6-bca2-3e0ef0eebc8d"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("bb119154-b00e-42fa-a0fc-bf0c3ba2059f"), new TimeSpan(0, 17, 30, 0, 0), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, new Guid("dc4e20a5-fac0-48a6-bca2-3e0ef0eebc8d"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("c1e90622-d593-465a-a7cf-5fb5a2d7904d"), new TimeSpan(0, 0, 0, 0, 0), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, 0, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, new Guid("dc4e20a5-fac0-48a6-bca2-3e0ef0eebc8d"), new TimeSpan(0, 0, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Editions",
                columns: new[] { "Id", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "EditionNumber", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Notes", "PublicationDate", "PublisherId", "WorkInventoryId", "WorkPublisherId" },
                values: new object[,]
                {
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, 2, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Second edition of Harry Potter and the Philosopher's Stone.", new DateTime(1998, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4b01eba8-54ca-4b26-892f-7722edd25c7c"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), null },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, 3, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Third edition of Harry Potter and the Philosopher's Stone.", new DateTime(1999, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d4fb1e33-d0bd-472c-8e29-1240e03298d0"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), null },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("00000000-0000-0000-0000-000000000000"), 0L, null, 1, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), null, "First edition of Harry Potter and the Philosopher's Stone.", new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4728e242-39a5-4bb1-a744-7722776c3d09"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), null }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Members",
                columns: new[] { "Id", "BorrowId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "ExtensionDurationInDays", "Gender", "HasPenalty", "IsDeleted", "IsDeletedById", "IsExtensionAllowed", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "MaxLateReturnsAllowed", "MemberType", "MembershipDate", "MembershipStatus", "NumberOfLateReturns", "Occupation", "PenaltyDurationInDays", "UserId" },
                values: new object[,]
                {
                    { new Guid("1a3c65e5-d70f-4161-b3b5-bcb089e58dcb"), null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, 0, "Female", true, false, new Guid("00000000-0000-0000-0000-000000000000"), false, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, new Guid("dc4e20a5-fac0-48a6-bca2-3e0ef0eebc8d"), 3, "Teacher", new DateTime(2024, 5, 3, 13, 55, 39, 98, DateTimeKind.Local).AddTicks(7309), "Active", 2, "Teacher", 7, new Guid("2c59a581-3627-487a-a005-e2f203d6f0e9") },
                    { new Guid("a75435f3-e199-44ea-8b9b-60958802f3e7"), null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, 7, "Male", false, false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, new Guid("dc4e20a5-fac0-48a6-bca2-3e0ef0eebc8d"), 3, "Adult", new DateTime(2024, 5, 3, 13, 55, 39, 98, DateTimeKind.Local).AddTicks(7303), "Active", 0, "Software Engineer", 0, new Guid("7874fec5-5004-4ae2-b6e2-0480d4c28516") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Shelves",
                columns: new[] { "Id", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "Name" },
                values: new object[,]
                {
                    { new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, new Guid("dc4e20a5-fac0-48a6-bca2-3e0ef0eebc8d"), "Shelf 4" },
                    { new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, new Guid("dc4e20a5-fac0-48a6-bca2-3e0ef0eebc8d"), "Shelf 2" },
                    { new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, new Guid("dc4e20a5-fac0-48a6-bca2-3e0ef0eebc8d"), "Shelf 3" },
                    { new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, new Guid("dc4e20a5-fac0-48a6-bca2-3e0ef0eebc8d"), "Shelf 1" }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Staffs",
                columns: new[] { "Id", "Address", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "EmploymentDate", "IsDeleted", "IsDeletedById", "IsFullTime", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "Phone", "Salary", "UserId" },
                values: new object[] { new Guid("74a1ff0e-8d0a-461e-b8ad-ced3bc42d1d4"), "Employee Address", new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, new DateTime(2024, 5, 3, 13, 55, 39, 98, DateTimeKind.Local).AddTicks(7342), false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, new Guid("dc4e20a5-fac0-48a6-bca2-3e0ef0eebc8d"), "+905553331122", 3000.00m, new Guid("46cfdabf-8076-418c-a38e-f8314240cf85") });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "WorkCatalogs",
                columns: new[] { "Id", "AudioFilePath", "AuthorId", "CoverImageUrl", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "DeweyCode", "Editor", "FavoriteListId", "FilePath", "GenreId", "HasTagPrinted", "ISBN", "IsApproved", "IsBorrowable", "IsDeleted", "IsDeletedById", "IsFeatured", "LastModifiedById", "LastModifiedDateUnix", "LibraryBranchId", "OriginalPublicationDate", "PageCount", "PublicationDate", "PublisherId", "ReadingListId", "Summary", "Title", "Translator", "WorkFormat", "WorkLanguage", "WorkStatus" },
                values: new object[] { new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), null, new Guid("d1529cff-b2e4-4365-8d6a-e125295a231c"), "https://m.media-amazon.com/images/I/81q77Q39nEL._SY385_.jpg", new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, "800", null, null, null, new Guid("858f344b-be54-410d-ab5c-a63fa37e1582"), false, "9781408855652", true, true, false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, new Guid("dc4e20a5-fac0-48a6-bca2-3e0ef0eebc8d"), new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 352, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4728e242-39a5-4bb1-a744-7722776c3d09"), null, "Harry Potter has never even heard of Hogwarts when the letters start dropping on the doormat at number four, Privet Drive.\r\nAddressed in green ink on yellowish parchment with a purple seal, they are swiftly confiscated by his grisly aunt and uncle.\r\nThen, on Harry's eleventh birthday, a great beetle-eyed giant of a man called Rubeus Hagrid bursts in with some astonishing news: Harry Potter is a wizard, and he has a place at Hogwarts School of Witchcraft and Wizardry. An incredible adventure is about to begin!", "Harry Potter and the Philosopher's Stone", null, "PrintedBook", "English", "Active" });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Author_WorkCatalogs",
                columns: new[] { "AuthorId", "WorkCatalogId" },
                values: new object[] { new Guid("d1529cff-b2e4-4365-8d6a-e125295a231c"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c") });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "LibraryBranch_Member",
                columns: new[] { "LibraryBranchId", "MemberId" },
                values: new object[,]
                {
                    { new Guid("552f9308-2db6-4be3-b1e4-cd5c5357792d"), new Guid("1a3c65e5-d70f-4161-b3b5-bcb089e58dcb") },
                    { new Guid("dc4e20a5-fac0-48a6-bca2-3e0ef0eebc8d"), new Guid("1a3c65e5-d70f-4161-b3b5-bcb089e58dcb") },
                    { new Guid("dc4e20a5-fac0-48a6-bca2-3e0ef0eebc8d"), new Guid("a75435f3-e199-44ea-8b9b-60958802f3e7") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Tag_WorkCatalogs",
                columns: new[] { "TagId", "WorkCatalogId" },
                values: new object[,]
                {
                    { new Guid("222baba6-2830-4043-a2cd-bfb3a361b7b8"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c") },
                    { new Guid("2c7fbf66-0138-4285-b295-bec7bccc928a"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c") },
                    { new Guid("eb8aa1b9-0ff8-4bcc-9668-89c89179f306"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "WorkCompartments",
                columns: new[] { "Id", "BookInventoryItemId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Name", "ShelfId" },
                values: new object[,]
                {
                    { new Guid("0687abd2-6746-4683-aba4-f4299688328a"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, "Compartment 2", new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6") },
                    { new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, "Compartment 4", new Guid("bbada433-922d-4330-8764-889dd2a387bb") },
                    { new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, "Compartment 3", new Guid("bbada433-922d-4330-8764-889dd2a387bb") },
                    { new Guid("2f522302-8d0a-4217-adea-831e584f63cb"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, "Compartment 1", new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643") },
                    { new Guid("427927be-637c-4744-bc27-712321117645"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, "Compartment 3", new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99") },
                    { new Guid("490bb461-c4a6-4830-83e3-28ed59d8390f"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, "Compartment 5", new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643") },
                    { new Guid("4ae27313-df1e-47c4-8f39-9feb34d18039"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, "Compartment 4", new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99") },
                    { new Guid("570025d6-3319-4e00-b104-fc9c382a9236"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, "Compartment 5", new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99") },
                    { new Guid("58c2c27e-46fb-45eb-a7a0-be7e6be8a9cb"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, "Compartment 4", new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6") },
                    { new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, "Compartment 2", new Guid("bbada433-922d-4330-8764-889dd2a387bb") },
                    { new Guid("80b50054-c134-4213-a7e4-64cc5868996a"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, "Compartment 1", new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6") },
                    { new Guid("88df95d2-9fab-496f-8ec6-e70107af193b"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, "Compartment 5", new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6") },
                    { new Guid("8bd63ba8-2113-4f6a-be51-18771b0fe393"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, "Compartment 3", new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6") },
                    { new Guid("91ddf33e-87af-43c5-a576-0949141109a4"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, "Compartment 3", new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643") },
                    { new Guid("96e6e36c-8e49-4c4a-ad7c-7b51a16e001c"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, "Compartment 4", new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643") },
                    { new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, "Compartment 5", new Guid("bbada433-922d-4330-8764-889dd2a387bb") },
                    { new Guid("ce6e5c00-e245-41e1-8b65-c8b15ea8baa1"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, "Compartment 2", new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643") },
                    { new Guid("d0b43a00-6479-4195-8ee6-380e06e4d588"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, "Compartment 2", new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99") },
                    { new Guid("d9b9e897-3e00-4807-8468-0c704fafd622"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, "Compartment 1", new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99") },
                    { new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, "Compartment 1", new Guid("bbada433-922d-4330-8764-889dd2a387bb") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "WorkInventories",
                columns: new[] { "Id", "BookNumber", "BookStatus", "BookStockTransactionType", "BorrowLendId", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "Description", "Donor", "EditionId", "IsAvailable", "IsDeleted", "IsDeletedById", "LastModifiedById", "LastModifiedDateUnix", "Notes", "ShelfId", "WorkCatalogId", "WorkCompartmentId" },
                values: new object[,]
                {
                    { new Guid("02024645-0961-439b-bd43-6d78786471db"), "HP-96", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("04329c42-d266-4c9a-89ae-e2b913ef7799"), "HP-82", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("04357fd3-dc07-4e1d-9be3-b57c80efd01c"), "HP-197", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("04d0ecd2-8954-4f12-83be-723a8440116f"), "HP-46", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("060f2c64-9b0d-4661-a276-a69d36278dc8"), "HP-160", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("0624215f-3650-41a1-8ba7-c37e063d2138"), "HP-195", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("075a3b8d-94c3-40ad-967f-1227c1d68308"), "HP-170", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("0975aaf2-2c4e-4d29-866a-dc4a02ed8512"), "HP-112", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("097ecc08-cec7-4d29-8091-c478ce3dda67"), "HP-110", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("09f83da2-d38e-4648-b4a5-f6789e677859"), "HP-90", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("0a3e2bd9-c5c4-4110-baed-18d2f4669657"), "HP-36", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("0c89807d-a0e6-4adc-befa-023fb0396744"), "HP-4", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("0c9e288f-d7f3-4646-afec-2e164b62769b"), "HP-32", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("0e65c69f-4c5c-4bc1-bee8-e33d8ab5a2e6"), "HP-42", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("0f88556a-1e3f-42a1-b0a4-c7390d12216e"), "HP-28", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("102349d3-7add-49d8-9e23-ee689b5f9607"), "HP-115", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("10a8659c-e29b-4b91-afcd-463fd4d88345"), "HP-165", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("10e38ffb-df66-43cd-9505-97a6721cba80"), "HP-30", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("11766781-058b-487b-bad0-2e74fff44804"), "HP-199", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("1293170f-4bea-4af7-bc1c-e3b362bfdfa5"), "HP-15", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("1557e92f-36fb-41a0-8ce6-5be7e58a7dad"), "HP-132", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("15ddb142-69d9-4cf4-92d2-59637235e898"), "HP-173", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("16550c25-7537-4a1e-8e40-90d41c5a2bda"), "HP-127", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("19117887-f18d-4b65-9d3b-8bc8d9b1e9c9"), "HP-157", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("19e8067c-2635-40d3-b80e-d6121ffd16d7"), "HP-18", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("1bfe035b-54ed-4c41-b120-f25d98591bbb"), "HP-148", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("1f0ceefb-9ce3-4277-a76e-22bf47868a5d"), "HP-41", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("2083f784-0224-4c17-83aa-a6bfa257192a"), "HP-187", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("213e7bee-01a2-41eb-9cfa-08657eac7beb"), "HP-14", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("22075e8c-a7ed-43bb-83af-6a07a6177e7f"), "HP-13", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("234d9e33-d468-4760-a979-4b41e80d9f99"), "HP-40", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("2402a6bb-32c5-45de-a601-9b847a7623f1"), "HP-191", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("245e1b38-a0d7-4adb-b349-32baf66d16ee"), "HP-168", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("2561e547-fb79-4609-ad1f-b7359087dc6b"), "HP-99", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("25f3bef9-6bb7-45a0-b169-08289ebd683e"), "HP-178", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("288d89f0-0d38-47c0-bcd7-f3bf2140ba9a"), "HP-185", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("2a7f2ce9-f44d-4966-a75b-8f2dfad72d9f"), "HP-106", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("2aeb7ca8-5a14-40cc-9ef8-43482e7fa57b"), "HP-179", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("2de56422-140f-4494-9993-339b38a9b47e"), "HP-57", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("2e0e6bdc-e62a-4259-a0c0-8017855f41bc"), "HP-114", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("2e730971-8cff-4775-a359-75e611a3a862"), "HP-79", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("2f9b14e5-52e3-4f4f-8a6d-8a3b0521e875"), "HP-85", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("2fa460da-60d5-45bc-966d-1cf1d162e85e"), "HP-70", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("30c1eda5-7060-46d8-807b-99a0356c97d1"), "HP-91", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("31071509-57b5-47a4-8c9f-27d49c65bfaf"), "HP-31", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("35422876-49a0-4e61-844b-e33b810f433c"), "HP-88", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("35484189-324f-48fa-8431-4f839f042b87"), "HP-81", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("38174c4c-451d-4551-a8ae-641d09a2d654"), "HP-194", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("39d3eb94-e66c-4a13-9c4c-f94218cd4a42"), "HP-21", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("3b59ec11-b47b-4396-acfa-d1a600b94138"), "HP-50", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("3bcf79ba-4fef-401a-9494-3e733993e25e"), "HP-175", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("407eac41-5d40-44cd-942e-82539d2fa712"), "HP-64", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("41af852d-fae3-45cc-b0ba-f6083b3373ff"), "HP-63", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("422d1a4a-75ce-4dad-8159-f40e79de42b5"), "HP-122", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("4355ca1c-e527-4dba-883e-ac8ca9bcd8f2"), "HP-192", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("43a73dee-fd96-4b78-a270-de3ddafb4539"), "HP-95", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("45810d0d-8c9b-4c54-bff1-980d8d681f65"), "HP-17", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("4935101c-608b-4578-826b-ad17a4e0fc3b"), "HP-123", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("4b7951c2-c3a5-4555-a01e-bdf5fa05e8e4"), "HP-67", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("4b8267f7-acc8-4e28-b18e-c46df505f315"), "HP-49", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("4d868f1e-3e61-4e19-82c5-9193e204587f"), "HP-142", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("4f7564d9-b6ca-4d07-bb41-fbf207605a97"), "HP-102", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("4feb5764-45d6-4c68-882f-f70e286588c1"), "HP-161", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("5057bb83-d249-40d2-bdd9-600ab97f613f"), "HP-8", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("51b68c40-1227-4f86-a025-0de50e9cd4c3"), "HP-190", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("54623db4-782b-4646-8f75-9edabd8d8b1a"), "HP-125", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("546f5e82-e422-490d-aced-44e9457fee0a"), "HP-174", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("57c88d58-6d4d-4a26-a615-ba574d535e75"), "HP-19", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("57ebec9e-44f6-4e9d-b216-336ebcbf86d2"), "HP-183", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("585663df-5c85-4687-a7d0-4eba60bcf5b6"), "HP-51", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("58827a47-907e-4c91-88b0-724e20fec5dd"), "HP-16", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("58ae9af3-e766-4ec5-8cd2-5171e1cc192d"), "HP-3", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("58cc3ac3-bbb3-4c93-a549-56ad20143d5d"), "HP-155", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("5a76cdae-df91-448e-90b1-9ab14ec1b1a6"), "HP-62", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("5ce82185-2c7f-4eb4-8cf6-a21d509d1732"), "HP-2", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("5f471c49-780c-4a07-b737-289f26dc435b"), "HP-171", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("60849b95-56f6-4345-8391-a7eb42ceff47"), "HP-150", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("6335d3e3-5737-420c-a494-0ed628370f0c"), "HP-100", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("64352f98-936c-4f04-809a-35f4dbe3b77b"), "HP-176", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("65727a8b-9023-40c6-aeb9-0e08363af68c"), "HP-108", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("66043067-5cef-45f8-97e4-6821e994ec45"), "HP-9", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("68f975ca-5d94-42ed-b154-3d5d57d8fed9"), "HP-193", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("691dc040-e68a-4625-a99f-346821751b00"), "HP-163", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("69f80bf3-b638-44d0-8956-4d4a82a8024d"), "HP-135", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("6c9ec93f-c041-4b40-a8b7-024d6fbb954b"), "HP-172", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("6d0f802f-cf67-4204-a472-fd07680dc584"), "HP-124", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("7031686e-a380-4974-9d0c-e804320b64a9"), "HP-149", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("7193b830-1cf8-45e5-8b65-a3639a8e57cd"), "HP-39", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("7424c5c8-3839-4a4c-9df1-a8433cae49e8"), "HP-29", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("76ba3920-5ed3-4423-8dab-ba32cef15fd5"), "HP-11", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("7717beb6-bf75-464c-b13b-1b32600295da"), "HP-6", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("7dee6545-d874-4aec-8904-1d85d2b19765"), "HP-104", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("7ec3b725-31a3-4efa-804e-e4f3d2e095e1"), "HP-58", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("7f0b2a5c-bd05-4fac-8d7d-cbdf8bd0513b"), "HP-117", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("7f3ae85d-3381-4bf1-a271-fcd3363bedd0"), "HP-75", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("80967e60-3c25-40fd-b478-39830166ece2"), "HP-74", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("8145bdcc-612b-44f0-a191-08c082dd206a"), "HP-131", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("81da8565-b9e6-46a6-ad94-1d7d491a8aed"), "HP-147", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("827fd7e4-cc34-4bab-a057-dcb8e1ea9a5e"), "HP-107", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("85053df5-1ccd-49e2-9c52-81cd66ee8675"), "HP-94", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("851df43c-e9f0-44d1-9ddf-0f31fd95d238"), "HP-180", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("864fe09d-5795-4c1e-90e7-e2451314e934"), "HP-60", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("86e765cc-0774-462a-9641-29bbef5a629d"), "HP-45", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("88b3199e-e5d1-4b93-b96c-c34d2b0769ab"), "HP-152", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("895546b2-2961-4d8d-ad53-8cd3e4ac7e50"), "HP-22", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("8a9189fa-37b2-4666-b87a-f5b775f5590c"), "HP-145", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("8b4be57e-f8d9-49a9-b08d-e98637a6a9f1"), "HP-119", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("8c623929-c71c-4055-9ff3-4e8881681903"), "HP-86", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("8cd38082-8079-4b55-a3c2-ccaa7085085f"), "HP-71", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("8f4179cd-31b9-48a5-977a-57559706d3a3"), "HP-93", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("8f79e1c2-1dbb-4993-b0c4-9ad36370dc48"), "HP-65", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("91745ef0-4ef6-4835-b546-0b24e4c67c66"), "HP-164", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("92a78343-eebf-432a-aa23-34f598df97d0"), "HP-10", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("94c56169-2447-4fdc-a113-c4d4ae8eb92b"), "HP-83", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("9bdd661b-619b-4f54-862c-d8cdd710bb0b"), "HP-61", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("9c630d65-daea-4484-8d9d-7771bbe82742"), "HP-66", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("9d01e030-eb28-426d-9cd5-49418b821fd4"), "HP-84", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("a0e72b73-3c8a-439f-aebf-b63742395826"), "HP-169", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("a11a71aa-1c0f-43a8-939a-1488ea6cfc12"), "HP-37", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("a382c6e9-5e3a-4932-9f08-4beada244d18"), "HP-156", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("a4061b0a-4534-4e37-9d17-7e1d493f4f78"), "HP-162", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("a559f0bc-0b7b-4fc6-a8a8-e7540b11affc"), "HP-56", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("a66fa59b-ab16-4490-bd0c-7316ea250882"), "HP-101", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("a717cdda-7176-48bd-927a-72ef0d913c35"), "HP-129", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("a728d519-f119-4449-bb16-95ef4b812d60"), "HP-153", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("a732a503-6800-4322-9b1e-6c2b5f8c0404"), "HP-38", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("a864fd65-f7f3-4698-92e5-4ea2e7fcf21d"), "HP-144", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("a87912bc-7c5e-42c4-9cbb-534bd98c6032"), "HP-182", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("a9e4435f-e0b2-43d7-8414-0b38bd8b7700"), "HP-7", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("aed13d03-b652-4128-8606-1e410a2c453f"), "HP-76", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("af468f54-9c95-4705-a94d-54bd6ffb2b4f"), "HP-184", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("b1f5d95e-186c-4038-9981-dce24116da89"), "HP-23", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("b2ca0e46-d857-4697-95ef-db1af8653fda"), "HP-24", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("b2e3eece-d7bd-4df2-9494-472daf8ef5e6"), "HP-141", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("b3624f4b-6fa0-4d74-8f6b-011168f6a759"), "HP-12", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("b44dc5c3-27d7-4bbb-9ff8-58e575e646f6"), "HP-177", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("b851c1e1-ed65-4dbb-9d8a-29f903f56087"), "HP-154", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("b944efcc-4a25-4ac2-bbd5-e1871b74368a"), "HP-72", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("ba50d35b-08cb-4b5b-9a47-44a747edd060"), "HP-87", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("ba8dd2d5-e1bd-4fa6-918f-f084ca19d8c4"), "HP-196", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("bb4b1541-99ec-450b-ab15-adbfebed4f78"), "HP-198", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("be71f1ea-c0fd-44dc-afb4-14b48fbe2e27"), "HP-73", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("bf56f43b-b094-4384-a840-7f58270a99ba"), "HP-130", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("c10a03a0-cb7a-46e8-960d-9d7760993584"), "HP-116", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("c164a365-80f0-43b4-b3ba-aa6040c0e4e7"), "HP-47", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("c49e3402-c698-4ad5-9714-42f0a7c870f5"), "HP-189", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("c51bcd27-45bd-4953-ba50-7de53aba93a6"), "HP-188", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("c5302f26-e957-4d70-9b3e-75620fee74bc"), "HP-143", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("c6b98d79-b9e6-42a6-b7e8-80bbf69652e6"), "HP-126", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("c7d06303-9bc0-4bd9-8d17-d793f7dfde2d"), "HP-139", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("c8953a5d-6d0b-464c-8a66-549f0cc91e43"), "HP-200", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("c899b7b1-1cbf-447e-b3b0-ef39da9413d1"), "HP-181", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("caa12176-e459-44fb-b8f6-3240a70b2062"), "HP-134", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("cb3761be-58fc-481a-83c6-0f3edeea6209"), "HP-133", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("cb724786-e071-471c-ab3e-ad1ea81ff2cc"), "HP-128", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("cb75a982-9a97-420d-bfc0-a87bf6c8c968"), "HP-68", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("cdcef74f-bc3d-46e6-a12f-6475373caf0f"), "HP-5", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("cdd1e47a-8cf9-4571-911e-5bad13b314e3"), "HP-136", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("cdf3cf39-260c-4c43-a520-78436151d9c4"), "HP-78", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("ce3fbf39-69cc-4341-a802-99958609269e"), "HP-53", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("ce97510a-0cb0-4f27-a2b7-64d78886e06a"), "HP-77", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("d1165404-4561-4f22-8cd6-7f78e3816d5f"), "HP-118", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("d2ddbc34-9ae1-40f4-948b-4a786980cb13"), "HP-69", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("d405bc5a-e472-4197-8243-affdd00abd23"), "HP-54", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("d54dae2d-7d0b-4c02-aca8-a6dd9bba4103"), "HP-109", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("d7dcdfd4-e615-41c5-8a7f-5b1f86048d18"), "HP-27", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("dc78896c-81e1-43f8-aec7-47b6a6f87310"), "HP-186", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("dd5306d1-68b1-4a59-b660-ade46e03228f"), "HP-151", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("dedcb749-1a5c-4512-a2c7-5fae31991829"), "HP-120", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("df63b923-7eee-4bbb-a47a-f5fb1c3d0efa"), "HP-48", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("e0262b3d-6d4d-4d47-a9b9-f944b9bcf3bc"), "HP-113", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("e082d543-cee8-43c4-a345-4c9c5c62d436"), "HP-166", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("e19449f7-3e1a-45e0-9583-dafd6c4b8c48"), "HP-25", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("e3131886-049a-42cf-959b-3feaf727bcf5"), "HP-140", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("e3a56fb5-cc87-48d5-9394-4b808bb3e866"), "HP-159", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("e43f42c0-1390-45ca-a5ef-fdab9b611499"), "HP-97", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("e5181e50-66bb-477f-9a31-9451c1e183d8"), "HP-1", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("e540b5d4-1d61-4aa2-9585-6e17e190a7f2"), "HP-26", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("e65cfc41-3f5f-4595-8007-077464b1b8b2"), "HP-158", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("e768bf61-2fd8-4a25-b9af-782f47d2a845"), "HP-43", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("e79dd894-5eca-4bd8-88df-dbb4358324d8"), "HP-103", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("ea0d5eaf-318c-49ab-9c36-8f8fc1bbd2a5"), "HP-44", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("ec317fdb-2479-4b33-825f-789ca53328b3"), "HP-80", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("ec5b5b73-5e2c-43a1-b14c-ca99a28131e1"), "HP-52", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("f0023071-f51e-45b3-b7d9-852a37af6f62"), "HP-59", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("f064b1e8-eaa9-4958-ad6c-4093cd5d9e78"), "HP-167", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("035ca2e1-1d6a-414a-ace3-c3e7bdc0ed99"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("f10ab653-c3cb-461b-b08f-54b4349a7bde"), "HP-98", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("f171fd6e-7bc4-440f-8eb2-ae9f84619ea7"), "HP-34", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("f38584e0-22f6-4fb7-89d1-82d52d2a2803"), "HP-33", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("f53d2d87-b1e5-4cb1-9407-ee9fbc71c537"), "HP-146", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("f56697d6-f751-413a-81a3-9284a73c7001"), "HP-20", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("f57b759d-1285-4b0f-a02f-7ec5fb1a07ef"), "HP-121", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1cc69a62-12a8-458a-a473-9ba96be0556c") },
                    { new Guid("f8103d30-4471-4239-a70c-0030b62f0e14"), "HP-138", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("fa3d0b84-5c6b-4247-a84a-0c30d51e96ab"), "HP-105", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("fbee9a35-54a0-49c6-aabc-a45813530894"), "HP-92", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("c69b1ada-9b99-46ba-973c-cdec66d765c5") },
                    { new Guid("fca3ad31-253d-4ce0-a93d-a6347957b125"), "HP-137", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("fd145434-f458-4a00-abcd-008c5509cccb"), "HP-111", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("5a4a4cc9-ed71-4cf4-a0e9-d12ac040b643"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("6935dfb8-70dc-40c8-bab0-42d1d4a4890e") },
                    { new Guid("feba3457-d503-49fc-92e8-8897a7c3377a"), "HP-35", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("bbada433-922d-4330-8764-889dd2a387bb"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") },
                    { new Guid("ff083741-4a7b-4143-997e-1cb0b1dd090d"), "HP-55", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("fc368689-9b08-4ea3-8f46-8ee137cc38bd") },
                    { new Guid("ff407f9e-477f-4c3e-9f12-89e30d9a5b11"), "HP-89", "Active", 0, null, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, false, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, null, new Guid("39bf086d-8254-48c0-8d9a-1e96c153afc6"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("116c3cad-62f6-4930-80cc-8096ccdaf8b0") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "BorrowLends",
                columns: new[] { "Id", "BorrowDate", "BorrowStatus", "CreatedById", "CreatedDateUnix", "DeletedDateUnix", "DueDate", "FeeAmount", "HasFee", "IsDeleted", "IsDeletedById", "IsLate", "LastModifiedById", "LastModifiedDateUnix", "LateDurationInDays", "MemberId", "ReturnDate", "StaffLenderId", "WorkCatalogId", "WorkInventoryId" },
                values: new object[,]
                {
                    { new Guid("7f62dd1c-9bba-4199-ae7c-220c2bd49361"), new DateTime(2024, 4, 23, 13, 55, 39, 98, DateTimeKind.Local).AddTicks(7652), "DelayedReturn", new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, new DateTime(2024, 5, 2, 13, 55, 39, 98, DateTimeKind.Local).AddTicks(7656), 0m, false, false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, 1, new Guid("1a3c65e5-d70f-4161-b3b5-bcb089e58dcb"), new DateTime(2024, 5, 3, 13, 55, 39, 98, DateTimeKind.Local).AddTicks(7657), new Guid("74a1ff0e-8d0a-461e-b8ad-ced3bc42d1d4"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("92a78343-eebf-432a-aa23-34f598df97d0") },
                    { new Guid("858aada6-9ed8-4652-8f16-b1b958f9c34d"), new DateTime(2024, 4, 23, 13, 55, 39, 98, DateTimeKind.Local).AddTicks(7584), "Returned", new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, new DateTime(2024, 5, 3, 13, 55, 39, 98, DateTimeKind.Local).AddTicks(7601), 0m, false, false, new Guid("00000000-0000-0000-0000-000000000000"), true, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, 0, new Guid("a75435f3-e199-44ea-8b9b-60958802f3e7"), new DateTime(2024, 5, 3, 13, 55, 39, 98, DateTimeKind.Local).AddTicks(7602), new Guid("74a1ff0e-8d0a-461e-b8ad-ced3bc42d1d4"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("cdcef74f-bc3d-46e6-a12f-6475373caf0f") },
                    { new Guid("b9216a82-1e13-4bc4-a250-42633f447f96"), new DateTime(2024, 4, 23, 13, 55, 39, 98, DateTimeKind.Local).AddTicks(7665), "Borrowed", new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), 1714744539L, null, new DateTime(2024, 5, 4, 13, 55, 39, 98, DateTimeKind.Local).AddTicks(7667), 0m, false, false, new Guid("00000000-0000-0000-0000-000000000000"), false, new Guid("1229fe05-57db-4687-9b58-234dbcd0f949"), null, 0, new Guid("1a3c65e5-d70f-4161-b3b5-bcb089e58dcb"), null, new Guid("74a1ff0e-8d0a-461e-b8ad-ced3bc42d1d4"), new Guid("da6ae698-0f5c-43b0-8ea9-110f64a5958c"), new Guid("1293170f-4bea-4af7-bc1c-e3b362bfdfa5") }
                });

            migrationBuilder.InsertData(
                schema: "lm",
                table: "Edition_WorkInventories",
                columns: new[] { "EditionId", "WorkInventoryId" },
                values: new object[,]
                {
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("02024645-0961-439b-bd43-6d78786471db") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("02024645-0961-439b-bd43-6d78786471db") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("02024645-0961-439b-bd43-6d78786471db") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("04329c42-d266-4c9a-89ae-e2b913ef7799") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("04329c42-d266-4c9a-89ae-e2b913ef7799") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("04329c42-d266-4c9a-89ae-e2b913ef7799") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("04357fd3-dc07-4e1d-9be3-b57c80efd01c") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("04357fd3-dc07-4e1d-9be3-b57c80efd01c") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("04357fd3-dc07-4e1d-9be3-b57c80efd01c") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("04d0ecd2-8954-4f12-83be-723a8440116f") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("04d0ecd2-8954-4f12-83be-723a8440116f") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("04d0ecd2-8954-4f12-83be-723a8440116f") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("060f2c64-9b0d-4661-a276-a69d36278dc8") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("060f2c64-9b0d-4661-a276-a69d36278dc8") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("060f2c64-9b0d-4661-a276-a69d36278dc8") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("0624215f-3650-41a1-8ba7-c37e063d2138") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("0624215f-3650-41a1-8ba7-c37e063d2138") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("0624215f-3650-41a1-8ba7-c37e063d2138") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("075a3b8d-94c3-40ad-967f-1227c1d68308") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("075a3b8d-94c3-40ad-967f-1227c1d68308") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("075a3b8d-94c3-40ad-967f-1227c1d68308") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("0975aaf2-2c4e-4d29-866a-dc4a02ed8512") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("0975aaf2-2c4e-4d29-866a-dc4a02ed8512") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("0975aaf2-2c4e-4d29-866a-dc4a02ed8512") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("097ecc08-cec7-4d29-8091-c478ce3dda67") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("097ecc08-cec7-4d29-8091-c478ce3dda67") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("097ecc08-cec7-4d29-8091-c478ce3dda67") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("09f83da2-d38e-4648-b4a5-f6789e677859") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("09f83da2-d38e-4648-b4a5-f6789e677859") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("09f83da2-d38e-4648-b4a5-f6789e677859") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("0a3e2bd9-c5c4-4110-baed-18d2f4669657") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("0a3e2bd9-c5c4-4110-baed-18d2f4669657") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("0a3e2bd9-c5c4-4110-baed-18d2f4669657") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("0c89807d-a0e6-4adc-befa-023fb0396744") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("0c89807d-a0e6-4adc-befa-023fb0396744") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("0c89807d-a0e6-4adc-befa-023fb0396744") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("0c9e288f-d7f3-4646-afec-2e164b62769b") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("0c9e288f-d7f3-4646-afec-2e164b62769b") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("0c9e288f-d7f3-4646-afec-2e164b62769b") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("0e65c69f-4c5c-4bc1-bee8-e33d8ab5a2e6") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("0e65c69f-4c5c-4bc1-bee8-e33d8ab5a2e6") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("0e65c69f-4c5c-4bc1-bee8-e33d8ab5a2e6") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("0f88556a-1e3f-42a1-b0a4-c7390d12216e") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("0f88556a-1e3f-42a1-b0a4-c7390d12216e") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("0f88556a-1e3f-42a1-b0a4-c7390d12216e") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("102349d3-7add-49d8-9e23-ee689b5f9607") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("102349d3-7add-49d8-9e23-ee689b5f9607") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("102349d3-7add-49d8-9e23-ee689b5f9607") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("10a8659c-e29b-4b91-afcd-463fd4d88345") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("10a8659c-e29b-4b91-afcd-463fd4d88345") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("10a8659c-e29b-4b91-afcd-463fd4d88345") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("10e38ffb-df66-43cd-9505-97a6721cba80") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("10e38ffb-df66-43cd-9505-97a6721cba80") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("10e38ffb-df66-43cd-9505-97a6721cba80") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("11766781-058b-487b-bad0-2e74fff44804") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("11766781-058b-487b-bad0-2e74fff44804") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("11766781-058b-487b-bad0-2e74fff44804") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("1293170f-4bea-4af7-bc1c-e3b362bfdfa5") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("1293170f-4bea-4af7-bc1c-e3b362bfdfa5") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("1293170f-4bea-4af7-bc1c-e3b362bfdfa5") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("1557e92f-36fb-41a0-8ce6-5be7e58a7dad") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("1557e92f-36fb-41a0-8ce6-5be7e58a7dad") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("1557e92f-36fb-41a0-8ce6-5be7e58a7dad") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("15ddb142-69d9-4cf4-92d2-59637235e898") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("15ddb142-69d9-4cf4-92d2-59637235e898") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("15ddb142-69d9-4cf4-92d2-59637235e898") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("16550c25-7537-4a1e-8e40-90d41c5a2bda") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("16550c25-7537-4a1e-8e40-90d41c5a2bda") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("16550c25-7537-4a1e-8e40-90d41c5a2bda") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("19117887-f18d-4b65-9d3b-8bc8d9b1e9c9") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("19117887-f18d-4b65-9d3b-8bc8d9b1e9c9") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("19117887-f18d-4b65-9d3b-8bc8d9b1e9c9") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("19e8067c-2635-40d3-b80e-d6121ffd16d7") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("19e8067c-2635-40d3-b80e-d6121ffd16d7") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("19e8067c-2635-40d3-b80e-d6121ffd16d7") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("1bfe035b-54ed-4c41-b120-f25d98591bbb") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("1bfe035b-54ed-4c41-b120-f25d98591bbb") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("1bfe035b-54ed-4c41-b120-f25d98591bbb") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("1f0ceefb-9ce3-4277-a76e-22bf47868a5d") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("1f0ceefb-9ce3-4277-a76e-22bf47868a5d") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("1f0ceefb-9ce3-4277-a76e-22bf47868a5d") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("2083f784-0224-4c17-83aa-a6bfa257192a") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("2083f784-0224-4c17-83aa-a6bfa257192a") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("2083f784-0224-4c17-83aa-a6bfa257192a") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("213e7bee-01a2-41eb-9cfa-08657eac7beb") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("213e7bee-01a2-41eb-9cfa-08657eac7beb") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("213e7bee-01a2-41eb-9cfa-08657eac7beb") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("22075e8c-a7ed-43bb-83af-6a07a6177e7f") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("22075e8c-a7ed-43bb-83af-6a07a6177e7f") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("22075e8c-a7ed-43bb-83af-6a07a6177e7f") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("234d9e33-d468-4760-a979-4b41e80d9f99") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("234d9e33-d468-4760-a979-4b41e80d9f99") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("234d9e33-d468-4760-a979-4b41e80d9f99") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("2402a6bb-32c5-45de-a601-9b847a7623f1") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("2402a6bb-32c5-45de-a601-9b847a7623f1") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("2402a6bb-32c5-45de-a601-9b847a7623f1") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("245e1b38-a0d7-4adb-b349-32baf66d16ee") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("245e1b38-a0d7-4adb-b349-32baf66d16ee") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("245e1b38-a0d7-4adb-b349-32baf66d16ee") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("2561e547-fb79-4609-ad1f-b7359087dc6b") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("2561e547-fb79-4609-ad1f-b7359087dc6b") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("2561e547-fb79-4609-ad1f-b7359087dc6b") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("25f3bef9-6bb7-45a0-b169-08289ebd683e") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("25f3bef9-6bb7-45a0-b169-08289ebd683e") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("25f3bef9-6bb7-45a0-b169-08289ebd683e") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("288d89f0-0d38-47c0-bcd7-f3bf2140ba9a") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("288d89f0-0d38-47c0-bcd7-f3bf2140ba9a") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("288d89f0-0d38-47c0-bcd7-f3bf2140ba9a") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("2a7f2ce9-f44d-4966-a75b-8f2dfad72d9f") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("2a7f2ce9-f44d-4966-a75b-8f2dfad72d9f") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("2a7f2ce9-f44d-4966-a75b-8f2dfad72d9f") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("2aeb7ca8-5a14-40cc-9ef8-43482e7fa57b") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("2aeb7ca8-5a14-40cc-9ef8-43482e7fa57b") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("2aeb7ca8-5a14-40cc-9ef8-43482e7fa57b") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("2de56422-140f-4494-9993-339b38a9b47e") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("2de56422-140f-4494-9993-339b38a9b47e") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("2de56422-140f-4494-9993-339b38a9b47e") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("2e0e6bdc-e62a-4259-a0c0-8017855f41bc") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("2e0e6bdc-e62a-4259-a0c0-8017855f41bc") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("2e0e6bdc-e62a-4259-a0c0-8017855f41bc") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("2e730971-8cff-4775-a359-75e611a3a862") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("2e730971-8cff-4775-a359-75e611a3a862") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("2e730971-8cff-4775-a359-75e611a3a862") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("2f9b14e5-52e3-4f4f-8a6d-8a3b0521e875") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("2f9b14e5-52e3-4f4f-8a6d-8a3b0521e875") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("2f9b14e5-52e3-4f4f-8a6d-8a3b0521e875") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("2fa460da-60d5-45bc-966d-1cf1d162e85e") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("2fa460da-60d5-45bc-966d-1cf1d162e85e") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("2fa460da-60d5-45bc-966d-1cf1d162e85e") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("30c1eda5-7060-46d8-807b-99a0356c97d1") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("30c1eda5-7060-46d8-807b-99a0356c97d1") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("30c1eda5-7060-46d8-807b-99a0356c97d1") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("31071509-57b5-47a4-8c9f-27d49c65bfaf") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("31071509-57b5-47a4-8c9f-27d49c65bfaf") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("31071509-57b5-47a4-8c9f-27d49c65bfaf") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("35422876-49a0-4e61-844b-e33b810f433c") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("35422876-49a0-4e61-844b-e33b810f433c") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("35422876-49a0-4e61-844b-e33b810f433c") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("35484189-324f-48fa-8431-4f839f042b87") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("35484189-324f-48fa-8431-4f839f042b87") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("35484189-324f-48fa-8431-4f839f042b87") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("38174c4c-451d-4551-a8ae-641d09a2d654") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("38174c4c-451d-4551-a8ae-641d09a2d654") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("38174c4c-451d-4551-a8ae-641d09a2d654") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("39d3eb94-e66c-4a13-9c4c-f94218cd4a42") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("39d3eb94-e66c-4a13-9c4c-f94218cd4a42") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("39d3eb94-e66c-4a13-9c4c-f94218cd4a42") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("3b59ec11-b47b-4396-acfa-d1a600b94138") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("3b59ec11-b47b-4396-acfa-d1a600b94138") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("3b59ec11-b47b-4396-acfa-d1a600b94138") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("3bcf79ba-4fef-401a-9494-3e733993e25e") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("3bcf79ba-4fef-401a-9494-3e733993e25e") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("3bcf79ba-4fef-401a-9494-3e733993e25e") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("407eac41-5d40-44cd-942e-82539d2fa712") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("407eac41-5d40-44cd-942e-82539d2fa712") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("407eac41-5d40-44cd-942e-82539d2fa712") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("41af852d-fae3-45cc-b0ba-f6083b3373ff") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("41af852d-fae3-45cc-b0ba-f6083b3373ff") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("41af852d-fae3-45cc-b0ba-f6083b3373ff") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("422d1a4a-75ce-4dad-8159-f40e79de42b5") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("422d1a4a-75ce-4dad-8159-f40e79de42b5") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("422d1a4a-75ce-4dad-8159-f40e79de42b5") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("4355ca1c-e527-4dba-883e-ac8ca9bcd8f2") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("4355ca1c-e527-4dba-883e-ac8ca9bcd8f2") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("4355ca1c-e527-4dba-883e-ac8ca9bcd8f2") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("43a73dee-fd96-4b78-a270-de3ddafb4539") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("43a73dee-fd96-4b78-a270-de3ddafb4539") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("43a73dee-fd96-4b78-a270-de3ddafb4539") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("45810d0d-8c9b-4c54-bff1-980d8d681f65") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("45810d0d-8c9b-4c54-bff1-980d8d681f65") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("45810d0d-8c9b-4c54-bff1-980d8d681f65") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("4935101c-608b-4578-826b-ad17a4e0fc3b") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("4935101c-608b-4578-826b-ad17a4e0fc3b") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("4935101c-608b-4578-826b-ad17a4e0fc3b") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("4b7951c2-c3a5-4555-a01e-bdf5fa05e8e4") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("4b7951c2-c3a5-4555-a01e-bdf5fa05e8e4") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("4b7951c2-c3a5-4555-a01e-bdf5fa05e8e4") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("4b8267f7-acc8-4e28-b18e-c46df505f315") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("4b8267f7-acc8-4e28-b18e-c46df505f315") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("4b8267f7-acc8-4e28-b18e-c46df505f315") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("4d868f1e-3e61-4e19-82c5-9193e204587f") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("4d868f1e-3e61-4e19-82c5-9193e204587f") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("4d868f1e-3e61-4e19-82c5-9193e204587f") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("4f7564d9-b6ca-4d07-bb41-fbf207605a97") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("4f7564d9-b6ca-4d07-bb41-fbf207605a97") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("4f7564d9-b6ca-4d07-bb41-fbf207605a97") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("4feb5764-45d6-4c68-882f-f70e286588c1") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("4feb5764-45d6-4c68-882f-f70e286588c1") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("4feb5764-45d6-4c68-882f-f70e286588c1") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("5057bb83-d249-40d2-bdd9-600ab97f613f") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("5057bb83-d249-40d2-bdd9-600ab97f613f") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("5057bb83-d249-40d2-bdd9-600ab97f613f") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("51b68c40-1227-4f86-a025-0de50e9cd4c3") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("51b68c40-1227-4f86-a025-0de50e9cd4c3") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("51b68c40-1227-4f86-a025-0de50e9cd4c3") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("54623db4-782b-4646-8f75-9edabd8d8b1a") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("54623db4-782b-4646-8f75-9edabd8d8b1a") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("54623db4-782b-4646-8f75-9edabd8d8b1a") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("546f5e82-e422-490d-aced-44e9457fee0a") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("546f5e82-e422-490d-aced-44e9457fee0a") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("546f5e82-e422-490d-aced-44e9457fee0a") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("57c88d58-6d4d-4a26-a615-ba574d535e75") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("57c88d58-6d4d-4a26-a615-ba574d535e75") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("57c88d58-6d4d-4a26-a615-ba574d535e75") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("57ebec9e-44f6-4e9d-b216-336ebcbf86d2") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("57ebec9e-44f6-4e9d-b216-336ebcbf86d2") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("57ebec9e-44f6-4e9d-b216-336ebcbf86d2") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("585663df-5c85-4687-a7d0-4eba60bcf5b6") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("585663df-5c85-4687-a7d0-4eba60bcf5b6") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("585663df-5c85-4687-a7d0-4eba60bcf5b6") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("58827a47-907e-4c91-88b0-724e20fec5dd") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("58827a47-907e-4c91-88b0-724e20fec5dd") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("58827a47-907e-4c91-88b0-724e20fec5dd") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("58ae9af3-e766-4ec5-8cd2-5171e1cc192d") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("58ae9af3-e766-4ec5-8cd2-5171e1cc192d") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("58ae9af3-e766-4ec5-8cd2-5171e1cc192d") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("58cc3ac3-bbb3-4c93-a549-56ad20143d5d") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("58cc3ac3-bbb3-4c93-a549-56ad20143d5d") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("58cc3ac3-bbb3-4c93-a549-56ad20143d5d") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("5a76cdae-df91-448e-90b1-9ab14ec1b1a6") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("5a76cdae-df91-448e-90b1-9ab14ec1b1a6") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("5a76cdae-df91-448e-90b1-9ab14ec1b1a6") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("5ce82185-2c7f-4eb4-8cf6-a21d509d1732") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("5ce82185-2c7f-4eb4-8cf6-a21d509d1732") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("5ce82185-2c7f-4eb4-8cf6-a21d509d1732") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("5f471c49-780c-4a07-b737-289f26dc435b") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("5f471c49-780c-4a07-b737-289f26dc435b") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("5f471c49-780c-4a07-b737-289f26dc435b") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("60849b95-56f6-4345-8391-a7eb42ceff47") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("60849b95-56f6-4345-8391-a7eb42ceff47") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("60849b95-56f6-4345-8391-a7eb42ceff47") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("6335d3e3-5737-420c-a494-0ed628370f0c") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("6335d3e3-5737-420c-a494-0ed628370f0c") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("6335d3e3-5737-420c-a494-0ed628370f0c") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("64352f98-936c-4f04-809a-35f4dbe3b77b") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("64352f98-936c-4f04-809a-35f4dbe3b77b") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("64352f98-936c-4f04-809a-35f4dbe3b77b") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("65727a8b-9023-40c6-aeb9-0e08363af68c") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("65727a8b-9023-40c6-aeb9-0e08363af68c") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("65727a8b-9023-40c6-aeb9-0e08363af68c") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("66043067-5cef-45f8-97e4-6821e994ec45") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("66043067-5cef-45f8-97e4-6821e994ec45") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("66043067-5cef-45f8-97e4-6821e994ec45") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("68f975ca-5d94-42ed-b154-3d5d57d8fed9") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("68f975ca-5d94-42ed-b154-3d5d57d8fed9") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("68f975ca-5d94-42ed-b154-3d5d57d8fed9") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("691dc040-e68a-4625-a99f-346821751b00") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("691dc040-e68a-4625-a99f-346821751b00") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("691dc040-e68a-4625-a99f-346821751b00") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("69f80bf3-b638-44d0-8956-4d4a82a8024d") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("69f80bf3-b638-44d0-8956-4d4a82a8024d") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("69f80bf3-b638-44d0-8956-4d4a82a8024d") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("6c9ec93f-c041-4b40-a8b7-024d6fbb954b") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("6c9ec93f-c041-4b40-a8b7-024d6fbb954b") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("6c9ec93f-c041-4b40-a8b7-024d6fbb954b") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("6d0f802f-cf67-4204-a472-fd07680dc584") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("6d0f802f-cf67-4204-a472-fd07680dc584") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("6d0f802f-cf67-4204-a472-fd07680dc584") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("7031686e-a380-4974-9d0c-e804320b64a9") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("7031686e-a380-4974-9d0c-e804320b64a9") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("7031686e-a380-4974-9d0c-e804320b64a9") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("7193b830-1cf8-45e5-8b65-a3639a8e57cd") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("7193b830-1cf8-45e5-8b65-a3639a8e57cd") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("7193b830-1cf8-45e5-8b65-a3639a8e57cd") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("7424c5c8-3839-4a4c-9df1-a8433cae49e8") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("7424c5c8-3839-4a4c-9df1-a8433cae49e8") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("7424c5c8-3839-4a4c-9df1-a8433cae49e8") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("76ba3920-5ed3-4423-8dab-ba32cef15fd5") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("76ba3920-5ed3-4423-8dab-ba32cef15fd5") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("76ba3920-5ed3-4423-8dab-ba32cef15fd5") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("7717beb6-bf75-464c-b13b-1b32600295da") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("7717beb6-bf75-464c-b13b-1b32600295da") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("7717beb6-bf75-464c-b13b-1b32600295da") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("7dee6545-d874-4aec-8904-1d85d2b19765") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("7dee6545-d874-4aec-8904-1d85d2b19765") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("7dee6545-d874-4aec-8904-1d85d2b19765") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("7ec3b725-31a3-4efa-804e-e4f3d2e095e1") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("7ec3b725-31a3-4efa-804e-e4f3d2e095e1") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("7ec3b725-31a3-4efa-804e-e4f3d2e095e1") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("7f0b2a5c-bd05-4fac-8d7d-cbdf8bd0513b") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("7f0b2a5c-bd05-4fac-8d7d-cbdf8bd0513b") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("7f0b2a5c-bd05-4fac-8d7d-cbdf8bd0513b") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("7f3ae85d-3381-4bf1-a271-fcd3363bedd0") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("7f3ae85d-3381-4bf1-a271-fcd3363bedd0") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("7f3ae85d-3381-4bf1-a271-fcd3363bedd0") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("80967e60-3c25-40fd-b478-39830166ece2") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("80967e60-3c25-40fd-b478-39830166ece2") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("80967e60-3c25-40fd-b478-39830166ece2") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("8145bdcc-612b-44f0-a191-08c082dd206a") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("8145bdcc-612b-44f0-a191-08c082dd206a") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("8145bdcc-612b-44f0-a191-08c082dd206a") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("81da8565-b9e6-46a6-ad94-1d7d491a8aed") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("81da8565-b9e6-46a6-ad94-1d7d491a8aed") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("81da8565-b9e6-46a6-ad94-1d7d491a8aed") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("827fd7e4-cc34-4bab-a057-dcb8e1ea9a5e") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("827fd7e4-cc34-4bab-a057-dcb8e1ea9a5e") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("827fd7e4-cc34-4bab-a057-dcb8e1ea9a5e") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("85053df5-1ccd-49e2-9c52-81cd66ee8675") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("85053df5-1ccd-49e2-9c52-81cd66ee8675") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("85053df5-1ccd-49e2-9c52-81cd66ee8675") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("851df43c-e9f0-44d1-9ddf-0f31fd95d238") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("851df43c-e9f0-44d1-9ddf-0f31fd95d238") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("851df43c-e9f0-44d1-9ddf-0f31fd95d238") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("864fe09d-5795-4c1e-90e7-e2451314e934") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("864fe09d-5795-4c1e-90e7-e2451314e934") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("864fe09d-5795-4c1e-90e7-e2451314e934") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("86e765cc-0774-462a-9641-29bbef5a629d") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("86e765cc-0774-462a-9641-29bbef5a629d") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("86e765cc-0774-462a-9641-29bbef5a629d") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("88b3199e-e5d1-4b93-b96c-c34d2b0769ab") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("88b3199e-e5d1-4b93-b96c-c34d2b0769ab") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("88b3199e-e5d1-4b93-b96c-c34d2b0769ab") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("895546b2-2961-4d8d-ad53-8cd3e4ac7e50") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("895546b2-2961-4d8d-ad53-8cd3e4ac7e50") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("895546b2-2961-4d8d-ad53-8cd3e4ac7e50") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("8a9189fa-37b2-4666-b87a-f5b775f5590c") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("8a9189fa-37b2-4666-b87a-f5b775f5590c") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("8a9189fa-37b2-4666-b87a-f5b775f5590c") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("8b4be57e-f8d9-49a9-b08d-e98637a6a9f1") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("8b4be57e-f8d9-49a9-b08d-e98637a6a9f1") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("8b4be57e-f8d9-49a9-b08d-e98637a6a9f1") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("8c623929-c71c-4055-9ff3-4e8881681903") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("8c623929-c71c-4055-9ff3-4e8881681903") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("8c623929-c71c-4055-9ff3-4e8881681903") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("8cd38082-8079-4b55-a3c2-ccaa7085085f") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("8cd38082-8079-4b55-a3c2-ccaa7085085f") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("8cd38082-8079-4b55-a3c2-ccaa7085085f") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("8f4179cd-31b9-48a5-977a-57559706d3a3") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("8f4179cd-31b9-48a5-977a-57559706d3a3") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("8f4179cd-31b9-48a5-977a-57559706d3a3") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("8f79e1c2-1dbb-4993-b0c4-9ad36370dc48") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("8f79e1c2-1dbb-4993-b0c4-9ad36370dc48") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("8f79e1c2-1dbb-4993-b0c4-9ad36370dc48") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("91745ef0-4ef6-4835-b546-0b24e4c67c66") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("91745ef0-4ef6-4835-b546-0b24e4c67c66") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("91745ef0-4ef6-4835-b546-0b24e4c67c66") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("92a78343-eebf-432a-aa23-34f598df97d0") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("92a78343-eebf-432a-aa23-34f598df97d0") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("92a78343-eebf-432a-aa23-34f598df97d0") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("94c56169-2447-4fdc-a113-c4d4ae8eb92b") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("94c56169-2447-4fdc-a113-c4d4ae8eb92b") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("94c56169-2447-4fdc-a113-c4d4ae8eb92b") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("9bdd661b-619b-4f54-862c-d8cdd710bb0b") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("9bdd661b-619b-4f54-862c-d8cdd710bb0b") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("9bdd661b-619b-4f54-862c-d8cdd710bb0b") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("9c630d65-daea-4484-8d9d-7771bbe82742") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("9c630d65-daea-4484-8d9d-7771bbe82742") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("9c630d65-daea-4484-8d9d-7771bbe82742") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("9d01e030-eb28-426d-9cd5-49418b821fd4") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("9d01e030-eb28-426d-9cd5-49418b821fd4") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("9d01e030-eb28-426d-9cd5-49418b821fd4") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("a0e72b73-3c8a-439f-aebf-b63742395826") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("a0e72b73-3c8a-439f-aebf-b63742395826") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("a0e72b73-3c8a-439f-aebf-b63742395826") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("a11a71aa-1c0f-43a8-939a-1488ea6cfc12") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("a11a71aa-1c0f-43a8-939a-1488ea6cfc12") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("a11a71aa-1c0f-43a8-939a-1488ea6cfc12") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("a382c6e9-5e3a-4932-9f08-4beada244d18") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("a382c6e9-5e3a-4932-9f08-4beada244d18") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("a382c6e9-5e3a-4932-9f08-4beada244d18") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("a4061b0a-4534-4e37-9d17-7e1d493f4f78") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("a4061b0a-4534-4e37-9d17-7e1d493f4f78") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("a4061b0a-4534-4e37-9d17-7e1d493f4f78") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("a559f0bc-0b7b-4fc6-a8a8-e7540b11affc") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("a559f0bc-0b7b-4fc6-a8a8-e7540b11affc") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("a559f0bc-0b7b-4fc6-a8a8-e7540b11affc") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("a66fa59b-ab16-4490-bd0c-7316ea250882") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("a66fa59b-ab16-4490-bd0c-7316ea250882") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("a66fa59b-ab16-4490-bd0c-7316ea250882") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("a717cdda-7176-48bd-927a-72ef0d913c35") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("a717cdda-7176-48bd-927a-72ef0d913c35") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("a717cdda-7176-48bd-927a-72ef0d913c35") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("a728d519-f119-4449-bb16-95ef4b812d60") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("a728d519-f119-4449-bb16-95ef4b812d60") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("a728d519-f119-4449-bb16-95ef4b812d60") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("a732a503-6800-4322-9b1e-6c2b5f8c0404") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("a732a503-6800-4322-9b1e-6c2b5f8c0404") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("a732a503-6800-4322-9b1e-6c2b5f8c0404") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("a864fd65-f7f3-4698-92e5-4ea2e7fcf21d") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("a864fd65-f7f3-4698-92e5-4ea2e7fcf21d") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("a864fd65-f7f3-4698-92e5-4ea2e7fcf21d") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("a87912bc-7c5e-42c4-9cbb-534bd98c6032") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("a87912bc-7c5e-42c4-9cbb-534bd98c6032") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("a87912bc-7c5e-42c4-9cbb-534bd98c6032") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("a9e4435f-e0b2-43d7-8414-0b38bd8b7700") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("a9e4435f-e0b2-43d7-8414-0b38bd8b7700") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("a9e4435f-e0b2-43d7-8414-0b38bd8b7700") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("aed13d03-b652-4128-8606-1e410a2c453f") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("aed13d03-b652-4128-8606-1e410a2c453f") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("aed13d03-b652-4128-8606-1e410a2c453f") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("af468f54-9c95-4705-a94d-54bd6ffb2b4f") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("af468f54-9c95-4705-a94d-54bd6ffb2b4f") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("af468f54-9c95-4705-a94d-54bd6ffb2b4f") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("b1f5d95e-186c-4038-9981-dce24116da89") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("b1f5d95e-186c-4038-9981-dce24116da89") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("b1f5d95e-186c-4038-9981-dce24116da89") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("b2ca0e46-d857-4697-95ef-db1af8653fda") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("b2ca0e46-d857-4697-95ef-db1af8653fda") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("b2ca0e46-d857-4697-95ef-db1af8653fda") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("b2e3eece-d7bd-4df2-9494-472daf8ef5e6") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("b2e3eece-d7bd-4df2-9494-472daf8ef5e6") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("b2e3eece-d7bd-4df2-9494-472daf8ef5e6") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("b3624f4b-6fa0-4d74-8f6b-011168f6a759") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("b3624f4b-6fa0-4d74-8f6b-011168f6a759") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("b3624f4b-6fa0-4d74-8f6b-011168f6a759") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("b44dc5c3-27d7-4bbb-9ff8-58e575e646f6") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("b44dc5c3-27d7-4bbb-9ff8-58e575e646f6") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("b44dc5c3-27d7-4bbb-9ff8-58e575e646f6") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("b851c1e1-ed65-4dbb-9d8a-29f903f56087") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("b851c1e1-ed65-4dbb-9d8a-29f903f56087") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("b851c1e1-ed65-4dbb-9d8a-29f903f56087") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("b944efcc-4a25-4ac2-bbd5-e1871b74368a") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("b944efcc-4a25-4ac2-bbd5-e1871b74368a") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("b944efcc-4a25-4ac2-bbd5-e1871b74368a") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("ba50d35b-08cb-4b5b-9a47-44a747edd060") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("ba50d35b-08cb-4b5b-9a47-44a747edd060") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("ba50d35b-08cb-4b5b-9a47-44a747edd060") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("ba8dd2d5-e1bd-4fa6-918f-f084ca19d8c4") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("ba8dd2d5-e1bd-4fa6-918f-f084ca19d8c4") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("ba8dd2d5-e1bd-4fa6-918f-f084ca19d8c4") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("bb4b1541-99ec-450b-ab15-adbfebed4f78") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("bb4b1541-99ec-450b-ab15-adbfebed4f78") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("bb4b1541-99ec-450b-ab15-adbfebed4f78") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("be71f1ea-c0fd-44dc-afb4-14b48fbe2e27") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("be71f1ea-c0fd-44dc-afb4-14b48fbe2e27") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("be71f1ea-c0fd-44dc-afb4-14b48fbe2e27") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("bf56f43b-b094-4384-a840-7f58270a99ba") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("bf56f43b-b094-4384-a840-7f58270a99ba") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("bf56f43b-b094-4384-a840-7f58270a99ba") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("c10a03a0-cb7a-46e8-960d-9d7760993584") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("c10a03a0-cb7a-46e8-960d-9d7760993584") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("c10a03a0-cb7a-46e8-960d-9d7760993584") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("c164a365-80f0-43b4-b3ba-aa6040c0e4e7") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("c164a365-80f0-43b4-b3ba-aa6040c0e4e7") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("c164a365-80f0-43b4-b3ba-aa6040c0e4e7") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("c49e3402-c698-4ad5-9714-42f0a7c870f5") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("c49e3402-c698-4ad5-9714-42f0a7c870f5") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("c49e3402-c698-4ad5-9714-42f0a7c870f5") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("c51bcd27-45bd-4953-ba50-7de53aba93a6") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("c51bcd27-45bd-4953-ba50-7de53aba93a6") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("c51bcd27-45bd-4953-ba50-7de53aba93a6") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("c5302f26-e957-4d70-9b3e-75620fee74bc") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("c5302f26-e957-4d70-9b3e-75620fee74bc") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("c5302f26-e957-4d70-9b3e-75620fee74bc") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("c6b98d79-b9e6-42a6-b7e8-80bbf69652e6") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("c6b98d79-b9e6-42a6-b7e8-80bbf69652e6") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("c6b98d79-b9e6-42a6-b7e8-80bbf69652e6") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("c7d06303-9bc0-4bd9-8d17-d793f7dfde2d") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("c7d06303-9bc0-4bd9-8d17-d793f7dfde2d") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("c7d06303-9bc0-4bd9-8d17-d793f7dfde2d") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("c8953a5d-6d0b-464c-8a66-549f0cc91e43") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("c8953a5d-6d0b-464c-8a66-549f0cc91e43") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("c8953a5d-6d0b-464c-8a66-549f0cc91e43") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("c899b7b1-1cbf-447e-b3b0-ef39da9413d1") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("c899b7b1-1cbf-447e-b3b0-ef39da9413d1") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("c899b7b1-1cbf-447e-b3b0-ef39da9413d1") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("caa12176-e459-44fb-b8f6-3240a70b2062") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("caa12176-e459-44fb-b8f6-3240a70b2062") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("caa12176-e459-44fb-b8f6-3240a70b2062") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("cb3761be-58fc-481a-83c6-0f3edeea6209") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("cb3761be-58fc-481a-83c6-0f3edeea6209") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("cb3761be-58fc-481a-83c6-0f3edeea6209") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("cb724786-e071-471c-ab3e-ad1ea81ff2cc") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("cb724786-e071-471c-ab3e-ad1ea81ff2cc") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("cb724786-e071-471c-ab3e-ad1ea81ff2cc") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("cb75a982-9a97-420d-bfc0-a87bf6c8c968") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("cb75a982-9a97-420d-bfc0-a87bf6c8c968") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("cb75a982-9a97-420d-bfc0-a87bf6c8c968") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("cdcef74f-bc3d-46e6-a12f-6475373caf0f") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("cdcef74f-bc3d-46e6-a12f-6475373caf0f") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("cdcef74f-bc3d-46e6-a12f-6475373caf0f") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("cdd1e47a-8cf9-4571-911e-5bad13b314e3") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("cdd1e47a-8cf9-4571-911e-5bad13b314e3") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("cdd1e47a-8cf9-4571-911e-5bad13b314e3") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("cdf3cf39-260c-4c43-a520-78436151d9c4") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("cdf3cf39-260c-4c43-a520-78436151d9c4") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("cdf3cf39-260c-4c43-a520-78436151d9c4") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("ce3fbf39-69cc-4341-a802-99958609269e") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("ce3fbf39-69cc-4341-a802-99958609269e") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("ce3fbf39-69cc-4341-a802-99958609269e") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("ce97510a-0cb0-4f27-a2b7-64d78886e06a") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("ce97510a-0cb0-4f27-a2b7-64d78886e06a") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("ce97510a-0cb0-4f27-a2b7-64d78886e06a") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("d1165404-4561-4f22-8cd6-7f78e3816d5f") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("d1165404-4561-4f22-8cd6-7f78e3816d5f") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("d1165404-4561-4f22-8cd6-7f78e3816d5f") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("d2ddbc34-9ae1-40f4-948b-4a786980cb13") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("d2ddbc34-9ae1-40f4-948b-4a786980cb13") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("d2ddbc34-9ae1-40f4-948b-4a786980cb13") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("d405bc5a-e472-4197-8243-affdd00abd23") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("d405bc5a-e472-4197-8243-affdd00abd23") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("d405bc5a-e472-4197-8243-affdd00abd23") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("d54dae2d-7d0b-4c02-aca8-a6dd9bba4103") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("d54dae2d-7d0b-4c02-aca8-a6dd9bba4103") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("d54dae2d-7d0b-4c02-aca8-a6dd9bba4103") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("d7dcdfd4-e615-41c5-8a7f-5b1f86048d18") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("d7dcdfd4-e615-41c5-8a7f-5b1f86048d18") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("d7dcdfd4-e615-41c5-8a7f-5b1f86048d18") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("dc78896c-81e1-43f8-aec7-47b6a6f87310") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("dc78896c-81e1-43f8-aec7-47b6a6f87310") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("dc78896c-81e1-43f8-aec7-47b6a6f87310") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("dd5306d1-68b1-4a59-b660-ade46e03228f") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("dd5306d1-68b1-4a59-b660-ade46e03228f") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("dd5306d1-68b1-4a59-b660-ade46e03228f") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("dedcb749-1a5c-4512-a2c7-5fae31991829") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("dedcb749-1a5c-4512-a2c7-5fae31991829") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("dedcb749-1a5c-4512-a2c7-5fae31991829") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("df63b923-7eee-4bbb-a47a-f5fb1c3d0efa") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("df63b923-7eee-4bbb-a47a-f5fb1c3d0efa") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("df63b923-7eee-4bbb-a47a-f5fb1c3d0efa") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("e0262b3d-6d4d-4d47-a9b9-f944b9bcf3bc") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("e0262b3d-6d4d-4d47-a9b9-f944b9bcf3bc") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("e0262b3d-6d4d-4d47-a9b9-f944b9bcf3bc") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("e082d543-cee8-43c4-a345-4c9c5c62d436") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("e082d543-cee8-43c4-a345-4c9c5c62d436") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("e082d543-cee8-43c4-a345-4c9c5c62d436") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("e19449f7-3e1a-45e0-9583-dafd6c4b8c48") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("e19449f7-3e1a-45e0-9583-dafd6c4b8c48") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("e19449f7-3e1a-45e0-9583-dafd6c4b8c48") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("e3131886-049a-42cf-959b-3feaf727bcf5") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("e3131886-049a-42cf-959b-3feaf727bcf5") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("e3131886-049a-42cf-959b-3feaf727bcf5") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("e3a56fb5-cc87-48d5-9394-4b808bb3e866") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("e3a56fb5-cc87-48d5-9394-4b808bb3e866") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("e3a56fb5-cc87-48d5-9394-4b808bb3e866") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("e43f42c0-1390-45ca-a5ef-fdab9b611499") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("e43f42c0-1390-45ca-a5ef-fdab9b611499") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("e43f42c0-1390-45ca-a5ef-fdab9b611499") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("e5181e50-66bb-477f-9a31-9451c1e183d8") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("e5181e50-66bb-477f-9a31-9451c1e183d8") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("e5181e50-66bb-477f-9a31-9451c1e183d8") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("e540b5d4-1d61-4aa2-9585-6e17e190a7f2") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("e540b5d4-1d61-4aa2-9585-6e17e190a7f2") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("e540b5d4-1d61-4aa2-9585-6e17e190a7f2") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("e65cfc41-3f5f-4595-8007-077464b1b8b2") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("e65cfc41-3f5f-4595-8007-077464b1b8b2") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("e65cfc41-3f5f-4595-8007-077464b1b8b2") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("e768bf61-2fd8-4a25-b9af-782f47d2a845") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("e768bf61-2fd8-4a25-b9af-782f47d2a845") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("e768bf61-2fd8-4a25-b9af-782f47d2a845") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("e79dd894-5eca-4bd8-88df-dbb4358324d8") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("e79dd894-5eca-4bd8-88df-dbb4358324d8") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("e79dd894-5eca-4bd8-88df-dbb4358324d8") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("ea0d5eaf-318c-49ab-9c36-8f8fc1bbd2a5") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("ea0d5eaf-318c-49ab-9c36-8f8fc1bbd2a5") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("ea0d5eaf-318c-49ab-9c36-8f8fc1bbd2a5") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("ec317fdb-2479-4b33-825f-789ca53328b3") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("ec317fdb-2479-4b33-825f-789ca53328b3") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("ec317fdb-2479-4b33-825f-789ca53328b3") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("ec5b5b73-5e2c-43a1-b14c-ca99a28131e1") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("ec5b5b73-5e2c-43a1-b14c-ca99a28131e1") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("ec5b5b73-5e2c-43a1-b14c-ca99a28131e1") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("f0023071-f51e-45b3-b7d9-852a37af6f62") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("f0023071-f51e-45b3-b7d9-852a37af6f62") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("f0023071-f51e-45b3-b7d9-852a37af6f62") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("f064b1e8-eaa9-4958-ad6c-4093cd5d9e78") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("f064b1e8-eaa9-4958-ad6c-4093cd5d9e78") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("f064b1e8-eaa9-4958-ad6c-4093cd5d9e78") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("f10ab653-c3cb-461b-b08f-54b4349a7bde") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("f10ab653-c3cb-461b-b08f-54b4349a7bde") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("f10ab653-c3cb-461b-b08f-54b4349a7bde") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("f171fd6e-7bc4-440f-8eb2-ae9f84619ea7") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("f171fd6e-7bc4-440f-8eb2-ae9f84619ea7") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("f171fd6e-7bc4-440f-8eb2-ae9f84619ea7") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("f38584e0-22f6-4fb7-89d1-82d52d2a2803") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("f38584e0-22f6-4fb7-89d1-82d52d2a2803") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("f38584e0-22f6-4fb7-89d1-82d52d2a2803") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("f53d2d87-b1e5-4cb1-9407-ee9fbc71c537") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("f53d2d87-b1e5-4cb1-9407-ee9fbc71c537") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("f53d2d87-b1e5-4cb1-9407-ee9fbc71c537") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("f56697d6-f751-413a-81a3-9284a73c7001") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("f56697d6-f751-413a-81a3-9284a73c7001") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("f56697d6-f751-413a-81a3-9284a73c7001") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("f57b759d-1285-4b0f-a02f-7ec5fb1a07ef") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("f57b759d-1285-4b0f-a02f-7ec5fb1a07ef") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("f57b759d-1285-4b0f-a02f-7ec5fb1a07ef") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("f8103d30-4471-4239-a70c-0030b62f0e14") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("f8103d30-4471-4239-a70c-0030b62f0e14") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("f8103d30-4471-4239-a70c-0030b62f0e14") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("fa3d0b84-5c6b-4247-a84a-0c30d51e96ab") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("fa3d0b84-5c6b-4247-a84a-0c30d51e96ab") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("fa3d0b84-5c6b-4247-a84a-0c30d51e96ab") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("fbee9a35-54a0-49c6-aabc-a45813530894") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("fbee9a35-54a0-49c6-aabc-a45813530894") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("fbee9a35-54a0-49c6-aabc-a45813530894") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("fca3ad31-253d-4ce0-a93d-a6347957b125") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("fca3ad31-253d-4ce0-a93d-a6347957b125") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("fca3ad31-253d-4ce0-a93d-a6347957b125") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("fd145434-f458-4a00-abcd-008c5509cccb") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("fd145434-f458-4a00-abcd-008c5509cccb") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("fd145434-f458-4a00-abcd-008c5509cccb") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("feba3457-d503-49fc-92e8-8897a7c3377a") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("feba3457-d503-49fc-92e8-8897a7c3377a") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("feba3457-d503-49fc-92e8-8897a7c3377a") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("ff083741-4a7b-4143-997e-1cb0b1dd090d") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("ff083741-4a7b-4143-997e-1cb0b1dd090d") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("ff083741-4a7b-4143-997e-1cb0b1dd090d") },
                    { new Guid("37b232e2-261b-4749-b3d1-bbd34022b79e"), new Guid("ff407f9e-477f-4c3e-9f12-89e30d9a5b11") },
                    { new Guid("7ebf0032-2313-40c0-8c51-691de77137d5"), new Guid("ff407f9e-477f-4c3e-9f12-89e30d9a5b11") },
                    { new Guid("e8d74326-9784-4500-a0e5-191947a2bea1"), new Guid("ff407f9e-477f-4c3e-9f12-89e30d9a5b11") }
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
