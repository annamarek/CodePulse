using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodePulse.API.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class FixPasswordSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67bc2761-87f5-4a1b-96c6-bed4a256d69f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee4d9745-b50e-4907-b7f7-369903b1011c", "AQAAAAIAAYagAAAAEJ83Ps13C/bCXQVIe1h7r+c0ptPCtNfarpFrqbJiVnjtA4EwkD1j1kRpxyAgbSF6EQ==", "ed42ba54-1ca8-4554-b5c5-9434f77483bc" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67bc2761-87f5-4a1b-96c6-bed4a256d69f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0413b1fa-f3dc-45ec-9f7e-fcce7ed747ca", "AQAAAAIAAYagAAAAEP+IYiQD/yVNmmRQITfHiuisraD91e535F/YjLly/Xn1CkiR9Yez5JDV69LP+m4lZA==", "f20a8158-74d5-42cb-8b20-7081ca19c961" });
        }
    }
}
