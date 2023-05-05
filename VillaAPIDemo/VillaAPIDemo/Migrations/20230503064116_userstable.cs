using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VillaAPIDemo.Migrations
{
    /// <inheritdoc />
    public partial class userstable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LocalUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalUsers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 5, 3, 12, 11, 15, 844, DateTimeKind.Local).AddTicks(5313), "one Villa" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 5, 3, 12, 11, 15, 844, DateTimeKind.Local).AddTicks(5333), "two Villa" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 5, 3, 12, 11, 15, 844, DateTimeKind.Local).AddTicks(5336), "three Villa" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 5, 3, 12, 11, 15, 844, DateTimeKind.Local).AddTicks(5338), "four Villa" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 5, 3, 12, 11, 15, 844, DateTimeKind.Local).AddTicks(5340), "five Villa" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocalUsers");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 5, 2, 14, 9, 54, 151, DateTimeKind.Local).AddTicks(2126), "abc Villa" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 5, 2, 14, 9, 54, 151, DateTimeKind.Local).AddTicks(2141), "def Villa" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 5, 2, 14, 9, 54, 151, DateTimeKind.Local).AddTicks(2143), "qwe Villa" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 5, 2, 14, 9, 54, 151, DateTimeKind.Local).AddTicks(2145), "poi Villa" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 5, 2, 14, 9, 54, 151, DateTimeKind.Local).AddTicks(2147), "mnb Villa" });
        }
    }
}
