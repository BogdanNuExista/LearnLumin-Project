using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LearnLumin.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Permissions", "RoleName" },
                values: new object[,]
                {
                    { "421398ec-782e-4e19-b48b-241918cd65ce", "ReadOnly", "User" },
                    { "4af8a668-2bb0-4069-9e7d-55f6e6a88c83", "ReadWrite", "Moderator" },
                    { "8f060b55-b6c2-4609-b5e2-e70fbbfb1978", "FullAccess", "Admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "421398ec-782e-4e19-b48b-241918cd65ce");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "4af8a668-2bb0-4069-9e7d-55f6e6a88c83");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8f060b55-b6c2-4609-b5e2-e70fbbfb1978");
        }
    }
}
