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
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    BookStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookFormat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookLanguage = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    BorrowStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    { new Guid("52bb77e0-2506-4a65-9cba-688e3a262bc6"), null, "e15081bf-8144-442d-9f10-7d45284a8292", "Staff", "STAFF" },
                    { new Guid("ad6b6471-57b2-4e53-b5d2-1e42a6b1ee18"), null, "1cd715d8-5cb9-4dd5-8378-f228a094929c", "Member", "MEMBER" },
                    { new Guid("b93550d2-207d-4395-87ab-a12f17e9977c"), null, "4f55e2f4-d739-4905-902c-7a53932ab7b2", "system", "SYSTEM" },
                    { new Guid("da67f859-4955-45a6-a244-75f15f338f24"), null, "2c9e899a-84c8-4416-9301-bda428daf6e8", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "CreatedById", "CreatedDate", "DeletedDate", "Email", "EmailConfirmed", "IsDeleted", "LastModifiedBy", "LastModifiedDate", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenEndDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("4b9a128e-e613-4651-b672-0d94923dc87c"), 0, "0d3fcb87-580c-45df-b9f0-2aabe08ab0b9", "system", new Guid("a1670e55-05e6-48f4-a57c-117efb032b28"), new DateTime(2024, 4, 14, 15, 11, 47, 64, DateTimeKind.Local).AddTicks(1658), null, "admin@example.com", true, false, "SYSTEM", null, false, null, "admin", "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAkHvuin6yeN6l4jeCO0QqbNgndh0nFCN86+0a1EOziuzLQqZvq8EsDqh1xRuZAwug==", null, false, null, null, "", "admin", false, "admin@example.com" },
                    { new Guid("8b60ed0d-ad2c-4df7-b7b0-f4561f6e1d43"), 0, "82b8292e-a9a6-4d88-8e30-fad0e96e4325", "system", new Guid("a1670e55-05e6-48f4-a57c-117efb032b28"), new DateTime(2024, 4, 14, 15, 11, 47, 107, DateTimeKind.Local).AddTicks(8922), null, "employee1@example.com", true, false, "SYSTEM", null, false, null, "admin", "EMPLOYEE2@EXAMPLE.COM", "EMPLOYEE2@EXAMPLE.COM", "AQAAAAIAAYagAAAAECI/9Z2oRfOjKHoPlOr08l4JpEtQkRhvftOrymVyoBz9xbB3kUJOfHtNkmBMsPmKQA==", null, false, null, null, "", "admin", false, "employee1@example.com" },
                    { new Guid("a1670e55-05e6-48f4-a57c-117efb032b28"), 0, "006ed127-1482-4fca-a938-647118af94b8", "SYSTEM", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2024, 4, 14, 15, 11, 47, 21, DateTimeKind.Local).AddTicks(2843), null, "system@domain.com", true, false, "SYSTEM", null, false, null, "system", "SYSTEM@DOMAIN.COM", "SYSTEM", "AQAAAAIAAYagAAAAEMzkSWqIvsQ5KpuKrrNNG21RZEprVS4y8gADXmyILRXHgeI2Yyzy1+l9aNv7O9aR+A==", null, false, null, null, "", "system", false, "system" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Biography", "BirthDate", "Country", "CreatedBy", "CreatedById", "CreatedDate", "DeletedDate", "IsDeleted", "LastModifiedBy", "LastModifiedDate", "Name", "Surname" },
                values: new object[] { new Guid("2e733534-e02a-43d8-8c99-9502a7b1d695"), "Joanne Rowling, better known by her pen name J.K. Rowling, is a British author, philanthropist, film producer, television producer, and screenwriter. She is best known for writing the Harry Potter fantasy series.", new DateTime(1965, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "United Kingdom", "system", new Guid("a1670e55-05e6-48f4-a57c-117efb032b28"), new DateTime(2024, 4, 14, 15, 11, 47, 162, DateTimeKind.Local).AddTicks(4427), null, false, "SYSTEM", null, "J.K.", "Rowling" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreatedBy", "CreatedById", "CreatedDate", "DeletedDate", "IsActive", "IsDeleted", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("bdd155d1-0967-44de-8905-86d087f61267"), "system", new Guid("a1670e55-05e6-48f4-a57c-117efb032b28"), new DateTime(2024, 4, 14, 15, 11, 47, 162, DateTimeKind.Local).AddTicks(4436), null, true, false, "SYSTEM", null, "Fantasy" },
                    { new Guid("f2cce02a-a6bf-4d17-ad3f-65b42b73828d"), "system", new Guid("a1670e55-05e6-48f4-a57c-117efb032b28"), new DateTime(2024, 4, 14, 15, 11, 47, 162, DateTimeKind.Local).AddTicks(4439), null, true, false, "SYSTEM", null, "Adventure" }
                });

            migrationBuilder.InsertData(
                table: "LibraryBranches",
                columns: new[] { "Id", "Address", "BookId", "BranchHourId", "CreatedBy", "CreatedById", "CreatedDate", "DeletedDate", "Description", "IsDeleted", "LastModifiedBy", "LastModifiedDate", "LibraryBranchId", "LibraryTransactionId", "MemberId", "Name", "OpeningDate", "PhoneNumber", "StaffId" },
                values: new object[] { new Guid("4e2ff95a-555f-4b6e-bec5-95b2547e2591"), "123 Ana Cadde", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "system", new Guid("a1670e55-05e6-48f4-a57c-117efb032b28"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bu bir örnek kütüphane şubesidir.", false, "SYSTEM", null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Örnek Kütüphane Şubesi", new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "123-456-7890", new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Address", "BirthDate", "BorrowId", "CreatedBy", "CreatedById", "CreatedDate", "DeletedDate", "Email", "ExtensionDurationInDays", "Gender", "HasPenalty", "IsDeleted", "IsExtensionAllowed", "LastModifiedBy", "LastModifiedDate", "LibraryBranchId", "MaxLateReturnsAllowed", "MembershipDate", "Name", "NumberOfLateReturns", "Occupation", "PenaltyDurationInDays", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("1dab653d-c69c-4f72-8dec-21c1f31b79b8"), "123 Main Street", new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "system", new Guid("a1670e55-05e6-48f4-a57c-117efb032b28"), new DateTime(2024, 4, 14, 15, 11, 47, 162, DateTimeKind.Local).AddTicks(4619), null, "john.doe@example.com", 7, true, false, false, true, "SYSTEM", null, new Guid("4e2ff95a-555f-4b6e-bec5-95b2547e2591"), 3, new DateTime(2024, 4, 14, 15, 11, 47, 162, DateTimeKind.Local).AddTicks(4614), "John Doe", 0, "Software Engineer", 0, "+1234567890" },
                    { new Guid("be83d51a-b7f8-4c0d-8e78-3b4b44ac28e4"), "456 Oak Street", new DateTime(1985, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "system", new Guid("a1670e55-05e6-48f4-a57c-117efb032b28"), new DateTime(2024, 4, 14, 15, 11, 47, 162, DateTimeKind.Local).AddTicks(4643), null, "jane.smith@example.com", 0, false, true, false, false, "SYSTEM", null, new Guid("4e2ff95a-555f-4b6e-bec5-95b2547e2591"), 3, new DateTime(2024, 4, 14, 15, 11, 47, 162, DateTimeKind.Local).AddTicks(4641), "Jane Smith", 2, "Teacher", 7, "+1987654321" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedById", "CreatedDate", "DeletedDate", "Email", "IsDeleted", "LastModifiedBy", "LastModifiedDate", "Name", "PhoneNumber", "Website" },
                values: new object[] { new Guid("71993c51-540a-4759-a16c-0a792d6a4761"), "50 Bedford Square, London, England", "system", new Guid("a1670e55-05e6-48f4-a57c-117efb032b28"), new DateTime(2024, 4, 14, 15, 11, 47, 162, DateTimeKind.Local).AddTicks(4463), null, "info@bloomsbury.com", false, "SYSTEM", null, "Bloomsbury Publishing", "+44 (0)20 7631 5600", "https://www.bloomsbury.com/" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "BookId", "CreatedBy", "CreatedById", "CreatedDate", "DeletedDate", "IsDeleted", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("704cf34a-f081-412b-a879-f2037accd656"), new Guid("1c2cf9fd-0b7f-40d8-b018-bc6136479d7e"), "system", new Guid("a1670e55-05e6-48f4-a57c-117efb032b28"), new DateTime(2024, 4, 14, 15, 11, 47, 162, DateTimeKind.Local).AddTicks(4598), null, false, "SYSTEM", null, "Hogwarts" },
                    { new Guid("a18fb570-71e9-42be-b888-770c313324ce"), new Guid("1c2cf9fd-0b7f-40d8-b018-bc6136479d7e"), "system", new Guid("a1670e55-05e6-48f4-a57c-117efb032b28"), new DateTime(2024, 4, 14, 15, 11, 47, 162, DateTimeKind.Local).AddTicks(4603), null, false, "SYSTEM", null, "Quidditch" },
                    { new Guid("c63e7d5a-fa1b-4baa-bbab-273411967671"), new Guid("1c2cf9fd-0b7f-40d8-b018-bc6136479d7e"), "system", new Guid("a1670e55-05e6-48f4-a57c-117efb032b28"), new DateTime(2024, 4, 14, 15, 11, 47, 162, DateTimeKind.Local).AddTicks(4601), null, false, "SYSTEM", null, "Harry Potter" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("da67f859-4955-45a6-a244-75f15f338f24"), new Guid("4b9a128e-e613-4651-b672-0d94923dc87c"), "AppUserRole" },
                    { new Guid("52bb77e0-2506-4a65-9cba-688e3a262bc6"), new Guid("8b60ed0d-ad2c-4df7-b7b0-f4561f6e1d43"), "AppUserRole" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "BookFormat", "BookLanguage", "BookStatus", "BookStockBranchId", "BorrowId", "CoverImageUrl", "CreatedBy", "CreatedById", "CreatedDate", "DeletedDate", "Description", "GenreId", "ISBN", "IsDeleted", "IsFeatured", "LastModifiedBy", "LastModifiedDate", "LibraryBranchId", "OriginalPublicationDate", "PageCount", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { new Guid("1c2cf9fd-0b7f-40d8-b018-bc6136479d7e"), new Guid("2e733534-e02a-43d8-8c99-9502a7b1d695"), "PrintedBook", "English", "Available", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "https://m.media-amazon.com/images/I/81q77Q39nEL._SY385_.jpg", "system", new Guid("a1670e55-05e6-48f4-a57c-117efb032b28"), new DateTime(2024, 4, 14, 15, 11, 47, 162, DateTimeKind.Local).AddTicks(4477), null, "Harry Potter has never even heard of Hogwarts when the letters start dropping on the doormat at number four, Privet Drive. Addressed in green ink on yellowish parchment with a purple seal, they are swiftly confiscated by his grisly aunt and uncle. Then, on Harry's eleventh birthday, a great beetle-eyed giant of a man called Rubeus Hagrid bursts in with some astonishing news: Harry Potter is a wizard, and he has a place at Hogwarts School of Witchcraft and Wizardry. An incredible adventure is about to begin!", new Guid("bdd155d1-0967-44de-8905-86d087f61267"), "9781408855652", false, true, "SYSTEM", null, new Guid("4e2ff95a-555f-4b6e-bec5-95b2547e2591"), new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 352, new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("71993c51-540a-4759-a16c-0a792d6a4761"), "Harry Potter and the Philosopher's Stone" });

            migrationBuilder.InsertData(
                table: "BranchHours",
                columns: new[] { "Id", "ClosingTime", "CreatedBy", "CreatedById", "CreatedDate", "DayOfWeek", "DeletedDate", "IsDeleted", "LastModifiedBy", "LastModifiedDate", "LibraryBranchId", "OpeningTime" },
                values: new object[,]
                {
                    { new Guid("028af088-751b-497c-bd81-2b4cf37d74a5"), new TimeSpan(0, 17, 30, 0, 0), "system", new Guid("a1670e55-05e6-48f4-a57c-117efb032b28"), new DateTime(2024, 4, 14, 15, 11, 47, 162, DateTimeKind.Local).AddTicks(4698), 0, null, false, "SYSTEM", null, new Guid("4e2ff95a-555f-4b6e-bec5-95b2547e2591"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("0b0205f8-2b23-4ced-a2e4-ae1788aa8ef3"), new TimeSpan(0, 17, 30, 0, 0), "system", new Guid("a1670e55-05e6-48f4-a57c-117efb032b28"), new DateTime(2024, 4, 14, 15, 11, 47, 162, DateTimeKind.Local).AddTicks(4693), 0, null, false, "SYSTEM", null, new Guid("4e2ff95a-555f-4b6e-bec5-95b2547e2591"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("24315f2c-1b35-441f-b6d2-ac148a105e1c"), new TimeSpan(0, 17, 30, 0, 0), "system", new Guid("a1670e55-05e6-48f4-a57c-117efb032b28"), new DateTime(2024, 4, 14, 15, 11, 47, 162, DateTimeKind.Local).AddTicks(4696), 0, null, false, "SYSTEM", null, new Guid("4e2ff95a-555f-4b6e-bec5-95b2547e2591"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("5018a967-3ee3-43f8-bafe-92a7a9c5f467"), new TimeSpan(0, 0, 0, 0, 0), "system", new Guid("a1670e55-05e6-48f4-a57c-117efb032b28"), new DateTime(2024, 4, 14, 15, 11, 47, 162, DateTimeKind.Local).AddTicks(4701), 0, null, false, "SYSTEM", null, new Guid("4e2ff95a-555f-4b6e-bec5-95b2547e2591"), new TimeSpan(0, 0, 0, 0, 0) },
                    { new Guid("6f0e01f6-ce41-4369-a0ce-0af0c4f3ec70"), new TimeSpan(0, 17, 30, 0, 0), "system", new Guid("a1670e55-05e6-48f4-a57c-117efb032b28"), new DateTime(2024, 4, 14, 15, 11, 47, 162, DateTimeKind.Local).AddTicks(4663), 0, null, false, "SYSTEM", null, new Guid("4e2ff95a-555f-4b6e-bec5-95b2547e2591"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("87b0d36e-1a0e-4704-a9f0-695a6e92a69a"), new TimeSpan(0, 17, 30, 0, 0), "system", new Guid("a1670e55-05e6-48f4-a57c-117efb032b28"), new DateTime(2024, 4, 14, 15, 11, 47, 162, DateTimeKind.Local).AddTicks(4658), 0, null, false, "SYSTEM", null, new Guid("4e2ff95a-555f-4b6e-bec5-95b2547e2591"), new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("f60c13bd-a9f4-4fe2-9aa6-a6c96d9a99cf"), new TimeSpan(0, 17, 30, 0, 0), "system", new Guid("a1670e55-05e6-48f4-a57c-117efb032b28"), new DateTime(2024, 4, 14, 15, 11, 47, 162, DateTimeKind.Local).AddTicks(4678), 0, null, false, "SYSTEM", null, new Guid("4e2ff95a-555f-4b6e-bec5-95b2547e2591"), new TimeSpan(0, 8, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "MemberLibraryBranch",
                columns: new[] { "LibraryBranchId", "MemberId" },
                values: new object[,]
                {
                    { new Guid("4e2ff95a-555f-4b6e-bec5-95b2547e2591"), new Guid("1dab653d-c69c-4f72-8dec-21c1f31b79b8") },
                    { new Guid("4e2ff95a-555f-4b6e-bec5-95b2547e2591"), new Guid("be83d51a-b7f8-4c0d-8e78-3b4b44ac28e4") }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedById", "CreatedDate", "DeletedDate", "EmploymentDate", "IsDeleted", "IsFullTime", "LastModifiedBy", "LastModifiedDate", "LibraryBranchId", "Phone", "Salary", "UserId" },
                values: new object[] { new Guid("92863cc9-0b7d-4699-934a-d12619ff0973"), "Employee Address", "system", new Guid("a1670e55-05e6-48f4-a57c-117efb032b28"), new DateTime(2024, 4, 14, 15, 11, 47, 162, DateTimeKind.Local).AddTicks(4716), null, new DateTime(2024, 4, 14, 15, 11, 47, 162, DateTimeKind.Local).AddTicks(4712), false, true, null, null, new Guid("4e2ff95a-555f-4b6e-bec5-95b2547e2591"), "+905553331122", 3000.00m, new Guid("8b60ed0d-ad2c-4df7-b7b0-f4561f6e1d43") });

            migrationBuilder.InsertData(
                table: "BookAuthor",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[] { new Guid("2e733534-e02a-43d8-8c99-9502a7b1d695"), new Guid("1c2cf9fd-0b7f-40d8-b018-bc6136479d7e") });

            migrationBuilder.InsertData(
                table: "BookStocks",
                columns: new[] { "Id", "BookId", "CreatedBy", "CreatedById", "CreatedDate", "DeletedDate", "IsDeleted", "LastModifiedBy", "LastModifiedDate", "Quantity" },
                values: new object[] { new Guid("3fcf90e1-37aa-4065-96f7-bdb35e5ee7d3"), new Guid("1c2cf9fd-0b7f-40d8-b018-bc6136479d7e"), "system", new Guid("a1670e55-05e6-48f4-a57c-117efb032b28"), new DateTime(2024, 4, 14, 15, 11, 47, 162, DateTimeKind.Local).AddTicks(4708), null, false, "SYSTEM", null, 100 });

            migrationBuilder.InsertData(
                table: "BookTag",
                columns: new[] { "BookId", "TagId" },
                values: new object[,]
                {
                    { new Guid("1c2cf9fd-0b7f-40d8-b018-bc6136479d7e"), new Guid("704cf34a-f081-412b-a879-f2037accd656") },
                    { new Guid("1c2cf9fd-0b7f-40d8-b018-bc6136479d7e"), new Guid("c63e7d5a-fa1b-4baa-bbab-273411967671") }
                });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "Id", "BookId", "BorrowDate", "BorrowStatus", "CreatedBy", "CreatedById", "CreatedDate", "DeletedDate", "DueDate", "HasFee", "IsDeleted", "LastModifiedBy", "LastModifiedDate", "LenderId", "MemberId" },
                values: new object[] { new Guid("53508a63-28a7-4ba2-aeee-fcf9a9e77ab4"), new Guid("1c2cf9fd-0b7f-40d8-b018-bc6136479d7e"), new DateTime(2024, 4, 14, 15, 11, 47, 162, DateTimeKind.Local).AddTicks(4721), "Borrowed", "system", new Guid("a1670e55-05e6-48f4-a57c-117efb032b28"), new DateTime(2024, 4, 14, 15, 11, 47, 162, DateTimeKind.Local).AddTicks(4746), null, new DateTime(2024, 4, 28, 15, 11, 47, 162, DateTimeKind.Local).AddTicks(4721), false, false, "SYSTEM", null, new Guid("92863cc9-0b7d-4699-934a-d12619ff0973"), new Guid("1dab653d-c69c-4f72-8dec-21c1f31b79b8") });

            migrationBuilder.InsertData(
                table: "Returns",
                columns: new[] { "Id", "BookStatus", "CreatedBy", "CreatedById", "CreatedDate", "DeletedDate", "IsDeleted", "IsLate", "LastModifiedBy", "LastModifiedDate", "LoanId", "PenaltyDurationInDays", "ReturnDate" },
                values: new object[] { new Guid("e8583752-b4ed-4cbf-9383-ed1bb24621c4"), 4, "system", new Guid("a1670e55-05e6-48f4-a57c-117efb032b28"), new DateTime(2024, 4, 14, 15, 11, 47, 162, DateTimeKind.Local).AddTicks(4775), null, false, false, "SYSTEM", null, new Guid("53508a63-28a7-4ba2-aeee-fcf9a9e77ab4"), -13, new DateTime(2024, 4, 14, 15, 11, 47, 162, DateTimeKind.Local).AddTicks(4750) });

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
