using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class Seedmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Posts",
                nullable: false,
                defaultValue: new DateTime(2018, 7, 24, 14, 23, 56, 438, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 7, 24, 14, 8, 8, 794, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "Email", "Name" },
                values: new object[] { new Guid("cd388eb8-0e51-4e81-b489-38a14b753b8c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john_doe@centric.eu", "Jon Doe" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "Email", "Name" },
                values: new object[] { new Guid("15034b09-226e-4ab2-b191-50349e71e3db"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "vic_boss_de_boss@centric.eu", "Victor Pantelemon" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("15034b09-226e-4ab2-b191-50349e71e3db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cd388eb8-0e51-4e81-b489-38a14b753b8c"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Posts",
                nullable: false,
                defaultValue: new DateTime(2018, 7, 24, 14, 8, 8, 794, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 7, 24, 14, 23, 56, 438, DateTimeKind.Local));
        }
    }
}
