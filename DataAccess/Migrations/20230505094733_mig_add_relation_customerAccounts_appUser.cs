using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_relation_customerAccounts_appUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "CustomerAccounts",
                newName: "CustomerAccountNumber");

            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "CustomerAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BankBranch",
                table: "CustomerAccounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "CustomerAccountBalance",
                table: "CustomerAccounts",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "CustomerAccountCurrency",
                table: "CustomerAccounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAccounts_AppUserId",
                table: "CustomerAccounts",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccounts_AspNetUsers_AppUserId",
                table: "CustomerAccounts",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccounts_AspNetUsers_AppUserId",
                table: "CustomerAccounts");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAccounts_AppUserId",
                table: "CustomerAccounts");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "CustomerAccounts");

            migrationBuilder.DropColumn(
                name: "BankBranch",
                table: "CustomerAccounts");

            migrationBuilder.DropColumn(
                name: "CustomerAccountBalance",
                table: "CustomerAccounts");

            migrationBuilder.DropColumn(
                name: "CustomerAccountCurrency",
                table: "CustomerAccounts");

            migrationBuilder.RenameColumn(
                name: "CustomerAccountNumber",
                table: "CustomerAccounts",
                newName: "Name");
        }
    }
}
