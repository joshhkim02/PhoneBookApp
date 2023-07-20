using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhoneBookApp.Migrations
{
    /// <inheritdoc />
    public partial class NumberTableUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NumberId",
                table: "Numbers",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Numbers",
                newName: "NumberId");
        }
    }
}
