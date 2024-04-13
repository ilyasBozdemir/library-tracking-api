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
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LibraryBranches",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpeningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchHourId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StaffId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LibraryBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LibraryTransactionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryBranches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BorrowId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LibraryBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Scope",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scope", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
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
                name: "BranchHours",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DayOfWeek = table.Column<int>(type: "int", nullable: false),
                    OpeningTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    ClosingTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LibraryBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchHours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BranchHours_LibraryBranches_LibraryBranchId",
                        column: x => x.LibraryBranchId,
                        principalTable: "LibraryBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LibraryTransactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransactionType = table.Column<int>(type: "int", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LibraryBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LibraryTransactions_LibraryBranches_LibraryBranchId",
                        column: x => x.LibraryBranchId,
                        principalTable: "LibraryBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LibraryBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmploymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsFullTime = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staff_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Staff_LibraryBranches_LibraryBranchId",
                        column: x => x.LibraryBranchId,
                        principalTable: "LibraryBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MemberLibraryBranch",
                columns: table => new
                {
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LibraryBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberLibraryBranch", x => new { x.MemberId, x.LibraryBranchId });
                    table.ForeignKey(
                        name: "FK_MemberLibraryBranch_LibraryBranches_LibraryBranchId",
                        column: x => x.LibraryBranchId,
                        principalTable: "LibraryBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MemberLibraryBranch_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PublisherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LibraryBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookStockBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BorrowId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoverImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PageCount = table.Column<int>(type: "int", nullable: false),
                    PublicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OriginalPublicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Format = table.Column<int>(type: "int", nullable: false),
                    BookLanguage = table.Column<int>(type: "int", nullable: false),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_LibraryBranches_LibraryBranchId",
                        column: x => x.LibraryBranchId,
                        principalTable: "LibraryBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "RoleScope",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScopeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleScope", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleScope_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleScope_Scope_ScopeId",
                        column: x => x.ScopeId,
                        principalTable: "Scope",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookAuthor",
                columns: table => new
                {
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthor", x => new { x.AuthorId, x.BookId });
                    table.ForeignKey(
                        name: "FK_BookAuthor_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookAuthor_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookStocks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookStocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookStocks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookTag",
                columns: table => new
                {
                    TagId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookTag", x => new { x.TagId, x.BookId });
                    table.ForeignKey(
                        name: "FK_BookTag_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookTag_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Borrows",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BorrowDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BorrowStatus = table.Column<int>(type: "int", nullable: false),
                    HasFee = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borrows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Borrows_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Borrows_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Borrows_Staff_LenderId",
                        column: x => x.LenderId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Returns",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsLate = table.Column<bool>(type: "bit", nullable: false),
                    BookStatus = table.Column<int>(type: "int", nullable: false),
                    PenaltyDurationInDays = table.Column<int>(type: "int", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Returns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Returns_Borrows_LoanId",
                        column: x => x.LoanId,
                        principalTable: "Borrows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "AppUserId", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("43f5fb94-f34c-4c1f-a72b-5f472ffddfba"), null, "18cc850a-e844-4a58-8f19-1cf0972f1a2a", "system", "SYSTEM" },
                    { new Guid("4808d776-2d79-47c2-af21-31d1882e669d"), null, "9405f1fb-5a31-4c97-8e67-6abc9a3035b9", "Member", "MEMBER" },
                    { new Guid("bbed431e-a0b9-41c5-b98e-755631670820"), null, "2b467c78-0b6a-49b1-ab18-4ef0f25bc976", "Staff", "STAFF" },
                    { new Guid("eca03ed8-8a54-4363-b4c0-3b9134fc512d"), null, "eef6be0f-e49a-4802-b495-b7e45f238360", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "CreatedById", "CreatedDate", "DeletedDate", "Email", "EmailConfirmed", "IsDeleted", "LastModifiedBy", "LastModifiedDate", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenEndDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0d01e176-ab43-4868-b448-c20f0cc4a0ca"), 0, "bc3dd1ea-0ddd-4db7-a8b5-a1a38e5b3bff", "SYSTEM", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2024, 4, 13, 22, 1, 54, 637, DateTimeKind.Local).AddTicks(3979), null, "system@domain.com", true, false, "SYSTEM", null, false, null, "system", "SYSTEM@DOMAIN.COM", "SYSTEM", "AQAAAAIAAYagAAAAEP5ojmurcRa/KXdpm6mzokDnTuCIRa7eJ55GEAmkU7X6Y+Ax/XrIDE9mDcWiEIud2A==", null, false, null, null, "", "system", false, "system" },
                    { new Guid("124b67f4-55d3-4095-8f9a-c3380cbb17a9"), 0, "19583f94-15d4-4833-bb46-fe3812d46d8c", "system", new Guid("0d01e176-ab43-4868-b448-c20f0cc4a0ca"), new DateTime(2024, 4, 13, 22, 1, 54, 719, DateTimeKind.Local).AddTicks(8027), null, "admin@example.com", true, false, "SYSTEM", null, false, null, "admin", "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ6km5zMMgzlmW74TNFmEw2Cmm9JAnCADSvCsu1W86aaByl6yXkNd6b4yMbqF7B9pw==", null, false, null, null, "", "admin", false, "admin@example.com" },
                    { new Guid("e3708dc1-90e7-47b5-89d7-98459e52198d"), 0, "2c7af404-8b72-474c-8257-0e159b6b5274", "system", new Guid("0d01e176-ab43-4868-b448-c20f0cc4a0ca"), new DateTime(2024, 4, 13, 22, 1, 54, 762, DateTimeKind.Local).AddTicks(6898), null, "employee1@example.com", true, false, "SYSTEM", null, false, null, "admin", "EMPLOYEE2@EXAMPLE.COM", "EMPLOYEE2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEE02TEN47ob/kZBH77WbfZ74ItIUU8WngxRWXgub29gEZTNrZbZBIBFdkscOHEzbHA==", null, false, null, null, "", "admin", false, "employee1@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Biography", "BirthDate", "Country", "CreatedBy", "CreatedById", "CreatedDate", "DeletedDate", "IsDeleted", "LastModifiedBy", "LastModifiedDate", "Name", "Surname" },
                values: new object[] { new Guid("f08db0d0-422c-436c-b262-d92ce18abd75"), "Joanne Rowling, better known by her pen name J.K. Rowling, is a British author, philanthropist, film producer, television producer, and screenwriter. She is best known for writing the Harry Potter fantasy series.", new DateTime(1965, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "United Kingdom", "system", new Guid("0d01e176-ab43-4868-b448-c20f0cc4a0ca"), new DateTime(2024, 4, 13, 22, 1, 54, 807, DateTimeKind.Local).AddTicks(5970), null, false, "SYSTEM", null, "J.K.", "Rowling" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreatedBy", "CreatedById", "CreatedDate", "DeletedDate", "IsActive", "IsDeleted", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("21919a2d-29cb-4fe1-9214-3590b5d9a946"), "system", new Guid("0d01e176-ab43-4868-b448-c20f0cc4a0ca"), new DateTime(2024, 4, 13, 22, 1, 54, 807, DateTimeKind.Local).AddTicks(5976), null, true, false, "SYSTEM", null, "Fantasy" },
                    { new Guid("72261faa-0991-45ca-9550-f151fef7dbd6"), "system", new Guid("0d01e176-ab43-4868-b448-c20f0cc4a0ca"), new DateTime(2024, 4, 13, 22, 1, 54, 807, DateTimeKind.Local).AddTicks(5979), null, true, false, "SYSTEM", null, "Adventure" }
                });

            migrationBuilder.InsertData(
                table: "LibraryBranches",
                columns: new[] { "Id", "Address", "BookId", "BranchHourId", "CreatedBy", "CreatedById", "CreatedDate", "DeletedDate", "Description", "IsDeleted", "LastModifiedBy", "LastModifiedDate", "LibraryBranchId", "LibraryTransactionId", "MemberId", "Name", "OpeningDate", "PhoneNumber", "StaffId" },
                values: new object[] { new Guid("d2dfa162-7790-4565-ae14-684c26b0f112"), "123 Ana Cadde", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "system", new Guid("0d01e176-ab43-4868-b448-c20f0cc4a0ca"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bu bir örnek kütüphane şubesidir.", false, "SYSTEM", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Örnek Kütüphane Şubesi", new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "123-456-7890", new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Address", "BirthDate", "BorrowId", "CreatedBy", "CreatedById", "CreatedDate", "DeletedDate", "Email", "ExtensionDurationInDays", "Gender", "HasPenalty", "IsDeleted", "IsExtensionAllowed", "LastModifiedBy", "LastModifiedDate", "LibraryBranchId", "MaxLateReturnsAllowed", "MembershipDate", "Name", "NumberOfLateReturns", "Occupation", "PenaltyDurationInDays", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("6e479a11-766a-4018-8348-65823d2eea98"), "456 Oak Street", new DateTime(1985, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "system", new Guid("0d01e176-ab43-4868-b448-c20f0cc4a0ca"), new DateTime(2024, 4, 13, 22, 1, 54, 807, DateTimeKind.Local).AddTicks(6212), null, "jane.smith@example.com", 0, false, true, false, false, "SYSTEM", null, new Guid("d2dfa162-7790-4565-ae14-684c26b0f112"), 3, new DateTime(2024, 4, 13, 22, 1, 54, 807, DateTimeKind.Local).AddTicks(6209), "Jane Smith", 2, "Teacher", 7, "+1987654321" },
                    { new Guid("e9e4af38-9e86-424c-ab61-ac94d28dd9fb"), "123 Main Street", new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "system", new Guid("0d01e176-ab43-4868-b448-c20f0cc4a0ca"), new DateTime(2024, 4, 13, 22, 1, 54, 807, DateTimeKind.Local).AddTicks(6206), null, "john.doe@example.com", 7, true, false, false, true, "SYSTEM", null, new Guid("d2dfa162-7790-4565-ae14-684c26b0f112"), 3, new DateTime(2024, 4, 13, 22, 1, 54, 807, DateTimeKind.Local).AddTicks(6197), "John Doe", 0, "Software Engineer", 0, "+1234567890" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedById", "CreatedDate", "DeletedDate", "Email", "IsDeleted", "LastModifiedBy", "LastModifiedDate", "Name", "PhoneNumber", "Website" },
                values: new object[] { new Guid("d552c02c-08d5-41bd-b889-de58d59e6d2b"), "50 Bedford Square, London, England", "system", new Guid("0d01e176-ab43-4868-b448-c20f0cc4a0ca"), new DateTime(2024, 4, 13, 22, 1, 54, 807, DateTimeKind.Local).AddTicks(5994), null, "info@bloomsbury.com", false, "SYSTEM", null, "Bloomsbury Publishing", "+44 (0)20 7631 5600", "https://www.bloomsbury.com/" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "BookId", "CreatedBy", "CreatedById", "CreatedDate", "DeletedDate", "IsDeleted", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("32f8fdba-8f37-4803-b542-5d66e412e03a"), new Guid("5d9de716-b54f-4317-8a50-c8d1d1e54e87"), "system", new Guid("0d01e176-ab43-4868-b448-c20f0cc4a0ca"), new DateTime(2024, 4, 13, 22, 1, 54, 807, DateTimeKind.Local).AddTicks(6159), null, false, "SYSTEM", null, "Harry Potter" },
                    { new Guid("9ea61456-c276-44f3-9a55-b29aba8773c1"), new Guid("5d9de716-b54f-4317-8a50-c8d1d1e54e87"), "system", new Guid("0d01e176-ab43-4868-b448-c20f0cc4a0ca"), new DateTime(2024, 4, 13, 22, 1, 54, 807, DateTimeKind.Local).AddTicks(6156), null, false, "SYSTEM", null, "Hogwarts" },
                    { new Guid("f5404d3b-b8f9-4423-b2bd-b720eb66fb85"), new Guid("5d9de716-b54f-4317-8a50-c8d1d1e54e87"), "system", new Guid("0d01e176-ab43-4868-b448-c20f0cc4a0ca"), new DateTime(2024, 4, 13, 22, 1, 54, 807, DateTimeKind.Local).AddTicks(6161), null, false, "SYSTEM", null, "Quidditch" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("eca03ed8-8a54-4363-b4c0-3b9134fc512d"), new Guid("124b67f4-55d3-4095-8f9a-c3380cbb17a9"), "AppUserRole" },
                    { new Guid("bbed431e-a0b9-41c5-b98e-755631670820"), new Guid("e3708dc1-90e7-47b5-89d7-98459e52198d"), "AppUserRole" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "BookLanguage", "BookStockBranchId", "BorrowId", "CoverImageUrl", "CreatedBy", "CreatedById", "CreatedDate", "DeletedDate", "Description", "Format", "GenreId", "ISBN", "IsDeleted", "IsFeatured", "LastModifiedBy", "LastModifiedDate", "LibraryBranchId", "OriginalPublicationDate", "PageCount", "PublicationDate", "PublisherId", "Status", "Title" },
                values: new object[] { new Guid("5d9de716-b54f-4317-8a50-c8d1d1e54e87"), new Guid("f08db0d0-422c-436c-b262-d92ce18abd75"), 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "https://m.media-amazon.com/images/I/81q77Q39nEL._SY385_.jpg", "system", new Guid("0d01e176-ab43-4868-b448-c20f0cc4a0ca"), new DateTime(2024, 4, 13, 22, 1, 54, 807, DateTimeKind.Local).AddTicks(6002), null, "Harry Potter has never even heard of Hogwarts when the letters start dropping on the doormat at number four, Privet Drive. Addressed in green ink on yellowish parchment with a purple seal, they are swiftly confiscated by his grisly aunt and uncle. Then, on Harry's eleventh birthday, a great beetle-eyed giant of a man called Rubeus Hagrid bursts in with some astonishing news: Harry Potter is a wizard, and he has a place at Hogwarts School of Witchcraft and Wizardry. An incredible adventure is about to begin!", 0, new Guid("21919a2d-29cb-4fe1-9214-3590b5d9a946"), "9781408855652", false, true, "SYSTEM", null, new Guid("d2dfa162-7790-4565-ae14-684c26b0f112"), new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 352, new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d552c02c-08d5-41bd-b889-de58d59e6d2b"), 4, "Harry Potter and the Philosopher's Stone" });

            migrationBuilder.InsertData(
                table: "BranchHours",
                columns: new[] { "Id", "ClosingTime", "CreatedBy", "CreatedById", "CreatedDate", "DayOfWeek", "DeletedDate", "IsDeleted", "LastModifiedBy", "LastModifiedDate", "LibraryBranchId", "OpeningTime" },
                values: new object[,]
                {
                    { new Guid("14f5ac13-5a16-4436-a12d-c63df4ae94d2"), new TimeSpan(0, 17, 30, 0, 0), "system", new Guid("0d01e176-ab43-4868-b448-c20f0cc4a0ca"), new DateTime(2024, 4, 13, 22, 1, 54, 807, DateTimeKind.Local).AddTicks(6232), 0, null, false, "SYSTEM", null, new Guid("d2dfa162-7790-4565-ae14-684c26b0f112"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("5d609e91-2f69-4586-b6bc-c9700cc75e67"), new TimeSpan(0, 17, 30, 0, 0), "system", new Guid("0d01e176-ab43-4868-b448-c20f0cc4a0ca"), new DateTime(2024, 4, 13, 22, 1, 54, 807, DateTimeKind.Local).AddTicks(6229), 0, null, false, "SYSTEM", null, new Guid("d2dfa162-7790-4565-ae14-684c26b0f112"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("60cfebdf-200c-47ce-bc67-b5f3084024f7"), new TimeSpan(0, 17, 30, 0, 0), "system", new Guid("0d01e176-ab43-4868-b448-c20f0cc4a0ca"), new DateTime(2024, 4, 13, 22, 1, 54, 807, DateTimeKind.Local).AddTicks(6265), 0, null, false, "SYSTEM", null, new Guid("d2dfa162-7790-4565-ae14-684c26b0f112"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("64f59f71-781e-420a-a310-2f6d291ee0f8"), new TimeSpan(0, 17, 30, 0, 0), "system", new Guid("0d01e176-ab43-4868-b448-c20f0cc4a0ca"), new DateTime(2024, 4, 13, 22, 1, 54, 807, DateTimeKind.Local).AddTicks(6267), 0, null, false, "SYSTEM", null, new Guid("d2dfa162-7790-4565-ae14-684c26b0f112"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("ae93e23f-9e9b-4e81-af2a-dabd8136afb9"), new TimeSpan(0, 0, 0, 0, 0), "system", new Guid("0d01e176-ab43-4868-b448-c20f0cc4a0ca"), new DateTime(2024, 4, 13, 22, 1, 54, 807, DateTimeKind.Local).AddTicks(6270), 0, null, false, "SYSTEM", null, new Guid("d2dfa162-7790-4565-ae14-684c26b0f112"), new TimeSpan(0, 0, 0, 0, 0) },
                    { new Guid("bbcd93d4-7b0c-47b2-bcf4-047be3bd1fec"), new TimeSpan(0, 17, 30, 0, 0), "system", new Guid("0d01e176-ab43-4868-b448-c20f0cc4a0ca"), new DateTime(2024, 4, 13, 22, 1, 54, 807, DateTimeKind.Local).AddTicks(6262), 0, null, false, "SYSTEM", null, new Guid("d2dfa162-7790-4565-ae14-684c26b0f112"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("fee463b5-88f5-4480-a44d-9dcf40ec5d46"), new TimeSpan(0, 17, 30, 0, 0), "system", new Guid("0d01e176-ab43-4868-b448-c20f0cc4a0ca"), new DateTime(2024, 4, 13, 22, 1, 54, 807, DateTimeKind.Local).AddTicks(6258), 0, null, false, "SYSTEM", null, new Guid("d2dfa162-7790-4565-ae14-684c26b0f112"), new TimeSpan(0, 8, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "MemberLibraryBranch",
                columns: new[] { "LibraryBranchId", "MemberId" },
                values: new object[,]
                {
                    { new Guid("d2dfa162-7790-4565-ae14-684c26b0f112"), new Guid("6e479a11-766a-4018-8348-65823d2eea98") },
                    { new Guid("d2dfa162-7790-4565-ae14-684c26b0f112"), new Guid("e9e4af38-9e86-424c-ab61-ac94d28dd9fb") }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedById", "CreatedDate", "DeletedDate", "EmploymentDate", "IsDeleted", "IsFullTime", "LastModifiedBy", "LastModifiedDate", "LibraryBranchId", "Phone", "Salary", "UserId" },
                values: new object[] { new Guid("30b98605-7cd2-4de8-9da5-9fc3483045ff"), "Employee Address", "system", new Guid("0d01e176-ab43-4868-b448-c20f0cc4a0ca"), new DateTime(2024, 4, 13, 22, 1, 54, 807, DateTimeKind.Local).AddTicks(6288), null, new DateTime(2024, 4, 13, 22, 1, 54, 807, DateTimeKind.Local).AddTicks(6279), false, true, null, null, new Guid("d2dfa162-7790-4565-ae14-684c26b0f112"), "+905553331122", 3000.00m, new Guid("e3708dc1-90e7-47b5-89d7-98459e52198d") });

            migrationBuilder.InsertData(
                table: "BookAuthor",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[] { new Guid("f08db0d0-422c-436c-b262-d92ce18abd75"), new Guid("5d9de716-b54f-4317-8a50-c8d1d1e54e87") });

            migrationBuilder.InsertData(
                table: "BookStocks",
                columns: new[] { "Id", "BookId", "CreatedBy", "CreatedById", "CreatedDate", "DeletedDate", "IsDeleted", "LastModifiedBy", "LastModifiedDate", "Quantity" },
                values: new object[] { new Guid("310b73a8-e27c-4dde-9c4d-250f8c3e91d8"), new Guid("5d9de716-b54f-4317-8a50-c8d1d1e54e87"), "system", new Guid("0d01e176-ab43-4868-b448-c20f0cc4a0ca"), new DateTime(2024, 4, 13, 22, 1, 54, 807, DateTimeKind.Local).AddTicks(6274), null, false, "SYSTEM", null, 100 });

            migrationBuilder.InsertData(
                table: "BookTag",
                columns: new[] { "BookId", "TagId" },
                values: new object[,]
                {
                    { new Guid("5d9de716-b54f-4317-8a50-c8d1d1e54e87"), new Guid("32f8fdba-8f37-4803-b542-5d66e412e03a") },
                    { new Guid("5d9de716-b54f-4317-8a50-c8d1d1e54e87"), new Guid("9ea61456-c276-44f3-9a55-b29aba8773c1") }
                });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "Id", "BookId", "BorrowDate", "BorrowStatus", "CreatedBy", "CreatedById", "CreatedDate", "DeletedDate", "DueDate", "HasFee", "IsDeleted", "LastModifiedBy", "LastModifiedDate", "LenderId", "MemberId" },
                values: new object[] { new Guid("86b3e870-4516-4a13-9648-a30d7f4a6ec0"), new Guid("5d9de716-b54f-4317-8a50-c8d1d1e54e87"), new DateTime(2024, 4, 13, 22, 1, 54, 807, DateTimeKind.Local).AddTicks(6291), 2, "system", new Guid("0d01e176-ab43-4868-b448-c20f0cc4a0ca"), new DateTime(2024, 4, 13, 22, 1, 54, 807, DateTimeKind.Local).AddTicks(6311), null, new DateTime(2024, 4, 27, 22, 1, 54, 807, DateTimeKind.Local).AddTicks(6292), false, false, "SYSTEM", null, new Guid("30b98605-7cd2-4de8-9da5-9fc3483045ff"), new Guid("e9e4af38-9e86-424c-ab61-ac94d28dd9fb") });

            migrationBuilder.InsertData(
                table: "Returns",
                columns: new[] { "Id", "BookStatus", "CreatedBy", "CreatedById", "CreatedDate", "DeletedDate", "IsDeleted", "IsLate", "LastModifiedBy", "LastModifiedDate", "LoanId", "PenaltyDurationInDays", "ReturnDate" },
                values: new object[] { new Guid("b5f0f3a7-d6f2-4f4f-9996-2c64ea5c5b82"), 4, "system", new Guid("0d01e176-ab43-4868-b448-c20f0cc4a0ca"), new DateTime(2024, 4, 13, 22, 1, 54, 807, DateTimeKind.Local).AddTicks(6362), null, false, false, "SYSTEM", null, new Guid("86b3e870-4516-4a13-9648-a30d7f4a6ec0"), -13, new DateTime(2024, 4, 13, 22, 1, 54, 807, DateTimeKind.Local).AddTicks(6315) });

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
                name: "IX_BookAuthor_BookId",
                table: "BookAuthor",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreId",
                table: "Books",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_LibraryBranchId",
                table: "Books",
                column: "LibraryBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherId",
                table: "Books",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_BookStocks_BookId",
                table: "BookStocks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookTag_BookId",
                table: "BookTag",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Borrows_BookId",
                table: "Borrows",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Borrows_LenderId",
                table: "Borrows",
                column: "LenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Borrows_MemberId",
                table: "Borrows",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchHours_LibraryBranchId",
                table: "BranchHours",
                column: "LibraryBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_LibraryTransactions_LibraryBranchId",
                table: "LibraryTransactions",
                column: "LibraryBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberLibraryBranch_LibraryBranchId",
                table: "MemberLibraryBranch",
                column: "LibraryBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Returns_LoanId",
                table: "Returns",
                column: "LoanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoleScope_RoleId",
                table: "RoleScope",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleScope_ScopeId",
                table: "RoleScope",
                column: "ScopeId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_LibraryBranchId",
                table: "Staff",
                column: "LibraryBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_UserId",
                table: "Staff",
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
                name: "BookAuthor");

            migrationBuilder.DropTable(
                name: "BookStocks");

            migrationBuilder.DropTable(
                name: "BookTag");

            migrationBuilder.DropTable(
                name: "BranchHours");

            migrationBuilder.DropTable(
                name: "LibraryTransactions");

            migrationBuilder.DropTable(
                name: "MemberLibraryBranch");

            migrationBuilder.DropTable(
                name: "Returns");

            migrationBuilder.DropTable(
                name: "RoleScope");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Borrows");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Scope");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Publishers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "LibraryBranches");
        }
    }
}
