using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhoneBookApp.Migrations
{
    /// <inheritdoc />
    public partial class TableUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ContactId",
                table: "Contacts",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Numbers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Numbers_ContactId",
                table: "Numbers",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Numbers_Contacts_ContactId",
                table: "Numbers",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Numbers_Contacts_ContactId",
                table: "Numbers");

            migrationBuilder.DropIndex(
                name: "IX_Numbers_ContactId",
                table: "Numbers");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Contacts",
                newName: "ContactId");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Numbers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
