using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodePulse.API.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class InitFixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67bc2761-87f5-4a1b-96c6-bed4a256d69f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "static-conc-stamp-001", "static-sec-stamp-001" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67bc2761-87f5-4a1b-96c6-bed4a256d69f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ee4d9745-b50e-4907-b7f7-369903b1011c", "ed42ba54-1ca8-4554-b5c5-9434f77483bc" });
        }
    }
}
