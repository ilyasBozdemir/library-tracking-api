using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryTrackingApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig003 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StockCount",
                table: "Books");

            migrationBuilder.CreateIndex(
                name: "IX_Returns_LoanId",
                table: "Returns",
                column: "LoanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Loans_BookId",
                table: "Loans",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookStocks_BookId",
                table: "BookStocks",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookStocks_Books_BookId",
                table: "BookStocks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Books_BookId",
                table: "Loans",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Members_Id",
                table: "Loans",
                column: "Id",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Returns_Loans_LoanId",
                table: "Returns",
                column: "LoanId",
                principalTable: "Loans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookStocks_Books_BookId",
                table: "BookStocks");

            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Books_BookId",
                table: "Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Members_Id",
                table: "Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_Returns_Loans_LoanId",
                table: "Returns");

            migrationBuilder.DropIndex(
                name: "IX_Returns_LoanId",
                table: "Returns");

            migrationBuilder.DropIndex(
                name: "IX_Loans_BookId",
                table: "Loans");

            migrationBuilder.DropIndex(
                name: "IX_BookStocks_BookId",
                table: "BookStocks");

            migrationBuilder.AddColumn<int>(
                name: "StockCount",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
