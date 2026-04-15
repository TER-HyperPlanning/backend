using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddProgramSoftDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Program",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Program",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Program",
                keyColumn: "program_id",
                keyValue: "1c6c23e0-16b5-6208-2733-cf363a81e9d2",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Program",
                keyColumn: "program_id",
                keyValue: "64cb6778-fd4f-ba09-1402-010a1e0e30ce",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Program",
                keyColumn: "program_id",
                keyValue: "6fecdbc8-b9a0-3c82-511f-b30cc40fa9df",
                columns: new[] { "DeletedAt", "IsDeleted" },
                values: new object[] { null, false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Program");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Program");
        }
    }
}
